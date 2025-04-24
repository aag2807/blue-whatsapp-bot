/**
 * @typedef {Object} Trip
 * @property {number} Id
 * @property {string} TripName
 * @property {boolean} IsActiveForToday
 * @property {Route} Route
 * @property {Schedule} Schedule
 * @property {Reservation[]} Reservations
 */

/**
 * @typedef {Object} Route
 * @property {number} id
 * @property {string} name
 * @property {string} description
 */

document.addEventListener('alpine:init', () => {
    Alpine.data('tripsManagement', () => ({
        /**
         * @type {Trip[]}
         */
        trips: [],
        
        /**
         * @type {Route[]}
         */
        routes: [],
        
        showModal: false,
        currentTrip: { 
            id: 0,
            tripName: '',
            isActiveForToday: true,
            route: null,
            schedule: null,
            reservations: []
        },
        searchTerm: '',
        debounceTimeout: null,
        saving: false,
        loading: true,
        error: null,
        connection: null,
        
        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/trips")
                .withAutomaticReconnect()
                .build();

            this.connection.on('ReceiveTrips', (trips) => {
                this.trips = trips;
                this.loading = false;
                console.log(trips);
            });

            this.connection.on('ReceiveRoutes', (routes) => {
                this.routes = routes;
            });

            this.connection.start()
                .then(() => {
                    this.fetchTrips();
                    this.fetchRoutes();
                })
                .catch(err => {
                    console.error('Error starting connection:', err);
                    this.error = 'Error al conectar con el servidor';
                });
        },

        get tripsCount() {
            return this.filteredTrips.length;
        },

        get filteredTrips() {
            if (!this.searchTerm.trim()) {
                return this.trips;
            }
            
            const search = this.searchTerm.toLowerCase();
            return this.trips.filter(trip => 
                (trip.tripName && trip.tripName.toLowerCase().includes(search)) ||
                (trip.route?.name && trip.route.name.toLowerCase().includes(search)) ||
                (trip.route?.description && trip.route.description.toLowerCase().includes(search)) ||
                (trip.schedule?.name && trip.schedule.name.toLowerCase().includes(search))
            );
        },

        handleSearch() {
            // Clear previous timeout
            if (this.debounceTimeout) {
                clearTimeout(this.debounceTimeout);
            }

            // Set new timeout
            this.debounceTimeout = setTimeout(() => {
                this.searchForTrips();
            }, 300); // 300ms debounce
        },

        async searchForTrips() {
            try {
                this.loading = true;
                await this.connection.invoke('SearchTrips', this.searchTerm);
            } catch (error) {
                console.error('Error searching trips:', error);
                this.error = 'Error al buscar viajes';
            } finally {
                this.loading = false;
            }
        },

        formatTime(time) {
            // If time is a string in HH:MM format, return it as is
            if (typeof time === 'string' && time.includes(':')) {
                return time;
            }
            
            // If time is a TimeSpan from C# (represented as a string like "01:30:00"),
            // format it to show only hours and minutes
            if (typeof time === 'string') {
                const parts = time.split(':');
                if (parts.length >= 2) {
                    return `${parts[0]}:${parts[1]}`;
                }
            }
            
            return time || '';
        },

        getRouteName(routeId) {
            const route = this.routes.find(r => r.id === parseInt(routeId));
            return route ? route.name : '';
        },

        async fetchTrips() {
            await this.connection.invoke('GetTrips');
        },

        async fetchRoutes() {
            await this.connection.invoke('GetRoutes');
        },

        openAddModal() {
            this.currentTrip = { 
                Id: 0,
                TripName: '',
                IsActiveForToday: true,
                Route: null,
                Schedule: null,
                Reservations: []
            };
            this.showModal = true;
        },

        openEditModal(trip) {
            this.currentTrip = { ...trip };
            
            // Ensure tripTime is in the correct format for the time input (HH:MM)
            if (typeof trip.tripTime === 'string' && trip.tripTime.includes(':')) {
                const parts = trip.tripTime.split(':');
                if (parts.length >= 2) {
                    this.currentTrip.tripTime = `${parts[0]}:${parts[1]}`;
                }
            }
            
            this.showModal = true;
        },

        toggleActive(trip) {
            const updatedTrip = { ...trip, isActiveForToday: !trip.isActiveForToday };
            
            // Send update to server
            this.updateTripStatus(updatedTrip);
        },

        async updateTripStatus(trip) {
            try {
                await this.connection.invoke('UpdateTripStatus', trip);
                
                const { Swal } = window;
                if (Swal) {
                    Swal.fire({
                        icon: 'success',
                        title: 'Estado actualizado',
                        text: `El viaje ha sido ${trip.isActiveForToday ? 'activado' : 'desactivado'} para hoy.`,
                        confirmButtonColor: '#0d5c46'
                    });
                }
            } catch (error) {
                console.error('Error updating trip status:', error);
                
                const { Swal } = window;
                if (Swal) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'No se pudo actualizar el estado del viaje. Por favor, inténtalo de nuevo.',
                        confirmButtonColor: '#0d5c46'
                    });
                }
            }
        },

        async saveTrip() {
            this.saving = true;
            
            try {
                await this.connection.invoke('SaveTrip', this.currentTrip);
            } catch (error) {
                console.error('Error saving trip:', error);
                
                const { Swal } = window;
                if (Swal) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'No se pudo guardar el viaje. Por favor, inténtalo de nuevo.',
                        confirmButtonColor: '#0d5c46'
                    });
                } else {
                    alert('Error al guardar el viaje: ' + error);
                }
            } finally {
                this.showModal = false;
                this.saving = false;
            }
        },

        async deleteTrip(tripId) {
            const { Swal } = window;
            
            const confirmDelete = Swal 
                ? new Promise(resolve => {
                    Swal.fire({
                        title: '¿Estás seguro?',
                        text: 'No podrás revertir esto!',
                        icon: 'warning',
                        showCancelButton: true,
                        confirmButtonColor: '#0d5c46',
                        cancelButtonColor: '#d33',
                        confirmButtonText: 'Si, eliminar!',
                        cancelButtonText: 'Cancelar'
                    }).then(result => resolve(result.isConfirmed));
                })
                : Promise.resolve(confirm('¿Estás seguro de que quieres eliminar este viaje? Esta acción no se puede deshacer.'));
            
            const isConfirmed = await confirmDelete;
            if (!isConfirmed)
            {
                this.showModal = false;
                return;
            };
            
            await this.connection.invoke('DeleteTrip', tripId);
        }
    }));
});
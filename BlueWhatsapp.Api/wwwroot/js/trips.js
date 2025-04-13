/**
 * @typedef {Object} Trip
 * @property {number} id
 * @property {string} userName
 * @property {string} userNumber
 * @property {string} tripTime - Time in HH:MM format
 * @property {number} routeId
 * @property {boolean} isActiveForToday
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
            userName: '', 
            userNumber: '', 
            tripTime: '', 
            routeId: '', 
            isActiveForToday: true
        },
        searchTerm: '',
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
                });
        },

        /**
         * Provides mock trip data if API calls fail
         */
        provideMockTrips() {
            this.trips = [
                {
                    id: 1,
                    userName: 'Juan Pérez',
                    userNumber: '+1234567890',
                    tripTime: '09:00',
                    routeId: 1,
                    isActiveForToday: true
                },
                {
                    id: 2,
                    userName: 'María García',
                    userNumber: '+0987654321',
                    tripTime: '10:30',
                    routeId: 2,
                    isActiveForToday: true
                },
                {
                    id: 3,
                    userName: 'Carlos Rodríguez',
                    userNumber: '+1122334455',
                    tripTime: '14:15',
                    routeId: 3,
                    isActiveForToday: false
                }
            ];
        },

        /**
         * Provides mock route data if API calls fail
         */
        provideMockRoutes() {
            this.routes = [
                { id: 1, name: 'RUTA A', description: 'Ruta Punta Cana (Cap Cana)' },
                { id: 2, name: 'RUTA B', description: 'Ruta La Romana' },
                { id: 3, name: 'RUTA C', description: 'Ruta Bávaro Sur' },
                { id: 4, name: 'RUTA D', description: 'Ruta Bávaro Norte' }
            ];
        },

        get tripsCount() {
            return this.trips.length;
        },

        get filteredTrips() {
            if (!this.searchTerm.trim()) {
                return this.trips;
            }
            
            const search = this.searchTerm.toLowerCase();
            return this.trips.filter(trip => 
                (trip.userName && trip.userName.toLowerCase().includes(search)) ||
                (trip.userNumber && trip.userNumber.toLowerCase().includes(search)) ||
                (this.getRouteName(trip.routeId) && this.getRouteName(trip.routeId).toLowerCase().includes(search))
            );
        },

        async searchForTrips()
        {
            await this.connection.invoke('SearchTrips', this.searchTerm);
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
                id: 0, 
                userName: '', 
                userNumber: '', 
                tripTime: '', 
                routeId: '', 
                isActiveForToday: true
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
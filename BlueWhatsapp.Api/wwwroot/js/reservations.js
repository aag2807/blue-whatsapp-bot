/**
 * @typedef {Object} Reservation
 * @property {number} id
 * @property {string} userName
 * @property {string} userNumber
 * @property {number} tripId
 * @property {Trip} trip - The associated Trip object
 */

/**
 * @typedef {Object} Trip
 * @property {number} id
 * @property {string} userName
 * @property {string} userNumber
 * @property {string} tripTime
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
    Alpine.data('reservationsManagement', () => ({
        /**
         * @type {Reservation[]}
         */
        reservations: [],
        
        /**
         * @type {Trip[]}
         */
        trips: [],
        
        /**
         * @type {Route[]}
         */
        routes: [],
        
        showModal: false,
        currentTab: 'all',
        currentReservation: { 
            id: 0, 
            userName: '', 
            userNumber: '', 
            tripId: ''
        },
        searchTerm: '',
        saving: false,
        loading: true,
        error: null,
        connection: null,
        
        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/reservations")
                .withAutomaticReconnect()
                .build();

            this.connection.on('ReceiveReservations', (reservations) => {
                this.reservations = reservations;
            });

            this.connection.on('ReceiveTrips', (trips) => {
                this.trips = trips;
            });

            this.connection.on('ReceiveRoutes', (routes) => {
                this.routes = routes;
            });

            this.connection.start()
                .then(() => {
                    this.fetchReservations();
                    this.fetchTrips();
                    this.fetchRoutes();
                })
                .catch(err => {
                    console.error('Error starting connection:', err);
                    // Fallback to fetch data without SignalR
                    this.fetchReservationsWithoutSignalR();
                    this.fetchTripsWithoutSignalR();
                    this.fetchRoutesWithoutSignalR();
                });
        },

        /**
         * Fallback method to fetch reservations without SignalR
         */
        async fetchReservationsWithoutSignalR() {
            try {
                const response = await fetch('/api/reservations');
                if (response.ok) {
                    this.reservations = await response.json();
                } else {
                    console.error('Failed to fetch reservations');
                    // Provide mock data as a last resort
                    this.provideMockReservations();
                }
            } catch (error) {
                console.error('Error fetching reservations:', error);
                // Provide mock data as a last resort
                this.provideMockReservations();
            }
        },

        /**
         * Fallback method to fetch trips without SignalR
         */
        async fetchTripsWithoutSignalR() {
            try {
                const response = await fetch('/api/trips');
                if (response.ok) {
                    this.trips = await response.json();
                } else {
                    console.error('Failed to fetch trips');
                    // Provide mock data as a last resort
                    this.provideMockTrips();
                }
            } catch (error) {
                console.error('Error fetching trips:', error);
                // Provide mock data as a last resort
                this.provideMockTrips();
            }
        },

        /**
         * Fallback method to fetch routes without SignalR
         */
        async fetchRoutesWithoutSignalR() {
            try {
                const response = await fetch('/api/routes');
                if (response.ok) {
                    this.routes = await response.json();
                } else {
                    console.error('Failed to fetch routes');
                    // Provide mock data as a last resort
                    this.provideMockRoutes();
                }
            } catch (error) {
                console.error('Error fetching routes:', error);
                // Provide mock data as a last resort
                this.provideMockRoutes();
            }
        },

        /**
         * Provides mock reservation data if API calls fail
         */
        provideMockReservations() {
            this.reservations = [
                {
                    id: 1,
                    userName: 'John Doe',
                    userNumber: '+1234567890',
                    tripId: 1
                },
                {
                    id: 2,
                    userName: 'Jane Smith',
                    userNumber: '+0987654321',
                    tripId: 2
                },
                {
                    id: 3,
                    userName: 'Alice Johnson',
                    userNumber: '+1122334455',
                    tripId: 3
                }
            ];
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

        get reservationsCount() {
            return this.filteredReservations.length;
        },

        get filteredReservations() {
            // First filter by tab
            let filtered = this.reservations;
            
            const today = new Date();
            today.setHours(0, 0, 0, 0);
            
            if (this.currentTab === 'today') {
                // For today's filter, we need to look at the associated trip's schedule
                filtered = filtered.filter(r => {
                    const trip = this.trips.find(t => t.id === r.tripId);
                    return trip && trip.isActiveForToday;
                });
            } else if (this.currentTab === 'upcoming') {
                // For upcoming, we need to look at trips that are scheduled for future dates
                // Since in your model trips don't have dates, we'll just show trips that are active
                // but not for today (assuming they're scheduled for a future date)
                filtered = filtered.filter(r => {
                    const trip = this.trips.find(t => t.id === r.tripId);
                    return trip && !trip.isActiveForToday;
                });
            }
            
            // Then filter by search term
            if (this.searchTerm.trim()) {
                const search = this.searchTerm.toLowerCase();
                filtered = filtered.filter(r => 
                    (r.userName && r.userName.toLowerCase().includes(search)) ||
                    (r.userNumber && r.userNumber.toLowerCase().includes(search)) ||
                    this.getTripInfo(r.tripId).toLowerCase().includes(search) ||
                    this.getRouteInfo(r.tripId).toLowerCase().includes(search)
                );
            }
            
            return filtered;
        },

        changeTab(tab) {
            this.currentTab = tab;
        },

        getTripInfo(tripId) {
            const trip = this.trips.find(t => t.id === tripId);
            if (!trip) return 'No disponible';
            
            return `${trip.tripTime} (${trip.userName})`;
        },

        getRouteInfo(tripId) {
            const trip = this.trips.find(t => t.id === tripId);
            if (!trip) return 'No disponible';
            
            const route = this.routes.find(r => r.id === trip.routeId);
            return route ? route.name : 'Ruta no encontrada';
        },

        formatTripOption(trip) {
            const route = this.routes.find(r => r.id === trip.routeId);
            return `${trip.tripTime} - ${route ? route.name : 'Ruta desconocida'} - ${trip.userName}`;
        },

        formatDate(date) {
            const options = { day: '2-digit', month: '2-digit', year: 'numeric' };
            return new Date(date).toLocaleDateString('es-ES', options);
        },

        async fetchReservations() {
            try {
                await this.connection.invoke('GetReservations');
            } catch (error) {
                console.error('Error fetching reservations via SignalR:', error);
                // Fallback to regular fetch
                this.fetchReservationsWithoutSignalR();
            }
        },

        async fetchTrips() {
            try {
                await this.connection.invoke('GetTrips');
            } catch (error) {
                console.error('Error fetching trips via SignalR:', error);
                // Fallback to regular fetch
                this.fetchTripsWithoutSignalR();
            }
        },

        async fetchRoutes() {
            try {
                await this.connection.invoke('GetRoutes');
            } catch (error) {
                console.error('Error fetching routes via SignalR:', error);
                // Fallback to regular fetch
                this.fetchRoutesWithoutSignalR();
            }
        },

        openAddModal() {
            this.currentReservation = { 
                id: 0, 
                userName: '', 
                userNumber: '', 
                tripId: ''
            };
            this.showModal = true;
        },

        openEditModal(reservation) {
            this.currentReservation = { ...reservation };
            this.showModal = true;
        },

        async saveReservation() {
            this.saving = true;
            
            try {
                if (this.connection.state === 'Connected') {
                    await this.connection.invoke('SaveReservation', this.currentReservation);
                } else {
                    // Fallback to regular fetch
                    const url = this.currentReservation.id ? `/api/reservations/${this.currentReservation.id}` : '/api/reservations';
                    const method = this.currentReservation.id ? 'PUT' : 'POST';
                    
                    const response = await fetch(url, {
                        method,
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(this.currentReservation)
                    });
                    
                    if (!response.ok) {
                        throw new Error('Failed to save reservation');
                    }
                    
                    // Refresh reservations list
                    await this.fetchReservationsWithoutSignalR();
                }
                
                this.showModal = false;
            } catch (error) {
                console.error('Error saving reservation:', error);
                
                const { Swal } = window;
                if (Swal) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'No se pudo guardar la reservación. Por favor, inténtalo de nuevo.',
                        confirmButtonColor: '#0d5c46'
                    });
                } else {
                    alert('Error al guardar la reservación: ' + error);
                }
            } finally {
                this.saving = false;
            }
        },

        async deleteReservation(reservationId) {
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
                : Promise.resolve(confirm('¿Estás seguro de que quieres eliminar esta reservación? Esta acción no se puede deshacer.'));
            
            const isConfirmed = await confirmDelete;
            if (!isConfirmed) return;
            
            try {
                if (this.connection.state === 'Connected') {
                    await this.connection.invoke('DeleteReservation', reservationId);
                } else {
                    // Fallback to regular fetch
                    const response = await fetch(`/api/reservations/${reservationId}`, {
                        method: 'DELETE'
                    });
                    
                    if (!response.ok) {
                        throw new Error('Failed to delete reservation');
                    }
                    
                    // Refresh reservations list
                    await this.fetchReservationsWithoutSignalR();
                }
                
                if (Swal) {
                    Swal.fire({
                        title: 'Eliminada!',
                        text: 'La reservación ha sido eliminada.',
                        icon: 'success',
                        confirmButtonColor: '#0d5c46'
                    });
                }
            } catch (error) {
                console.error('Error deleting reservation:', error);
                
                if (Swal) {
                    Swal.fire({
                        title: 'Error!',
                        text: 'No se pudo eliminar la reservación.',
                        icon: 'error',
                        confirmButtonColor: '#0d5c46'
                    });
                } else {
                    alert('Error al eliminar la reservación: ' + error);
                }
            }
        }
    }));
});
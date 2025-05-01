/**
 * @typedef {Object} Reservation
 * @property {string} userNumber
 * @property {string} username
 * @property {string} details
 * @property {string} reservationDate
 * @property {string} reserveTime
 * @property {string} hotelName
 */

document.addEventListener('alpine:init', () => {
    Alpine.data('reservationsManagement', () => ({
        /**
         * @type {Reservation[]}
         */
        reservations: [],
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

        trips: [],
        routes: [],
        
        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/reservations")
                .withAutomaticReconnect()
                .build();

            this.connection.on('ReceiveReservations', (reservations) => {
                this.reservations = reservations;
                console.log(reservations);
            });

            this.connection.on('ReceiveTrips', (trips) => {
                this.trips = trips;
            });

            this.connection.on('ReceiveRoutes', (routes) => {
                this.routes = routes;
            });

            this.connection.start()
                .then(() =>
                {
                    this.connection.invoke('GetReservations');
                } )
                .catch(err => {
                });
        },

        get reservationsCount() {
            return this.filteredReservations.length;
        },

        get filteredReservations() {
            let filtered = this.reservations;
            
            const today = new Date();
            today.setHours(0, 0, 0, 0);
            
            if (this.currentTab === 'today')
            {
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
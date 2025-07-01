const { animate, scroll, stagger } = Motion

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

        /**
         * @type {Schedule[]}
         */
        schedules: [],

        /**
         * @type {Reservation[]}
         */
        reservations: [],

        // View state
        currentView: 'trips', // 'trips' or 'reservations'

        showModal: false,
        currentTrip: {
            id: 0,
            tripName: '',
            routeId: '',
            scheduleIds: [],
            isActiveForToday: true
        },
        searchTerm: '',
        debounceTimeout: null,
        saving: false,
        loading: false,
        reservationsLoading: false,
        error: null,
        connection: null,
        reservationsConnection: null,
        animateElement(el, index) {
            const delay = index + 1;
            setTimeout(() => {
                el.classList.remove('hidden');
                animate(el, {
                    opacity: [0, 1],
                    x: [200, 0],
                    delay: delay * 0.3
                });
            }, 100 * delay);
        },
        get tripsCount() {
            return this.filteredTrips.length;
        },

        get reservationsCount() {
            return this.filteredReservations.length;
        },

        get filteredTrips() {
            if (!this.searchTerm) return this.trips;
            
            const searchLower = this.searchTerm.toLowerCase();
            return this.trips.filter(trip => {
                const tripNameMatch = trip.tripName.toLowerCase().includes(searchLower);
                const routeMatch = trip.route?.name.toLowerCase().includes(searchLower);
                const scheduleMatch = trip.schedules?.some(s => s.name.toLowerCase().includes(searchLower));
                return tripNameMatch || routeMatch || scheduleMatch;
            });
        },

        get filteredReservations() {
            if (!this.searchTerm) return this.reservations;
            
            const searchLower = this.searchTerm.toLowerCase();
            return this.reservations.filter(reservation => {
                const usernameMatch = reservation.username?.toLowerCase().includes(searchLower);
                const userNumberMatch = reservation.userNumber?.toLowerCase().includes(searchLower);
                const hotelMatch = reservation.hotelName?.toLowerCase().includes(searchLower);
                const tripMatch = reservation.trip?.tripName?.toLowerCase().includes(searchLower);
                const emailMatch = reservation.email?.toLowerCase().includes(searchLower);
                return usernameMatch || userNumberMatch || hotelMatch || tripMatch || emailMatch;
            });
        },

        formatTime(time) {
            if (typeof time === 'string' && time.includes(':')) {
                return time;
            }

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

        getTripName(reservation) {
            return reservation.trip?.tripName || `Trip ${reservation.tripId}`;
        },

        getRouteName(reservation) {
            return reservation.trip?.route?.name || 'N/A';
        },

        getStatusBadgeClass(status) {
            switch (status?.toLowerCase()) {
                case 'active':
                    return 'bg-green-100 text-green-800';
                case 'cancelled':
                    return 'bg-red-100 text-red-800';
                case 'rescheduled':
                    return 'bg-yellow-100 text-yellow-800';
                default:
                    return 'bg-gray-100 text-gray-800';
            }
        },

        getStatusText(status) {
            switch (status?.toLowerCase()) {
                case 'active':
                    return 'Activo';
                case 'cancelled':
                    return 'Cancelado';
                case 'rescheduled':
                    return 'Reprogramado';
                default:
                    return status || 'Desconocido';
            }
        },

        getPersonCount(reservation) {
            const adults = reservation.adultsCount || 0;
            const children = reservation.childrenCount || 0;
            const total = adults + children;
            
            if (children > 0) {
                return `${total} personas (${adults} adultos, ${children} niños)`;
            }
            return `${total} ${total === 1 ? 'persona' : 'personas'}`;
        },

        // New method: Get daily capacity for a specific trip and date (like in reservations.js)
        getDailyTripCapacity(tripId, date) {
            if (!date || !tripId) return { current: 0, max: 30, remaining: 30 };
            
            // Use today's date if no date provided
            const targetDate = date || new Date().toISOString().split('T')[0];
            
            // Count reservations for this trip on this specific date
            const dailyReservations = this.reservations.filter(r => 
                r.tripId === tripId && 
                r.reservationDate === targetDate &&
                r.status !== 'Cancelled' // Don't count cancelled reservations
            );
            
            const maxCapacity = 30; // Daily limit per trip
            const currentCount = dailyReservations.length;
            const remaining = Math.max(0, maxCapacity - currentCount);
            
            return {
                current: currentCount,
                max: maxCapacity,
                remaining: remaining
            };
        },

        // Get today's reservations count for a trip
        getTodayReservationsCount(tripId) {
            if (!tripId || !this.reservations || this.reservations.length === 0) {
                return 0;
            }
            const today = new Date().toISOString().split('T')[0];
            const count = this.getDailyTripCapacity(tripId, today).current;
            console.log(`Trip ${tripId} today (${today}): ${count} reservations`);
            return count;
        },

        async init() {
            this.loading = true;
            this.reservationsLoading = true;
            try {
                // Create SignalR connection for trips
                this.connection = new signalR.HubConnectionBuilder()
                    .withUrl("/trips")
                    .withAutomaticReconnect()
                    .build();

                this.connection.on('ReceiveTrips', (trips) => {
                    const filteredTrips = trips.filter(trip => trip.tripName != "Externo");
                    this.trips = filteredTrips;
                });

                this.connection.on('ReceiveRoutes', (routes) => {
                    this.routes = routes;
                });

                this.connection.on('ReceiveSchedules', (schedules) => {
                    this.schedules = schedules;
                });

                // Create SignalR connection for reservations
                this.reservationsConnection = new signalR.HubConnectionBuilder()
                    .withUrl("/reservations")
                    .withAutomaticReconnect()
                    .build();

                this.reservationsConnection.on('ReceiveReservations', (reservations) => {
                    this.reservations = reservations;
                    console.log('Received reservations:', reservations.length);
                    
                    // Log some details about the reservations for debugging
                    if (reservations.length > 0) {
                        const today = new Date().toISOString().split('T')[0];
                        const todayReservations = reservations.filter(r => r.reservationDate === today);
                        console.log(`Today's reservations (${today}):`, todayReservations.length);
                        console.log('Sample reservation:', reservations[0]);
                    }
                });

                // Start connections
                await this.connection.start();
                await this.reservationsConnection.start();
                console.log('SignalR Connected - Trips and Reservations');

                // Get initial data
                await this.connection.invoke('GetTrips');
                await this.connection.invoke('GetRoutes');
                await this.connection.invoke('GetSchedules');

                // Get today's reservations for counting
                await this.reservationsConnection.invoke('GetReservationsForToday');

            } catch (err) {
                console.error('Error:', err);
                this.error = 'Error al conectar con el servidor';
            } finally {
                this.loading = false;
                this.reservationsLoading = false;
            }
        },

        async refreshReservations() {
            this.reservationsLoading = true;
            try {
                await this.reservationsConnection.invoke('GetReservationsForToday');
            } catch (err) {
                console.error('Error refreshing reservations:', err);
                this.error = 'Error al actualizar las reservas';
            } finally {
                this.reservationsLoading = false;
            }
        },

        openAddModal() {
            this.currentTrip = {
                id: 0,
                tripName: '',
                routeId: '',
                scheduleIds: [],
                isActiveForToday: true
            };
            this.showModal = true;
        },

        openEditModal(trip) {
            this.currentTrip = {
                ...trip,
                scheduleIds: trip.schedules?.map(s => s.id) || [],
                routeId: trip.route?.id || '',
                isActiveForToday: trip.isActiveForToday
            };
            this.showModal = true;
        },

        async saveTrip() {
            this.saving = true;

            try {
                // Prepare trip data for saving
                const tripToSave = {
                    id: this.currentTrip.id,
                    tripName: this.currentTrip.tripName,
                    isActiveForToday: this.currentTrip.isActiveForToday,
                    route: this.routes.find(r => r.id === parseInt(this.currentTrip.routeId)),
                    schedules: this.schedules.filter(s => this.currentTrip.scheduleIds.includes(s.id))
                };

                await this.connection.invoke('SaveTrip', tripToSave);
                this.showModal = false;
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
            if (!isConfirmed) return;

            await this.connection.invoke('DeleteTrip', tripId);
        },

        async toggleActive(trip) {
            const updatedTrip = {
                ...trip,
                isActiveForToday: !trip.isActiveForToday
            };
            await this.connection.invoke('SaveTrip', updatedTrip);
        }
    }));
});

// Alpine Multi Select Component
document.addEventListener('alpine:init', () => {
    Alpine.data('alpineMultiSelect', ({
        selected = [],
        name = '',
        placeholder = 'Seleccionar...',
        maxItems = null
    }) => ({
        items: [],
        search: '',
        selected: selected,
        open: false,
        name: name,
        placeholder: placeholder,
        maxItems: maxItems,
        
        init() {
            this.$watch('selected', (value) => {
                this.$dispatch('change', this.selected);
            });
        },
        
        get filteredItems() {
            const filtered = this.items.filter(item => {
                const searchText = item.search || item.text;
                return searchText.toLowerCase().includes(this.search.toLowerCase());
            });
            return filtered;
        },
        
        isSelected(value) {
            return this.selected.includes(value);
        },
        
        toggleItem(value) {
            if (this.maxItems && !this.isSelected(value) && this.selected.length >= this.maxItems) return;
            
            const index = this.selected.indexOf(value);
            if (index === -1) {
                this.selected.push(value);
            } else {
                this.selected.splice(index, 1);
            }
        },
        
        getItemText(value) {
            const item = this.items.find(item => item.value === value);
            return item ? item.text : '';
        }
    }));
});

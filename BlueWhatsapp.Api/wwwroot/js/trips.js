
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
        error: null,
        connection: null,
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

        async init() {
            this.loading = true;
            try {
                // Create SignalR connection
                this.connection = new signalR.HubConnectionBuilder()
                    .withUrl("/trips")
                    .withAutomaticReconnect()
                    .build();

                // Set up handlers
                this.connection.on('ReceiveTrips', (trips) => {
                    console.log(trips)
                    this.trips = trips;
                });

                this.connection.on('ReceiveRoutes', (routes) => {
                    this.routes = routes;
                });

                this.connection.on('ReceiveSchedules', (schedules) => {
                    this.schedules = schedules;
                });

                // Start connection
                await this.connection.start();

                // Get initial data
                await this.connection.invoke('GetTrips');
                await this.connection.invoke('GetRoutes');
                await this.connection.invoke('GetSchedules');

            } catch (err) {
                console.error('Error:', err);
                this.error = 'Error al conectar con el servidor';
            } finally {
                this.loading = false;
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

const { animate, scroll, stagger } = Motion

/**
 * @typedef {Object} Hotel
 * @property {number} id
 * @property {string} name
 * @property {string} route
 * @property {number} routeId
 * @property {string} travelType
 * @property {number} price
 * @property {string} currency
 * @property {string} meetingPoint
 * @property {Array} hotelSchedules
 */

/**
 * @typedef {Object} Route
 * @property {number} id
 * @property {string} name
 * @property {string} description
 */

/**
 * @typedef {Object} Schedule
 * @property {number} id
 * @property {string} name
 * @property {string} time
 */

/**
 * @typedef {Object} HotelSchedule
 * @property {number} id
 * @property {number} hotelId
 * @property {number} scheduleId
 * @property {number} recogidaNumber
 */

document.addEventListener('alpine:init', () => {
    Alpine.data('hotelsManagement', () => ({
        /**
         * @type {Hotel[]}
         */
        hotels: [],
        
        /**
         * @type {Route[]}
         */
        routes: [],
        
        /**
         * @type {Schedule[]}
         */
        schedules: [],
        
        showModal: false,
        showSchedulesModal: false,
        currentHotel: { 
            id: 0, 
            name: '', 
            routeId: '', 
            travelType: '', 
            price: 0.00, 
            currency: 'USD', 
            meetingPoint: '', 
            customMeetingPoint: ''
        },
        selectedHotel: { id: 0, name: '', hotelSchedules: [] },
        hotelSchedules: [],
        searchTerm: '',
        scheduleSearch: '',
        saving: false,
        savingAssignments: false,
        loading: true,
        error: null,
        connection: null,
        animateElement(el, index) {
            const delay = index + 1;
            setTimeout(() => {
                el.classList.remove('hidden');
                animate(el, {
                    opacity: [0, 1],
                    x: [100, 0],
                    delay: delay * 0.3
                });
            }, 100 * delay);
        },

        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/hotels")
                .withAutomaticReconnect()
                .build();

            this.connection.on('ReceiveHotels', (hotels) => {
                console.log(hotels);
                
                this.hotels = hotels;
            });

            this.connection.on('ReceiveRoutes', (routes) => {
                this.routes = routes;
            });

            this.connection.on('ReceiveSchedules', (schedules) => {
                this.schedules = schedules;
            });

            this.connection.start()
                .then(() => {
                    this.fetchHotels();
                    this.fetchRoutes();
                    this.fetchSchedules();
                })
                .catch(err => {
                    console.error('Error starting connection:', err);
                });
        },

        get hotelsCount() {
            return this.hotels.length;
        },

        get filteredHotels() {
            if (!this.searchTerm.trim()) {
                return this.hotels;
            }

            const search = this.searchTerm.toLowerCase();
            return this.hotels.filter(hotel =>
                hotel.name.toLowerCase().includes(search) ||
                hotel.route.toLowerCase().includes(search) ||
                hotel.travelType.toLowerCase().includes(search) ||
                hotel.meetingPoint.toLowerCase().includes(search)
            );
        },

        get filteredSchedules() {
            if (!this.scheduleSearch.trim()) {
                return this.schedules;
            }

            const search = this.scheduleSearch.toLowerCase();
            return this.schedules.filter(schedule =>
                schedule.name.toLowerCase().includes(search) ||
                schedule.time.toLowerCase().includes(search)
            );
        },

        isScheduleAssigned(scheduleId) {
            return this.hotelSchedules.some(hs => hs.scheduleId === scheduleId);
        },

        getHotelSchedule(scheduleId) {
            return this.hotelSchedules.find(hs => hs.scheduleId === scheduleId) || {};
        },

        toggleScheduleAssignment(schedule) {
            const index = this.hotelSchedules.findIndex(hs => hs.scheduleId === schedule.id);
            
            if (index > -1) {
                // Remove schedule assignment
                this.hotelSchedules.splice(index, 1);
            } else {
                // Add schedule assignment
                this.hotelSchedules.push({
                    hotelId: this.selectedHotel.id,
                    scheduleId: schedule.id,
                    recogidaNumber: 1 // Default value
                });
            }
        },

        async fetchHotels() {
            this.connection.invoke('GetHotels');
        },

        async fetchRoutes() {
            this.connection.invoke('GetRoutes');
        },

        async fetchSchedules() {
            this.connection.invoke('GetSchedules');
        },

        openAddModal() {
            this.currentHotel = { 
                id: 0, 
                name: '', 
                routeId: '', 
                travelType: '', 
                price: 0.00, 
                currency: 'USD', 
                meetingPoint: '',
                customMeetingPoint: ''
            };
            this.showModal = true;
        },

        openEditModal(hotel) {
            this.currentHotel = { ...hotel };
            if (!['Lobby', 'Barrera'].includes(hotel.meetingPoint)) {
                this.currentHotel.customMeetingPoint = hotel.meetingPoint;
                this.currentHotel.meetingPoint = 'Otro';
            }
            this.showModal = true;
        },

        openSchedulesModal(hotel) {
            this.selectedHotel = { ...hotel };
            this.hotelSchedules = hotel.hotelSchedules ? [...hotel.hotelSchedules] : [];
            this.scheduleSearch = '';
            this.showSchedulesModal = true;
        },

        async saveHotel() {
            this.saving = true;
            
            try {
                // If custom meeting point is set, use it
                if (this.currentHotel.meetingPoint === 'Otro' && this.currentHotel.customMeetingPoint) {
                    this.currentHotel.meetingPoint = this.currentHotel.customMeetingPoint;
                }
                
                // Set the route name based on the routeId
                const selectedRoute = this.routes.find(r => r.id === parseInt(this.currentHotel.routeId));
                if (selectedRoute) {
                    this.currentHotel.route = selectedRoute.name;
                }
                
                this.currentHotel.price = parseFloat(this.currentHotel.price);
                this.currentHotel.routeId = parseInt(this.currentHotel.routeId);

                this.connection.invoke('CreateHotel', this.currentHotel);
                this.showModal = false;
            } catch (error) {
                console.error('Error saving hotel:', error);
                
                const { Swal } = window;
                if (Swal) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'No se pudo guardar el hotel. Por favor, inténtalo de nuevo.'
                    });
                } else {
                    alert('Error al guardar el hotel: ' + error);
                }
            } finally {
                this.saving = false;
            }
        },

        async saveScheduleAssignments() {
            this.savingAssignments = true;
            
            try {
                await this.connection.invoke('SaveHotelSchedules', {
                    hotelId: this.selectedHotel.id,
                    schedules: this.hotelSchedules
                });
                
                this.showSchedulesModal = false;
            } catch (error) {
                console.error('Error saving schedule assignments:', error);
                
                const { Swal } = window;
                if (Swal) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'No se pudieron guardar las asignaciones de horarios. Por favor, inténtalo de nuevo.'
                    });
                } else {
                    alert('Error al guardar las asignaciones de horarios: ' + error);
                }
            } finally {
                this.savingAssignments = false;
            }
        },

        async deleteHotel(hotelId) {
            const { Swal } = window;
            
            if (Swal) {
                Swal.fire({
                    title: '¿Estás seguro?',
                    text: 'No podrás revertir esto!',
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#0d5c46',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Si, eliminar!',
                    cancelButtonText: 'Cancelar'
                }).then((result) => {
                    if (result.isConfirmed) {
                        this.connection.invoke('DeleteHotel', parseInt(hotelId))
                            .then(() => {
                                Swal.fire({
                                    title: 'Eliminado!',
                                    text: 'El hotel ha sido eliminado.',
                                    icon: 'success',
                                    confirmButtonColor: '#0d5c46'
                                });
                            })
                            .catch(error => {
                                console.error('Error deleting hotel:', error);
                                Swal.fire({
                                    title: 'Error!',
                                    text: 'No se pudo eliminar el hotel.',
                                    icon: 'error',
                                    confirmButtonColor: '#0d5c46'
                                });
                            });
                    }
                });
            } else {
                if (confirm('¿Estás seguro de que quieres eliminar este hotel? Esta acción no se puede deshacer.')) {
                    try {
                        await this.connection.invoke('DeleteHotel', hotelId);
                    } catch (error) {
                        console.error('Error deleting hotel:', error);
                        alert('Error al eliminar el hotel: ' + error);
                    }
                }
            }
        }
    }));
});
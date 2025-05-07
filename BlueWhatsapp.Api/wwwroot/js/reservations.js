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
            username: '', 
            userNumber: '', 
            details: '',
            reservationDate: '',
            reserveTime: '',
            hotelName: '',
            tripId: '',
            scheduleId: '',
            hotelId: ''
        },
        searchTerm: '',
        saving: false,
        loading: true,
        error: null,
        connection: null,

        schedules: [],
        hotels: [],
        trips: [],
        
        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/reservations")    
                .withAutomaticReconnect()
                .build();

            this.connection.start()
                .then(() => {
                    console.log("SignalR Connected");
                    this.loadData();
                })
                .catch(err => {
                    console.error("SignalR Connection Error: ", err);
                    this.error = "Error connecting to server";
                });

            this.connection.on("ReceiveReservations", (reservations) => {
                this.reservations = reservations;
                this.loading = false;
            });

            this.connection.on("ReceiveSchedules", (schedules) => {
                this.schedules = schedules;
            });

            this.connection.on("ReceiveHotels", (hotels) => {
                this.hotels = hotels;
            });

            this.connection.on("ReceiveTrips", (trips) => {
                this.trips = trips;
            });
        },

        loadData() {
            this.loading = true;
            this.error = null;
            this.connection.invoke("GetReservations")
                .catch(err => {
                    console.error("Error loading reservations: ", err);
                    this.error = "Error loading reservations";
                    this.loading = false;
                });
            this.connection.invoke("GetSchedules")
                .catch(err => console.error("Error loading schedules: ", err));
            this.connection.invoke("GetHotels")
                .catch(err => console.error("Error loading hotels: ", err));
            this.connection.invoke("GetTrips")
                .catch(err => console.error("Error loading trips: ", err));
        },

        get reservationsCount() {
            return this.filteredReservations.length;
        },

        get filteredReservations() {
            let filtered = this.reservations;
            
            if (this.currentTab === 'today') {
                filtered = filtered.filter(r => {
                    const reservationDate = new Date(r.reservationDate);
                    const today = new Date();
                    return reservationDate.toDateString() === today.toDateString();
                });
            } else if (this.currentTab === 'upcoming') {
                const today = new Date();
                filtered = filtered.filter(r => {
                    const reservationDate = new Date(r.reservationDate);
                    return reservationDate > today;
                });
            }
            
            if (this.searchTerm.trim()) {
                const search = this.searchTerm.toLowerCase();
                filtered = filtered.filter(r => 
                    (r.username && r.username.toLowerCase().includes(search)) ||
                    (r.userNumber && r.userNumber.toLowerCase().includes(search)) ||
                    (r.hotelName && r.hotelName.toLowerCase().includes(search))
                );
            }
            
            return filtered;
        },

        changeTab(tab) {
            console.log('Changing tab to:', tab);
            this.currentTab = tab;
            if (this.connection.state === 'Connected') {
                console.log('SignalR connection is connected, invoking method...');
                switch(tab) {
                    case 'today':
                        console.log('Invoking GetReservationsForToday');
                        this.connection.invoke('GetReservationsForToday')
                            .catch(err => console.error('Error invoking GetReservationsForToday:', err));
                        break;
                    case 'upcoming':
                        console.log('Invoking GetUpcomingReservations');
                        this.connection.invoke('GetUpcomingReservations')
                            .catch(err => console.error('Error invoking GetUpcomingReservations:', err));
                        break;
                    default:
                        console.log('Invoking GetReservations');
                        this.connection.invoke('GetReservations')
                            .catch(err => console.error('Error invoking GetReservations:', err));
                        break;
                }
            } else {
                console.warn('SignalR connection is not connected. Current state:', this.connection.state);
            }
        },

        formatDate(date) {
            if (!date) {
                return 'No disponible'
            };
            const options = { day: '2-digit', month: '2-digit', year: 'numeric' };
            return new Date(date).toLocaleDateString('es-ES', options);
        },

        formatTime(time) {
            if (!time) {
                return 'No disponible'
            };
            return time;
        },

        openAddModal() {
            this.currentReservation = { 
                id: 0, 
                username: '', 
                userNumber: '', 
                details: '',
                reservationDate: '',
                reserveTime: '',
                hotelName: '',
                tripId: '',
                scheduleId: '',
                hotelId: ''
            };
            this.showModal = true;
        },

        openEditModal(reservation) {
            this.currentReservation = { ...reservation };
            this.showModal = true;
        },

        async saveReservation() {
            try {
                await this.connection.invoke("SaveReservation", this.currentReservation);
                this.closeModal();
                Swal.fire({
                    icon: 'success',
                    title: 'Success',
                    text: 'Reservation saved successfully'
                });
            } catch (error) {
                console.error("Error saving reservation:", error);
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: error.message || 'Error saving reservation'
                });
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
                    
                    if (Swal) {
                        Swal.fire({
                            title: 'Eliminada!',
                            text: 'La reservación ha sido eliminada.',
                            icon: 'success',
                            confirmButtonColor: '#0d5c46'
                        });
                    }
                } else {
                    throw new Error('No connection to server');
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
        },

        getTripCapacity(tripId) {
            const trip = this.trips.find(t => t.id === tripId);
            if (!trip) return { current: 0, max: 30 };
            return {
                current: trip.currentReservations,
                max: trip.maxCapacity,
                remaining: trip.remainingCapacity
            };
        },

        getTripName(tripId) {
            const trip = this.trips.find(t => t.id === tripId);
            return trip ? trip.tripName : 'Unknown Trip';
        },

        closeModal() {
            this.showModal = false;
        }
    }));
});
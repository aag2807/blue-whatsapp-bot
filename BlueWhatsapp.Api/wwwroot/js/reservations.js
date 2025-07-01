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
        showCancelModal: false,
        showRescheduleModal: false,
        currentTab: 'all',
        currentReservation: { 
            id: 0, 
            username: '', 
            userNumber: '', 
            email: '',
            roomNumber: '',
            adultsCount: 1,
            childrenCount: 0,
            details: '',
            reservationDate: '',
            reserveTime: '',
            hotelName: '',
            tripId: '',
            scheduleId: '',
            hotelId: ''
        },
        reservationToCancel: null,
        reservationToReschedule: null,
        cancelReason: '',
        customCancelReason: '',
        rescheduleReason: '',
        customRescheduleReason: '',
        rescheduleData: {
            reservationDate: '',
            scheduleId: '',
            tripId: ''
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
            // Explicitly ensure modals are hidden on initialization
            this.showModal = false;
            this.showCancelModal = false;
            this.showRescheduleModal = false;
            
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

            this.connection.on("ReservationStatusChanged", (statusUpdate) => {
                // Find and update the reservation in the local array
                const reservation = this.reservations.find(r => r.id === statusUpdate.reservationId);
                if (reservation) {
                    reservation.status = statusUpdate.status;
                    reservation.statusReason = statusUpdate.statusReason;
                    console.log(`Updated reservation ${statusUpdate.reservationId} status to ${statusUpdate.status}`);
                } else {
                    console.warn(`Reservation with ID ${statusUpdate.reservationId} not found in local array`);
                }
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
                    const reservationDate = this.parseLocalDate(r.reservationDate);
                    const today = new Date();
                    return reservationDate && reservationDate.toDateString() === today.toDateString();
                });
            } else if (this.currentTab === 'upcoming') {
                const today = new Date();
                filtered = filtered.filter(r => {
                    const reservationDate = this.parseLocalDate(r.reservationDate);
                    return reservationDate && reservationDate > today;
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

        // Computed property for trips with daily capacity info
        get availableTrips() {
            if (!this.currentReservation.reservationDate) {
                return this.trips.map(trip => ({
                    ...trip,
                    dailyCapacity: { current: 0, max: 30, remaining: 30 },
                    hasCapacity: true
                }));
            }
            
            return this.getAvailableTripsForDate(this.currentReservation.reservationDate);
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
            // Parse as local date to avoid timezone issues
            const [year, month, day] = date.split('-');
            const localDate = new Date(parseInt(year), parseInt(month) - 1, parseInt(day));
            const options = { day: '2-digit', month: '2-digit', year: 'numeric' };
            return localDate.toLocaleDateString('es-ES', options);
        },

        // Helper function to parse date string as local date
        parseLocalDate(dateString) {
            if (!dateString) return null;
            const [year, month, day] = dateString.split('-');
            return new Date(parseInt(year), parseInt(month) - 1, parseInt(day));
        },

        // Method to format date for templates (avoiding timezone issues)
        formatDateForDisplay(dateString) {
            if (!dateString) return 'No disponible';
            const [year, month, day] = dateString.split('-');
            const localDate = new Date(parseInt(year), parseInt(month) - 1, parseInt(day));
            return localDate.toLocaleDateString('es-ES', { day: '2-digit', month: '2-digit', year: 'numeric' });
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
                email: '',
                roomNumber: '',
                adultsCount: 1,
                childrenCount: 0,
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
            
            // Map hotel name to hotel ID
            if (reservation.hotelName && this.hotels.length > 0) {
                const hotel = this.hotels.find(h => h.name === reservation.hotelName);
                if (hotel) {
                    this.currentReservation.hotelId = hotel.id;
                } else {
                    this.currentReservation.hotelId = '';
                }
            } else {
                this.currentReservation.hotelId = '';
            }
            
            // Map reserve time to schedule ID
            if (reservation.reserveTime && this.schedules.length > 0) {
                const schedule = this.schedules.find(s => s.time === reservation.reserveTime);
                if (schedule) {
                    this.currentReservation.scheduleId = schedule.id;
                } else {
                    this.currentReservation.scheduleId = '';
                }
            } else {
                this.currentReservation.scheduleId = '';
            }
            
            this.showModal = true;
        },

        async saveReservation() {
            try {
                // Validate daily capacity before saving
                if (!this.hasDailyCapacity(
                    this.currentReservation.tripId, 
                    this.currentReservation.reservationDate, 
                    this.currentReservation.id // Exclude current reservation when editing
                )) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Capacidad Excedida',
                        text: `El viaje seleccionado ya tiene 30 reservaciones para la fecha ${this.formatDateForDisplay(this.currentReservation.reservationDate)}. Por favor seleccione otro viaje o fecha.`
                    });
                    return;
                }

                // Always update fields based on current selections
                if (this.currentReservation.hotelId) {
                    const hotel = this.hotels.find(h => h.id == this.currentReservation.hotelId);
                    if (hotel) {
                        this.currentReservation.hotelName = hotel.name;
                    }
                }

                if (this.currentReservation.scheduleId) {
                    const schedule = this.schedules.find(s => s.id == this.currentReservation.scheduleId);
                    if (schedule) {
                        this.currentReservation.reserveTime = schedule.time;
                    }
                }

                // Convert string values to proper types
                const reservationToSave = {
                    ...this.currentReservation,
                    tripId: parseInt(this.currentReservation.tripId) || 0,
                    scheduleId: parseInt(this.currentReservation.scheduleId) || 0,
                    hotelId: parseInt(this.currentReservation.hotelId) || 0,
                    adultsCount: parseInt(this.currentReservation.adultsCount) || 1,
                    childrenCount: parseInt(this.currentReservation.childrenCount) || 0
                };

                await this.connection.invoke("SaveReservation", reservationToSave);
                this.closeModal();
                Swal.fire({
                    icon: 'success',
                    title: 'Success',
                    text: 'Reservation saved successfully'
                });
                this.loadData();
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

        // New method: Get daily capacity for a specific trip and date
        getDailyTripCapacity(tripId, date) {
            if (!date || !tripId) return { current: 0, max: 30, remaining: 30 };
            
            // Count reservations for this trip on this specific date
            const dailyReservations = this.reservations.filter(r => 
                r.tripId === tripId && 
                r.reservationDate === date &&
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

        // Check if a trip has available capacity for a specific date
        hasDailyCapacity(tripId, date, excludeReservationId = null) {
            if (!date || !tripId) return false;
            
            const dailyReservations = this.reservations.filter(r => 
                r.tripId === tripId && 
                r.reservationDate === date &&
                r.status !== 'Cancelled' &&
                r.id !== excludeReservationId // Exclude current reservation when editing
            );
            
            return dailyReservations.length < 30;
        },

        // Get available trips for a specific date
        getAvailableTripsForDate(date) {
            if (!date) return this.trips;
            
            return this.trips.map(trip => {
                const dailyCapacity = this.getDailyTripCapacity(trip.id, date);
                return {
                    ...trip,
                    dailyCapacity: dailyCapacity,
                    hasCapacity: dailyCapacity.remaining > 0
                };
            });
        },

        getTripName(tripId) {
            const trip = this.trips.find(t => t.id === tripId);
            return trip ? trip.tripName : 'Unknown Trip';
        },

        closeModal() {
            this.showModal = false;
        },

        updateReserveTime() {
            if (this.currentReservation.scheduleId) {
                const schedule = this.schedules.find(s => s.id == this.currentReservation.scheduleId);
                if (schedule) {
                    this.currentReservation.reserveTime = schedule.time;
                }
            } else {
                this.currentReservation.reserveTime = '';
            }
        },

        // Cancel functionality
        openCancelModal(reservation) {
            this.reservationToCancel = reservation;
            this.cancelReason = 'reason';
            this.customCancelReason = '';
            this.showCancelModal = true;
        },

        closeCancelModal() {
            this.showCancelModal = false;
            this.reservationToCancel = null;
            this.cancelReason = '';
            this.customCancelReason = '';
        },

        async confirmCancelReservation() {
            if (!this.cancelReason) {
                alert('Por favor seleccione un motivo para la cancelación');
                return;
            }

            const reason = this.cancelReason === 'Otro' ? this.customCancelReason : this.cancelReason;
            
            if (this.cancelReason === 'Otro' && !this.customCancelReason.trim()) {
                alert('Por favor especifique el motivo de la cancelación');
                return;
            }

            try {
                await this.connection.invoke("CancelReservation", this.reservationToCancel.id, reason);
                this.closeCancelModal();
                Swal.fire({
                    icon: 'success',
                    title: 'Cancelada',
                    text: 'La reservación ha sido cancelada exitosamente'
                });
            } catch (error) {
                console.error("Error cancelling reservation:", error);
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: error.message || 'Error al cancelar la reservación'
                });
            }
        },

        // Reschedule functionality
        openRescheduleModal(reservation) {
            this.reservationToReschedule = reservation;
            this.rescheduleReason = '';
            this.customRescheduleReason = '';
            this.rescheduleData = {
                reservationDate: reservation.reservationDate,
                scheduleId: reservation.scheduleId || '',
                tripId: reservation.tripId || ''
            };
            this.showRescheduleModal = true;
        },

        closeRescheduleModal() {
            this.showRescheduleModal = false;
            this.reservationToReschedule = null;
            this.rescheduleReason = '';
            this.customRescheduleReason = '';
            this.rescheduleData = {
                reservationDate: '',
                scheduleId: '',
                tripId: ''
            };
        },

        async confirmRescheduleReservation() {
            if (!this.rescheduleReason) {
                alert('Por favor seleccione un motivo para la reprogramación');
                return;
            }

            if (!this.rescheduleData.reservationDate || !this.rescheduleData.tripId) {
                alert('Por favor complete todos los campos requeridos');
                return;
            }

            // Validate daily capacity before proceeding
            if (!this.hasDailyCapacity(
                this.rescheduleData.tripId, 
                this.rescheduleData.reservationDate, 
                this.reservationToReschedule.id // Exclude the original reservation
            )) {
                Swal.fire({
                    icon: 'error',
                    title: 'Capacidad Excedida',
                    text: `El viaje seleccionado ya tiene 30 reservaciones para la fecha ${this.formatDateForDisplay(this.rescheduleData.reservationDate)}. Por favor seleccione otro viaje o fecha.`
                });
                return;
            }

            const reason = this.rescheduleReason === 'Otro' ? this.customRescheduleReason : this.rescheduleReason;
            
            if (this.rescheduleReason === 'Otro' && !this.customRescheduleReason.trim()) {
                alert('Por favor especifique el motivo de la reprogramación');
                return;
            }

            // Create new reservation data based on original reservation
            const newReservation = {
                ...this.reservationToReschedule,
                id: 0, // New reservation
                reservationDate: this.rescheduleData.reservationDate,
                scheduleId: this.rescheduleData.scheduleId,
                tripId: this.rescheduleData.tripId,
                originalReservationId: this.reservationToReschedule.id
            };

            try {
                await this.connection.invoke("RescheduleReservation", this.reservationToReschedule.id, newReservation, reason);
                this.closeRescheduleModal();
                Swal.fire({
                    icon: 'success',
                    title: 'Reprogramada',
                    text: 'La reservación ha sido reprogramada exitosamente'
                });
            } catch (error) {
                console.error("Error rescheduling reservation:", error);
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: error.message || 'Error al reprogramar la reservación'
                });
            }
        }
    }));
});
/**
 * @typedef {Object} Schedule
 * @property {number} id
 * @property {string} name
 * @property {string} time
 */

/**
 * @typedef {Object} PaginatedResponse
 * @property {number} total
 * @property {number} page
 * @property {number} pageSize
 * @property {Schedule[]} data
 */

document.addEventListener('alpine:init', () => {
    Alpine.data('schedulesManagement', () => ({
        /**
         * @type {Schedule[]}
         */
        schedules: [],
        
        hotels: [],
        showModal: false,
        showHotelsModal: false,
        currentSchedule: { id: 0, name: '', time: '' },
        selectedSchedule: { id: 0, name: '', hotelSchedules: [] },
        hotelSchedules: [],
        hotelSearch: '',
        saving: false,
        savingAssignments: false,
        loading: true,
        error: null,
        connection: null,
        currentPage: 1,

        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/schedules")
                .withAutomaticReconnect()
                .build();

            this.connection.on('ReceiveSchedules', (schedules) => {
                this.schedules = schedules;
            });

            this.connection.start()
                .then(() => {
                    this.fetchSchedules();
                })
                .catch(err => {
                    console.error('Error starting connection:', err);
                });
        },

        get schedulesCount() {
            return this.schedules.length;
        },

        get filteredHotels() {
            if (!this.hotelSearch.trim()) {
                return this.hotels;
            }

            const search = this.hotelSearch.toLowerCase();
            return this.hotels.filter(hotel =>
                hotel.name.toLowerCase().includes(search) ||
                (hotel.meetingPoint && hotel.meetingPoint.toLowerCase().includes(search))
            );
        },

        isHotelAssigned(hotelId) {
            return this.hotelSchedules.some(hs => hs.hotelId === hotelId);
        },

        getHotelSchedule(hotelId) {
            return this.hotelSchedules.find(hs => hs.hotelId === hotelId) || {};
        },

        toggleHotelAssignment(hotel) {

        },

        async fetchSchedules()
        {
            this.connection.invoke('GetSchedules');
        },

        openAddModal() {
            this.currentSchedule = { id: 0, name: '', time: '' };
            this.showModal = true;
        },

        openEditModal(schedule) {
            this.currentSchedule = { ...schedule };
            this.showModal = true;
        },

        openHotelsModal(schedule) {
            this.selectedSchedule = { ...schedule };
            this.hotelSchedules = schedule.hotelSchedules ? [...schedule.hotelSchedules] : [];
            this.hotelSearch = '';
            this.showHotelsModal = true;
        },

        async saveSchedule() {
            this.saving = true;
            try {
                await this.connection.invoke('CreateSchedule', this.currentSchedule);
            } catch (error) {
                console.error('Error saving schedule:', error);
            } finally {
                this.showModal = false;
                this.saving = false;
            }
        },

        async saveHotelAssignments() {

        },

        async deleteSchedule(scheduleId) {
            const { Swal } = window;
            Swal.fire({
                title: '¿Estás seguro?',
                text: 'No podrás revertir esto!',
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Si, eliminar!',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                if (result.isConfirmed) {
                    this.connection.invoke('DeleteSchedule', scheduleId);
                }
            });
        }
    }));
});
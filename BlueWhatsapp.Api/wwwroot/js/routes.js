const { animate, scroll, stagger } = Motion

/**
 * @typedef {Object} Route
 * @property {number} id
 * @property {string} name
 * @property {string} description
 */

document.addEventListener('alpine:init', () => {
    Alpine.data('routesManagement', () => ({
        /**
         * @type {Route[]}
         */
        routes: [],
        showModal: false,
        /**
         * @type {Route}
         */
        currentRoute: { id: 0, name: '', description: '' },
        saving: false,
        loading: true,
        error: null,
        connection: null,
        isEditing: false,
        animateElement(el, index) {
            const delay = index + 1;
            setTimeout(() => {
                el.classList.remove('hidden');
                animate(el, {
                    opacity: [0, 1],
                    x: [100, 0],
                    delay: delay * 0.2
                });
            }, 100 * delay);
        },
        
        init() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/routes")
                .withAutomaticReconnect()
                .build();

            this.connection.start()
            .then(() => {
                this.connection.invoke('GetRoutes');
                this.loading = true;
            })
            .catch(err => {
                console.error('SignalR Connection Error: ', err);
                this.loading = false;
            });

            this.connection.on('ReceiveRoutes', (routes) => {
                this.receiveRoutes(routes);
            });

            this.connection.onclose(() => {
                console.log('SignalR Connection Closed');
            });

            this.connection.onreconnecting(() => {
                console.log('SignalR Reconnecting...');
            });

            this.connection.onreconnected(() => {
                console.log('SignalR Reconnected');
            });
        },

        receiveRoutes(routes) {
            this.routes = routes;
            this.loading = false;
        },

        get routeCount() {
            return this.routes.length;
        },

        openAddModal() {
            this.currentRoute = { id: 0, name: '', description: '' };
            this.showModal = true;
        },
        
        openEditModal(route) {
            this.currentRoute = { ...route };
            this.showModal = true;
            this.isEditing = true;
        },

        async saveRoute() {
            if (this.isEditing) {
                await this.updateRoute();
            } else {
                await this.createRoute();
            }
        },

        async createRoute() {
            if (!this.connection || this.connection.state !== signalR.HubConnectionState.Connected) {
                console.error('SignalR connection is not established');
                return;
            }

            this.saving = true;
            try {
                console.log('Attempting to create route:', this.currentRoute);
                const routeToCreate = {
                    id: 0,
                    name: this.currentRoute.name,
                    description: this.currentRoute.description
                };
                await this.connection.invoke('CreateRoute', routeToCreate);
                this.showModal = false;
            } catch (error) {
                console.error('Error creating route:', error);
                alert('Error creating route: ' + error.message);
            } finally {
                this.saving = false;
            }
        },

        async updateRoute() {
            this.saving = true;
            await this.connection.invoke('UpdateRoute', this.currentRoute);
            this.showModal = false;
            this.saving = false;
        },

        async deleteRoute(id) {
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
            }).then(async (result) => {
                if (result.isConfirmed) {
                    await this.connection.invoke('DeleteRoute', id);
                }
            });
        }
    }));
});
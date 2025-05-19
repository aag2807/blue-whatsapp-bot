document.addEventListener('alpine:init', () => {
    Alpine.data('usersManagement', () => ({
        users: [],
        filteredUsers: [],
        searchTerm: '',
        showModal: false,
        showPasswordModal: false,
        currentUser: {
            id: null,
            name: '',
            email: '',
            password: ''
        },
        passwordData: {
            newPassword: '',
            confirmPassword: ''
        },
        connection: null,

        init() {
            this.initializeSignalR();
            this.$watch('searchTerm', (value) => {
                this.filterUsers();
            });
        },

        get usersCount() {
            return this.filteredUsers.length;
        },

        initializeSignalR() {
            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/users")
                .withAutomaticReconnect()
                .build();

            this.connection.on("ReceiveUsers", (users) => {
                this.users = users;
                this.filterUsers();
            });

            this.connection.on("Error", (message) => {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: message
                });
            });

            this.connection.start()
                .then(() => {
                    console.log("Connected to UsersHub");
                    this.loadUsers();
                })
                .catch(err => console.error("Error connecting to UsersHub:", err));
        },

        loadUsers() {
            this.connection.invoke("GetAllUsers")
                .catch(err => console.error("Error loading users:", err));
        },

        filterUsers() {
            if (!this.searchTerm) {
                this.filteredUsers = this.users;
                return;
            }

            const searchLower = this.searchTerm.toLowerCase().trim();
            this.filteredUsers = this.users.filter(user => 
                user.name.toLowerCase().includes(searchLower) ||
                user.email.toLowerCase().includes(searchLower) ||
                user.id.toString().includes(searchLower)
            );
        },

        openAddModal() {
            this.currentUser = {
                id: null,
                name: '',
                email: '',
                password: ''
            };
            this.showModal = true;
        },

        openEditModal(user) {
            this.currentUser = { ...user };
            this.showModal = true;
        },

        openPasswordModal() {
            this.passwordData = {
                newPassword: '',
                confirmPassword: ''
            };
            this.showPasswordModal = true;
        },

        updatePassword() {
            if (!this.passwordData.newPassword || !this.passwordData.confirmPassword) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: 'Por favor complete todos los campos'
                });
                return;
            }

            if (this.passwordData.newPassword !== this.passwordData.confirmPassword) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: 'Las contraseñas no coinciden'
                });
                return;
            }

            this.connection.invoke("UpdatePassword", this.passwordData.newPassword)
                .then(() => {
                    this.showPasswordModal = false;
                    Swal.fire({
                        icon: 'success',
                        title: 'Éxito',
                        text: 'Contraseña actualizada correctamente'
                    });
                })
                .catch(err => {
                    console.error("Error updating password:", err);
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'Error al actualizar la contraseña'
                    });
                });
        },

        saveUser() {
            if (!this.currentUser.name || !this.currentUser.email) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: 'Por favor complete todos los campos requeridos'
                });
                return;
            }

            if (!this.currentUser.id && !this.currentUser.password) {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: 'La contraseña es requerida para nuevos usuarios'
                });
                return;
            }

            if (this.currentUser.id) {
                this.connection.invoke("UpdateUser", this.currentUser)
                    .then(() => {
                        this.showModal = false;
                        Swal.fire({
                            icon: 'success',
                            title: 'Éxito',
                            text: 'Usuario actualizado correctamente'
                        });
                    })
                    .catch(err => {
                        console.error("Error updating user:", err);
                        Swal.fire({
                            icon: 'error',
                            title: 'Error',
                            text: 'Error al actualizar el usuario'
                        });
                    });
            } else {
                this.connection.invoke("CreateUser", this.currentUser)
                    .then(() => {
                        this.showModal = false;
                        Swal.fire({
                            icon: 'success',
                            title: 'Éxito',
                            text: 'Usuario creado correctamente'
                        });
                    })
                    .catch(err => {
                        console.error("Error creating user:", err);
                        Swal.fire({
                            icon: 'error',
                            title: 'Error',
                            text: 'Error al crear el usuario'
                        });
                    });
            }
        },

        deleteUser(id) {
            Swal.fire({
                title: '¿Estás seguro?',
                text: "Esta acción no se puede deshacer",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Sí, eliminar',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                if (result.isConfirmed) {
                    this.connection.invoke("DeleteUser", id)
                        .catch(err => {
                            console.error("Error deleting user:", err);
                            Swal.fire({
                                icon: 'error',
                                title: 'Error',
                                text: 'Error al eliminar el usuario'
                            });
                        });
                }
            });
        },

        animateElement(element, index) {
            setTimeout(() => {
                element.classList.remove('hidden');
                element.classList.add('animate-fade-in');
            }, index * 50);
        }
    }));
}); 
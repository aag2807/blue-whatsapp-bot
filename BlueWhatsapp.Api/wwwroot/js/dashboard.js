const { animate, scroll, stagger } = Motion

/**
 * @typedef {Object} OpenChat
 * @property {string} number
 * @property {string} from
 * @property {string} body
 * @property {number} status
 * @property {string} createdTime
 */

/**
 * @typedef {Object} Conversation
 * @property {number} currentStep
 * @property {boolean} isAdminOverridden
 * @property {boolean} isComplete
 * @property {string} userNumber
 * @property {string} createdTime //ex  0001-01-01T00:00:00
 * @property {string} modifiedTime //  0001-01-01T00:00:00
 */

/**
 * @typedef {Object} WeeklyConversation
 * @property {number} flow
 * @property {string} userNumber
 * @property {number} currentStep
 * @property {boolean} isAdminOverridden
 * @property {boolean} isComplete
 * @property {string} createdTime //ex  0001-01-01T00:00:00
 * @property {string} modifiedTime //  0001-01-01T00:00:00
 * @property {string} zoneId
 * @property {string} hotelId
 * @property {string} languageId
 * @property {string} pickUpDate
 * @property {string} reservationDetails
 * @property {string} scheduleId
 * @property {string} personName
 */

document.addEventListener('alpine:init', () => {
    Alpine.data('dashboard', () => ({
        // State variables
        openChats: 0,
        totalMessages: 0,
        recentMessages: [],
        currentConversation: null,
        modalConversationHeader: '',
        conversationMessages: [],
        currentConversationId: null,
        connection: null,
        newMessage: '',
        isOpen: false,

        // Chart references
        chartRef$: null,
        mobileChartRef$: null,

        // Conversation lists
        conversations: [],
        pendingChats: [],
        closedChats: [],
        weeklyConversations: [],
        recentConversations: [],

        // Computed properties
        get pendingChatCount() {
            return this.pendingChats.length;
        },

        get closedChatCount() {
            return this.closedChats.length;
        },

        get weeklyConversationCount() {
            return this.weeklyConversations.length;
        },

        // Methods
        showAllConversationMessages(conversation) {
            this.modalConversationHeader = conversation.userNumber + ' - ' + conversation.personName;
            this.currentConversationId = conversation.id;
            this.conversationMessages = [];
            this.isOpen = true;
            
            // Get messages for this conversation
            this.connection.invoke("GetAllMessagesFromConversation", conversation.id)
                .then(() => {
                    // Scroll to bottom after messages are loaded
                    this.$nextTick(() => {
                        const chatMessages = document.getElementById('chat-messages');
                        if (chatMessages) {
                            chatMessages.scrollTop = chatMessages.scrollHeight;
                        }
                    });
                })
                .catch(error => {
                    console.error("Error loading conversation messages:", error);
                });
        },
        
        handleConversationRefresh()
        {
            console.log('conversation refresh');
            this.connection.invoke("GetAllMessagesFromConversation", this.currentConversationId)
        },

        sendMessage() {
            if (!this.newMessage.trim() || !this.currentConversationId) return;
            
            // Send message through SignalR
            this.connection.invoke("SendMessageToConversation", this.currentConversationId, this.newMessage)
                .then(() => {
                    // Clear input after successful send
                    this.newMessage = '';

                    // Scroll to bottom
                    this.$nextTick(() => {
                        const chatMessages = document.getElementById('chat-messages');
                        if (chatMessages) {
                            chatMessages.scrollTop = chatMessages.scrollHeight;
                        }
                    });
                })
                .catch(error => {
                    console.error("Error sending message:", error);
                });
        },

        mapDateTime(dateTime) {
            if (!dateTime) return '';
            const date = new Date(dateTime);
            return date.toLocaleString('es-ES', {
                year: 'numeric',
                month: '2-digit',
                day: '2-digit',
                hour: '2-digit',
                minute: '2-digit'
            });
        },

        handleManuallyConversation(conversation) {
            if(conversation.isAdminOverridden) {
                return;
            }
            
            this.connection.invoke("MarkConversationAsManuallyOverriden", conversation.id);
        },

        animateElement(el, index) {
            setTimeout(() => {
                el.classList.remove('hidden');
                animate(el, {
                    opacity: [0, 1],
                    x: [100, 0],
                    delay: (index + 1) * 0.2
                });
            }, 100 * (index + 1));
        },

        animateClosedChats() {
            const closedCounterCard = document.getElementById('closed-counter-card');
            if (closedCounterCard) {
                animate(0, this.closedChatCount,
                    {
                        ease: 'circCout',
                        onUpdate: (value) => {
                            closedCounterCard.textContent = Math.round(value);
                        }
                    }
                )
            }

            const closedCounterResponsive = document.getElementById('closed-counter-responsive');
            if (closedCounterResponsive) {
                animate(0, this.closedChatCount,
                    {
                        ease: 'circCout',
                        onUpdate: (value) => {
                            closedCounterResponsive.textContent = Math.round(value);
                        }
                    }
                )
            }
        },
        animateOpenChats() {
            const openCounterCard = document.getElementById('open-counter-card');
            if (openCounterCard) {
                animate(0, this.pendingChatCount,
                    {
                        ease: 'circCout',
                        onUpdate: (value) => {
                            openCounterCard.textContent = Math.round(value);
                        }
                    }
                )
            }

            const openCounterResponsive = document.getElementById('open-counter-responsive');
            if (openCounterResponsive) {
                animate(0, this.pendingChatCount,
                    {
                        ease: 'circCout',
                        onUpdate: (value) => {
                            openCounterResponsive.textContent = Math.round(value);
                        }
                    }
                )
            }
        },
        animateTotalConversations() {
            const totalConversationsResponsive = document.getElementById('total-conversations-responsive');
            if (totalConversationsResponsive) {
                animate(0, this.weeklyConversationCount,
                    {
                        ease: 'circCout',
                        onUpdate: (value) => {
                            totalConversationsResponsive.textContent = Math.round(value);
                        }
                    }
                )
            }

            const totalConversationsCard = document.getElementById('total-conversations-card');
            if (totalConversationsCard) {
                animate(0, this.weeklyConversationCount,
                    {
                        ease: 'circCout',
                        onUpdate: (value) => {
                            totalConversationsCard.textContent = Math.round(value);
                        }
                    }
                )
            }
        },
        init() {
            // Debounce function
            const debounce = (func, wait) => {
                let timeout;
                return function executedFunction(...args) {
                    const later = () => {
                        clearTimeout(timeout);
                        func(...args);
                    };
                    clearTimeout(timeout);
                    timeout = setTimeout(later, wait);
                };
            };

            // Debounced resize handler
            const handleResize = debounce(() => {
                if (this.chartRef$ && this.weeklyConversations.length > 0) {
                    this.chartRef$.destroy();
                    this.mobileChartRef$.destroy();
                    this.initCharts(this.weeklyConversations);
                }
            }, 250);

            window.addEventListener("resize", handleResize);

            this.connection = new signalR.HubConnectionBuilder()
                .withUrl("/messages")
                .withAutomaticReconnect()
                .build();

            this.connection.on('ReceiveOpenChats', (openChats) => {
                const mappedPendingChats = openChats.map(m => ({
                    from: m.from,
                    timestamp: new Date(m.createdTime).toLocaleString()
                }))

                this.pendingChats = mappedPendingChats
                this.animateOpenChats()
            })
            
            this.connection.on("RefreshCurrentConversation", () =>
            {
              this.handleConversationRefresh()  
            })

            this.connection.on("ReceiveWeeklyConversations", (weeklyConversations) => {
                this.weeklyConversations = weeklyConversations;
                this.initCharts(weeklyConversations);
                this.animateTotalConversations()
            })
            
            this.connection.on("ReceiveModalMessages", (messages) => {
                this.conversationMessages = messages.map(m => ({
                    from: m.from,
                    body: m.body,
                    createdTime: m.createdTime,
                    status: m.status
                }));
                
                // Scroll to bottom after messages are loaded
                this.$nextTick(() => {
                    const chatMessages = document.getElementById('chat-messages');
                    if (chatMessages) {
                        chatMessages.scrollTop = chatMessages.scrollHeight;
                    }
                });
            });

            this.connection.on('ReceiveClosedMessages', (openChats) => {
                const mappedClosedChats = openChats.map(m => ({
                    from: m.from,
                    timestamp: new Date(m.createdTime).toLocaleString()
                }))

                this.closedChats = mappedClosedChats
                this.animateClosedChats()
            })

            // Handle receiving a new message
            this.connection.on("ReceiveWhatsAppMessage", (from, timestamp) => {
                this.connection.invoke("GetPendingMessages");
                this.connection.invoke("GetClosedMessages");
                this.connection.invoke("GetAllConversations");
                this.connection.invoke("GetWeeklyConversations");
                this.connection.invoke("GetRecentConversations", 20);
            });

            this.connection.on("ReceiveAllConversations", (conversations) => {
                this.conversations = conversations;
            });

            // Handle receiving recent messages
            this.connection.on("ReceiveRecentMessages", (messages) => {
                this.recentMessages = messages.map(m => ({
                    from: m.from,
                    timestamp: new Date(m.createdTime).toLocaleString()
                }));
            });

            // Handle receiving message history for a conversation
            this.connection.on("ReceiveMessageHistory", (from, messages) => {
                this.conversationMessages = messages.map(m => ({
                    from: m.from,
                    body: m.body,
                    createdTime: m.createdTime,
                    status: m.status
                }));
                
                // Scroll to bottom after messages are loaded
                this.$nextTick(() => {
                    const chatMessages = document.getElementById('chat-messages');
                    if (chatMessages) {
                        chatMessages.scrollTop = chatMessages.scrollHeight;
                    }
                });
            });

            this.connection.on("ReceiveRecentConversations", (conversations) => {
                this.recentConversations = conversations;
            });


            // Start the connection
            this.connection.start()
                .then(() => {
                    this.connection.invoke("GetPendingMessages");
                    this.connection.invoke("GetClosedMessages");
                    this.connection.invoke("GetAllConversations");
                    this.connection.invoke("GetWeeklyConversations");
                    this.connection.invoke("GetRecentConversations", 20);
                })
                .catch(err => console.error("SignalR Connection Error: ", err));
        },
        // Method to load a conversation
        loadConversation(from) {
            this.connection.invoke("GetMessagesByFrom", from);
        },
        // Method to show browser notification
        showNotification(from) {
            if (Notification.permission === "granted") {
                new Notification("New WhatsApp Message", { body: `New message from ${from}` });
            } else if (Notification.permission !== "denied") {
                Notification.requestPermission();
            }
        },
        initCharts(weeklyConversations) {
            const ctx = document.getElementById('totalClosedConversationsVsOpen');
            const mobileCtx = document.getElementById('mobileTotalClosedConversationsVsOpen');

            const closedConversations = weeklyConversations.filter(cv => cv.isComplete);
            const openConversations = weeklyConversations.filter(cv => !cv.isComplete);

            // If chart already exists, destroy it before creating a new one
            if (this.chartRef$) {
                this.chartRef$.destroy();
            }

            if (this.mobileChartRef$) {
                this.mobileChartRef$.destroy();
            }

            //chart js donut chart config
            const data = {
                labels: ['Abiertas', 'Cerradas'],
                datasets: [{
                    data: [openConversations.length, closedConversations.length],
                    backgroundColor: ['#FF6384', '#36A2EB'],
                    hoverBackgroundColor: ['#FF6384', '#36A2EB']
                }]
            };

            const options = {
                responsive: true,
                maintainAspectRatio: true,
                aspectRatio: 1.5,
                plugins: {
                    legend: {
                        position: 'bottom',
                        labels: {
                            font: {
                                size: 16
                            }
                        }
                    }
                },
                onResize: (chart, size) => {
                    chart.resize();
                }
            };

            this.chartRef$ = new Chart(ctx, {
                type: 'doughnut',
                data: data,
                options: options
            });

            this.mobileChartRef$ = new Chart(mobileCtx, {
                type: 'doughnut',
                data: data,
                options: options
            });

            // Force a resize after initialization
            setTimeout(() => {
                if (this.chartRef$) {
                    this.chartRef$.resize();
                }
                if (this.mobileChartRef$) {
                    this.mobileChartRef$.resize();
                }
            }, 100);
        }

    }));
})

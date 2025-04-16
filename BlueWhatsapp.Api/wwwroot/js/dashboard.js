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
        openChats: 0,
        totalMessages: 0,
        recentMessages: [],
        currentConversation: null,
        conversationMessages: [],
        connection: null,
        /**
         * @type {Conversation[]}
         */
        conversations: [],
        /**
         * @type {Conversation[]}
         */
        pendingChats: [],
        /**
         * @type {Conversation[]}
         */
        closedChats: [],

        /**
         * @type {WeeklyConversation[]}
         */
        weeklyConversations: [],

        /**
         * @type {Conversation[]}
         */
        recentConversations: [],

        get pendingChatCount() {
            return this.pendingChats.length;
        },

        get closedChatCount() {
            return this.closedChats.length;
        },

        get weeklyConversationCount() {
            return this.weeklyConversations.length;
        },

        mapDateTime(dateTime) {
            return new Date(dateTime).toLocaleString();
        },

        init() {
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
            })

            this.connection.on("ReceiveWeeklyConversations", (weeklyConversations) => {
                this.weeklyConversations = weeklyConversations;
                this.initCharts(weeklyConversations);
            })

            this.connection.on('ReceiveClosedMessages', (openChats) => {
                const mappedClosedChats = openChats.map(m => ({
                    from: m.from,
                    timestamp: new Date(m.createdTime).toLocaleString()
                }))

                this.closedChats = mappedClosedChats
            })

            // Handle receiving a new message
            this.connection.on("ReceiveWhatsAppMessage", (from, timestamp) => {
                this.connection.invoke("GetPendingMessages")
                this.connection.invoke("GetClosedMessages")
                this.connection.invoke("GetAllConversations");
                this.connection.invoke("GetWeeklyConversations");
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
                this.currentConversation = from;
                this.conversationMessages = messages.map(m => ({
                    from: m.from,
                    body: m.body,
                    timestamp: new Date(m.createdTime).toLocaleString()
                }));
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
                new Notification("New WhatsApp Message", {body: `New message from ${from}`});
            } else if (Notification.permission !== "denied") {
                Notification.requestPermission();
            }
        },
        initCharts(weeklyConversations) {
            const ctx = document.getElementById('totalClosedConversationsVsOpen');
            const openConversations = weeklyConversations.filter(cv => cv.isComplete);
            const closedConversations = weeklyConversations.filter(cv => !cv.isComplete);

            console.log({openConversations, closedConversations});
            
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
                maintainAspectRatio: false,
                plugins: {
                    legend: {
                        position: 'right',
                        labels: {
                            font: {
                                size: 16
                            }
                        }
                    }
                }
            };

            const myChart = new Chart(ctx, {
                type: 'doughnut',
                data: data,
                options: options
            });
        }

    }));
})

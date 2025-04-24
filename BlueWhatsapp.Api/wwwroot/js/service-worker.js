// BlueWhatsApp Bot - Service Worker
const CACHE_NAME = 'bluewhatsapp-cache-v1';

const PRECACHE_ASSETS = [
    '/',
    '/offline.html',
    '/css/index.css',
    '/js/alpine.js',
    '/js/chart.js',
    '/js/dashboard.js',
    '/js/hotels.js',
    '/js/reservations.js',
    '/js/routes.js',
    '/js/schedule.js',
    '/js/sweetalert.js',
    '/js/tailwind.js',
    '/js/trips.js',
    '/manifest.json'
  ];

self.addEventListener('install', event => {
    console.log('Service Worker installing');
    self.skipWaiting(); // Force activation on existing tabs
    event.waitUntil(
        caches.open(CACHE_NAME)
            .then(cache => {
                console.log('Opened cache');
                return cache.addAll(PRECACHE_ASSETS);
            })
            .catch(error => {
                console.error('Precaching failed:', error);
            })
    );
});

self.addEventListener('activate', event => {
    console.log('Service Worker activating');
    const cacheWhitelist = [CACHE_NAME];
    event.waitUntil(
        caches.keys().then(cacheNames => {
            return Promise.all(
                cacheNames.map(cacheName => {
                    if (cacheWhitelist.indexOf(cacheName) === -1) {
                        console.log('Deleting old cache:', cacheName);
                        return caches.delete(cacheName);
                    }
                })
            );
        })
            .then(() => {
                console.log('Service Worker activated');
                return self.clients.claim(); // Take control of all clients
            })
    );
});

const apiPattern = /\/(api|controllers|hubs)\//;

const cacheFirstPattern = /\.(css|js|woff2|png|jpg|jpeg|svg|ico)$/;

self.addEventListener('fetch', event => {
    const url = new URL(event.request.url);
    console.log('Service Worker fetching', url);

    if (url.origin !== self.location.origin) {
        return;
    }

    if (event.request.method !== 'GET') {
        return;
    }

    if (apiPattern.test(url.pathname)) {
        event.respondWith(networkFirstStrategy(event.request));
        return;
    }

    if (cacheFirstPattern.test(url.pathname)) {
        event.respondWith(cacheFirstStrategy(event.request));
        return;
    }

    event.respondWith(networkFirstStrategy(event.request));
});

async function cacheFirstStrategy(request) {
    const cachedResponse = await caches.match(request);
    if (cachedResponse) {
        return cachedResponse;
    }

    try {
        const networkResponse = await fetch(request);

        // Cache valid responses
        if (networkResponse && networkResponse.status === 200 && networkResponse.type === 'basic') {
            const responseToCache = networkResponse.clone();
            const cache = await caches.open(CACHE_NAME);
            cache.put(request, responseToCache);
        }

        return networkResponse;
    } catch (error) {
        console.error('Cache-first fetch failed:', error);
        // If we can't fetch, we have no fallback
        return new Response('Network error occurred', {
            status: 408,
            headers: { 'Content-Type': 'text/plain' }
        });
    }
}

async function networkFirstStrategy(request) {
    try {
        const networkResponse = await fetch(request);

        // Cache valid responses
        if (networkResponse && networkResponse.status === 200 && networkResponse.type === 'basic') {
            const responseToCache = networkResponse.clone();
            const cache = await caches.open(CACHE_NAME);
            cache.put(request, responseToCache);
        }

        return networkResponse;
    } catch (error) {
        console.log('Network first fetch failed, falling back to cache:', error);

        const cachedResponse = await caches.match(request);
        if (cachedResponse) {
            return cachedResponse;
        }

        if (request.headers.get('Accept').includes('text/html')) {
            // For HTML requests, you could return a custom offline page
            return caches.match('/offline.html')
                .catch(() => new Response('You are offline and no cached version is available', {
                    status: 503,
                    headers: { 'Content-Type': 'text/html' }
                }));
        }

        return new Response('Network error occurred and no cached version is available', {
            status: 503,
            headers: { 'Content-Type': 'text/plain' }
        });
    }
}

self.addEventListener('push', event => {
    console.log('Service Worker push', event);
    if (!event.data) return;

    const data = event.data.json();
    const options = {
        body: data.body || 'New notification from BlueWhatsApp Bot',
        icon: '/images/icons/icon-192x192.png',
        badge: '/images/icons/badge-72x72.png',
        data: data.url || '/',
        actions: data.actions || [],
        vibrate: [100, 50, 100]
    };

    event.waitUntil(
        self.registration.showNotification(
            data.title || 'BlueWhatsApp Bot',
            options
        )
    );
});

self.addEventListener('notificationclick', event => {
    console.log('Service Worker notificationclick', event);
    event.notification.close();

    const urlToOpen = event.notification.data || '/';

    event.waitUntil(
        clients.matchAll({ type: 'window' })
            .then(clientList => {
                // Check if a window is already open
                for (const client of clientList) {
                    if (client.url === urlToOpen && 'focus' in client) {
                        return client.focus();
                    }
                }
                // If no window is open, open a new one
                if (clients.openWindow) {
                    return clients.openWindow(urlToOpen);
                }
            })
    );
});
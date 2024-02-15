const cacheName = 'v2';

const cacheFiles = {
    assets: 'assets-v' + cacheName,
    content: 'content-v' + cacheName,
    offline: 'offline-v' + cacheName,
    notFound: '404-v' + cacheName,
};

self.addEventListener('install', (e) => {
    e.waitUntil(
        caches.open(cacheName).then((cache) => {
            return cache.addAll(cacheFiles);
        })
    );
});

//This code will delete any caches with a name different from the current cacheName when the service worker is activated.
self.addEventListener('activate', (e) => {
    e.waitUntil(
        caches.keys().then((keyList) => {
            return Promise.all(
                keyList.map((key) => {
                    if (key !== cacheName) {
                        return caches.delete(key);
                    }
                })
            );
        })
    );
});

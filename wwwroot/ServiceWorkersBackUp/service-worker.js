// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('fetch', () => { });

async function onInstall(event) {
    console.info('Service worker: Install');

    // Activate the new service worker as soon as the old one is retired.
    self.skipWaiting();

    // Fetch and cache all matching items from the assets manifest
    const assetsRequests = self.assetsManifest.assets
        .filter(asset => offlineAssetsInclude.some(pattern => pattern.test(asset.url)))
        .filter(asset => !offlineAssetsExclude.some(pattern => pattern.test(asset.url)))
        //.map(asset => new Request(asset.url, { integrity: asset.hash }));
        .map(asset => new Request(asset.url));//Remove SHA256 Check 
    await caches.open(cacheName).then(cache => cache.addAll(assetsRequests));
}



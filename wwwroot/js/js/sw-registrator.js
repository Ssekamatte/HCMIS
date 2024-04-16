// sw-registrator.js
if ('serviceWorker' in navigator) {
    window.addEventListener('load', () => {
        navigator.serviceWorker.register('service-worker.js').then(registration => {
            console.log('Service Worker registered with scope:', registration.scope);
            registration.addEventListener('updatefound', () => {
                registration.installing.addEventListener('statechange', () => {
                    if (registration.installing.state === 'installed') {
                        if (navigator.serviceWorker.controller) {
                            // A new service worker is installed, but not yet active
                            // Prompt the user to refresh the page to activate the new version
                            displayUpdateNotification();
                        }
                    }
                });
            });
        }).catch(error => {
            console.error('Service Worker registration failed:', error);
        });
    });
}

function displayUpdateNotification() {
    // Display a notification to the user about the update
    // You can customize this notification according to your design preferences
    const updateNotification = document.createElement('div');
    updateNotification.innerHTML = `
        <div style="position: fixed; bottom: 0; left: 0; width: 100%; background-color: #ffffff; padding: 10px; text-align: center;">
            <p>A new version of the app is available!</p>
            <button onclick="refreshApp()">Refresh</button>
        </div>
    `;
    document.body.appendChild(updateNotification);

    // Listen for user's click on the refresh button
    function refreshApp() {
        // Refresh the page to activate the new service worker
        window.location.reload();
    }
}

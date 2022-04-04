if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('/sw.js')
        .then(function (registration) {
            console.log("serviceworker registrado com sucesso no escopo:", registration.scope);
        }, function (error) {
            console.log('falha ao registrat o serviceworker', error)
        })
}
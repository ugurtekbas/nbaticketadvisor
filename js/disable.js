function disableSendingAnalytics() {
    var host = window.location.hostname;
    if(host == "localhost") {
        window['ga-disable-G-YFL3KVP5YX'] = true;
    }
}

disableSendingAnalytics();
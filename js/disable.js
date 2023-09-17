function disableSendingAnalytics() {
    var protocol = window.location.protocol;
    
    if(protocol == "file:") {
        window['ga-disable-G-YFL3KVP5YX'] = true;
    }
}

disableSendingAnalytics();
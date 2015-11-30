console.log = function (message) {
        cordova.exec("", "", "Logger", "log", ["Log : " + message]);
    }
    WL.Logger.warn = function ( message ) {
        cordova.exec("", "", "Logger", "log", ["Warning : " + message]);
    }
    WL.Logger.error = function (message) {
        cordova.exec("", "", "Logger", "log", ["Error : " + message]);
    }
    WL.Logger.debug = function (message) {
        cordova.exec("", "", "Logger", "log", ["Debug : " + message]);
    }
    WL.Logger.info = function (message) {
        cordova.exec("", "", "Logger", "log", ["Info : " + message]);
    }
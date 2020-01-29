window.blazorExtensions = {

    WriteCookie: function (name, value, days) {

        

        /*var expires;
        if (days) {
            let date = new Date.now();
            date.setMinutes(5)
            expires = date.toUTCString();
        }
        else {
            let date = new Date.now;
            date.setMinutes(1);
            expires = date.toUTCString();
        }*/

        alert(days);

        document.cookie = `${name}=${value}; expires=${days}; path=/`
    },
    GetCookie: function () {
        let cookie = document.cookie;
        var value = cookie.split('=')[1];
        alert(value);
        return value;
    }
}

function Redirect(url) {
    window.location.href = url;
}

function Redirect_NewTab(url) {
    window.open(url, '_blank');
}

function Reload() {
    location.reload();
}


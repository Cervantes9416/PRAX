function jsonMessage(code, message) {
  return { "Code": code, "Message": message };
};
function sendToast(data, reload) {

    console.log("send toast->" + data.Code);
    switch (data.Code) {
        case jsonSuccess:
            console.log("success toast");
            $.toast({
                heading: 'Guardado',
                text: data.Message,
                showHideTransition: 'slide',
                icon: 'success',
                position: 'bottom-right',
                afterHidden: function () {
                    if (reload)
                        window.location.reload();
                }
            });
            break;
        case jsonError:
            console.log("error toast");
            $.toast({
                heading: 'Error',
                text: data.Message,
                showHideTransition: 'slide',
                icon: 'error',
                position: 'bottom-right'
            });
            break;
        case jsonWarning:
            console.log("warning toast");
            $.toast({
                heading: 'Problema',
                text: data.Message,
                showHideTransition: 'slide',
                icon: 'warning',
                position: 'bottom-right'
            });
            break;
    }
};

function sendErrorToast() {
    console.log("default error toast");
    $.toast({
        heading: 'Error',
        text: 'Ocurrió un problema',
        showHideTransition: 'slide',
        icon: 'error',
        position: 'bottom-right',

    });
}
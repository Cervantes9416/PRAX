

function Select2Init(){
    $('.js-select2').select2();
}

async function ConfirmMessage(title,message) {
    let result = await Swal.fire({
        title: title,
        text: message,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, Estoy seguro',
        cancelButtonText: 'Cancelar'
    })

    if (result.value) {
        return true;
    } else if (result.dismiss) {
        return false;
    }
}


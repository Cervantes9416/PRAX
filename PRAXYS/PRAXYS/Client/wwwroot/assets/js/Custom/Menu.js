var menu = {}

function initMenu () {
    $(".hamburguer").click(function () {
        $(".wrapper-page").toggleClass("collap");
    });
}

function RemoveAttribute(attribute) {

    $('.readonly-input').prop('readonly', false);
}

function AddAttribute(attribute) {

    $('.readonly-input').prop('readonly', true);
}

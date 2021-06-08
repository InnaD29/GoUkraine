let btnReserveTour = document.querySelector('.reserveTour');
let btnCloseReserve = document.querySelector('.btnCloseForm');
let formReserve = document.querySelector('.formReserve');


btnReserveTour.onclick = function () {
    formReserve.classList.add('slide-form');
}

btnCloseReserve.onclick = function () {
    formReserve.classList.remove('slide-form');
}

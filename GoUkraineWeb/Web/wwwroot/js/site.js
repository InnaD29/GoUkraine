
let header = document.querySelector('header');
let itemsHeader = document.querySelectorAll('.text');
let btnCloseCallMe = document.querySelector('span.btnCloseCallMe');
let callToMe = document.querySelector('.callToMe');
let bookingTour = document.querySelector('.bookingTour');


btnCloseCallMe.onclick = function () {
    document.querySelector('.formCallMe').style.display = 'none';
}
function openForm() {
    document.getElementById("myForm").style.display = "block";
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
}

window.onscroll = function () {
    for (let i = 0; i < itemsHeader.length; i++) {
        if (window.pageYOffset === 0) {
        header.classList.remove('navbar-scroll');
        itemsHeader[i].classList.remove('header-item');
    } else if (window.pageYOffset === 0.90 || window.pageYOffset > 90) {
        header.classList.add('navbar-scroll');
        itemsHeader[i].classList.add('header-item');
        } 
   
    } 
} 
callToMe.onclick = function () {
    let formData = {
        "PhoneNumber": document.querySelector('#PhoneNumber').value,
    }
    $.ajax({
        url: '/Home/AskToCall',
        method: 'POST',
        data: formData,
        success: function (data) {
            if (data.success === true);
            /* document.querySelector('.success-call').style.display = 'block';*/
            alert(true)
        },
        error: function (data) {
            alert('false')
        }

    });
}
function getRequestVerificationToken() {
    var token = "";
    var inputs = $('input[name="__RequestVerificationToken"]');
    if (inputs && inputs.length > 0)
        token = inputs[0].value;
    return token;
}
function initAjaxPrefilter() {
    $.ajaxPrefilter(function (options, originalOptions, jqXHR) {
        if (originalOptions.type === 'POST' || options.type === 'POST' ||
            originalOptions.type === 'PUT' || options.type === 'PUT' ||
            originalOptions.type === 'DELETE' || options.type === 'DELETE' ||
            originalOptions.type === 'PATCH' || options.type === 'PATCH') {

            switch (typeof options.data) {
                case "string": if (options.data.indexOf("__RequestVerificationToken=") == -1) options.data += "&__RequestVerificationToken=" + getRequestVerificationToken() + '';
                    break;
                case "object": options.data.__RequestVerificationToken = getRequestVerificationToken();
                    break;
                default:
            }
        }
    });
}
(function () {
    initAjaxPrefilter();
}());

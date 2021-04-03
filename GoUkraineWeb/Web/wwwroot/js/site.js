
let header = document.querySelector('header');
let itemsHeader = document.querySelectorAll('.text');

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
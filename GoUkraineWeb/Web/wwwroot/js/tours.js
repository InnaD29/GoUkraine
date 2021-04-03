function openNav() {
    document.getElementById("mySidenav").style.display = "block";
}
let sidenav = document.getElementById("mySidenav");
let openbtn = document.querySelector('.openbtn');
let closebtn = document.querySelector('.closebtn');
let filter = document.querySelector('.side-filter');

window.onresize = () => {
    let w = window.innerWidth;
    sidenav.style.display = "block"
    if (w < 1200) {
        sidenav.style.display = "none"
        openbtn.style.display = 'block';
   } else {
        sidenav.style.display = "block"
        openbtn.style.display = 'none';
    }
}
openbtn.onclick = function () {
    filter.classList.add('sidenav');
    sidenav.style.display = "block"
}
function closeNav() {
    sidenav.style.display = "none";
    filter.classList.remove('sidenav');
    closebtn.style.display = "block";
}





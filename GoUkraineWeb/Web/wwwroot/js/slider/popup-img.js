let modal = document.getElementById("templateModal");
let img = document.querySelectorAll('.gellary img');
let modalImg = document.getElementById("modalImg");
for (let i = 0; i < img.length; i++) {
    img[i].onclick = function () {
        modal.style.display = "block";
        modalImg.src = this.src;
    }
}
let span = document.getElementsByClassName("close")[0];
span.onclick = function () {
    modal.style.display = "none";
}  
// Get the modal
var modal = document.getElementById("gallary");

// Get the button that opens the modal
var btn = document.getElementById("photosLink");

// Get all the links
const images = document.querySelectorAll('.modalGallary-content img'); 

const menuLinks = document.querySelectorAll('.menuImgLink');

//hide images when user clicks an image
images.forEach(image => {
    image.onclick = function () {
        modal.style.display = "none";
    };
});

menuLinks.forEach(menuLink => {
    menuLink.onclick = function () {
        modal.style.display = "block";
    };
});

// Get the <span> element that closes the modal
//var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal
btn.onclick = function () {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
//span.onclick = function () {
//    modal.style.display = "none";
//}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
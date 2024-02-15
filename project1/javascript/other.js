// other.js

document.addEventListener("DOMContentLoaded", function () {
    const toggleButton = document.getElementById("toggle-button");
    const otherDetails = document.getElementById("other-details");
  
    toggleButton.addEventListener("click", () => {
      if (otherDetails.style.display === "none" || !otherDetails.style.display) {
        otherDetails.style.display = "block";
      } else {
        otherDetails.style.display = "none";
      }
    });
  });
  
  // JavaScript for the accordion
document.addEventListener("DOMContentLoaded", function () {
    const accordionHeaders = document.querySelectorAll(".accordion-header");
  
    accordionHeaders.forEach(function (header) {
      header.addEventListener("click", function () {
        const content = header.nextElementSibling;
        content.style.display = content.style.display === "none" ? "block" : "none";
      });
    });
  });

// JavaScript for the modal
document.addEventListener("DOMContentLoaded", function () {
    const modal = document.getElementById("myModal");
    const openModalButton = document.getElementById("open-modal");
    const closeButton = modal.querySelector(".close");
  
    openModalButton.addEventListener("click", function () {
      modal.style.display = "block";
    });
  
    closeButton.addEventListener("click", function () {
      modal.style.display = "none";
    });
  
    window.addEventListener("click", function (event) {
      if (event.target === modal) {
        modal.style.display = "none";
      }
    });
  });
// JavaScript for the image slideshow
document.addEventListener("DOMContentLoaded", function () {
    const images = document.querySelectorAll(".image-slideshow img");
    let currentImage = 0;
  
    function showImage(index) {
      images.forEach((image, i) => {
        image.style.display = i === index ? "block" : "none";
      });
    }
  
    function nextImage() {
      currentImage = (currentImage + 1) % images.length;
      showImage(currentImage);
    }
  

    setInterval(nextImage, 3000);
  

    showImage(currentImage);
  });
    
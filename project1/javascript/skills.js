document.addEventListener("DOMContentLoaded", function () {
    const accordionHeaders = document.querySelectorAll(".accordion-header");
  
    accordionHeaders.forEach(function (header) {
      header.addEventListener("click", function () {
        const content = header.nextElementSibling;
        content.style.display = content.style.display === "none" ? "block" : "none";
      });
    });
  });
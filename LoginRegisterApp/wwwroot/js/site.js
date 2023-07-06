// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var imageSources = [ "~/Images/landing-3.svg", "~/Images/landing-4.jpeg","~/Images/landing-5.png"]; // Değiştirilecek src değerleri

    var imgElement = document.getElementById("landing-pic");
    var currentIndex = 0;

    setInterval(function() {
      currentIndex = (currentIndex + 1) % imageSources.length; // Dizide döngü oluşturmak için mod alıyoruz
      imgElement.src = imageSources[currentIndex];
    }, 5000); // Her 5 saniyede bir src değerini değiştirir
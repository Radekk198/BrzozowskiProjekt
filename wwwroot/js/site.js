﻿//Ikona rozwijająca menu na urządzeniach mobilnych
var navbarToggler = document.querySelector('.navbar-toggler');
var navbarCollapse = document.querySelector('.navbar-collapse');

navbarToggler.addEventListener('click', function () {
    navbarCollapse.classList.toggle('show');
});


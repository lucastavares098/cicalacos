// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$$(document).ready(function () {
    setInterval(function() {
        $('#img-1').fadeIn();
        setTimeout($('#img-1').fadeOut, 2000);
        $('#img-2').fadeIn();
        setTimeout($('#img-2').fadeOut, 2000);
        $('#img-3').fadeIn();
        setTimeout($('#img-3').fadeOut, 2000);
    }, 6000);
});

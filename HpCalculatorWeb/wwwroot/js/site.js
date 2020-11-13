// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.addEventListener("DOMContentLoaded", function () {

    // Get reference to drop down
    var ddl = document.getElementById('leveldropdownid');

    for (var i = 1; i < 21; i++) {
        var theOption = document.createElement("option");
        theOption.text = i;
        theOption.value = i;
        // If it is the first option, make it be selected
        i === 1 ? theOption.selected = "selected" : "";
        ddl.options[i] = theOption;
    }

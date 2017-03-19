/// <reference path="jquery-3.1.1.min.js" />

var photoform = $("#photoform");
var form = $('form');

$(document).on('submit', "#photoform", function (e) {

    e.preventDefault();

    $.ajax({
        url: "/Home/Create/",
        method: "POST",
        data: new FormData(form[0]),
        success: function (partialResult) {

            alert("bilden har laddats up");
            window.location.href = "/Home/Index";
        },
        error: function (data) {
            alert("fel")
        },
        processData: false,
        contentType: false,
    });

});

/// <reference path="jquery-3.1.1.min.js" />



var commentform = $("#commentform");
var form = $('form');

$(document).on('submit', "#commentform", function (e) {

    e.preventDefault();

    $.ajax({
        url: "/Home/Comment",
        method: "POST",
        data: new FormData(form[0]),
        success: function (partialResult) {
            $("#photosPanel").Html(partialResult);

            alert("Successfully commented!")

            window.location.href = "/Home/Index";
        },
        error: function (data) {
            alert("somehting went wrong")
        },
        processData: false,
        contentType: false,
    });

});

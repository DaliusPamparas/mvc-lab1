$(document).ready(function (e) {

    setInterval(reload_New_Comments, 10000);
});

var reload_New_Comments = function (e) {
    $.ajax({
        type: "GET",
        url: "/Home",
        success: function (data) {
           
            $('#photosPanel').html(data);
        }
    });
};
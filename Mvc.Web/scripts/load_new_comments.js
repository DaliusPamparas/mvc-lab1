$(document).ready(function (e) {

    setInterval(reload_New_Comments, 5000);
});

var reload_New_Comments = function (e) {
    $.ajax({
        type: "GET",
        url: "/Home/Index/",
        success: function (data) {
            console.log("laddat");
            $('#photosPanel').html(data);

        }
    });
};
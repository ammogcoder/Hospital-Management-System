$(document).ready(function (e) {
    $("#LinkButton1").hide();
    $(":checkbox").change(function (e) {
        if ($("#form1 input:checkbox:checked").length > 0)
            $("#LinkButton1").show();
        else
            $("#LinkButton1").hide();
    });
});
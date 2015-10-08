$(document).ready(function (e) {
    $("#TextBox2").timepicker();
    $("#LinkButton4").hide();
    $(":checkbox").change(function (e) {
        if ($("#form1 input:checkbox:checked").length > 0)
            $("#LinkButton4").show();
        else
            $("#LinkButton4").hide();
    });
});
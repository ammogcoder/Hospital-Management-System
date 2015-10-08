$(document).ready(function (e) {
    showTimePicker();
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(showTimePicker);
    $("#LinkButton4").hide();
    $(":checkbox").change(function (e) {
        if ($("#form1 input:checkbox:checked").length > 0)
            $("#LinkButton4").show();
        else
            $("#LinkButton4").hide();
    });
});
function showTimePicker() {
    $("#TextBox2").timepicker();
}
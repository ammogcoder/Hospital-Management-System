$(document).ready(function (e) {
    showTimePicker();
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(showTimePicker);
});
function showTimePicker() {
    $("#TextBox2").timepicker();
    $("#TextBox7").timepicker();
}
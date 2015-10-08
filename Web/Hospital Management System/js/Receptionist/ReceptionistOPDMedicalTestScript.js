$(document).ready(function (e) {
    showTimePicker();
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(showTimePicker);
});
function showTimePicker() {
    $("#TextBox3").timepicker();
}
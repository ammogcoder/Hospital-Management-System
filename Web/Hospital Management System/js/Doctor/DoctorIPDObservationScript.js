$(document).ready(function (e) {
    showTimePicker();
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(showTimePicker);
});
function showTimePicker() {
    $("#TextBox9").timepicker();
    $("#TextBox11").timepicker();
}
function openWardTransferWindow() {
    window.open("DoctorIPDWardTransfer.aspx", "_blank", "width=540, height=550, status=yes, toolbar=no, menubar=no, location=no");
    return false;
}
function openDoctorTransferWindow() {
    window.open("DoctorTransferIPD.aspx", "_blank", "width=540, height=550, status=yes, toolbar=no, menubar=no, location=no");
    return false;
}
$(document).ready(function (e) {
    showTimePicker();
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(showTimePicker);
});
function showTimePicker() {
    $("#TextBox19").timepicker();
}
function clientRequiredFieldCustomValidator1(source, arguments) {
    var radioButtonList = document.getElementById('RadioButtonList5');
    var radioButton = radioButtonList.getElementsByTagName('input');
    var flag = null;
    for (var i = 0; i < radioButton.length; i++) {
        if (radioButton[i].checked)
            flag = radioButton[i].value;
    }

    if (flag==1 && arguments.Value == "")
        arguments.IsValid = false;
    else
        arguments.IsValid = true;
}
function clientRequiredFieldCustomValidator2(source, arguments) {
    var radioButtonList = document.getElementById('RadioButtonList3');
    var radioButton = radioButtonList.getElementsByTagName('input');
    var flag = null;
    for (var i = 0; i < radioButton.length; i++) {
        if (radioButton[i].checked)
            flag = radioButton[i].value;
    }

    if (flag == 1 && arguments.Value == "")
        arguments.IsValid = false;
    else
        arguments.IsValid = true;
}
function clientRequiredFieldCustomValidator3(source, arguments) {
    var radioButtonList = document.getElementById('RadioButtonList1');
    var radioButton = radioButtonList.getElementsByTagName('input');
    var flag = null;
    for (var i = 0; i < radioButton.length; i++) {
        if (radioButton[i].checked)
            flag = radioButton[i].value;
    }

    if (flag == 1 && arguments.Value == "")
        arguments.IsValid = false;
    else
        arguments.IsValid = true;
}

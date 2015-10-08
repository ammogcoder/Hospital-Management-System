$(document).ready(function (e) {
    $("#DropDownList1").change(function (e) {
        var refSource = $(this).val();
        if (refSource == 1)
            $("#ModalPopupExtender1").show();
    });
});
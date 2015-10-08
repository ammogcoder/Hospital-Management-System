$(document).ready(function (e) {
    $("#DropDownList3").change(function (e) {
        var refSource = $(this).val();
        if (refSource == 1)
            $("#ModalPopupExtender1").show();
        if (refSource == 2)
            $("#ModalPopupExtender2").show();
    });
});
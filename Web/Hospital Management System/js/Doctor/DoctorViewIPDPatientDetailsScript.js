$(document).ready(function (e) {
    var allergies = $("#Label6").val();
    if (allergies == '') {
        $("#tr1").remove();
    }
    var surgery1 = $("#Label8").val();
    if (surgery1 == '') {
        $("#tr2").remove();
    }
    var surgery2 = $("#Label10").val();
    if (surgery2 == '') {
        $("#tr3").remove();
    }
    var surgery3 = $("#Label12").val();
    if (surgery3 == '') {
        $("#tr4").remove();
    }
    var insurance = $("#Label14").val();
    if (insurance == '') {
        $("#tr5").remove();
        $("#tr6").remove();
    }
    var medications = $("#Label4").val();
    if (medications == '') {
        $("#tr7").remove();
    }
});
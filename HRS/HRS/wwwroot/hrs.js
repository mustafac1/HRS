$(".Cliniz-Select").change(function () {
    $("#doctor-option").html("");
    var id = $(this).find("option:selected").val();
    $.ajax({
        url: "MakeAnAppointment/Clinic",
        type: "post",
        data: { id: id },
        success: function (response) {
            $("#doctor-option").append("<option>--SEC--</option>");
            $.each(response, function (value) {
                $("#doctor-option").append("<option value='" + response[value].id + "'>" + response[value].name + "</option>");
            });
        }
    });
});
$(document).on("change", ".Doctor-Select", function () {
    var id = $(this).find("option:selected").val();
    $.ajax({
        url: "MakeAnAppointment/Appointment",
        type: "post",
        data: { id:id },
        success: function (response) {
            $.each(response, function (value) {

                //$("#times-list").append(JSON.stringify(response[value].startTime.hours), JSON.stringify(response[value].startTime.minutes));

                $("#times-list").append("<input type='radio' name='TimeId' value='" + response[value].id + "'> " + response[value].startTime + " - " + response[value].endTime + "<br>");
                //console.log(response[value]);
            });
        }
    });
});
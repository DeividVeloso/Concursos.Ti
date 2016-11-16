///// <reference path="jquery-3.1.1.js" />
///// <reference path="jquery-3.1.1.intellisense.js" />
////(function () {

////    $('formHourToMinutes').submit(postHoursToMinute);

//    function postHoursToMinute() {
//        let request = {
//            Hour: $('input[name="Hour"]').val(),
//            Minutes: $('input[name="Minutes"]').val()
//        };

//        $.ajax({
//            url: 'http://localhost:59509/api/HoursToMinutes',
//            type: 'POST',
//            data: JSON.stringify(request),
//            contentType: "application/json",
//            success: function (resposta) {
//                $('input[name="Resultado"]').val(resposta)
//            },
//            error: function (resposta) {
//                console.log("erro")
//            }
//        });

//        //return false;
//    };
////})();

$('#btnEnviaHoras').click(function (e) {
    e.preventDefault();
    let request = {
        Hour: $('input[name="Hour"]').val(),
        Minutes: $('input[name="Minutes"]').val()
    };

    $.ajax({
        url: 'http://negociodireto.com/Api.SumHoursAndMinutes/api/HoursToMinutes',
        type: 'POST',
        data: JSON.stringify(request),
        contentType: "application/json",
        success: function (resposta) {
            $('input[name="Resultado"]').val(resposta)
        },
        error: function (resposta) {
            console.log("erro")
        }
    });

    return false;

})

//function postMinutesToHour() {
//    let request = {
//        Hour: 0,
//        Minutes: $('input[name="Minutes"]').val()
//    };

//    $.ajax({
//        url: 'http://localhost:59509/api/MinutesToHours',
//        type: 'POST',
//        data: JSON.stringify(request),
//        contentType: "application/json",
//        success: function (resposta) {
//            $('input[name="Resultado"]').val(resposta)
//        },
//        error: function (resposta) {
//            console.log("erro")
//        }
//    });
//};

//$("#formMinutesToHour").on("submit", function (e) {
//    e.preventDefault();
//    let request = {
//        Hour: 0,
//        Minutes: $('input[name="Minutes"]').val()
//    };

//    $.ajax({
//        url: 'http://localhost:59509/api/MinutesToHours',
//        type: 'POST',
//        data: JSON.stringify(request),
//        contentType: "application/json",
//        success: function (resposta) {
//            $('input[name="Resultado"]').val(resposta)
//        },
//        error: function (resposta) {
//            console.log("erro")
//        }
//    });
//    return false;
//});

$("#btnEnviaMinutos").click(function (e) {
    e.preventDefault();
    let request = {
        Hour: 0,
        Minutes: $('input[name="Minutes"]').val()
    };

    $.ajax({
        url: 'http://negociodireto.com/Api.SumHoursAndMinutes/api/MinutesToHours',
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
});

/// <reference path="jquery-3.1.1.js" />
/// <reference path="jquery-3.1.1.intellisense.js" />
(function () {
 

    $('form').submit(postHoursToMinute);

    function postHoursToMinute() {
        let request = {
            Hour: $('input[name="Hour"]').val(),
            Minutes: $('input[name="Minutes"]').val()
        };

        $.ajax({
            url: 'http://localhost:59509/api/MinutesToHours',
            type: 'POST',
            data: JSON.stringify(request),
            contentType: "application/json",
            success: function (resposta) { console.log(resposta) },
            error: function (resposta) { console.log("erro") }
        });

        return false;
    };

})();

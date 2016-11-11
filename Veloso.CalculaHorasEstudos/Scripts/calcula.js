function postHoursToMinute(evento) {
    evento.preventDefault();
    let dadosSerializado = $('#formDados').serealize();
    $.ajax({
        url: 'http://localhost:59509/api/MinutesToHours',
        contentType: "application/json",
        dataType: 'json',
        type: 'post',
        data: dadosSerializado,
        sucess: function (resposta) { console.log(resposta) },
        error: function (resposta) { console.log("erro") }

    });

};
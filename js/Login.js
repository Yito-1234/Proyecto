$(document).on('submit', '#Login', function (e) {

    e.preventDefault();
    $.ajax({
        beforeSend: function () {

            $('#Login button[type=submit]').prop('disabled', true);
        },
        type: this.method,
        url: this.action,
        data: $(this).serialize(),
        success: function (data) {

            alert('Bienvenido' + data.Usuario1);
        },
        error: function (xhr, status) {

            alert(xhr.responseJSON.Message);
        },
        complete: function () {
            $('#Login button[type=submit]').prop('disabled', false);

        }


    });

});


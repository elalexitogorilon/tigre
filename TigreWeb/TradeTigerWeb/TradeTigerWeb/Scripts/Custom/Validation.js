

$("#subaccount").click(function () {


    if (!(ValidateEmpteField($("#username").val())
        && ValidateEmpteField($("#email").val())
        && ValidateEmpteField($("#password").val())
        && ValidateEmpteField($("#repassword").val())))
    {
        alert("invalid fields");
        return false;
    }

    if ($("#password").val() != $("#repassword").val()) {
        alert("invalid passwod");
    }
});


function ValidateEmpteField(field)
{

    if (field == null)
    {
        return false;
    }

    if (field.length < 1)
    {
        return false;
    }

    return true;
}


$.ajax({
    url: 'http://api.joind.in/v2.1/talks/10889',
    data: {
        format: 'json'
    },
    dataType: 'jsonp',
    success: function (data) {
    },
    type:'POST'

});


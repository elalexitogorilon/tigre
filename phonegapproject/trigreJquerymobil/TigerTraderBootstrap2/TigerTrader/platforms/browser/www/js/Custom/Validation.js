

$("#subaccount").click(function () {
    console.log('in click event');
    
  
    if (!(ValidateEmpteField($("#UserName").val())
        && ValidateEmpteField($("#UserEmail").val())
        && ValidateEmpteField($("#UserPassword").val())
        && ValidateEmpteField($("#repassword").val())))
    {
        Console.log("invalid fields");
        return false;
    }

    if ($("#UserPassword").val() != $("#repassword").val()) {
        Console.log("invalid passwod");
        return;
    }
    submitUserAccount($("#UserName").val(), $("#UserEmail").val(), $("#UserPassword").val())
});


$("#subaccount").click(function () {
    console.log('in click event');


    if (!(ValidateEmpteField($("#UserName").val())
        && ValidateEmpteField($("#UserPassword").val())
    ))
    {
        Console.log("invalid fields");
        return false;
    }
    submitLogin($("#UserName").val(), $("#UserPassword").val())
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

function submitLogin(name,password)
{
    console.log('in submit log');
    var url = "http://localhost/TigerAPI/api/LogIn/";
  
    var data = { UserName: name, UserPassword: password };
    console.log(data);
    ExecuteAjax(url, data, 'GET', , "Welcome", "exception");

}

function submitUserAccount (name, email,password)
{
    console.log('in submitUserAccount');
    //http://localhost:64918/api/UserCredentials/David/rtrtr@gmail.com/testpass http://localhost:64781/
   // var url = "http://localhost/TigerAPI/api/UserCredentials/DataPapasAA/cueaBBvitas@gmail.com/paBB2323swordtest"
    

    var url = "http://localhost/TigerAPI/api/UserCredentials/";
        
    var data = { UserName: name, UserEmail: email, UserPassword: password };
    console.log(data);
    var stuff = url;

    //ExecAjax(url, data, 'POST');
    ExecuteAjax(url, data, 'GET', "Welcome","exception");

}

      //  dataType: 'jsonp',
//
//function ExecAjax(url, datainput, httptype) {
//    console.log('in execute ajax');// data: JSON.stringify(datainput) ,
//    $.ajax({
//        url: url,
//        type: "POST",
//        dataType: 'json',
//        data: datainput,
//        success: function (data) {
//            console.log('good post***')
//        },
        
//        error: function (error) {
//            console.log(error.responseText);
//        }

//    });
//}

function ExecuteAjax(url, datainput, httptype,redirectto,errorpage) {
    console.log('in execute ajax');// data: JSON.stringify(datainput) ,
    $.ajax({
        url: url,
        type: "GET",
        dataType: 'json',
        data: datainput,
        success: function (data) {
            console.log('good get *** ' +window.location.href )
            window.location.href = url + "#" + redirectto;
        },
        
        error: function (errors) {
            console.log('error get *** ' + errors)
            console.log(errors.responseText);
            window.location.href = url + "#" + errorpage;
        }

    });
}

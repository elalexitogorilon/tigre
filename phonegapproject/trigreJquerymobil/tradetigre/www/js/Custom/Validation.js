

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


$("#sublogin").click(function () {
    console.log('in click event');


    if (!(ValidateEmpteField($("#UserName").val())
        && ValidateEmpteField($("#repassword").val()))) {
        Console.log("invalid fields");
        return false;
    }
    loginsubmit($("#UserName").val(), $("#UserEmail").val())
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




function submitUserAccount (name, email,password)
{
    console.log('in submitUserAccount');
    //http://localhost:64918/api/UserCredentials/David/rtrtr@gmail.com/testpass http://localhost:64781/
   // var url = "http://localhost/TigerAPI/api/UserCredentials/DataPapasAA/cueaBBvitas@gmail.com/paBB2323swordtest"
    var url = "http://localhost/TigerAPI/api/UserCredentials/";
    var data = { UserName: name, UserEmail: email, UserPassword: password };
    console.log(data);
   // ExecAjax(url, data, 'POST');
    ExecuteAjax(url, data, 'GET', "Welcome", "exception");

}

function loginsubmit(name, email, password) {
    console.log('in loginsubmit');
    var url = "http://localhost/TigerAPI/api/UserLogin/";
    var data = { UserName: name, UserPassword: password };
    console.log(data);
    ExecuteAjax(url, data, 'GET', "Welcome", "exception");
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

function ExecuteAjax(url, datainput, httptype, redirectto, errorpage) {
    console.log('in execute ajax');// data: JSON.stringify(datainput) ,
    $.ajax({
        url: url,
        type: "GET",
        dataType: 'json',
        data: datainput,
        success: function (data) {
            if (data.Result == true)
            {
                $(location).attr("href", "/#" + redirectto);
                console.log('good get ***')
            }
            else
            {
                console.log('bad request ***' + data.Message)
                $(location).attr("href", "/#" + errorpage);
                $("#errormessag").html(data.Message);
            }
        },
        error: function (error) {
            console.log(error.responseText);
            $(location).attr("href", "/#" + errorpage);
        }

    });
}

function validaemail() {

    retorno = true;

    var email = $("#email").val();
    if (email === "") {
        $("#email").removeClass("is-valid");
        $("#email").focus();
        $("#email").addClass("is-invalid");
        $("#emailmsg").text("E-mail é obrigatório");
        $("#emailmsg").addClass("text-danger");
        retorno = false;
    } else if (email.indexOf("@") < 0) {
        $("#email").removeClass("is-valid");
        $("#email").focus();
        $("#email").addClass("is-invalid");
        $("#emailmsg").text("@ é obrigatório");
        $("#emailmsg").addClass("text-danger");
        retorno = false;
    } else {
        $("#emailmsg").text("");
        $("#email").removeClass("is-invalid");
        $("#email").addClass("is-valid");
    }
    return retorno;
}
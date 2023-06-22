

function validarEnviar() {
    let itsOkey = true;
    var form = document.getElementById("form1");
    var txtNombre = document.getElementById("txtNombre");
    var txtApellido = document.getElementById("txtApellido");
    var txtEmail = document.getElementById("txtEmail");
    var txtChk1 = document.getElementById("txtChk1");
    var txtChk2 = document.getElementById("txtChk2");
    var txtChk3 = document.getElementById("txtChk3");
    var txtChk4 = document.getElementById("txtChk4");

    if (txtNombre.value == "") {
        itsOkey = false;
        txtNombre.style.borderColor = "red";
        alert('Debes ingresar un Nombre')
    } else {
        txtNombre.style.borderColor = "rgb(118, 118, 118)";
    }
    if(txtApellido.value == ""){
        itsOkey = false;
        txtApellido.style.borderColor = "red";
        alert('Debes ingresar un Apellido')
    } else {
        txtApellido.style.borderColor = "rgb(118, 118, 118)";
    }
    if (txtEmail.value == "") {
        itsOkey = false;
        txtEmail.style.borderColor = "red";
        alert('Debes ingresar un email')

    } else {
        txtEmail.style.borderColor = "rgb(118, 118, 118)";
    }
    console.log("valor del check", txtChk1.checked )
    if (txtChk1.checked == false && txtChk2.checked == false && txtChk3.checked == false && txtChk4.checked == false) {
        itsOkey= false;
        alert('Debes seleccionar una opcion de los temas')
    }
    if (itsOkey) {
        form.submit();
    }

}
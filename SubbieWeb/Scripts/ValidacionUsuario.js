localStorage.clear();
var evt = document.getElementById('login') ///Problema con el tipo de boton
//en arreglo para cambiar la api Al registrarse como nuevo Usuario.

    //< script src = "~/Scripts/ValidacionUsuario.js" ></script>html login
evt.addEventListener('submit', function (event) { 
    const emailHtml = document.getElementById('email').value
    const passwordHtml = document.getElementById('password').value
    localStorage.setItem('email', emailHtml)
    localStorage.setItem('password', passwordHtml)
    
})



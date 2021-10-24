localStorage.clear();
let evt = document.querySelector('.Ingresar') ///Problema con el tipo de boton
//en arreglo para cambiar la api Al registrarse como nuevo Usuario.

    //< script src = "~/Scripts/ValidacionUsuario.js" ></script>html login
evt.addEventListener('click', function () {
    const emailHtml = document.querySelector('.email').value
    const passwordHtml = document.querySelector('.password').value

    localStorage.setItem('email', emailHtml)
    localStorage.setItem('password', passwordHtml)
    const email = localStorage.getItem('email');
    const password = localStorage.getItem('password');
   
        
            fetch(`https://localhost:44332/api/usuarios/iniciarsesion?correo=${email}&password=${password}`)
                .then(response => response.json())
                .then(data => {
                    if (data == null || email == null || password == null) {
                        alert("Ouch! Al parecer tu clave o contraseña no son correctos")

                    } else {
                        console.log(data.id)
                        const id = data.id
                        localStorage.setItem('id', id)
                                           }
                }).catch(error => alert("Ouch! Ocurrio un error inesperado" + error))
        console.log("Guardo los datos en el local")

    
})



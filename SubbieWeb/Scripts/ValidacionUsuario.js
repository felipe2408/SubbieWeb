let evt = document.querySelector('.Ingresar')
evt.addEventListener('click', function () {
    const emailHtml = document.querySelector('.email').value
    const passwordHtml = document.querySelector('.password').value
    localStorage.setItem('email', emailHtml)
    localStorage.setItem('password', passwordHtml)
    const email = localStorage.getItem('email');
    const password = localStorage.getItem('password');
    try {
        fetch(`https://localhost:44332/api/usuarios/iniciarsesion?correo=${email}&password=${password}`)
            .then(response => response.json())
            .then(data => {
                if (data == null) {
                    alert("Ouch! Al parecer tu clave o contraseña no son correctos")

                } else {
                    var url = "https://localhost:44332/Home/Index";
                    window.location = url;
                }
            })
    } catch (error) {
        alert("Ouch! Ocurrio un error inesperado" + error)
    }
    localStorage.clear();
    console.log("Guardo los datos en el local")
})



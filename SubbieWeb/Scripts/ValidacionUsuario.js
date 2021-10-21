localStorage.clear();
let evt = document.querySelector('.Ingresar')
evt.addEventListener('click', function () {
    const emailHtml = document.querySelector('.email').value
    const passwordHtml = document.querySelector('.password').value

    localStorage.setItem('email', emailHtml)
    localStorage.setItem('password', passwordHtml)
    const email = localStorage.getItem('email');
    const password = localStorage.getItem('password');
    if (emailHtml == null || password == null || emailHtml == "" || passwordHtml == "") {
        alert('Ingresa tu correo o tu clave para poder ingresar!')
    }
    else {
        
            fetch(`https://localhost:44332/api/usuarios/iniciarsesion?correo=${email}&password=${password}`)
                .then(response => response.json())
                .then(data => {
                    if (data == null || email == null || password == null) {
                        alert("Ouch! Al parecer tu clave o contraseña no son correctos")

                    } else {
                        console.log(data.id)
                        const id = data.id
                        localStorage.setItem('id', id)
                        var url = "https://localhost:44332/Home/Index";
                        window.location = url;
                    }
                }).catch(error => alert("Ouch! Ocurrio un error inesperado" + error))
        console.log("Guardo los datos en el local")
    }

    
})



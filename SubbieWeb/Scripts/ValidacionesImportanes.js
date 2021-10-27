const email = localStorage.getItem('email');
const password = localStorage.getItem('password');
console.log(email + password)
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
const email = localStorage.getItem('email');
const password = localStorage.getItem('password');
console.log(email + password)
let obtener = true;
if (obtener) {
    fetch(`https://localhost:44332/api/usuarios/iniciarsesion?correo=${email}&password=${password}`)
        .then(response => response.json())
        .then(data => {
            console.log(data.id)
            const id = data.id
            localStorage.setItem('id', id)
        }
    )
obtener = false;
console.log("Guardo los datos en el local")
}

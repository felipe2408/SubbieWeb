const email = localStorage.getItem('email');
const password = localStorage.getItem('password');
const nombre = localStorage.getItem('nombre');
const apellido = localStorage.getItem('apellido');
let obtener = true;
if (obtener) {
    fetch(`http://18.228.29.128/api/usuarios/iniciarsesion?correo=${email}&password=${password}`)
        .then(response => response.json())
        .then(data => {
            console.log(data.id)
            const id = data.id
            localStorage.setItem('id', id)
        }
    )

obtener = false;
    console.log("Guardo los datos en el local")
    let ele = document.getElementById('nombre')
    ele.innerHTML = `<h4>Bienvenido, ${nombre} ${apellido}</h4> `
    let el = document.getElementById('el')
    el.innerHTML = `<h4>Bienvenido, ${nombre}</h4> `

}

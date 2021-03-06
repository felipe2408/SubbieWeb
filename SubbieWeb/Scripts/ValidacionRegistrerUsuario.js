localStorage.clear()
// obtenemos la informacion de acuerdo al boton de registrar del html
let registrer = document.querySelector('.Registrar')
registrer.addEventListener('click', function () {
    const emailRegistrer = document.querySelector('.emailReg').value
    const claveReg = document.querySelector('.pass').value
    const claveRegConf = document.querySelector('.passConf').value
    // guardarmos la informacion en el localStorage del navegador
    localStorage.setItem('emailReg', emailRegistrer)
    localStorage.setItem('pass', claveReg)
    localStorage.setItem('passConf', claveRegConf)
    if (claveReg == claveRegConf) {

        const datos = {
            correo: emailRegistrer,
            password: claveReg,
            usuarioNuevo: "false"
        }
        const URL = 'https://localhost:44332/api/usuarios/registrarusuario'

        fetch(URL, {
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, *cors, same-origin
            cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
            credentials: 'same-origin', // include, *same-origin, omit
            headers: {
                'Content-Type': 'application/json; charset=utf-8', Accept: '*/*'
            },
            body: JSON.stringify(datos) // body data type must match "Content-Type" header
        })

        // mensaje de alerta para un registro exitoso
        var alerta = '';

        alerta += `<div class="alert alert-info alert-dismissible fade show" role="alert">

                            REGISTRO REALIZADO CON EXITO

                            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>

                        </div>`;
        $('#alerta').html(alerta);
        // re direcciona a la pagina de home al momento de agregar la informacion
        var url = "https://localhost:44332/Home/Index";
        window.location = url;
    } else {
        alert("Ouch! Al parecer una de las claves no es igual")
    }
    
});
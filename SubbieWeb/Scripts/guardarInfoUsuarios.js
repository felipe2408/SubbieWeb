var event = document.querySelector('.Guardar')

event.addEventListener('click', function () {
    var id = localStorage.getItem('id');
    const nombreHTML = document.querySelector('.nombres').value
    const apellidosHTML = document.querySelector('.apellidos').value
    const tipoIDHTML = document.querySelector('.tipoID').value
    const numIdHTML = document.querySelector('.numId').value
    const telefonoHTML = document.querySelector('.telefono').value
    const direccionHTML = document.querySelector('.direccion').value
    const ciudadHTML = document.querySelector('.ciudad').value

    var URL = 'https://localhost:44332/api/InfoUsuarios/addInfo'
    const datos = {
        fk_idusuario: id,
        nombres: nombreHTML,
        apellidos: apellidosHTML,
        telefono: telefonoHTML,
        ciudad: ciudadHTML,
        direccion: direccionHTML,
        tipoIdentificacion: tipoIDHTML,
        identificacion: numIdHTML
    }
    fetch(URL, {
        method: 'POST', // *GET, POST, PUT, DELETE, etc.
        mode: 'same-origin', // no-cors, *cors, same-origin
        cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
        credentials: 'same-origin', // include, *same-origin, omit
        headers: {
            'Content-Type': 'application/json; charset=utf-8', Accept: '*/*'
        },
        body: JSON.stringify(datos) // body data type must match "Content-Type" header
    })
})
    

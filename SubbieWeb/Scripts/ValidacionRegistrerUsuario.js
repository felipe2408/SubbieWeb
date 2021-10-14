localStorage.clear()
let registrer = document.querySelector('.Registrar')
registrer.addEventListener('click', function () {
    const emailRegistrer = document.querySelector('.emailReg').value
    const claveReg = document.querySelector('.pass').value
    const claveRegConf = document.querySelector('.passConf').value
    localStorage.setItem('emailReg', emailRegistrer)
    localStorage.setItem('pass', claveReg)
    localStorage.setItem('passConf', claveRegConf)
    if (claveReg == claveRegConf) {
        fetch()
    } else {
        alert("Ouch! Al parecer una de las claves no es igual")
    }
    
});
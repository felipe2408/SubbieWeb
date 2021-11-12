const nombre = localStorage.getItem('nombre');
let ele = document.getElementById('chats')
ele.innerHTML = `<h4>${nombre}</h4>`
const form = document.getElementById("loginform");
const username = document.getElementById("username");
const password = document.getElementById("password");
const userlog = document.getElementById("userlog");
const btnclose = document.getElementById("btnclose");
const box = document.getElementById("overlap-box");
const btnlogin = document.getElementById("btnlogin");
const btnsubmit = document.getElementById("btnsubmit");
const today = document.getElementById("day");
const week = document.querySelectorAll('h6');

var days = ['Domingo','Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado'];
var d = new Date(Date.now());
var dayName = days[d.getDay()];
today.innerHTML = dayName.toUpperCase();
for (var i = 0; i < week.length; i++) {
    week[i].innerHTML = days[d.getDay() + i].toUpperCase();
}

if (localStorage.length > 0) {
    btnlogin.style.visibility = "hidden";
    userlog.style.visibility = "visible";
    let userdata = JSON.parse(localStorage.getItem('user'));
    userlog.innerHTML = "Bienvenido: " + userdata[0].user;
}

btnlogin.addEventListener('click', function (event) {
    event.preventDefault();
    if (box.style.visibility != "visible") {
        box.style.visibility = "visible";
    } else {
        box.style.visibility = "hidden";
    }
})


btnsubmit.addEventListener('click', function (event) {
    event.preventDefault();
    let users = Array(
        {
            user: username.value,
            pass: password.value
        }
    )
    localStorage.setItem('user', JSON.stringify(users));
    let userdata = JSON.parse(localStorage.getItem('user'));
    if (userdata != null) {
        userlog.innerHTML = "Bienvenido: " + userdata[0].user;
    }
    box.style.visibility = "hidden";
    btnlogin.style.visibility = "hidden";
    btnclose.style.visibility = "visible";
});



btnclose.addEventListener('click', function (event) {
    event.preventDefault();
    localStorage.clear();
    userlog.innerHTML = " ";
    btnlogin.style.visibility = "visible";
    console.log("BORRAME");
});
const a_szam = document.getElementById("a_szam"); //'A' input mező
const b_szam = document.querySelector("#b_szam"); //'B' input mező
const kijelzo = document.querySelector("#eredmeny");

function osszead() {
    a = parseFloat (a_szam.value);
    b = parseFloat (b_szam.value);
    kijelzo.innerHTML = 'Összeadva ' + (a+b).toString();
}
function kivon() {
    a = parseFloat (a_szam.value);
    b = parseFloat (b_szam.value);
    kijelzo.innerHTML = 'Összeadva ' + (a-b).toString();
}

function szoroz() {
    a = parseFloat (a_szam.value);
    b = parseFloat (b_szam.value);
    kijelzo.innerHTML = 'Összeadva ' + (a*b).toString();
}

function oszt() {
    a = parseFloat (a_szam.value);
    b = parseFloat (b_szam.value);
    kijelzo.innerHTML = 'Összeadva ' + (a/b).toString();
}



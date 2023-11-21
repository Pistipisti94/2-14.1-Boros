const inputid = document.querySelector("#id");
const inputusername = document.querySelector("#username");
const inputdarab = document.querySelector("#darab");
const buttonRead = document.querySelector("#read");
const buttonDelete = document.querySelector("#delete");
const buttonCreate = document.querySelector("#create");
const buttonUpdate = document.querySelector("#update");
const cards = document.getElementById("cards");
window.addEventListener("load", getAllUsers);//a lap betöltésekor jelennek meg az adatok (false kikapcsolva)
buttonRead.addEventListener("click", getAllUsers);// a gombra kattintva jelennek meg az adatok

async function getAllUsers() {
    try {
        let endPoint = "https://retoolapi.dev/Hfa9uy/data";
        const response = await fetch(endPoint); //nohead és body
        const users = await response.json(); //body to JSON
        showAllUsers(users);
    } catch (error) {
        console.log(error);
    }
}
function showAllUsers(params) {
    let html = "";
    params.forEach(user => {
        html += ` <div class="card" style="width: 18rem;">
            <img src="noImages.png" class="card-img-top" alt="noImages.png">
            <div class="card-body">
                <h5 class="card-title">${user.id}. ${user.username}</h5>
                <p class="card-text">Szám: ${user.darab} db</p>
                <button class="btn btn-info" onclick="betoltInputMezobe(${user.id})">Select</button>
                </div></div>`;
        cards.innerHTML = html;
    });
}
async function betoltInputMezobe(id) {
    let url = `https://retoolapi.dev/Hfa9uy/data/${id}`;
    try {
        const response = await fetch(url);
        const users = await response.json();
        inputid.value = users.id;
        inputusername.value = users.username;
        inputdarab.value = users.darab;
        location.href = "#formEleje";
    } catch (error) {
        alert(error);
    }
}
//Új user létrehozása
buttonCreate.addEventListener("click", async () => {
    let url = "https://retoolapi.dev/Hfa9uy/data";
    let data = {
        username: inputusername.value,
        darab: inputdarab.value
    };
    console.log(data);
    try {
        const response = await fetch(url, {
            method: "POST",
            headers: {"Content-Type": "application/json"},
            body: JSON.stringify(data)
        });
        await response.json();
        beviteliMezoAlaphelyzetbe();
        getAllUsers();
    } catch (error) {
        alert(error);
    }
});



//Felhasználó módosítása
buttonUpdate.addEventListener("click", async () => {
    let url = `https://retoolapi.dev/Hfa9uy/data/${inputid.value}`;
    let data = {
        username: inputusername.value,
        darab: inputdarab.value
    };
    console.log(data);
    try {
        const response = await fetch(url, {
            method: "PUT",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(data)
        });
        await response.json();
        beviteliMezoAlaphelyzetbe();
        getAllUsers();
    } catch (error) {
        alert(error);
    }
});



//Felhasználó törlése
buttonDelete.addEventListener("click", async () => {
    let url = `https://retoolapi.dev/Hfa9uy/data/${user.id}`;
    try {
        const response = await fetch(url, {
            method: "DELETE",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(data)
        });
        await response.json();
        beviteliMezoAlaphelyzetbe();
        getAllUsers();
    } catch (error) {
        alert(error);
    }
});

function beviteliMezoAlaphelyzetbe() {
    inputid.value = "";
    inputdarab.value = "1";
    inputusername.value = "";
}
const inputid = document.querySelector("#id");
const inputusername = document.querySelector("#username");
const inputdarab = document.querySelector("#darab");
const buttonRead = document.querySelector("#read");
const body = document.getElementsByTagName("body")[0];

body.addEventListener("load", getAllUsers, false);//a lap betöltésekor jelennek meg az adatok
buttonRead.addEventListener("click", getAllUsers);// a gombra kattintva jelennek meg az adatok

async function getAllUsers() {
    try {
        let endPoint = "https://retoolapi.dev/Hfa9uy/data";
        const response = await fetch(endPoint); //head és body
        const users = await response.json(); //body to JSON
        showAllUsers(users);
    } catch (error) {
        console.log(error);
    }
}
function showAllUsers(params) {
    params.forEach(user => {
        card = "<div class=\"card\" style=\"width: 18rem;\">"
        +   "<img src=\"noImages.png\" class=\"card-img-top\" alt=\"noImages.png\">"   
        +   "<div class=\"card-body\">"       
        +   "<h5 class=\"card-title\">Card title</h5>",user.id;
    });
}


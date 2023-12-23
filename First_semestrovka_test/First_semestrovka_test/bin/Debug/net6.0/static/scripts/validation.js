
const form = document.getElementById("form");

const email = document.getElementById("mail");
const emailErrorPLace = document.getElementById("mail-error");

const username = document.getElementById("username");
const usernameErrorPlace = document.getElementById("username-error");

const password = document.getElementById("password");
const passwordErrorPlace = document.getElementById("password-error");

let inputs = [email, username, password];
let errors = [emailErrorPLace , usernameErrorPlace, passwordErrorPlace];

let errorInputs = [
    {
        input: email,
        errorPlace: emailErrorPLace,
        regularExp:/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*\.{5,20}$/
    },
    {
        input: username,
        errorPlace: usernameErrorPlace,
        regularExp: /[-a-zA-Z0-9~!$%^&*_=+}{'?]+(\.[-a-zA-Z0-9~!$%^&*_=+}{'?]+)*@([a-zA-Z0-9_][-a-zA-Z0-9_]*(\.[-a-zA-Z0-9_]+)*\.([cC][oO][mM]))(:[0-9]{8,20})?/
    },
    {
        input: password,
        errorPlace: passwordErrorPlace,
        regularExp: /^[a-zA-Z0-9~!*_=+?]+\.{5,20}$/
    }
]


errorInputs.forEach((object) =>{
    object.input.addEventListener("input", function (event) {

        console.log("console.log(object.input.validity.valid):");
        console.log(object.input.validity.valid);


        if (object.input.validity.valid) {
            object.errorPlace.textContent = ""; // Сбросить содержимое сообщения
            object.errorPlace.className = "error"; // Сбросить визуальное состояние сообщения
        } else {
            showError(object);
        }
    });
});

form.addEventListener("submit", function (event) {

    errorInputs.forEach((object) =>{
        console.log("form.input:");


        if (!object.input.validity.valid) {
            showError(object);
            event.preventDefault();
        }
    });
});

function showError(object) {

    console.log(object.input.value);


    if (object.input.validity.valueMissing) {

        object.errorPlace.textContent = "Заполните поле!";
    }
    else if (object.input.validity.tooShort) {

        object.errorPlace.textContent = `Введёные данные должны иметь длину не менее ${object.input.minLength} символов!`;
    }
    else if (!object.regularExp.test(object.input.value)){
        object.errorPlace.textContent = "Вводите корректные данные";

    }
    object.errorPlace.className = "error ";
}


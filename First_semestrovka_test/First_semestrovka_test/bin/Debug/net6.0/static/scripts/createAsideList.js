
function GetAjaxList(){
    $.ajax({
        url: "/sendData/sendListToClient",
        type: "GET",
        success: function (data) {
            console.log("Данные списка успешно получены с сервера");
            console.log(data);
            ProcessingData(data, CreateAsideList);
        },
        error: function (error) {
            console.error("Произошла ошибка при получении данных списка из сервера");
        }
    });
}

function CreateAsideList(imageData, elementName, link){
    let listElement = document.createElement("li");
    listElement.classList.add("popular-pages__list");

    let elementLink = document.createElement("a");
    elementLink.classList.add("popular-pages__link");
    elementLink.href = link;

    let image = document.createElement("img");
    image.classList.add("popular-pages__image");
    image.src = imageData;

    let span = document.createElement("span");
    span.style.color = "black";
    span.innerHTML = elementName;

    elementLink.append(image, span);
    listElement.appendChild(elementLink);

    document.getElementById("aside-list").appendChild(listElement);/////////////////
}

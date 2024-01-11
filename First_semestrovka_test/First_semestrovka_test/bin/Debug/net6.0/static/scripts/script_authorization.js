
document.addEventListener("DOMContentLoaded", function() {
    $(".add-button").on("click", function(element) {

        let mainElementId = $(this).closest("form").attr("id");
        let formData = new FormData($("#" + mainElementId)[0]);
        let file = $("#" + mainElementId +"-file-input").get(0).files[0];
        let textValue = $(this).siblings()[0].value;

        formData.append("mainElementId", mainElementId);

        if (file) {

            let reader = new FileReader();
            reader.onload = function (e) {
                let data = e.target.result;
                formData.append("imageData", data);

                sendAjaxRequest(formData, textValue, file, mainElementId);
            };
            reader.readAsDataURL(file);
        } else {

            sendAjaxRequest(formData, textValue, null, mainElementId);
        }
        $(this).siblings()[0].value = '';
    });

    function sendAjaxRequest(formData, textValue, file, mainElementId) {
        $.ajax({
            url: "/storeInfo/storeInfoInDataBase",
            type: "POST",
            data: formData,
            contentType: false,
            processData: false,
            success: function (response) {
                console.log("Данные успешно отправлены на сервер");
                CreateParagraph(textValue, file, mainElementId + "-next");
            },
            error: function (error) {
                console.error("Произошла ошибка при отправке данных на сервер");
            }
        });
    }
});

function GetAjaxResponse(){
    $.ajax({
        url: "/storeInfo/getInfoFromDataBase",
        type: "GET",
        success: function (data) {
            console.log("Данные успешно получены с сервера");
            console.log(data);
            ProcessingData(data, CreateParagraph);
        },
        error: function (error) {
            console.error("Произошла ошибка при получении данных из сервера");
        }
    });
}

function CreateParagraph(text,  elementID  , image,){
    let div = document.createElement("div");
    div.style.display ='flex';
    //div.style.width = '100%';
    div.style.flexDirection = 'column';
    div.classList.add('content');

    image = (typeof image === "string")? (image.length > 5 ? image : null) : image

    if(image){
        let reader = new FileReader();
        let imageElement = document.createElement("img");

        imageElement.style.width = "250px";
        imageElement.style.display = "flex";
        imageElement.style.justifyContent = "end";


        reader.onload = function(e) {
            imageElement.src = e.target.result ;
        }
        if (typeof image === "string")
            image = dataURItoBlob(image);
        reader.readAsDataURL(image);
        div.appendChild(imageElement);
        //document.getElementById(elementID).appendChild(imageElement);
    }
    else {
        let imageElement = document.createElement("img");

        imageElement.style.width = "250px";
        imageElement.style.display = "flex";
        imageElement.style.justifyContent = "end";

        imageElement.src = "./images/open_graph1012022304887324820image.webp" ;
        div.appendChild(imageElement);
    }

    if(text){
        let paragraph = document.createElement("a");
        paragraph.innerHTML = text;
        paragraph.href = "http://127.0.0.1:2323/static/index2.html";
        paragraph.style.textAlign = 'center';
        paragraph.style.textOverflow = 'ellipsis'
        div.appendChild(paragraph);
    }

    document.getElementById(elementID + "-next").style.display = 'flex';
    document.getElementById(elementID + "-next").style.flexWrap = 'wrap';
    document.getElementById(elementID + "-next").style.gap = '25px';
    document.getElementById(elementID + "-next").appendChild(div);
}

function ProcessingData(data, Function){
    if (data){
        data.forEach((element) => {
            let values  = Object.values(element);
            Function(values[1], values[2], values[3])
        });
    }
    else{
        console.log("переменная data не определена");
    }
}


function dataURItoBlob(dataURI) {

    let byteString = atob(dataURI.split(',')[1]);
    let mimeString = dataURI.split(',')[0].split(':')[1].split(';')[0]
    let ab = new ArrayBuffer(byteString.length);
    let ia = new Uint8Array(ab);

    for (let i = 0; i < byteString.length; i++) {
        ia[i] = byteString.charCodeAt(i);
    }
    let blob = new Blob([ab], {type: mimeString});
    return blob;
}
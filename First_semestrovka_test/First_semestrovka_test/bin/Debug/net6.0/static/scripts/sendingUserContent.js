document.addEventListener('DOMContentLoaded', function() {
    console.log("sendUserContent");
    $(".users-wrap").on("click", function(element){

        localStorage.removeItem('text' );
        localStorage.removeItem('imagePath' );

        event.preventDefault();

        var text = element.target.innerText;
        var imagePath = element.target.previousSibling.src;//$(this).siblings()[0].src;

        localStorage.setItem('text', text);
        localStorage.setItem('imagePath', imagePath);

        console.log(imagePath);

        window.location.href = 'http://127.0.0.1:2323/static/index2.html' ;
    });
});
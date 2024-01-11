document.addEventListener('DOMContentLoaded', function() {

    var text = localStorage.getItem('text');
    var image = localStorage.getItem('imagePath');

    console.log(text);

    var contentDiv = document.getElementById('content');
    contentDiv.style.display = 'flex';
    contentDiv.style.flexDirection = 'column';
    contentDiv.style.gap = '10px';
    contentDiv.style.paddingBottom = '40px';
    contentDiv.style.borderBottom = '1px solid lightgray';
    contentDiv.innerHTML = '<img src="' + image + '" alt="Изображение" style="width: 300px"><p style="color: #2ed73a">' + text + '</p>';

});
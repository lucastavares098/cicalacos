// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // Esconder todas as imagens inicialmente
    $('#img-1, #img-2, #img-3').hide();

    function fadeInOut(element) {
        element.fadeIn(2500, function () {
            $(this).fadeOut(3500);
        });
    }

    function changeImage() {
        fadeInOut($('#img-1'));

        setTimeout(function () {
            fadeInOut($('#img-2'));
        }, 6000);

        setTimeout(function () {
            fadeInOut($('#img-3'));
        }, 12000);
    }

    // Chamar a função inicialmente e, em seguida, a cada 15 segundos
    changeImage();
    setInterval(changeImage, 18000);
});

function formatarMoeda(element) {
    // Remove caracteres não numéricos
    let valor = element.value.replace(/\D/g, '');

    // Limita o número de caracteres para 6
    valor = valor.substring(0, 6);

    // Formata o valor como moeda
    valor = (Number(valor) / 100).toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });

    // Atualiza o valor no campo com o sufixo "R$"
    element.value = valor.replace(/^[^\d]+/, 'R$ ');
}




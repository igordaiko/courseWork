$(function() {
    $('#search').on('keyup', function() {
        var pattern = $(this).val();
        $('.searchable-container .items').hide();
        $('.searchable-container .items').filter(function() {
            return $(this).text().match(new RegExp(pattern, 'i'));
        }).show();
    });
});


$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip(); 
});

/*Смена фильтров для разных категорий*/
function change_filters(id) {
    $('html, body').animate({ scrollTop: $('#filter').position().top }, 1500);
    $('#hid_name').val(id);
    $('#sub').click();
}
/*Плавный скроллинг*/


/*РОМА. ГАВНОКОД!!! Сделай по человечески. Код повторяется!!!*/
$('#but_go').click(function(){
       $('html, body').animate({scrollTop:$('#choose_cat').position().top}, 1500);
});
$('#but_filter').click(function(){
       $('html, body').animate({scrollTop:$('#sum').position().top}, 1500);
});
$('#sum_but').click(function(){
       $('html, body').animate({scrollTop:$('#result').position().top}, 1500);
});



/*Carousel*/

$(function() {
    $('#carousel-zw').carouFredSel({
        auto: false,
        items: {
            visible: 1,
            start: 1
        }
    });
    $('#carousel-txt').carouFredSel({
        auto: false,
        items: 1,
        scroll: {
            fx: 'fade',
            duration: 2000
        }
    });
    $('#carousel-fc').carouFredSel({
        synchronise: [ ['#carousel-zw'], ['#carousel-txt', false] ],
        items: 1,
        scroll: {
            duration: 1000,
            timeoutDuration: 3000
        },
        prev: '#prev',
        next: '#next'
    });
});

'use strict';

$(document).ready(function () {
    $('.side-btn').click(function () {
        $('.side-bar').addClass('active-side-bar');
        $('.side-bgcolor').addClass('active-side-bgcolor');
        $('body').css('overflow','hidden');
    })
    $(".close-btn").click(function () {
        $('.side-bar').removeClass('active-side-bar');
        $('.side-bgcolor').removeClass('active-side-bgcolor');
        $('body').css('overflow-y','scroll');
    })
    $(".side-bgcolor").click(function () {
        $('.side-bar').removeClass('active-side-bar');
        $('.side-bgcolor').removeClass('active-side-bgcolor');
        $('body').css('overflow-y','scroll');
    })
    $('.slick-slider').slick({
        dots: true,
        infinite: true,
        autoplay: true,
        autoplaySpeed: 3500,
        arrow: false
    });
    $(".accordion-menu").slideUp();
    $("#acc-btn").click(function (e) { 
        $(".accordion-menu").slideToggle();
    });
});

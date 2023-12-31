// scroll section
let sections = document.querySelectorAll('section');
let navLinks = document.querySelectorAll('header nav a');

window.onscroll = () => {
    // active navbar links
    sections.forEach(sec => {
        let top = window.scrollY;
        let offset = sec.offsetTop - 100;
        let height = sec.offsetHeight;
        let id = sec.getAttribute('id');

        if (top >= offset && top < offset + height) {
            navLinks.forEach(links => {
                links.classList.remove('active');
                document.querySelector('header nav a[href*=' + id + ']').classList.add('active');
            });

            // active sections for animation on scroll
            sec.classList.add('show-animate');
        }
        else {
            sec.classList.remove('show-animate');
        }
    });

    // header background
    let header = document.querySelector('header');
    header.classList.toggle('sticky', window.scrollY > 200);

    // remove toggle icon and navbar when navbar links scroll
    menuIcon.classList.remove('bx-x');
    navbar.classList.remove('active');
}

// toggle icon navbar
let menuIcon = document.querySelector('#menu-icon');
let navbar = document.querySelector('.navbar');

menuIcon.onclick = () =>{
    menuIcon.classList.toggle('bx-x');
    navbar.classList.toggle('active');
}


const $overlay = $('.pup-up');
'use strict';


    var lastWindowScrollTop = 0,
        userAgent = navigator.userAgent,
        $body = $('body'),
        isIOS = /iPhone|iPad/.test(userAgent),
        NO_SCROLL_CLASS = isIOS
            ? 'ios-noscroll'
            : 'non-ios-noscroll';

    function fixedBody() {
        if (isIOS) {
            lastWindowScrollTop = $(window).scrollTop();
            $body.addClass(NO_SCROLL_CLASS);
            $body.css('top', '-' + lastWindowScrollTop + 'px');
        } else {
            $body.addClass(NO_SCROLL_CLASS);
        }
    }

    function looseBody() {
        $body.removeClass(NO_SCROLL_CLASS);
        if (isIOS) {
            $body.css('top', '');
            window.scrollTo(0, lastWindowScrollTop);
        }
    }

    $.fn.scrollableOverlay = function () {
        this.on('show', fixedBody)
        this.on('hide', looseBody)
    };


// $overlay.scrollableOverlay();


function togglePopup(id) {
    $overlay.removeClass('hide');
    fixedBody();
}

function hidePopup(id) {
    $overlay.addClass('hide');
    looseBody();
}
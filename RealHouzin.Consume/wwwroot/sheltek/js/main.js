/*

Template:  Sheltek Real Estate HTML5 Template
Author: http://devitems.com/
Version: 1
Design and Developed by: http://devitems.com/

*/
/*================================================
[  Table of contents  ]
================================================
	1. jQuery MeanMenu
	2. wow js active
	3. scrollUp jquery active
    4. Nivo Slider 
    5. Price Slider
	6. slick carousel 
    6. tooltip
    7. Service Carousel
    8. Agents Carousel
    9. Testimonial Carousel
    10. Blog Carousel
    11. Brand Carousel
    12. Blog Carousel
    13. counter
    14. Background Youtube Video 
    15. Background Vimeo Video 
    16. Find home hide
    17. STICKY sticky - header
 
======================================
[ End table content ]
======================================*/


(function ($) {
    "use strict";
    // Check if element exists
    $.fn.elExists = function () {
        return this.length > 0;
    };

    /*-------------------------------------------
        1. jQuery MeanMenu
    --------------------------------------------- */
    jQuery('nav#dropdown').meanmenu();

    /*-------------------------------------------
        2. wow js active
    --------------------------------------------- */
    new WOW().init();

    /*-------------------------------------------
        3. scrollUp jquery active
    --------------------------------------------- */
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });

    /*-------------------------------------------
        4. Nivo Slider
    --------------------------------------------- */
    $('#ensign-nivoslider-3').nivoSlider({
        // effect: 'fade',
        effect: 'random',
        slices: 15,
        boxCols: 8,
        boxRows: 4,
        animSpeed: 500,
        pauseTime: 5000,
        prevText: 'p<br/>r<br/>e<br/>v',
        nextText: 'n<br/>e<br/>x<br/>t',
        startSlide: 0,
        directionNav: true,
        controlNav: true,
        controlNavThumbs: false,
        pauseOnHover: true,
        manualAdvance: false
    });

    /* ********************************************
        5. Price Slider
    ******************************************** */
    $("#slider-range").slider({
        range: true,
        min: 20,
        max: 2500,
        values: [80, 2000],
        slide: function (event, ui) {
            $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
        }
    });
    $("#amount").val("$" + $("#slider-range").slider("values", 0) +
        " - $" + $("#slider-range").slider("values", 1));

    /*************************
        6. tooltip
    *************************/
    $('[data-toggle="tooltip"]').tooltip();

    /*************************
        7. Service Carousel
    *************************/
    $('.service-carousel').slick({
        arrows: false,
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 3,
        responsive: [{
                breakpoint: 992,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 2
                }
            }, // Tablet
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }, // Large Mobile
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            } // Small Mobile
        ]
    });
    /*************************
        8. Agents Carousel
    *************************/
    $('.agents-carousel').slick({
        arrows: false,
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 3,
        responsive: [{
                breakpoint: 992,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 2
                }
            }, // Tablet
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }, // Large Mobile
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            } // Small Mobile
        ]
    });

    /*************************
        9. Testimonial Carousel
    *************************/
    $('.testimonial-carousel').slick({
        arrows: false,
        dots: true,
        infinite: true,
        speed: 300,
        slidesToShow: 1,
        slidesToScroll: 1
    });

    /*************************
        10. Blog Carousel
    *************************/
    $('.blog-carousel').slick({
        arrows: false,
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 3,
        slidesToScroll: 2,
        responsive: [{
                breakpoint: 992,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }, // Tablet
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }, // Large Mobile
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            } // Small Mobile
        ]
    });

    /*************************
        11. Brand Carousel
    *************************/
    $('.brand-carousel').slick({
        arrows: false,
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 5,
        slidesToScroll: 4,
        responsive: [{
                breakpoint: 1169,
                settings: {
                    slidesToShow: 4,
                    slidesToScroll: 3
                }
            }, // Medium Device
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 2
                }
            }, // Tablet
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }, // Large Mobile
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            } // Small Mobile
        ]
    });

    /*************************
        12. Blog Carousel
    *************************/
    $('.pro-details-carousel').slick({
        arrows: false,
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 3,
        responsive: [{
                breakpoint: 992,
                settings: {
                    slidesToShow: 4,
                    slidesToScroll: 3
                }
            }, // Tablet
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 2
                }
            }, // Large Mobile
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            } // Small Mobile
        ]
    });

    /*************************
        13. counter
    *************************/
    $('.counter').counterUp({
        delay: 10,
        time: 1000
    });

    /* ********************************************
        14. Background Youtube Video 
    ******************************************** */
    $(".youtube-bg").YTPlayer({
        videoURL: "Sz_1tkcU0Co",
        containment: '.youtube-bg',
        mute: true,
        loop: true,
        startAt: 7,
        showControls: false,
        showYTLogo: false
    });

    /* ********************************************
        15. Background Vimeo Video 
    ******************************************** */
    $(".vimeo-bg").vimeo_player({
        videoURL: "363664444",
        containment: '.vimeo-bg',
        mute: true,
        loop: true,
        showControls: false,
        mobileFallbackImage: 'images/bg/10.jpg'
    });

    /* ********************************************
        16. Find home hide
    ******************************************** */
    $('.close-home').on('click', function () {
        $('.find-home-box').addClass('hidden');

    });


    /**********************
     * Countdown Timer
     ***********************/


    function makeTimer($endDate, $this, $format) {
        var today = new Date();
        var BigDay = new Date($endDate),
            msPerDay = 24 * 60 * 60 * 1000,
            timeLeft = (BigDay.getTime() - today.getTime()),
            e_daysLeft = timeLeft / msPerDay,
            daysLeft = Math.floor(e_daysLeft),
            e_hrsLeft = (e_daysLeft - daysLeft) * 24,
            hrsLeft = Math.floor(e_hrsLeft),
            e_minsLeft = (e_hrsLeft - hrsLeft) * 60,
            minsLeft = Math.floor((e_hrsLeft - hrsLeft) * 60),
            e_secsLeft = (e_minsLeft - minsLeft) * 60,
            secsLeft = Math.floor((e_minsLeft - minsLeft) * 60);

        var yearsLeft = 0;
        var monthsLeft = 0
        var weeksLeft = 0;

        if ($format != 'short') {
            if (daysLeft > 365) {
                yearsLeft = Math.floor(daysLeft / 365);
                daysLeft = daysLeft % 365;
            }

            if (daysLeft > 30) {
                monthsLeft = Math.floor(daysLeft / 30);
                daysLeft = daysLeft % 30;
            }
            if (daysLeft > 7) {
                weeksLeft = Math.floor(daysLeft / 7);
                daysLeft = daysLeft % 7;
            }
        }




        yearsLeft = yearsLeft < 10 ? "0" + yearsLeft : yearsLeft;
        monthsLeft = monthsLeft < 10 ? "0" + monthsLeft : monthsLeft;
        weeksLeft = weeksLeft < 10 ? "0" + weeksLeft : weeksLeft;
        daysLeft = daysLeft < 10 ? "0" + daysLeft : daysLeft;
        hrsLeft = hrsLeft < 10 ? "0" + hrsLeft : hrsLeft;
        minsLeft = minsLeft < 10 ? "0" + minsLeft : minsLeft;
        secsLeft = secsLeft < 10 ? "0" + secsLeft : secsLeft;

        var yearsText = yearsLeft > 1 ? 'years' : 'year',
            monthsText = monthsLeft > 1 ? 'months' : 'month',
            weeksText = weeksLeft > 1 ? 'weeks' : 'week',
            daysText = daysLeft > 1 ? 'days' : 'day',
            hourText = hrsLeft > 1 ? 'hrs' : 'hr',
            minsText = minsLeft > 1 ? 'mins' : 'min',
            secText = secsLeft > 1 ? 'secs' : 'sec';

        var $markup = {
            wrapper: $this.find('.countdown__item'),
            year: $this.find('.yearsLeft'),
            month: $this.find('.monthsLeft'),
            week: $this.find('.weeksLeft'),
            day: $this.find('.daysLeft'),
            hour: $this.find('.hoursLeft'),
            minute: $this.find('.minsLeft'),
            second: $this.find('.secsLeft'),
            yearTxt: $this.find('.yearsText'),
            monthTxt: $this.find('.monthsText'),
            weekTxt: $this.find('.weeksText'),
            dayTxt: $this.find('.daysText'),
            hourTxt: $this.find('.hoursText'),
            minTxt: $this.find('.minsText'),
            secTxt: $this.find('.secsText')
        }

        var elNumber = $markup.wrapper.length;
        $this.addClass('item-' + elNumber);
        $($markup.year).html(yearsLeft);
        $($markup.yearTxt).html(yearsText);
        $($markup.month).html(monthsLeft);
        $($markup.monthTxt).html(monthsText);
        $($markup.week).html(weeksLeft);
        $($markup.weekTxt).html(weeksText);
        $($markup.day).html(daysLeft);
        $($markup.dayTxt).html(daysText);
        $($markup.hour).html(hrsLeft);
        $($markup.hourTxt).html(hourText);
        $($markup.minute).html(minsLeft);
        $($markup.minTxt).html(minsText);
        $($markup.second).html(secsLeft);
        $($markup.secTxt).html(secText);
    }

    if ($('.countdown').elExists) {
        $('.countdown').each(function () {
            var $this = $(this);
            var $endDate = $(this).data('countdown');
            var $format = $(this).data('format');
            setInterval(function () {
                makeTimer($endDate, $this, $format);
            }, 0);
        });
    }





})(jQuery);

/* ********************************************
    17. STICKY sticky-header
******************************************** */
var hth = $('.header-top-bar').height();
$(window).on('scroll', function () {
    if ($(this).scrollTop() > hth) {
        $('#sticky-header').addClass("sticky");
    } else {
        $('#sticky-header').removeClass("sticky");
    }
});
/* ********************************************************* */
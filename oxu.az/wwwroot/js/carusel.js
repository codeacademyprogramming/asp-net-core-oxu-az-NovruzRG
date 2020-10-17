var countOfSliderImage = $(".featured-container .featured-i").length;
var margin = 0;
var i = 0;
setInterval(function () { addMargin() }, 5000);

$(document).on("click", ".featured-switch", function () {
    if ($(this).hasClass("s-next")) {
        if ((countOfSliderImage - 1) == i) {
            margin = 0
            i = 0
        }
        else {
            margin -= 620;
            i++
        }
        $(".featured-content").css({
            marginLeft: '' + margin + '' + 'px'
        })
    }
    else if ($(this).hasClass("s-left")) {
        if (i == 0) {
            margin = (-620) * (countOfSliderImage - 1)
            i = countOfSliderImage - 1
        }
        else {
            margin += 620;
            i--
        }
        $(".featured-content").css({
            marginLeft: '' + margin + '' + 'px'
        })
    }
})
function addMargin() {
    if ((countOfSliderImage - 1) == i) {
        margin = 0
        i = 0
    }
    else {
        margin -= 620;
        i++
    }
    $(".featured-content").css({
        marginLeft: '' + margin + '' + 'px'
    })
}
       


$(document).ready(function () {
    var starIcons = $(".RatingIcons>li>i");
    starIcons.click(function () {
        let active = $(this);
        $("#ratingInput").val($(this).index()+1);
        for (let i = 0; i <= $(this).index(); i++) {
            active.removeClass("fa-regular");
            active.addClass("fa-solid");
            active = active.prev();
        }
        let next = $(this).next();
        for (let i = $(this).index() + 1; i <= 5; i++) {
            next.addClass("fa-regular");
            next.removeClass("fa-solid");
            next = next.next();
        }
    })
})
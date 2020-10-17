$(function () {
       
    $(document).on("click", ".stats_likes", function () {
        $(this).click(false);

        var id_ = $(this).parent().attr("data-id");
        $(`.stats[data-id=${id_}] .stats_dislikes`).click(false);
        var data_ = {
            id: id_
        }
        $.ajax({
            url: "/Home/Like",
            type: "post",
            data: data_,
            dataType: "json",
            success: function () {
                var count = $(`.stats[data-id=${id_}] .stats_likes`).find(".stats-i  span").text();
                count++;
                $(`.stats[data-id=${id_}] .stats_likes`).find(".stats-i  span").text(count);
            }
        })
    })
    $(document).on("click", ".stats_dislikes", function () {
        $(this).click(false);

        var id_ = $(this).parent().attr("data-id");
        $(`.stats[data-id=${id_}] .stats_likes`).click(false);
        var data_ = {
            id: id_
        }
        $.ajax({
            url: "/Home/Dislike",
            type: "post",
            data: data_,
            dataType: "json",
            success: function () {
                var count = $(`.stats[data-id=${id_}] .stats_dislikes`).find(".stats-i > span").text();
                count++;
                $(`.stats[data-id=${id_}] .stats_dislikes`).find(".stats-i > span").text(count);
            }
        })
    })
})
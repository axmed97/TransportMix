var count = 7;
$("#news-load-more").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreNews?skipCount=" + count,
        method: "GET",
        success: function (res) {
            $(".newsLoad").append(res);
            count += 1;
        }

    })
})
$("#article-load-more").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreArticle?skipCount=" + count,
        method: "GET",
        success: function (res) {
            $(".articleLoad").append(res);
            count += 1;
        }

    })
})


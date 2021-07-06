let skip = 9;

$("#salonloadMore").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreAutoSalon?skipCount=" + skip,
        method: "GET",
        success: function (response) {
            $(".auto-section .container .row").append(response)
            skip += 3
        }
    })
})

$("#insuranceloadMore").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreInsurance?skipCount=" + skip,
        method: "GET",
        success: function (response) {
            $(".auto-section .container .row").append(response)
            skip += 3
        }
    })
})

$("#serviceloadMore").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreService?skipCount=" + skip,
        method: "GET",
        success: function (response) {
            $(".auto-section .container .row").append(response)
            skip += 3
        }
    })
})

$("#masterloadMore").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreMaster?skipCount=" + skip,
        method: "GET",
        success: function (response) {
            $(".auto-section .container .row").append(response)
            skip += 3
        }
    })
})

$("#rentloadMore").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreRent?skipCount=" + skip,
        method: "GET",
        success: function (response) {
            $(".auto-section .container .row").append(response)
            skip += 3
        }
    })
})

$("#transloadMore").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreTransport?skipCount=" + skip,
        method: "GET",
        success: function (response) {
            $(".auto-section .container .row").append(response)
            skip += 3
        }
    })
})
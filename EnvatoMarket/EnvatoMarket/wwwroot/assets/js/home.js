$(document).ready(function () {
    
    $(document).on('click', '#myTab>li>a', function () {
        var value = $(this).attr("class");
        var ActiceSelectionId = $(this).attr("data-id");
        if (!value.includes("selected")) {
            $.ajax({
                methood: "get",
                url: `/Home/SearchByCategory/${ActiceSelectionId}`,
                success: function (data) {
                    console.log(data);
                    $("#new>div>div").empty();
                    $("#new>div>div").append(data);
                    $("#new>div>div").removeClass("slick-initialized slick-slider");
                },
                error: function (error) {
                    console.log(error);
                }
            })
        }
        $("#myTab>li>a").removeClass("selected");
        
        $(this).attr("class", "active selected");

    })
    $(document).on('click', '#ProductMenu2>li>a', function () {
        var value = $(this).attr("class");
        var ActiceSelectionId = $(this).attr("data-id");
        if (!value.includes("selected")) {
            $.ajax({
                methood: "get",
                url: `/Home/SearchByCategory/${ActiceSelectionId}`,
                success: function (data) {
                    console.log(data);
                    $("#computer>div>div").empty();
                    $("#computer>div>div").append(data);
                    $("#computer>div>div").removeClass("slick-initialized slick-slider");
                },
                error: function (error) {
                    console.log(error);
                }
            })
        }
        $("#ProductMenu2>li>a").removeClass("selected");

        $(this).attr("class", "active selected");

    })
})

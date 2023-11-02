
$(document).ready(function () {
    
    $(document).on('change', '#categorySelection', function () {
        
        $.ajax({
            methood: "get",
            url: `/Home/SearchByProduct?categoryId=${$(this).val()}`,
            success: function (data) {
                $("#Products").empty();
                data.forEach(item => {
                    var option = $("<option>");
                    
                    option.attr("value", item)
                    $("#Products").append(option);
                });
                
            },
            error: function (error) {
                console.log(error);
            }
        })
    })
    $.ajax({
        methood: "get",
        url: `/Home/SearchByProduct?categoryId=0`,
        success: function (data) {
            $("#Products").empty();
            data.forEach(item => {
                var option = $("<option>");

                option.attr("value", item)
                $("#Products").append(option);
            });

        },
        error: function (error) {
            console.log(error);
        }
    })
})
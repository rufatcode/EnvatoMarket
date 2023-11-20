setTimeout(function () {
    document.getElementById("AllertMessage").remove()
}, 3000)

setTimeout(function () {
    document.getElementById("SuccessMessage").remove()
}, 3000)
$(document).ready(function () {
    let countrySelect = document.querySelector("#countyList");
    let citySelect = document.querySelector("#cityList");
    $.ajax({
        method: "get",
        url: "https://countriesnow.space/api/v0.1/countries/",
        success: function (data) {
            console.log(data)
            data.data.forEach(item => {
                let option = document.createElement("option");
                option.innerHTML = item.country;
                option.setAttribute("value", item.country);
                countrySelect.appendChild(option);
            });
        },
        error: function (error) {
            console.log(error);
        }
    });
    let countryInput = document.querySelector("#selectCountry");
    countryInput.addEventListener("change", function () {
        citySelect.innerHTML = "";
        $.ajax({
            method: "get",
            url: "https://countriesnow.space/api/v0.1/countries/",
            success: function (data) {
                let city = data.data.filter(item => item.country == countryInput.value);
                city[0].cities.forEach(item => {
                    let option = document.createElement("option");
                    option.innerHTML = item;
                    option.setAttribute("value", item);
                    citySelect.append(option);
                })
            },
            error: function (error) {
                console.log(error);
            }
        });
    })
})

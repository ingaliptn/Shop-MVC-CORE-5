// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    let imgArray = [];
    $("#uploadBtn").on("click", function () {
        let formData = new FormData();
        formData.append("file", $("#file")[0].files[0]);
        $.ajax({
            url: "/api/Asset",
            type: "post",
            data: formData,
            cache: false,
            contentType: false,
            processData: false,
            error: function (data) {
                debugger;
            },
            success: function (responce) {//приймет массив id картинок
                if (responce != null) {
                    imgArray.push(responce[0])
                    $("#img").attr("src", "/api/Asset/" + responce[0]);
                    $(".preview img").show();
                    for (let i = 1; i < responce.length; i++) {
                        imgArray.push(responce[i]);
                        let img = new image(responce[i]);
                        let counter = 1;
                        img.onLoad = function () {
                            if (++counter === imgArray.length) {
                                alert("+ 1");
                            }
                        }
                    }
                }
            }
        })
    })
});
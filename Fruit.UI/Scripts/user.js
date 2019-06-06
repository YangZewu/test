$(function () {
    //找回
    $("#btnEdit").click(function () {
        $.ajax({
            url: "/User/Edit",
            type: "Post",
            data: {
                "userName": $("#inputEUName").val(),
                "userPwd": $("#inputEPwd").val()
            },
            success: function (data) {
                if (data.success) {
                    alert("找回成功");
                    $("#myModal").modal("hide");
                }
                else {
                    alert("找回失败");
                }
            }
        });
    }),
        //弹出窗口
        $("#btnUp").click(function () {
            $("#myModal").modal();
        }),
        //登录
        $("#btnLog").click(function () {
            $.ajax({
                url: "/User/GetUser",
                type: "Post",
                data: {
                    "userName": $("#inputUName").val(),
                    "userPwd": $("#inputUPwd").val(),
                },
                success: function (data) {
                    if (data.success) {
                        alert("登录成功");
                    }
                    else {
                        alert("登录失败");
                    }
                }
            });
        }),
        //注册
        $("#btnReg").click(function () {
            $.ajax({
                url: "/User/Add",
                type: "Post",
                data: {
                    "userName": $("#inputUName").val(),
                    "userPwd": $("#inputUPwd").val(),
                    "userTel": $("#inputUTel").val(),
                    "userEmail": $("#inputUEmail").val(),
                    "userSex": $("#USex").val(),
                    "userPwd": $("#inputUPwd").val(),
                    "userQQ": $("#inputQQ").val(),
                    "userTime": $("#inputTime").val()
                },
                success: function (data) {
                    if (data.success) {
                        alert("注册成功");
                        window.location = "/User/Login";
                    }
                    else {
                        alert("注册失败");
                    }
                }
            });
        });
});
function submiFile() {


    if ($("#form0").valid()) {
        $("#form0").ajaxSubmit(function () {
            $.ajax({
                type: "post",
                url: "/admin/AddProduct",
                success: function (data) {
                    console.log(data);
                    if (data > 0) {
                        alert("添加成功");
                    }
                }
            });
        });
    }

}



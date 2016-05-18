function ajax(url, pars, callback) {
    $.ajax({
        cache: false,
        type: "post",
        url: url,
        data: pars,
        async: false,
        dataType: "json",
        success: function (ret) {
            ret = eval(ret);
            callback(ret);
        }
    });
}
//上传图片
function uploadImage(fl, fpath, callback) {
    
    //创建FormData对象
    var data = new FormData();
    //为FormData对象添加数据
    $.each($('#' + fl)[0].files, function (i, file) {
        data.append('upload_file', file);
    });
    data.append('fpath', fpath);
    //判断上传文件的后缀名
    var imgPath = $("#" + fl).val();
    var strExtension = imgPath.substr(imgPath.lastIndexOf('.') + 1);
    if (strExtension != 'jpg' && strExtension != 'gif'
            && strExtension != 'png' && strExtension != 'bmp') {
        alert("请选择图片文件");
        return;
    }
    $.ajax({
        type: "POST",
        url: "/handler/UploadImageHandler.ashx",
        data: data,
        cache: false,
        contentType: false,    //不可缺
        processData: false,    //不可缺
        success: function (ret) {
            ret = eval("("+ret+")");
            callback(ret);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("上传失败，请检查网络后重试");
        }
    });
}

function isNull(exp) {
    if (!exp && typeof (exp) != "undefined" && exp != 0) {
        alert("is null"+exp)
        return true;
    }
    else {
        alert("is not null" + exp)
        return false;
    }
}
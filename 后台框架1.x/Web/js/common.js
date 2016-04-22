function ajax(url,pars,callback) {
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
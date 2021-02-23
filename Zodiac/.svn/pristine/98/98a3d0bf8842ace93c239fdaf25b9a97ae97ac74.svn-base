; (function ($) {

    $.extend($, {
        alertMsg: function (msg,title,funcSuc) {
            if ($.messager) {
                $.messager.alert(title, msg, "info", function () {
                    if (funcSuc) {
                        funcSuc();
                    }
                })
            }
            else {
                alert(title + "\r\n " + msg);
                if (funcSuc) {
                    funcSuc();
                }
            }
        },
        //是否有权限访问此url如果没有 会根据请求类型返回数据，此请求会到过滤器处理
        validateUrl: function (url, funcSuc, funcErr, type) {
            $.ajax({
                type: type,
                url: url,
                success: function (data) {
                   // alert(data);
                    if (data.Msg) {
                        funcErr(data);
                    } else {
                        funcSuc();
                    }
                }
            });
        }
        ,
        procAjaxMsg: function (data, funcSuc, funcErr) {
            if (!data.Statu) {
                return;
            }
            var state = parseInt(data.Statu);            
            switch (state) {
             
                case 1:
                    if (funcSuc) {
                        funcSuc(data);
                    }
                    break;
                case 2:
                    if (funcErr) {
                        funcErr(data);
                    }
                    break;
                case 4:
                    //是否登录
                    $.alertMsg(data.Msg, '系统提示', function () {
                        if (window != top) {
                            top.location.href = data.BackUrl;
                        }
                        else {
                            window.location.href = data.BackUrl;
                        }
                    });
                    break;
                case 5:
                    //是否有权
                    $.alertMsg(data.Msg, '系统提示',null);
                    break;
            }

        }

    });

})(jQuery);

/**
 * 
 * 取消easyui默认开启的parser
 * 
 * 在页面加载之前，先开启一个进度条
 * 
 * 然后在页面所有easyui组件渲染完毕后，关闭进度条
 * 
 * 
 * @requires jQuery,EasyUI
 * 
 */
$.parser.auto = false;
$(function () {
    $.messager.progress({
        text: 'loading....',
        interval: 100
    });
    $.parser.parse(window.document);
    window.setTimeout(function () {
        $.messager.progress('close');
        if (self != parent) {
            window.setTimeout(function () {
                try {
                    parent.$.messager.progress('close');
                } catch (e) {
                }
            }, 500);
        }
    }, 1);
    $.parser.auto = true;
});

/**
 * 使panel和datagrid在加载时提示
 *
 * 
 * @requires jQuery,EasyUI
 * 
 */
$.fn.panel.defaults.loadingMessage = '加载中....';
$.fn.datagrid.defaults.loadMsg = '加载中....';


(function ($) {
    $.extend($,
        {
            //显示消息：如果有easyui，则调用easyui的message组件显示消息
            alertMsg: function (msg, title, funcSuc) {
                //error,question,info,warning
                if ($.messager) {
                    $.messager.alert(title, msg, "info", function () {
                        if (funcSuc) funcSuc();
                    });
                } else {
                    alert(title + "\r\n     " + msg);
                    if (funcSuc) funcSuc();
                }
            },
            //统一处理 返回的json数据格式
            procAjaxData: function (data, funcSuc, funcErr) {
                if (!data || !data.Statu) {
                    return;
                }

                switch (data.Statu) {
                    case "ok":
                        if (data.Msg && data.Msg.trim() != "") { $.alertMsg(data.Msg, "系统提示", function () { funcSuc(data); }); }
                        else funcSuc(data);
                        break;
                    case "err":
                        if (data.Msg && data.Msg.trim() != "") { $.alertMsg(data.Msg, "系统提示", function () { funcErr(data); }); }
                        else funcErr(data);
                        break;
                    case "nologin":
                        $.alertMsg(data.Msg, "系统提示", function () { if (window.top) window.top.location = data.BackUrl; else window.location = data.BackUrl; });
                        break;
                }
            }
        });
}(jQuery));
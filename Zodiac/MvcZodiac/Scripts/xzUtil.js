/*定义全局对象,类似于命名空间的作用*/
var xz = $.extend({},xz);
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
        text: 'Loading....',
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
* @author 闲筝
* 更换EasyUI皮肤的方法
*/
xz.changeTheme = function (themeName) {
    var $easyuiTheme = $("#easyuiTheme");
    var url = $easyuiTheme.attr('href');
    var href = url.substring(0, url.indexOf('themes')) + 'themes/' + themeName + '/easyui.css';
    $easyuiTheme.attr('href', href);
    /*近一步调整iframe内嵌框架的样式*/
    var $iframe = $('iframe');
    if ($iframe.length > 0) {
        for (var i = 0; i < $iframe.length; i++) {
            var ifr = $iframe[i];
            $(ifr).contents().find("$easyuiTheme").attr('href', href);
        }
    }
    /*用cookie保存主题*/
    $.cookie('easyuiThemeName', href, {
        path: '/',
        expires: 7
    });
}

/**
* @author 闲筝
* 把一个div以easyui对话框形式显示出来
*
*/
xz.dialog = function (options) {
    var opts = $.extend({
        modal: true,
        onClose: function () {
            
            $(this).dialog('destroy');
        }
    }, options);
    //$()中的是一个字符串，用这样一段字串构建了jQuery对象
    // return $('<div/>').dialog(opts);
    //20150906 modify by zhanglei 
    return $('<div></div>').dialog(opts);
}
/**
*formatestring
*格式化字符串
*/
xz.fs = function (str) {
    for (var i = 0; i < arguments.length - 1; i++) {
        str = str.replace("{" + i + "}", arguments[i + 1]);
    }
    return str;
}

/**
* 格式化字符串
* 用法:
.formatString("{0}-{1}","a","b");
*/
xz.formatString = function () {
    for (var i = 1; i < arguments.length; i++) {
        var exp = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
        arguments[0] = arguments[0].replace(exp, arguments[i]);
    }
    return arguments[0];
};
/**
* ajax提交成功以后调用的方法
*
*/
xz.dealWith = function (jsonData) {
    $.procAjaxMsg(jsonData,null,null);
}
/**
*操作信息提示alert
*/
xz.messagerAlert = function (title, msg, icon, fn) {
    return $.messager.alert(title,msg,icon,fn);
}
/**
*操作信息提示Show
*/
xz.messagerShow = function (options) {
    return $.messager.show(options);
}
/**
*操作信息提示Confirm
*/
xz.messagerConfirm = function (title, msg, fn) {
    return $.messager.confirm(title, msg, fn);
}
/**
*是否禁用
*/
xz.formatterEnable = function (value,row) {
    return '<img src="/Content/images/' + ((value || '').toString() == "true" ? "checked.gif" : "unchecked.gif") + '"/>';
}

/**
 * @author 闲筝
 * 
 * 生成UUID
 * 
 * @returns UUID字符串
 */
xz.random4 = function () {
    return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
};

xz.UUID = function () {
    return (xz.random4() + xz.random4() + "-" + xz.random4() + "-" + xz.random4() + "-" + xz.random4() + "-" + xz.random4() + xz.random4() + xz.random4());
};

/**
*把表单元素序列化成对象
*/
xz.serializeObject = function (form) {
   
    var serializeObj = {};
    /////增加//表单序列化获取未选中的CheckBox
    var temp = form.serializeArray();
    var not_checked_object = $('input[type=checkbox]:not(:checked)', form);
    $.each(not_checked_object, function () {
        if (!temp.hasOwnProperty(this.name)) {//this指没选中的一个object
            temp.push({ name: this.name, value: "" });
        }
    });

    $(temp).each(function () {  //将有相通name的CheckBox合并到一个数组中
        if (serializeObj[this.name]) {
            if ($.isArray(serializeObj[this.name])) {
                serializeObj[this.name].push(this.value);
            } else {
                serializeObj[this.name] = [serializeObj[this.name], this.value];
            }
        } else {
            serializeObj[this.name] = this.value;
        }
    });


 


    return serializeObj;
 



    //////////////update by zhanglei 20191104
   // var o = {};
    //$.each(form.serializeArray(), function (intdex) {
    //    if (o[this['name']]) {
    //        o[this['name']] = o[this['name']] + "," + this['value'];
    //    } else {
    //        o[this['name']] = this['value']
    //    }
    //});

    //return o;
}
/**
*把一个以逗号分割的字符串，返回List，List里每一项都是一个字符串
*/
xz.getList = function (value) {
    if (value != undefined && value != '') {
        var values = [];
        var t = value.split(',');
        for (var i = 0; i < t.length; i++) {
            values.push('' + t[i]);
        }
        return values;
    } else {
        return [];
    }
}
/**
*按参数显示各图表信息
*renderTo:图表所依托的DIV
*type:图表类型
*name:数据列的名称
*url:获取后台数据的url
*title:图表的主标题
*/
xz.loadHighChart = function (renderTo,type,name,url,title) {
    var xAxis = [];
    var series = [];
    /*从后台读取各部门人数*/
    $.getJSON(
        url
        , function (jsonData) {
            /*把相关的数据放入对应的数组*/
            for (var key in jsonData) {
                if (jsonData[key].Name) {
                    xAxis.push(jsonData[key].Name);
                    series.push([jsonData[key].Name, jsonData[key].Count]);
                }
            }
            var chart1 = new Highcharts.Chart({                  
                chart: {
                    renderTo: renderTo,
                    backgroundColor: null,
                    plotBackgroundColor:null
                },
                title: {
                    text: title      //指定图表标题
                },
                tooltip:{
                  pointFormat: '{series.name}: <b>{point.y}</b><br/>',
                  valueSuffix: ' 人',
                  shared: true
                },
                xAxis: {
                    categories: xAxis  //指定x轴分组
                },
                yAxis: {
                    title: {
                        text: '人数(个)'                  //指定y轴的标题
                    }
                },
                plotOptions:{
                    series: {
                        dataLabels: {
                            enabled: true,
                            borderRadius: 5,
                            backgroundColor: 'rgba(252, 255, 197, 0.7)',
                            borderWidth: 1,
                            borderColor: '#AAA',
                            y: -6
                        }
                    },
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: true,
                            format: '<b>{point.name}</b>:{point.percentage:.1f}%',
                            style: {
                                color:'black'
                            }
                        }
                    }
                },
                series: [{                                 //指定数据列
                    type: type,
                    name: name,                          //数据列名
                    data: series                       //数据
                }]
            });

        }
     );


}
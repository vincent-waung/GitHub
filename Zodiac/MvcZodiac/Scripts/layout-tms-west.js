/*绑定权限树菜单*/
var ctrlTree;
/*easyui经典示例的菜单*/
var menuTree;
/*手风琴菜单*/
var accordion;
$(function () {
    $.ajax({
        type: 'POST',
        url: '/Admin_Areas/Sys_UserSetting/GetOneUserSetting',
        data: {
            SettingCode: 'navigation',
        },
        dataType: "json",
        success: function (jsonData) {
            
            if (jsonData.SettingValue == "accordion") {
                
                initAccordion();
                
                $('#actree').remove();
            } else {               
                initTree();
                $('#wnav').remove();
            }
        }
    });  
   
})

/*绑定树型菜单*/
function initTree() {
    ctrlTree = $('#ctrlTree').tree({
        url: '/Admin_Areas/Sys_Permission/GetUserPers',
        lines: true,
        onLoadSuccess: function (node, data) {
            if (data.Msg) {
                dealWith(data);
            }
        },
        onClick: function (node) {
            addTab(node);
        },
        onDblClick: function (node) {
            if (node.state == 'closed') {
                $(this).tree('expand', node.target);
            } else {
                $(this).tree('collapse', node.target);
            }
        }
    });
}
/*绑定Accordion菜单*/
function initAccordion() {

    alert("开始/Admin_Areas/Sys_Permission/GetAllMenusForTree");
    $.ajax({
        type: 'POST',       
        url: '/Admin_Areas/Sys_Permission/GetAllMenusForTree',
        success: function (jsonData) {
             
            menuAccordion(jsonData);
        }
    });

}
function menuAccordion(menus) {
    menus = $.parseJSON(menus);
    var $obj = $('#wnav');
    $obj.accordion({ animate: false, fit: true, border: false });
    /*手风琴的一级菜单*/
    for (var i = 0; i < menus.length; i++) {
        var html = '<ul>';
        /*菜单图标和文本*/
        var temple = '<li><div><a ref="{0}" href="javascript:void(0)" rel="{1}"><span id="iconImg" style="padding-left:18px;display:inline-block;line-height;16px;" class="{2}">&nbsp;</span><span class="nav" style="display:inline-block;line-height;16px;">{3}</span></a></div></li>'
        var jsonobj = menus[i];
        if (jsonobj.children.length > 0) {
            /*手风琴的二级菜单*/
            for (var j = 0; j < jsonobj.children.length; j++) {
                var m = jsonobj.children[j];
                html += xz.formatString(temple, m.id, m.attributes.url, m.iconCls, m.text);
            }
        }
        html += '</ul>';
        $obj.accordion('add', {
            title: jsonobj.text,
            content: html,
            iconCls: jsonobj.iconCls,
            border:false
        });
        /*获取所有面板*/
        var panels = $obj.accordion('panels');
        /*选择第一个面板。'which'参数可以是面板标题或者索引。*/
        $obj.accordion('select', panels[0].panel('options').title);
        /*单击二级菜单时的事件*/
        $obj.find('li').click(function () {
            /*一级菜单移除选中样式*/
            $obj.find('li div').removeClass('selected');
            /*二级菜单添加选中的样式*/
            $(this).children('div').addClass('selected');
            /*创建添加tab页所须NODE节点的属性*/
            var link = $(this).find('a');
            var title = link.children('.nav').text();
            var url = link.attr('rel');
            var id = link.attr('ref');
            var icon = link.children('#iconImg').attr('class');
            var myNode = {
                'id': id,
                'text': title,
                'attributes': {
                    'url':url
                },
                'iconCls':icon
            };
            addTab(myNode);
        }).hover(function () {
            $(this).children('div').addClass('hover');
        },function () {
            $(this).children('div').removeClass('hover');
        });

    }
}
/*绑定EasyUI树型菜单*/
function initEasyuiTree() {
    menuTree = $('#menuTree').tree({
        url: '/EasyUI_Areas/AdminIndex/GetAllEasyUI',
        lines: true,
        onLoadSuccess: function (node, data) {
            if (data.Msg) {
                dealWith(data);
            }
        },
        onClick: function (node) {
            addTab(node);
        },
        onDblClick: function (node) {
            if (node.state == 'closed') {
                $(this).tree('expand', node.target);
            } else {
                $(this).tree('collapse', node.target);
            }
        }
    });
}

/*ajax 提交成以后调用的方法*/
function dealWith(jsonData) {
    $.procAjaxMsg(jsonData, null, null);
}


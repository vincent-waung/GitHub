/*实现tab效果*/
/*实现tab页右键菜单效果*/
var centerTabs;
var tabsMenu;
$(function () {
    tabsMenu = $('#tabsMenu').menu({
        onClick: function (item) {
            var curTabTitle = $(this).data('tabTitle');
            var type = $(item.target).attr('title');

            if (type == 'refresh') {
                refreshTab(curTabTitle);
                return;
            }
            if (type == 'close') {
                var t = centerTabs.tabs('getTab', curTabTitle);
                if (t.panel('options').closable) {
                    centerTabs.tabs('close', curTabTitle);
                }
                return;
            }

            var allTabs = centerTabs.tabs('tabs');
            var closeTabsTitle = [];

            $.each(allTabs, function () {
                var opt = $(this).panel('options');
                if (opt.closable && opt.title != curTabTitle && type == 'closeOther') {
                    closeTabsTitle.push(opt.title);
                } else if (opt.closable && type == 'closeAll') {
                    closeTabsTitle.push(opt.title);
                }
            });

            for (var i = 0; i < closeTabsTitle.length; i++) {
                centerTabs.tabs('close', closeTabsTitle[i]);
            }
        }

    });
    centerTabs = $('#centerTabs').tabs({
        fit: true,
        border: false,
        onContextMenu: function (e, title) {
            e.preventDefault();
            tabsMenu.menu('show', {
                left: e.pageX,
                top:e.pageY
            }).data('tabTitle',title)
        }
    });
});

//页面的frame
function newIframe(url) {
    var ifrStr = "<iframe src='" + url + "' frameborder=0 style='width:100%;height:99.4%;border:0' ></iframe>";
    return ifrStr;
}
/*刷新tab页*/
function refreshTab(title) {
    var tab = centerTabs.tabs('getTab', title);
    centerTabs.tabs("update", {
        tab: tab,
        options: tab.panel('options') 
    })
}
/*设置tab页*/
function addTab(node) {
    if (centerTabs.tabs("exists", node.text)) {
        centerTabs.tabs("select", node.text)
    } else {
        if (node.attributes.url && node.attributes.url.length > 0) {
            $.messager.progress({
                text: 'Loading......',
                interval:20
            });
            window.setTimeout(function () {
                try {
                    $.messager.progress('close');
                }
                catch (e) {

                }
            }, 1000);

            centerTabs.tabs('add', {
                title: node.text,
                content: newIframe(node.attributes.url),
                closable: true,
                iconCls:node.iconCls,
                tools: [{
                    iconCls: 'icon-mini-refresh',
                    handler: function () {
                        refreshTab(node.text);
                    }
                }]

            });
        }

    }
}
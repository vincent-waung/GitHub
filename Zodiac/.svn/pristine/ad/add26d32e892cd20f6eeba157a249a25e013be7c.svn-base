var portal;
var panels;
$(function () {

    panels = [{
        id: 'p1',
        title: '当前时间',
        height: 200,
        collapsible: true,
        href: '/Admin_Areas/AdminIndex/ShowClock'
    }, {
        id: 'p2',
        title: '各部门人数统计',
        height: 200,
        collapsible: true,
        content: '<div id="chartOne" style="width:100%;height:100%;"></div>'
    }, {
        id: 'p3',
        title: '日历',
        height: 200,
        collapsible: true,
        content: '<div id="calendar"></div>'
    }, {
        id: 'p4',
        title: '企业视频',
        height: 200,
        collapsible: true,
        href: '/Admin_Areas/AdminIndex/ShowCompany'
    }, {
        id: 'p5',
        title: '男女人数统计',
        height: 200,
        collapsible: true,
        content: '<div id="chartTwo" style="width:100%;height:100%;"></div>'
    }, {
        id: 'p6',
        title: '统计报表',
        height: 200,
        collapsible: true,
        href: '/Admin_Areas/AdminIndex/ShowReports'
    }];

    portal = $('#portal').portal({
        border: false,
        fit: true,
        onStateChange: function () {
            $.cookie('portal-state', getPortalState(), {
                expires: 7
            });
        }
    });
    var state = $.cookie('portal-state');
    if (!state) {
        state = 'p1,p2,p3:p4,p5,p6';/*冒号代表列，逗号代表行*/
    }
    addPanels(state);
    portal.portal('resize');

});

function getPanelOptions(id) {
    for (var i = 0; i < panels.length; i++) {
        if (panels[i].id == id) {
            return panels[i];
        }
    }
    return undefined;
}
function getPortalState() {
    var aa = [];
    for (var columnIndex = 0; columnIndex < 2; columnIndex++) {
        var cc = [];
        var panels = portal.portal('getPanels', columnIndex);
        for (var i = 0; i < panels.length; i++) {
            cc.push(panels[i].attr('id'));
        }
        aa.push(cc.join(','));
    }
    return aa.join(':');
}
function addPanels(portalState) {
    var columns = portalState.split(':');
    for (var columnIndex = 0; columnIndex < columns.length; columnIndex++) {
        var cc = columns[columnIndex].split(',');
        for (var j = 0; j < cc.length; j++) {
            var options = getPanelOptions(cc[j]);
            if (options) {
                var p = $('<div/>').attr('id', options.id).appendTo('body');
                p.panel(options);
                portal.portal('add', {
                    panel: p,
                    columnIndex: columnIndex
                });
            }
        }
    }
}
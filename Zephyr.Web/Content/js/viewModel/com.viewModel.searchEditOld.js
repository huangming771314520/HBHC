﻿/**
* 模块名：com viewModel
* 程序名: SearchEdit.js
* Copyright(c) 2013-2015 liuhuisheng [ liuhuisheng.xm@gmail.com ] 
**/
var com = com || {};
com.viewModel = com.viewModel || {};

com.viewModel.searchEdit = function (data) {
    var self = this;
    this.urls = data.urls;
    this.resx = data.resx;
    this.dataSource = data.dataSource;
    this.form = ko.mapping.fromJS(data.form); 
    this.defaultRow = data.defaultRow;
    this.setting = data.setting;
    delete this.form.__ko_mapping__;

    this.grid = {
        size: { w: 4, h: 84 },
        url: self.urls.query,
        queryParams: ko.observable(),
        pagination: true
    };
    this.grid2 = {
        size: { w: 4, h: 84 },
        url: self.urls.query2,
        queryParams: ko.observable(),
        pagination: true
    };
    this.gridEdit = new com.editGridViewModel(this.grid);
    this.grid.onDblClickRow = this.gridEdit.begin;
    this.grid.onClickRow = this.gridEdit.ended;
    this.grid.OnAfterCreateEditor = function (editors) {
        if (editors[self.setting.idField]) com.readOnlyHandler('input')(editors[self.setting.idField].target, true);
    };
    this.searchClick = function () { 
            var param = ko.toJS(this.form);
            this.grid.queryParams(param); 
    };
    this.searchClick2 = function () {
        var param = ko.toJS(this.form);
        this.grid2.queryParams(param);
    };
    this.clearClick = function () {
        $.each(self.form, function () { this(''); }); 
        this.searchClick();
    };
    this.refreshClick = function () {
        window.location.reload();
    };
    this.addClick = function () {
        com.ajax({
            type: 'GET',
            url: self.urls.newkey,
            success: function (d) {
                var row = $.extend({}, self.defaultRow);
                row[self.setting.idField] = d;
                self.gridEdit.addnew(row);
            }
        });
    };
    this.deleteClick = self.gridEdit.deleterow;
    this.editClick = function () {
        var row = self.grid.datagrid('getSelected');
        if (!row) return com.message('warning', self.resx.noneSelect);
        self.gridEdit.begin()
    };
    this.grid.onDblClickRow = this.editClick;
    this.auditClick = function () {
        var row = self.grid.datagrid('getSelected');
        if (!row) return com.message('warning', self.resx.noneSelect);
        com.auditDialog(function (d) {
            com.ajax({
                type: 'POST',
                url: self.urls.audit + row.BillNo,
                data:JSON.stringify(d),
                success: function () {
                    com.message('success', self.resx.auditSuccess);
                }
            });
        });
    };
    this.saveClick = function () {
        self.gridEdit.ended(); //结束grid编辑状态
        var post = {};
        post.list = self.gridEdit.getChanges(self.setting.postListFields);
        if (self.gridEdit.ended() && post.list._changed) {
            com.ajax({
                url: self.urls.edit,
                data: ko.toJSON(post),
                success: function (d) {
                    com.message('success', self.resx.editSuccess);
                    self.gridEdit.accept();
                }
            });
        }
    };
    this.downloadClick = function (vm, event) {
        if (self.grid2)
        {
            com.exporter(self.grid2).download($(event.currentTarget).attr("suffix"));
        }
        com.exporter(self.grid).download($(event.currentTarget).attr("suffix"));
    };
    com.FormatDate = function (datevalue) {
       // var tempdate = new Date(datevalue);
        return datevalue.getFullYear() + "-" + (datevalue.getMonth() + 1) + "-" + datevalue.getDate() + " " + datevalue.getHours() + ":" + datevalue.getMinutes();

    };
    //跳转打印页面
    this.printTab = function () { 
                //com.openTab('统计', self.urls.print + "?F1=" + self.form.F1._latestValue + "&banci="
                //    + self.form.banci._latestValue + "&F3_From=" + self.form.F3_From._latestValue
                //    + "&F3_To=" + self.form.F3_To._latestValue + "&LineName=" + self.form.LineName._latestValue, 'icon-printer_color');
        
    }; 
    this.copyClick = function () {
        var source = self.grid.datagrid('getSelected');
        if (!source) return com.message('warning', self.resx.noneSelect);
        com.ajax({
            type: 'GET',
            url: self.urls.newkey,
            success: function (d) {
                var target = $.extend({}, source);
                target[self.setting.idField] = d;
                self.gridEdit.addnew(target);
            }
        });
    };
};

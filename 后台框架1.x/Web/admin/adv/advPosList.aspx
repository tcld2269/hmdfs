<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="advPosList.aspx.cs" Inherits="hm.Web.admin.adv.advPosList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="addpanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    广告位添加</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位名称：</label>
                        <div class="col-sm-8">
                            <input id="ap_name" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位宽度：</label>
                        <div class="col-sm-8">
                            <input id="ap_width" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位高度：</label>
                        <div class="col-sm-8">
                            <input id="ap_height" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位简介：</label>
                        <div class="col-sm-8">
                            <textarea id="ap_summary" minlength="2" type="text" class="form-control" rows="2"></textarea>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位模板：</label>
                        <div class="col-sm-8">
                            <textarea id="ap_temp" minlength="2" type="text" class="form-control" rows="4"></textarea>
                            标签：{url}链接地址 {pic}图片 {remark}文字 {id}广告ID
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <button id="btnsubmit" class="btn btn-warning" type="button" onclick="addRole()">
                                添加</button>
                            <button id="btncancle" class="btn btn-default" type="button" onclick="cancleaddpanel()">
                                取消</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="editPanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    广告位编辑</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位ID：</label>
                        <div class="col-sm-8">
                            <input id="id_edit" type="text" class="form-control" style="border:0;background-color:#fff" readonly="true">
                        </div>
                    </div>
                   <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位名称：</label>
                        <div class="col-sm-8">
                            <input id="ap_name_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位宽度：</label>
                        <div class="col-sm-8">
                            <input id="ap_width_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位高度：</label>
                        <div class="col-sm-8">
                            <input id="ap_height_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位简介：</label>
                        <div class="col-sm-8">
                            <textarea id="ap_summary_edit" minlength="2" type="text" class="form-control" rows="2"></textarea>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告位模板：</label>
                        <div class="col-sm-8">
                            <textarea id="ap_temp_edit" minlength="2" type="text" class="form-control" rows="4"></textarea>
                            标签：{url}链接地址 {pic}图片 {remark}文字 {id}广告ID
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <button id="Button1" class="btn btn-warning" type="button" onclick="editRole()">
                                修改</button>
                            <button id="Button2" class="btn btn-default" type="button" onclick="cancleEditpanel()">
                                取消</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    广告位管理 <button class="btn btn-warning btn-xs" type="button" onclick="showaddpanel()">添加广告位</button></h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <table class="table table-striped table-bordered table-hover dataTables-example">
                    <thead>
                        <tr>
                            <th>
                                ID
                            </th>
                            <th style="width: 50%">
                                广告位名称
                            </th>
                            <th>
                                宽度
                            </th>
                            <th>
                                高度
                            </th>
                            <th>
                                编辑
                            </th>
                            <th>
                                删除
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptList" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%#Eval("id")%>
                                    </td>
                                    <td>
                                        <%#Eval("name")%>
                                    </td>
                                    <td>
                                        <%#Eval("width")%>
                                    </td>
                                    <td>
                                        <%#Eval("height")%>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick="editShow(<%#Eval("id")%>)">编辑</a>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick="del(<%#Eval("id")%>)">删除</a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
                
            </div>
            
        </div>
        
    </div>
    <input id="id" type="hidden" value="<%=id %>" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
<script>
    function showaddpanel() {
        $("#addpanel").attr("class", "col-sm-12");
    }
    function cancleaddpanel() {
        $("#addpanel").attr("class", "col-sm-12 hidden");
    }
    function showEditpanel() {
        $("#editPanel").attr("class", "col-sm-12");
    }
    function cancleEditpanel() {
        $("#editPanel").attr("class", "col-sm-12 hidden");
    }


    function addRole() {
        var apName = $("#ap_name").val();
        var apWidth = $("#ap_width").val();
        var apHeight = $("#ap_height").val();
        var apSummary = $("#ap_summary").val();
        var apTemp = $("#ap_temp").val();
        if (apName == "") {
            layer.msg("请输入广告位名称！");
            return;
        }
        if (apWidth == "") {
            layer.msg("请输入广告位宽度！");
            return;
        }
        if (apHeight == "") {
            layer.msg("请输入广告位高度！");
            return;
        }
        var pars = {apName: apName, apWidth: apWidth, apHeight: apHeight, apSummary: apSummary, apTemp: apTemp };
        ajax("/admin/adv/advPosList.aspx?act=add&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function editShow(id) {
        var pars = { id: id };
        ajax("/admin/adv/advPosList.aspx?act=editshow&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#id_edit").val(id);
                $("#ap_name_edit").val(ret.name);
                $("#ap_width_edit").val(ret.width);
                $("#ap_height_edit").val(ret.height);
                $("#ap_summary_edit").val(ret.summary);
                $("#ap_temp_edit").val(ret.template);
                showEditpanel();
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function editRole() {
        var id = $("#id_edit").val();
        var apName = $("#ap_name_edit").val();
        var apWidth = $("#ap_width_edit").val();
        var apHeight = $("#ap_height_edit").val();
        var apSummary = $("#ap_summary_edit").val();
        var apTemp = $("#ap_temp_edit").val();
        if (apName == "") {
            layer.msg("请输入广告位名称！");
            return;
        }
        if (apWidth == "") {
            layer.msg("请输入广告位宽度！");
            return;
        }
        if (apHeight == "") {
            layer.msg("请输入广告位高度！");
            return;
        }
        var pars = { id: id, apName: apName, apWidth: apWidth, apHeight: apHeight, apSummary: apSummary, apTemp: apTemp };
        ajax("/admin/adv/advPosList.aspx?act=editsubmit&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function del(id) {
        if (confirm('是否删除？')) {
            var pars = { id: id };
            ajax("/admin/adv/advPosList.aspx?act=del&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    location.href = location.href;
                }
                else {
                    layer.msg(ret.msg)
                }
            });
        }
    }
</script>
</asp:Content>

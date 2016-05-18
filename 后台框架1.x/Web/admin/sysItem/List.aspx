<%@ Page Title="sysItem" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.sysItem.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
                   <div id="addpanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    字典添加</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            字典名称：</label>
                        <div class="col-sm-8">
                            <input id="item_name" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            字典路径：</label>
                        <div class="col-sm-8">
                            <input id="item_path" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项1：</label>
                        <div class="col-sm-8">
                            <input id="back1" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项2：</label>
                        <div class="col-sm-8">
                            <input id="back2" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项3：</label>
                        <div class="col-sm-8">
                            <input id="back3" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项4：</label>
                        <div class="col-sm-8">
                            <input id="back4" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            排序：</label>
                        <div class="col-sm-8">
                            <input id="orders" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
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
                    字典编辑</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            字典ID：</label>
                        <div class="col-sm-8">
                            <input id="id_edit" type="text" class="form-control" style="border:0;background-color:#fff" readonly="true">
                        </div>
                    </div>
                   <div class="form-group">
                        <label class="col-sm-3 control-label">
                            字典名称：</label>
                        <div class="col-sm-8">
                            <input id="item_name_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            字典路径：</label>
                        <div class="col-sm-8">
                            <input id="item_path_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项1：</label>
                        <div class="col-sm-8">
                            <input id="back1_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项2：</label>
                        <div class="col-sm-8">
                            <input id="back2_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项3：</label>
                        <div class="col-sm-8">
                            <input id="back3_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            选项4：</label>
                        <div class="col-sm-8">
                            <input id="back4_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            排序：</label>
                        <div class="col-sm-8">
                            <input id="orders_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
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
                    字典管理 <button class="btn btn-warning btn-xs" type="button" onclick="showaddpanel()">添加字典</button></h5>
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
                                字典名称
                            </th>
                            <th>
                                字典路径
                            </th>
                            <th>
                                选项1
                            </th>
                            <th>
                                选项2
                            </th>
                            <th>
                                选项3
                            </th>
                            <th>
                                选项4
                            </th>
                            <th>
                                排序
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
                                        <%#Eval("siId")%>
                                    </td>
                                    <td>
                                        <%#Eval("itemName")%>
                                    </td>
                                    <td>
                                        <%#Eval("itemPath")%>
                                    </td>
                                    <td>
                                        <%#Eval("back1")%>
                                    </td>
                                    <td>
                                        <%#Eval("back2")%>
                                    </td>
                                    <td>
                                        <%#Eval("back3")%>
                                    </td>
                                    <td>
                                        <%#Eval("back4")%>
                                    </td>
                                    <td>
                                        <%#Eval("orders")%>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick="editShow(<%#Eval("siId")%>)">编辑</a>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick="del(<%#Eval("siId")%>)">删除</a>
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
        var itemName = $("#item_name").val();
        var itemPath = $("#item_path").val();
        var back1 = $("#back1").val();
        var back2 = $("#back2").val();
        var back3 = $("#back3").val();
        var back4 = $("#back4").val();
        var orders = $("#orders").val();
        var id = $("#id").val();
        if (itemName == "") {
            layer.msg("请输入字典名称！");
            return;
        }
        var pars = { id: id, itemName: itemName, itemPath: itemPath, back1: back1, back2: back2, back3: back3, back4: back4, orders: orders };
        ajax("/admin/sysItem/List.aspx?act=add&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function editShow(id) {
        var pars = { siId: id };
        ajax("/admin/sysItem/List.aspx?act=editshow&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#id_edit").val(id);
                $("#item_name_edit").val(ret.itemName);
                $("#item_path_edit").val(ret.itemPath);
                $("#back1_edit").val(ret.back1);
                $("#back2_edit").val(ret.back2);
                $("#back3_edit").val(ret.back3);
                $("#back4_edit").val(ret.back4);
                $("#orders_edit").val(ret.orders);
                showEditpanel();
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function editRole() {
        var siId = $("#id_edit").val();
        var itemName = $("#item_name_edit").val();
        var itemPath = $("#item_path_edit").val();
        var back1 = $("#back1_edit").val();
        var back2 = $("#back2_edit").val();
        var back3 = $("#back3_edit").val();
        var back4 = $("#back4_edit").val();
        var orders = $("#orders_edit").val();
        var pars = { siId: siId, itemName: itemName, itemPath: itemPath, back1: back1, back2: back2, back3: back3, back4: back4, orders: orders };
        ajax("/admin/sysItem/List.aspx?act=editsubmit&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function del(catId) {
        if (confirm('是否删除？')) {
            var pars = { catId: catId };
            ajax("/admin/sysItem/List.aspx?act=del&t=" + Math.random(), pars, function (ret) {
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

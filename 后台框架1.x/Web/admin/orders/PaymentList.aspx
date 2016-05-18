<%@ Page Title="订单表" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="PaymentList.aspx.cs" Inherits="hm.Web.orders.PaymentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
.order-goods{float:left;margin-right:5px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="addpanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    支付方式添加</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式名称：</label>
                        <div class="col-sm-8">
                            <input id="name" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式编码：</label>
                        <div class="col-sm-8">
                            <input id="code" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式简介：</label>
                        <div class="col-sm-8">
                            <input id="summary" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            returnUrl：</label>
                        <div class="col-sm-8">
                            <input id="returnUrl" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            notifyUrl：</label>
                        <div class="col-sm-8">
                            <input id="notifyUrl" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            gateUrl：</label>
                        <div class="col-sm-8">
                            <input id="gateUrl" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            项目路径：</label>
                        <div class="col-sm-8">
                            <input id="filePath" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数1：</label>
                        <div class="col-sm-8">
                            <input id="parm1" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数2：</label>
                        <div class="col-sm-8">
                            <input id="parm2" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数3：</label>
                        <div class="col-sm-8">
                            <input id="parm3" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数4：</label>
                        <div class="col-sm-8">
                            <input id="parm4" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数5：</label>
                        <div class="col-sm-8">
                            <input id="parm5" minlength="2" type="text" class="form-control"
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
                    支付方式编辑</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式ID：</label>
                        <div class="col-sm-8">
                            <input id="id_edit" type="text" class="form-control" style="border:0;background-color:#fff" readonly="true">
                        </div>
                    </div>
                   <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式名称：</label>
                        <div class="col-sm-8">
                            <input id="name_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式编码：</label>
                        <div class="col-sm-8">
                            <input id="code_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            支付方式简介：</label>
                        <div class="col-sm-8">
                            <input id="summary_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            returnUrl：</label>
                        <div class="col-sm-8">
                            <input id="returnUrl_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            notifyUrl：</label>
                        <div class="col-sm-8">
                            <input id="notifyUrl_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            gateUrl：</label>
                        <div class="col-sm-8">
                            <input id="gateUrl_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            项目路径：</label>
                        <div class="col-sm-8">
                            <input id="filePath_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数1：</label>
                        <div class="col-sm-8">
                            <input id="parm1_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数2：</label>
                        <div class="col-sm-8">
                            <input id="parm2_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数3：</label>
                        <div class="col-sm-8">
                            <input id="parm3_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数4：</label>
                        <div class="col-sm-8">
                            <input id="parm4_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            参数5：</label>
                        <div class="col-sm-8">
                            <input id="parm5_edit" minlength="2" type="text" class="form-control"
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
                    支付方式管理 <button class="btn btn-warning btn-xs" type="button" onclick="showaddpanel()">添加</button></h5>
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
                            <th>
                                支付方式
                            </th>
                            <th>
                                支付代码
                            </th>
                            <th>
                                简介
                            </th>
                            <th>
                                状态
                            </th>
                            <th>
                                编辑
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
                                        <%#Eval("code")%>
                                    </td>
                                    <td>
                                        <%#Eval("summary")%>
                                    </td>
                                    <td>
                                        <%#Eval("statusString")%>
                                    </td>
                                    <td>
                                        
                                        <a href="javascript:void(0)" onclick='editStatus(<%#Eval("id")%>,<%#Eval("status")%>)'><%#Eval("status").ToString()=="0"?"启用":"停用"%></a>
                                        <a href="javascript:void(0)" onclick="editShow(<%#Eval("id")%>)">编辑</a>
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
        var name = $("#name").val();
        var code = $("#code").val();
        var summary = $("#summary").val();
        var returnUrl = $("#returnUrl").val();
        var notifyUrl = $("#notifyUrl").val();
        var gateUrl = $("#gateUrl").val();
        var filePath = $("#filePath").val();
        var parm1 = $("#parm1").val();
        var parm2 = $("#parm2").val();
        var parm3 = $("#parm3").val();
        var parm4 = $("#parm4").val();
        var parm5 = $("#parm5").val();
        if (name == "") {
            layer.msg("请输入支付方式名称！");
            return;
        }
        var pars = { name: name, code: code, summary: summary, returnUrl: returnUrl, notifyUrl: notifyUrl, gateUrl: gateUrl, filePath: filePath, parm1: parm1, parm2: parm2, parm3: parm3, parm4: parm4, parm5: parm5 };
        ajax("/admin/orders/PaymentList.aspx?act=add&t=" + Math.random(), pars, function (ret) {
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
        ajax("/admin/orders/PaymentList.aspx?act=editshow&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#id_edit").val(id);
                $("#name_edit").val(ret.name);
                $("#code_edit").val(ret.code);
                $("#summary_edit").val(ret.summary);
                $("#returnUrl_edit").val(ret.returnUrl);
                $("#notifyUrl_edit").val(ret.notifyUrl);
                $("#gateUrl_edit").val(ret.gateUrl);
                $("#filePath_edit").val(ret.filePath);
                $("#parm1_edit").val(ret.parm1);
                $("#parm2_edit").val(ret.parm2);
                $("#parm3_edit").val(ret.parm3);
                $("#parm4_edit").val(ret.parm4);
                $("#parm5_edit").val(ret.parm5);
                showEditpanel();
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function editRole() {
        var id = $("#id_edit").val();
        var name = $("#name_edit").val();
        var code = $("#code_edit").val();
        var summary = $("#summary_edit").val();
        var returnUrl = $("#returnUrl_edit").val();
        var notifyUrl = $("#notifyUrl_edit").val();
        var gateUrl = $("#gateUrl_edit").val();
        var filePath = $("#filePath_edit").val();
        var parm1 = $("#parm1_edit").val();
        var parm2 = $("#parm2_edit").val();
        var parm3 = $("#parm3_edit").val();
        var parm4 = $("#parm4_edit").val();
        var parm5 = $("#parm5_edit").val();
        if (name == "") {
            layer.msg("请输入支付方式名称！");
            return;
        }
        var pars = { id: id, name: name, code: code, summary: summary, returnUrl: returnUrl, notifyUrl: notifyUrl, gateUrl: gateUrl, filePath: filePath, parm1: parm1, parm2: parm2, parm3: parm3, parm4: parm4, parm5: parm5 };
        ajax("/admin/orders/PaymentList.aspx?act=editsubmit&t=" + Math.random(), pars, function (ret) {
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
            ajax("/admin/orders/PaymentList.aspx?act=del&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    location.href = location.href;
                }
                else {
                    layer.msg(ret.msg)
                }
            });
        }
    }
    function editStatus(id, status) {
        var str = "启用";
        if (status == "1") {
            str = "停用";
        }
        if (confirm('是否' + str + '？')) {
            var pars = { id: id };
            ajax("/admin/orders/PaymentList.aspx?act=editStatus&t=" + Math.random(), pars, function (ret) {
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

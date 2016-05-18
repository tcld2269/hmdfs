<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.admin.adv.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="/admin/css/plugins/chosen/chosen.css" rel="stylesheet">
<link href="/admin/css/style.min862f.css?v=4.1.0" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="addpanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    广告添加</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                            <label class="col-sm-3 control-label">
                                所属广告位：</label>
                            <div class="col-sm-8">
                                <select id="apId" data-placeholder="选择广告位..." class="chosen-select" style="width: 100%;"
                                    tabindex="2">
                                    <option value="0">请选择上级菜单</option>
                                    <%=advPosthtml %>
                                </select>
                            </div>
                        </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告名称：</label>
                        <div class="col-sm-8">
                            <input id="ad_title" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告链接：</label>
                        <div class="col-sm-8">
                            <input id="ad_url" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告图片：</label>
                        <div class="col-sm-8">
                            <table>
                            <tr>
                            <td><input id="ad_pic" minlength="2" type="file" class="form-control left" style="width:200px;"></td>
                            <td style="width:10px"></td>
                            <td><button type="button" class="btn btn-primary left" onclick="uploadPic('ad_pic')" style="margin-top:4px">上传</button></td>
                            <td style="width:10px"></td>
                            <td id="ad_pic_show"></td>
                            </tr>
                            </table>
                             
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告文字：</label>
                        <div class="col-sm-8">
                            <textarea id="ad_remark" minlength="2" type="text" class="form-control" rows="2"></textarea>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            开始时间：</label>
                        <div class="col-sm-8">
                            <input id="ad_startDate" class="form-control layer-date" placeholder="YYYY-MM-DD hh:mm:ss" onclick="laydate({istime: true, format: 'YYYY-MM-DD hh:mm:ss'})">
                            <label class="laydate-icon"></label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            结束时间：</label>
                        <div class="col-sm-8">
                            <input id="ad_endDate" class="form-control layer-date" placeholder="YYYY-MM-DD hh:mm:ss" onclick="laydate({istime: true, format: 'YYYY-MM-DD hh:mm:ss'})">
                            <label class="laydate-icon"></label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            价格：</label>
                        <div class="col-sm-8">
                            <input id="ad_price" minlength="2" type="text" class="form-control" style="width:240px" value="0"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            排序：</label>
                        <div class="col-sm-8">
                            <input id="ad_orders" minlength="2" type="text" class="form-control" style="width:240px"
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
                    广告编辑</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告ID：</label>
                        <div class="col-sm-8">
                            <input id="id_edit" type="text" class="form-control" style="border:0;background-color:#fff" readonly="true">
                        </div>
                    </div>
                   <div class="form-group">
                            <label class="col-sm-3 control-label">
                                所属广告位：</label>
                            <div class="col-sm-8">
                                <select id="apId_edit" data-placeholder="选择广告位..." class="chosen-select" style="width: 100%;"
                                    tabindex="2">
                                    <option value="0">请选择上级菜单</option>
                                    <%=advPosthtml %>
                                </select>
                            </div>
                        </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告名称：</label>
                        <div class="col-sm-8">
                            <input id="ad_title_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告链接：</label>
                        <div class="col-sm-8">
                            <input id="ad_url_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告图片：</label>
                        <div class="col-sm-8">
                            <table>
                            <tr>
                            <td><input id="ad_pic_edit" minlength="2" type="file" class="form-control left" style="width:200px;"></td>
                            <td style="width:10px"></td>
                            <td><button type="button" class="btn btn-primary left" onclick="uploadPic('ad_pic_edit')" style="margin-top:4px">上传</button></td>
                            <td style="width:10px"></td>
                            <td id="ad_pic_edit_show"></td>
                            </tr>
                            </table>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            广告文字：</label>
                        <div class="col-sm-8">
                            <textarea id="ad_remark_edit" minlength="2" type="text" class="form-control" rows="2"></textarea>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            开始时间：</label>
                        <div class="col-sm-8">
                            <input id="ad_startDate_edit" class="form-control layer-date" placeholder="YYYY-MM-DD hh:mm:ss" onclick="laydate({istime: true, format: 'YYYY-MM-DD hh:mm:ss'})">
                            <label class="laydate-icon"></label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            结束时间：</label>
                        <div class="col-sm-8">
                            <input id="ad_endDate_edit" class="form-control layer-date" placeholder="YYYY-MM-DD hh:mm:ss" onclick="laydate({istime: true, format: 'YYYY-MM-DD hh:mm:ss'})">
                            <label class="laydate-icon"></label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            价格：</label>
                        <div class="col-sm-8">
                            <input id="ad_price_edit" minlength="2" type="text" class="form-control" style="width:240px" value="0"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            排序：</label>
                        <div class="col-sm-8">
                            <input id="ad_orders_edit" minlength="2" type="text" class="form-control" style="width:240px"
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
                    广告管理 <button class="btn btn-warning btn-xs" type="button" onclick="showaddpanel()">添加广告</button></h5>
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
                                广告名称
                            </th>
                            <th>
                                链接
                            </th>
                            <th>
                                图片
                            </th>
                            <th>
                                文字
                            </th>
                            <th>
                                点击次数
                            </th>
                            <th>
                                添加时间
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
                                        <%#Eval("title")%>
                                    </td>
                                    <td>
                                        <%#Eval("url")%>
                                    </td>
                                    <td>
                                        <a target="_blank" href="<%#Eval("pic")%>"><img height="35px" src='<%#Eval("pic")%>' /></a>
                                    </td>
                                    <td>
                                        <%#Eval("remark")%>
                                    </td>
                                    <td>
                                        <%#Eval("clickCount")%>
                                    </td>
                                    <td>
                                        <%#Eval("addTime")%>
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
    <input id="picEdit" type="hidden"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
<script src="/admin/js/plugins/chosen/chosen.jquery.js"></script>
<script src="/admin/js/demo/form-advanced-demo.min.js"></script>
<script src="/admin/js/plugins/layer/laydate/laydate.js"></script>
<script>
    $("#apId_chosen").css("width", "100%");
    $("#apId_edit_chosen").css("width", "100%");
    
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
        var apId = $("#apId").val();
        var adTitle = $("#ad_title").val();
        var adUrl = $("#ad_url").val();
        var adPic = $("#picEdit").val();
        var adRemark = $("#ad_remark").val();
        var adStartDate = $("#ad_startDate").val();
        var adEndDate = $("#ad_endDate").val();
        var adPrice = $("#ad_price").val();
        var adOrders = $("#ad_orders").val();
        if (adTitle == "") {
            layer.msg("请输入广告名称！");
            return;
        }
        if (adUrl == "") {
            layer.msg("请输入广告链接！");
            return;
        }
        if (!$.isNumeric(adPrice)) {
            layer.msg('价格输入错误');
            return false;
        }
        if (!$.isNumeric(adOrders)) {
            layer.msg('排序输入错误');
            return false;
        }
        var pars = { apId: apId, adTitle: adTitle, adUrl: adUrl, adPic: adPic, adRemark: adRemark, adStartDate: adStartDate, adEndDate: adEndDate, adPrice: adPrice, adOrders: adOrders };
        ajax("/admin/adv/List.aspx?act=add&t=" + Math.random(), pars, function (ret) {
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
        ajax("/admin/adv/List.aspx?act=editshow&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#id_edit").val(id);
                $("#apId_edit").val(apId);
                $("#ad_title_edit").val(ret.title);
                $("#ad_url_edit").val(ret.url);
                
                $("#ad_remark_edit").val(ret.remark);
                $("#ad_startDate_edit").val(ret.startDate);
                $("#ad_endDate_edit").val(ret.endDate);
                $("#ad_price_edit").val(ret.price);
                $("#ad_orders_edit").val(ret.orders);

                $("#apId_edit option[value='" + ret.apId + "']").attr("selected", "selected");  
                $("#apId_edit").chosen();
                $("#apId_edit").trigger("chosen:updated");

                $("#ad_pic_edit_show").html("<a target=\"_blank\" href=\"" + ret.pic + "\"><img height=\"35px\" src=\"" + ret.pic + "\" />");
                $("#picEdit").val(ret.pic);

                showEditpanel();
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function editRole() {
        var id = $("#id_edit").val();
        var apId = $("#apId_edit").val();
        var adTitle = $("#ad_title_edit").val();
        var adUrl = $("#ad_url_edit").val();
        var adPic = $("#picEdit").val();
        var adRemark = $("#ad_remark_edit").val();
        var adStartDate = $("#ad_startDate_edit").val();
        var adEndDate = $("#ad_endDate_edit").val();
        var adPrice = $("#ad_price_edit").val();
        var adOrders = $("#ad_orders_edit").val();
        if (adTitle == "") {
            layer.msg("请输入广告名称！");
            return;
        }
        if (adUrl == "") {
            layer.msg("请输入广告链接！");
            return;
        }
        if (!$.isNumeric(adPrice)) {
            layer.msg('价格输入错误');
            return false;
        }
        if (!$.isNumeric(adOrders)) {
            layer.msg('排序输入错误');
            return false;
        }
        var pars = { id:id,apId: apId, adTitle: adTitle, adUrl: adUrl, adPic: adPic, adRemark: adRemark, adStartDate: adStartDate, adEndDate: adEndDate, adPrice: adPrice, adOrders: adOrders };
        ajax("/admin/adv/List.aspx?act=editsubmit&t=" + Math.random(), pars, function (ret) {
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
            ajax("/admin/adv/List.aspx?act=del&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    location.href = location.href;
                }
                else {
                    layer.msg(ret.msg)
                }
            });
        }
    }

    function uploadPic(fl) {
        uploadImage(fl, 'adv', function (ret) {
            $("#" + fl + "_show").html("<a target=\"_blank\" href=\"" + ret.pic + "\"><img height=\"35px\" src=\"" + ret.pic + "\" />");
            $("#picEdit").val(ret.pic);
        })
    }
</script>
</asp:Content>

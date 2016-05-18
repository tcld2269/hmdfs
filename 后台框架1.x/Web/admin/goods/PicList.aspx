<%@ Page Title="商品表" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="PicList.aspx.cs" Inherits="hm.Web.goods.PicList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    商品图片管理 </h5>
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
                                图片
                            </th>
                            <th>
                                录入时间
                            </th>
                            <th>
                                排序
                            </th>
                           <th>
                                默认图片
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
                                        <a target="_blank" href="<%#Eval("picBig")%>"><img height="35px" src='<%#Eval("picSmall")%>' /></a>
                                    </td>
                                    <td>
                                        <%#Eval("addTime")%>
                                    </td>
                                    <td id="orders_<%#Eval("id")%>">
                                        <%#Eval("orders")%>
                                    </td>
                                    <td>
                                        <%#Eval("isDefault").ToString()=="1"?"是":"否"%>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick='editDefault(<%#Eval("id")%>)'>设为默认</a>
                                        <a href="javascript:void(0)" onclick='editOrders(<%#Eval("id")%>,<%#Eval("orders")%>)'>排序</a>
                                        <a href="javascript:void(0)" onclick="del(<%#Eval("id")%>)">删除</a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
                <button class="btn btn-warning" type="button" onclick="openPic()">上传图片</button>
                <button class="btn btn-default" type="button" onclick="history.back()">返回</button>
            </div>
            
        </div>
        
    </div>
    <input id="goodsId" type="hidden" value="<%=goodsId %>" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
<script>
    function openPic() {
        var addHtml = "";
        layer.open({
            type: 1,
            title: '上传图片',
            skin: 'layui-layer-rim', //加上边框
            area: ['420px', '120px'], //宽高
            content: "<center><table style='margin-top:15px'><tr><td><input id=\"goods\" type=\"file\" class=\"form-control\" style=\"width: 200px;\"></td><td style=\"width:10px\"></td><td><button type=\"button\" class=\"btn btn-primary\" onclick=\"uploadPic('goods')\">上传</button></td></tr></table></center>"
        });
    }
    
    function uploadPic(fl) {
        uploadImage(fl, 'goods', function (ret) {
            addPic(ret.pic);
        })
    }
    function addPic(pic) {
        var goodsId = $("#goodsId").val();
        var pars = { goodsId: goodsId, pic: pic };
        ajax("/admin/goods/PicList.aspx?act=addPic&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg('上传失败！');
            }
        });
    }
    function editOrders(id,orderstr) {
        layer.prompt({
            title: '请输入排序号',
            value:orderstr,
            formType: 0
        }, function (data) {
            var pars = { id: id,orders:data };
            ajax("/admin/goods/PicList.aspx?act=editOrders&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    $("#orders_" + id).html(data);
                    layer.msg('修改成功！');
                }
                else {
                    layer.msg('修改失败！');
                }
            });
            
        });
    }
    function editDefault(id) {
        if (confirm('是否设为默认图片？')) {
            var pars = { id: id };
            ajax("/admin/goods/PicList.aspx?act=editDefault&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    location.href = location.href;
                }
                else {
                    layer.msg(ret.msg)
                }
            });
        }
    }
    function del(id) {
        if (confirm('是否删除？')) {
            var pars = { id: id };
            ajax("/admin/goods/PicList.aspx?act=del&t=" + Math.random(), pars, function (ret) {
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

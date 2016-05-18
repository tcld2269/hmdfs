<%@ Page Title="订单表" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.orders.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
.order-goods{float:left;margin-right:5px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    订单管理 </h5>
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
                                订单号
                            </th>
                            <th>
                                商品
                            </th>
                            <th>
                                买家
                            </th>
                            <th>
                                商家
                            </th>
                            <th>
                                订单金额
                            </th>
                            <th>
                                下单时间
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
                                        <%#Eval("orderNo")%>
                                    </td>
                                    <td>
                                        <%#Eval("goodsHtml")%>
                                    </td>
                                    <td>
                                        <%#Eval("buyerName")%>
                                    </td>
                                    <td>
                                        <%#Eval("storeName")%>
                                    </td>
                                    <td>
                                        <%#Eval("orderPrice")%>
                                    </td>
                                    <td>
                                        <%#Eval("addTime")%>
                                    </td>
                                    <td>
                                        <%#Eval("statusString")%>
                                    </td>
                                    <td>
                                        <a href="PicList.aspx?id=<%#Eval("id")%>&backurl=adminlist">图片</a>
                                        <a href="goodsStands.aspx?id=<%#Eval("id")%>&backurl=adminlist">规格</a>
                                        <a href="javascript:void(0)" onclick='editOrders(<%#Eval("id")%>,<%#Eval("orders")%>)'>排序</a>
                                        <a href="Modify.aspx?id=<%#Eval("id")%>&backurl=adminlist">编辑</a>
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
    function editOrders(id,orderstr) {
        layer.prompt({
            title: '请输入排序号',
            value:orderstr,
            formType: 0
        }, function (data) {
            var pars = { id: id,orders:data };
            ajax("/admin/goods/List.aspx?act=editOrders&t=" + Math.random(), pars, function (ret) {
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
    function del(id) {
        if (confirm('是否删除？')) {
            var pars = { id: id };
            ajax("/admin/goods/List.aspx?act=del&t=" + Math.random(), pars, function (ret) {
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

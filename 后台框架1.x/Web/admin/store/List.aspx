<%@ Page Title="新闻表" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.store.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    店铺管理 </h5>
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
                                店铺名称
                            </th>
                            <th>
                                电话
                            </th>
                            <th>
                                录入时间
                            </th>
                            <th>
                                状态
                            </th>
                            <th>
                                操作
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
                                        <%#Eval("storeName")%>
                                    </td>
                                    <td>
                                        <%#Eval("tel")%>
                                    </td>
                                    <td>
                                        <%#Eval("addTime")%>
                                    </td>
                                    <td>
                                        <%#Eval("statusString")%>
                                    </td>
                                    <td>
                                        <a href="ModifyBanner.aspx?id=<%#Eval("id")%>">幻灯片</a>
                                        <a href="Modify.aspx?id=<%#Eval("id")%>">编辑</a>
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
    function del(id) {
        if (confirm('是否删除？')) {
            var pars = { id: id };
            ajax("/admin/store/List.aspx?act=del&t=" + Math.random(), pars, function (ret) {
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

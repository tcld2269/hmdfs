<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminList.aspx.cs" Inherits="hm.Web.admin.users.AdminList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    管理员管理 <button class="btn btn-warning btn-xs" type="button" onclick="location.href='AddAdmin.aspx'">添加管理员</button></h5>
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
                                用户名
                            </th>
                            <th>
                                部门名称
                            </th>
                            <th>
                                角色
                            </th>
                            <th>
                                注册时间
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
                                        <%#Eval("userId")%>
                                    </td>
                                    <td>
                                        <%#Eval("userName")%>
                                    </td>
                                    <td>
                                        <%#Eval("deptName")%>
                                    </td>
                                    <td>
                                        <%#Eval("roleName")%>
                                    </td>
                                    <td>
                                        <%#Eval("addTime")%>
                                    </td>
                                    <td>
                                        <%#Eval("status").ToString()=="1"?"正常":"冻结"%>
                                    </td>
                                    <td>
                                        <a href="Modify.aspx?id=<%#Eval("userId")%>&backurl=adminlist">编辑</a>
                                        <a href="javascript:void(0)" onclick="del(<%#Eval("userId")%>)">删除</a>
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
    function del(userId) {
        if (confirm('是否删除？')) {
            var pars = { userId: userId };
            ajax("/admin/users/AdminList.aspx?act=del&t=" + Math.random(), pars, function (ret) {
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

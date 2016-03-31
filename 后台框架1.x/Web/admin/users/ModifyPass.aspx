<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="ModifyPass.aspx.cs" Inherits="hm.Web.users.ModifyPass" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
修改密码
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		原密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width="150px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		新密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtNewPass" TextMode="Password" runat="server" Width="150px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		重新输入新密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtReNewPass" TextMode="Password" runat="server" Width="150px"></asp:TextBox>
	</td></tr>
    <tr>
    <td colspan="2">
    <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="right-button09"></asp:Button>
<input name="btnFanhui" type="button" class="right-button09" value="返回" onclick="history.go(-1)" />
    </td>
    </tr>
    </table>

            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>


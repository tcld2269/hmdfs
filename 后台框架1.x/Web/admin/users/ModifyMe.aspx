<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="ModifyMe.aspx.cs" Inherits="hm.Web.users.ModifyMe" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
个人信息

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		用户ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lbluserId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		真实姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTrueName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所在系
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrDept" runat="server" Enabled="false"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属角色
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrRole" runat="server" Enabled="false"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Value="1" Selected="True">男</asp:ListItem>
        <asp:ListItem Value="0">女</asp:ListItem>
        </asp:RadioButtonList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtemail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		qq
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtqq" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		状态
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrStatus" runat="server" Enabled="false"></asp:DropDownList>
	</td></tr>
    <tr>
	<td height="25" colspan="2">
	
		<asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="right-button09"></asp:Button>
<input name="btnFanhui" type="button" class="right-button09" value="返回" onclick="history.go(-1)" />
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>


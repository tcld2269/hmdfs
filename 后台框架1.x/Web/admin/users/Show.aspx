<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="hm.Web.users.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
查看信息
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
		<asp:Label id="lbluserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登陆名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpassword" runat="server"></asp:Label>
	</td></tr>
		<tr>
	<td height="25" width="30%" align="right">
		真实姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTrueName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所在小区
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldeptName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属角色
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroleName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		qq
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblqq" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		注册时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后登录时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllastLoginTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		状态
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatus" runat="server"></asp:Label>
	</td></tr>
</table>

					</td>
				</tr>
			</table>
			<center><input name="btnFanhui" type="button" class="right-button09" value="返回" onclick="history.go(-1)" /></center>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





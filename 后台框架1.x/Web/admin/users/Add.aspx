<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true"
	CodeBehind="Add.aspx.cs" Inherits="hm.Web.users.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
添加用户
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
	<table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
		<tr>
			<td class="tdbg">
				
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		登录名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassword" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
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
		所属部门
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrPlace" runat="server"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属角色
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrRole" runat="server"></asp:DropDownList>
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
		手机
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
		<asp:DropDownList ID="ddrStatus" runat="server">
		<asp:ListItem Value="0">冻结</asp:ListItem>
		<asp:ListItem Value="1" Selected="True">正常</asp:ListItem>
		</asp:DropDownList>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

			</td>
		</tr>
		<tr>
		<th align="center"><asp:Button ID="btnSave" runat="server" Text="保存" 
					OnClick="btnSave_Click" class="right-button09"></asp:Button>
				<asp:Button ID="btnCancle" runat="server" Text="取消"
					OnClick="btnCancle_Click" class="right-button09" ></asp:Button></th>
		</tr>
	</table>
	<br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

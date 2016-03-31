<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true"
	CodeBehind="Add.aspx.cs" Inherits="hm.Web.role.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
添加角色
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
	<table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
		<tr>
			<td class="tdbg">
				
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		角色名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroleName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

			</td>
		</tr>
		<tr><th align="cneter"><asp:Button ID="btnSave" runat="server" Text="保存" 
					OnClick="btnSave_Click" class="right-button09"></asp:Button>
				<asp:Button ID="btnCancle" runat="server" Text="取消"
					OnClick="btnCancle_Click" class="right-button09" ></asp:Button></th></tr>
	</table>
	<br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="hm.Web.role.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
编辑角色
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		角色ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblroleId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		角色名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroleName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
    <td colspan="2" align="center">
    <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="right-button09"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="right-button09"></asp:Button>
    </td>
    </tr>
</table>

            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>


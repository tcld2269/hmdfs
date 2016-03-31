<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="hm.Web.news.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		录入人
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserName" runat="server"></asp:Label>
	</td></tr>
	
	<tr>
	<td height="25" width="30%" align="right">
		标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsTitle" runat="server"></asp:Label>
	</td></tr>
	
	<tr>
	<td height="25" width="30%" align="right">
		新闻内容
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsContent" runat="server"></asp:Label>
	</td></tr>
	
	<tr>
	<td height="25" width="30%" align="right">
		添加时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		修改时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmodifyTime" runat="server"></asp:Label>
	</td></tr>
	
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





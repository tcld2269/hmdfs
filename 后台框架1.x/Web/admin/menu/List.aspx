<%@ Page Title="menu" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.menu.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
菜单列表
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                <td width="21"><img src="../images/ico07.gif" width="20" height="18" /></td>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>上级菜单：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:DropDownList ID="ddrMenuAdd" runat="server"></asp:DropDownList>   
                    菜单名称：
                    <asp:TextBox ID="txtMenuNameAdd" runat="server"></asp:TextBox>
                    排序：
                    <asp:TextBox ID="txtOrderAdd" runat="server" Width="20px" Text="1"></asp:TextBox>
                    路径：
                    <asp:TextBox ID="txtUrlAdd" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Button ID="Button1" CssClass="right-button02" runat="server" Text="添加菜单"  OnClick="btnAdd_Click" >
                    </asp:Button>   
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="list" runat="server">
<div style="float:left;width:50%">
<asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" ShowLines="True" 
        onselectednodechanged="TreeView1_SelectedNodeChanged" >
    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
        HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
    <ParentNodeStyle Font-Bold="False" />
    <SelectedNodeStyle Font-Bold="True" />
    </asp:TreeView>
</div>
<div style="float:left;width:50%">
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
<tr>
	<td height="25" width="100%" colspan="2" align="center">
		修改菜单
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblpId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上级菜单
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrParent" runat="server"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		菜单名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMenuName" runat="server" Width="200px" MaxLength="50"></asp:TextBox><span class="red">* </span>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		排序
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrder" runat="server" Width="200px" MaxLength="50"></asp:TextBox><span class="red">* </span>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		路径
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUrl" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="100%" colspan="2" align="center">
		<asp:Button ID="btnMod" runat="server" Text="修改" OnClick="btnMod_Click" /> <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click" OnClientClick="return confirm('确定删除？')" />
	</td></tr>
</table>
</div>
            
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

<%@ Page Title="仓库" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.place.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
    
部门列表
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>上级部门：</b>
                    </td>
                    <td class="tdbg">  
                    <asp:DropDownList ID="ddrDept" runat="server"></asp:DropDownList>    
                    <b>部门名称：</b>                 
                    <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAdd" runat="server" Text="添加部门"  OnClick="btnAdd_Click" >
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
		修改部门
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
		上级部门
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrParent" runat="server"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部门名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDeptName" runat="server" Width="200px" MaxLength="50"></asp:TextBox><span class="red">* </span>
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

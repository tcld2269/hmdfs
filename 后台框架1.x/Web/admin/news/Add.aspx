<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="hm.Web.news.Add" Title="增加页" ValidateRequest="false"  %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
添加
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
<tr>
	<td height="25" width="30%" align="right">
		所属分类
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrCat" runat="server"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnewsTitle" runat="server" Width="400px"></asp:TextBox>
	</td></tr>
	
	<tr>
	<td height="25" width="30%" align="right">
		新闻内容
	：</td>
	<td height="25" width="*" align="left">
        <CKEditor:CKEditorControl ID="txtContent" runat="server" Height="300px"></CKEditor:CKEditorControl>
	</td></tr>
	<%--<tr>
	<td height="25" width="30%" align="right">
		来源
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcontentSource" runat="server" Width="200px"></asp:TextBox>
	</td></tr>--%>
	
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <input type="button" value="取消" onclick="history.go(-1)" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

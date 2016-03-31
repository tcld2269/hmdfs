<%@ Page Title="users" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.users.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
管理员列表
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
				<tr>
				<td width="21"><img src="../images/ico07.gif" width="20" height="18" /></td>
					<td style="width: 80px" align="right" class="tdbg">
						 <b>用户名：</b>
					</td>
					<td class="tdbg">                       
					<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
					&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button ID="Button1" CssClass="right-button02" runat="server" Text="查询"  OnClick="btnSearch_Click" >
					</asp:Button>   
					<input type="button" class="right-button02" onclick="location.href='addAdmin.aspx'" value="添加" />
					</td>
					<td class="tdbg">
					</td>
				</tr>
                <tr>
                <td colspan="4">
                <asp:RadioButtonList ID="rblOrg" runat="server" RepeatDirection="Horizontal" 
                        AutoPostBack="true" onselectedindexchanged="rblOrg_SelectedIndexChanged"></asp:RadioButtonList>
                </td>
                </tr>
			</table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="list" runat="server">
		   <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" 
					CellPadding="4"  OnPageIndexChanging ="gridView_PageIndexChanging"
					BorderWidth="1px" DataKeyNames="userId" OnRowDataBound="gridView_RowDataBound"
					AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" 
					OnRowCreated="gridView_OnRowCreated" BackColor="White" BorderColor="#DEDFDE" 
					BorderStyle="None" ForeColor="Black" GridLines="Vertical" >
					<AlternatingRowStyle BackColor="White" />
					<Columns>
					<asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
								<ItemTemplate>
									<asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
								</ItemTemplate>
							</asp:TemplateField> 
							
		<asp:BoundField DataField="userName" HeaderText="用户名" SortExpression="userName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="deptName" HeaderText="部门名称" SortExpression="deptName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="roleName" HeaderText="角色" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="addTime" HeaderText="注册时间" SortExpression="addTime" ItemStyle-HorizontalAlign="Center"  DataFormatString="{0:yyyy-MM-dd}" /> 
		<asp:BoundField DataField="statusString" HeaderText="状态" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
							<asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="userId" DataNavigateUrlFormatString="Show.aspx?id={0}"
								Text="详细"  />
							<asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="userId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
								Text="编辑"  />
							<asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
								<ItemTemplate>
									<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
										 Text="删除"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateField>
						</Columns>
						 <FooterStyle BackColor="#CCCC99" />
					<HeaderStyle BackColor="#e1e5ee" Font-Bold="True" ForeColor="#666666" Font-Size="14px" CssClass="nowtable" />
					<PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />

<RowStyle HorizontalAlign="Center" BackColor="#f2f2f2" Font-Size="12px"></RowStyle>
					<SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
					<SortedAscendingCellStyle BackColor="#FBFBF2" />
					<SortedAscendingHeaderStyle BackColor="#848384" />
					<SortedDescendingCellStyle BackColor="#EAEAD3" />
					<SortedDescendingHeaderStyle BackColor="#575357" />
				</asp:GridView>
			   <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
				<tr>
					<td style="width: 1px;">                        
					</td>
					<td align="left">
						<asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
					</td>
				</tr>
			</table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

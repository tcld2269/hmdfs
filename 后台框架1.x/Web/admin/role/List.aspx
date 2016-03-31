<%@ Page Title="role" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.role.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
角色设置
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
				<tr>
				<td width="21"><img src="../images/ico07.gif" width="20" height="18" /></td>
					<td style="width: 80px" align="right" class="tdbg">
						 <b>关键字：</b>
					</td>
					<td class="tdbg">                       
					<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
					&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button ID="Button1" CssClass="right-button02" runat="server" Text="查询"  OnClick="btnSearch_Click" >
					</asp:Button>                    
					<input type="button" class="right-button03" onclick="location.href='add.aspx'" value="添加角色" />
					</td>
					<td class="tdbg">
					</td>
				</tr>
			</table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="list" runat="server">
			<br />
			<asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" 
					CellPadding="4"  OnPageIndexChanging ="gridView_PageIndexChanging"
					BorderWidth="1px" DataKeyNames="roleId" OnRowDataBound="gridView_RowDataBound"
					AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" 
					OnRowCreated="gridView_OnRowCreated" BackColor="White" BorderColor="#DEDFDE" 
					BorderStyle="None" ForeColor="Black" GridLines="Vertical" 
                onrowdeleting="gridView_RowDeleting">
					<Columns>
		<asp:BoundField DataField="roleName" HeaderText="角色名称" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
							<asp:HyperLinkField HeaderText="菜单权限" ControlStyle-Width="50" DataNavigateUrlFields="roleId" DataNavigateUrlFormatString="RoleMenuEdit.aspx?roleId={0}"
								Text="编辑"  />
							<asp:HyperLinkField HeaderText="修改" ControlStyle-Width="50" DataNavigateUrlFields="roleId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
								Text="修改"  />
							<asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="true"  >
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

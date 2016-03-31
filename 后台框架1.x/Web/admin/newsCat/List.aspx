<%@ Page Title="newsCat" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.newsCat.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
列表
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="search" runat="server">

            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        <input type="button" class="right-button03" onclick="location.href='add.aspx'" value="添加根分类" />
                    <asp:Button ID="Button2" CssClass="right-button03" runat="server" Text="返回到根分类"  OnClick="btnBack_Click" >
                    </asp:Button>
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="list" runat="server">
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" 
                    CellPadding="4"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="catId" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" 
                    OnRowCreated="gridView_OnRowCreated" BackColor="White" BorderColor="#DEDFDE" 
                    BorderStyle="None" ForeColor="Black" GridLines="Vertical" OnRowDeleting="gridView_RowDeleting" onrowcommand="gridView_RowCommand">
<AlternatingRowStyle BackColor="White" />
                    <Columns>
                             
		<asp:BoundField DataField="catName" HeaderText="分类名称" SortExpression="catName" ItemStyle-HorizontalAlign="Center"  /> 
		
		<asp:TemplateField ControlStyle-Width="50" HeaderText="展开"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbExpand" runat="server" CausesValidation="False" CommandName="expand" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"catId") %>'
                                         Text="展开"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:HyperLinkField HeaderText="添加下级菜单" ControlStyle-Width="50" DataNavigateUrlFields="catId,type" DataNavigateUrlFormatString="Add.aspx?id={0}&type={1}"
                                Text="添加"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="catId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="true"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                        无下级菜单
                        </EmptyDataTemplate>
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

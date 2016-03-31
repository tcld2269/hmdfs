<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="RoleMenuEdit.aspx.cs" Inherits="hm.Web.role.RoleMenuEdit" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function checkAll(id) {
            var ids = id + ",";
            var list = document.getElementsByName('menu' + id);
            if (document.getElementById('checkMenu' + id).checked == true) {
                for (var i = 0; i < list.length; i++) {
                    list[i].checked = true;
                    ids += list[i].value + ",";
                }
            }
            else {
                for (var i = 0; i < list.length; i++) {
                    list[i].checked = false;
                    ids = id + ",";
                }
            }
            getIds();
        }
        function checkParent(id) {
            document.getElementById('checkMenu' + id).checked = true;
            getIds()
        }
        function submitUrl() {
            getIds();
            var ids = document.getElementById('txtIds').value;
            document.location.href = "saveRoleMenu.aspx?roleId="+document.getElementById("roleId").value+"&ids=" + ids;
        }
        function getIds() {
            var ids = "";
            var menuParentIds = document.getElementById('menuIds').value.split(',');
            for (var t = 0; t < menuParentIds.length; t++) {
                var list = document.getElementsByName('menu' + menuParentIds[t]);
                if (document.getElementById('checkMenu' + menuParentIds[t]).checked) {
                    ids += menuParentIds[t] + ",";
                }
                for (var y = 0; y < list.length; y++) {
                    if (list[y].checked) {
                        ids += list[y].value + ",";
                    }
                }

            }
            document.getElementById('txtIds').value = ids;
        }
</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
菜单权限
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  

    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg" style="vertical-align:top">
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
<asp:Literal ID="litMenu" runat="server"></asp:Literal>
</table>

            </td>
        </tr>
        <tr>
        <td colspan="2">
        <input type="button" value="保存" class="right-button09" onclick="submitUrl()" />
                <input name="btnFanhui" type="button" class="right-button09" value="返回" onclick="history.go(-1)" />
        </td>
        </tr>
    </table>
    <input type="hidden" id="txtIds" style="width:400px"  />
<asp:Literal id="litMenuIds" runat="server"></asp:Literal>
<asp:Literal id="litRoleId" runat="server"></asp:Literal>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>


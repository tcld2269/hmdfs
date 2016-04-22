<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="RoleMenuEdit.aspx.cs" Inherits="hm.Web.admin.role.RoleMenuEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="/admin/css/bootstrap.min14ed.css?v=3.3.6" rel="stylesheet">
    <link href="/admin/css/plugins/dataTables/dataTables.bootstrap.css" rel="stylesheet">
    <link href="/admin/css/animate.min.css" rel="stylesheet">
    <link href="/admin/css/style.min862f.css?v=4.1.0" rel="stylesheet">
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
            document.location.href = "saveRoleMenu.aspx?roleId=" + document.getElementById("roleId").value + "&ids=" + ids;
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
    <style>
    .show-table tr td{padding:5px}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div id="addpanel" class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    权限配置</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
               <table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
        <asp:Literal ID="litMenu" runat="server"></asp:Literal>
    </table>
    <input type="button" value="保存" class="btn btn-warning" onclick="submitUrl()" />
    <input name="btnFanhui" type="button" class="btn btn-default" value="返回" onclick="history.go(-1)" />
            </div>
        </div>
    </div>

    
    
    <input type="hidden" id="txtIds" style="width: 400px" />
    <asp:Literal ID="litMenuIds" runat="server"></asp:Literal>
    <asp:Literal ID="litRoleId" runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
</asp:Content>

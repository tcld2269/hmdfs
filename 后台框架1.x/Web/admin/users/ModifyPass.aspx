<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ModifyPass.aspx.cs" Inherits="hm.Web.users.ModifyPass" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">    
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    修改密码</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            原密码：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            新密码：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtNewPass" TextMode="Password" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            重复输入新密码：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtReNewPass" TextMode="Password" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <asp:Button ID="btnSave" runat="server" Text="保存" 
					OnClick="btnSave_Click" CssClass="btn btn-warning"></asp:Button>
                            <button id="Button2" class="btn btn-default" type="button" onclick="history.back()">
                                取消</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="foot" runat="server">
<script src="/admin/js/plugins/chosen/chosen.jquery.js"></script>
<script src="/admin/js/demo/form-advanced-demo.min.js"></script>
</asp:Content>


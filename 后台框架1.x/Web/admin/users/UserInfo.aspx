<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="hm.Web.admin.users.UserInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
.lbl{line-height:30px}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div class="row">
        <div class="col-sm-12">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <h5>
                        个人信息修改</h5>
                    <div class="ibox-tools">
                        <a class="collapse-link"><i class="fa fa-chevron-up"></i></a><a class="dropdown-toggle"
                            data-toggle="dropdown" href="form_editors.html#"></a>
                    </div>
                </div>
                <div class="ibox-content">
                    <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            登录名：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            密码：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox> （不填则不修改）
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            真实姓名：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtTruename" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            昵称：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtNickname" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            电话：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtTel" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            Email：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            QQ：</label>
                        <div class="col-sm-8">
                           <asp:TextBox ID="txtQQ" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            账户余额：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblAccount" runat="server" CssClass="lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            积分：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblScore" runat="server" CssClass="lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            状态：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblStatus" runat="server" CssClass="lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                             <asp:Button ID="btnSave" runat="server" Text="保存" CssClass="btn btn-warning" 
                                onclick="btnSave_Click" />
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
</asp:Content>

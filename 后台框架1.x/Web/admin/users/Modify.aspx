<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="hm.Web.users.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="/admin/css/plugins/chosen/chosen.css" rel="stylesheet">
<link href="/admin/css/style.min862f.css?v=4.1.0" rel="stylesheet">
<style>
.zdy-radio tr td{padding:0 10px}
.form-control-static{line-height:34px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">    
	<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    编辑用户信息</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            用户ID：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lbluserId" runat="server" CssClass="form-control-static"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            登录名：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtuserName" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            密码：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtpassword" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            真实姓名：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtTrueName" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            所属部门：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddrPlace" runat="server" CssClass="chosen-select" Width="200px"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            所属角色：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddrRole" runat="server" CssClass="chosen-select" Width="200px"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            性别：</label>
                        <div class="col-sm-8">
                            <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal" CssClass="zdy-radio">
		<asp:ListItem Value="1" Selected="True">男</asp:ListItem>
		<asp:ListItem Value="0">女</asp:ListItem>
		</asp:RadioButtonList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            手机：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txttel" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            Email：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtemail" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            QQ：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtqq" runat="server" Width="200px" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            状态：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddrStatus" runat="server" CssClass="chosen-select" Width="200px">
                            <asp:ListItem Value="0">冻结</asp:ListItem>
                            <asp:ListItem Value="1">正常</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <asp:Button ID="btnSave" runat="server" Text="保存" 
					OnClick="btnSave_Click" CssClass="btn btn-warning"></asp:Button>
                            <button id="Button1" class="btn btn-default" type="button" onclick="history.back()">
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
<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="siteConfig.aspx.cs" Inherits="hm.Web.admin.common.siteConfig" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
.fl{width:250px;float:left}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    站点设置</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            站点名称：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            Logo：</label>
                        <div class="col-sm-8">
                            <asp:FileUpload ID="flLogo" runat="server" CssClass="form-control fl" />
                            <asp:Literal ID="litLogo" runat="server"></asp:Literal>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            网站地址：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtUrl" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            SEO标题：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            SEO关键字：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtKeywords" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            SEO描述：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtDes" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            copyright：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtCopyright" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            联系人：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtContact" runat="server" CssClass="form-control"></asp:TextBox>
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
                            联系电话：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            传真：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtFax" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            联系地址：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            备案号：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtIcp" runat="server" CssClass="form-control"></asp:TextBox>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
</asp:Content>

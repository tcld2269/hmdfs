<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="VerifyShow.aspx.cs" Inherits="hm.Web.store.VerifyShow" Title="增加页" ValidateRequest="false" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .fl
        {
            width: 250px;
            float: left;
        }
        .sel-ads
        {
            min-width: 80px !important;
            max-width: 30% !important;
            float: left !important;
            margin-right: 5px !important;
        }
        .lbl
        {
            border:0!important;
        }
        .cardPic{height:35px}
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    审核店铺</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            企业名称：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtStoreName" runat="server" CssClass="form-control lbl" ></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            企业类型：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblType" runat="server" CssClass="form-control lbl" ></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            所属区域：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblAddressNo" runat="server" CssClass="form-control lbl" ></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            详细地址：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtAddress" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            主营：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtSale" runat="server" CssClass="form-control lbl" required="" aria-required="true"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            Logo：</label>
                        <div class="col-sm-8">
                            <asp:Image ID="imgLog" runat="server" Height="35px" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            保证金：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtCashPrice" runat="server" CssClass="form-control lbl" Text="0"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            联系人：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtContact" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            QQ：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtQQ" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            电话：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="txtTel" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            详细介绍：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblContent" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                     <div class="form-group">
                        <label class="col-sm-3 control-label">
                            证件号：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblIdcard" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                     <div class="form-group">
                        <label class="col-sm-3 control-label">
                            证件照：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblImg" runat="server" CssClass="form-control lbl"></asp:Label>
                        </div>
                    </div>
                     <div class="form-group">
                        <label class="col-sm-3 control-label">
                            反馈信息：</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtFeedBack" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <asp:Button ID="btnSave" runat="server" Text="通过" OnClientClick="return check()"
                                OnClick="btnSave_Click" class="inputbutton" CssClass="btn btn-warning"></asp:Button>
                            <asp:Button ID="Button1" runat="server" Text="驳回" OnClientClick="return check()"
                                OnClick="btnBack_Click" class="inputbutton" CssClass="btn btn-primary"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <input id="addressVal" name="addressVal" type="hidden" value="0" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="foot" runat="server">
    <script>
    function check() {
        

    }
   
    </script>
</asp:Content>

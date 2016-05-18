<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="MessageShow.aspx.cs" Inherits="hm.Web.common.MessageShow" Title="显示页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .lbl
        {
            line-height: 30px;
        }
        .form-control
        {
            border: 0 !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <h5>
                        消息详情</h5>
                    <div class="ibox-tools">
                        <a class="collapse-link"><i class="fa fa-chevron-up"></i></a><a class="dropdown-toggle"
                            data-toggle="dropdown" href="form_editors.html#"></a>
                    </div>
                </div>
                <div class="ibox-content">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                消息ID：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblId" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                消息标题：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblTitle" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                发送者：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblSender" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                接收者：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblReceiver" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                消息类型：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblType" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                发送时间：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblAddTime" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                消息详情：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblRemark" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                状态：</label>
                            <div class="col-sm-8">
                                <asp:Label ID="lblStatus" runat="server" CssClass="form-control"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                </label>
                            <div class="col-sm-8">
                            <input type="button" class="btn btn-primary" value="返回" onclick="history.back()" />
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

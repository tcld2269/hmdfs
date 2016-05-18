<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="hm.Web.news.Add" Title="增加页" ValidateRequest="false"  %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    添加新闻</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            所属分类：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddrCat" runat="server" CssClass="form-control"></asp:DropDownList>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            标题：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtnewsTitle" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            新闻内容：</label>
                        <div class="col-sm-8">
                            <CKEditor:CKEditorControl ID="txtContent" runat="server" Height="300px"></CKEditor:CKEditorControl>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" CssClass="btn btn-warning"></asp:Button>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="foot" runat="server">
</asp:Content>
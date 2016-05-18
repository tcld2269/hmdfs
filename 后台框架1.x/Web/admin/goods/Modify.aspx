<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="Modify.aspx.cs" Inherits="hm.Web.goods.Modify" Title="增加页" ValidateRequest="false"  %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" charset="utf-8" src="/ueditor/ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="/ueditor/ueditor.all.js"> </script>
    <script type="text/javascript" charset="utf-8" src="/ueditor/ueditor.all.min.js"> </script>
    <style>
    .form-control label{margin-right: 10px;}
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    修改商品</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品ID：</label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblId" runat="server" CssClass="form-control"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品名称：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtTitle" runat="server" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品编号：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtSn" runat="server" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            所属分类：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddrCat" runat="server" CssClass="form-control"></asp:DropDownList>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            市场价格：</label>
                        <div class="col-sm-8">
                        <asp:TextBox id="txtMarketPrice" runat="server" CssClass="form-control" Width="200px" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商城价格：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtStorePrice" runat="server" CssClass="form-control" Width="200px" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            运费：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtFreightPrice" runat="server" CssClass="form-control" Width="200px" required="" aria-required="true" Text="0"></asp:TextBox>
                        </div>
                    </div>
                     <div class="form-group">
                        <label class="col-sm-3 control-label">
                            积分购买：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtBuyScore" runat="server" CssClass="form-control" Width="200px" required="" aria-required="true" Text="0"></asp:TextBox>购买此商品所需积分，填0为不允许积分购买
                        </div>
                    </div>
                     <%--<div class="form-group">
                        <label class="col-sm-3 control-label">
                            赠送积分：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtGiveScore" runat="server" CssClass="form-control" Width="200px" required="" aria-required="true" Text="0"></asp:TextBox>
                        </div>
                    </div>--%>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            库存：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtStock" runat="server" CssClass="form-control" Width="200px" required="" aria-required="true" Text="1"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品图片：</label>
                        <div class="col-sm-8">
                            <table>
                            <tr>
                            <td><asp:FileUpload ID="flPic" runat="server"  CssClass="form-control" Width="300px"/></td>
                            <td style="width:10px"></td>
                            <td><asp:Literal ID="litPicShow" runat="server"></asp:Literal></td>
                            </tr>
                            </table>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品简介：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtSummary" runat="server" CssClass="form-control" TextMode="MultiLine" Height="80px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品内容：</label>
                        <div class="col-sm-8">
                            <script id="editor" type="text/plain" style="width:100%;height:200px;"><%=remark %></script>

                                 <script type="text/javascript">
                                     var ue = UE.getEditor('editor');
                                     
                                 </script>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商品属性：</label>
                        <div class="col-sm-8">
                            <asp:CheckBoxList ID="cbl" runat="server" RepeatDirection="Horizontal" CssClass="form-control">
                            <asp:ListItem Value="show" Text="显示" Enabled="true"></asp:ListItem>
                            <asp:ListItem Value="new" Text="新品"></asp:ListItem>
                            <asp:ListItem Value="recommend" Text="推荐"></asp:ListItem>
                            <asp:ListItem Value="hot" Text="热销"></asp:ListItem>
                            </asp:CheckBoxList>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <asp:Button ID="btnSave" runat="server" Text="保存" OnClientClick="return check()"
                    OnClick="btnSave_Click" CssClass="btn btn-warning"></asp:Button>
                            <input type="button" class="btn btn-default" value="返回" onclick="history.back()" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <input type="hidden" id="content" runat="server" />
    <asp:Label ID="lblPicSmall" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lblPicNormal" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lblPicBig" runat="server" Visible="false"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="foot" runat="server">
<script>

    function check() {
        $("#ctl00_content_content").val(UE.getEditor('editor').getContent());
        var cat = $("#ctl00_content_ddrCat").val();
        var marketPrice = $("#ctl00_content_txtMarketPrice").val();
        var storePrice = $("#ctl00_content_txtStorePrice").val();
        var freightPrice = $("#ctl00_content_txtFreightPrice").val();
        var stock = $("#ctl00_content_txtStock").val();

        if (cat == "0") {
            layer.msg('请选择商品分类');
            return false;
        }
        if (!$.isNumeric(marketPrice)) {
            layer.msg('市场价格输入错误');
            return false;
        }
        if (!$.isNumeric(storePrice)) {
            layer.msg('商城价格输入错误');
            return false;
        }
        if (!$.isNumeric(freightPrice)) {
            layer.msg('运费输入错误');
            return false;
        }
        if (!$.isNumeric(stock)) {
            layer.msg('库存输入错误');
            return false;
        }
    }
</script>
</asp:Content>
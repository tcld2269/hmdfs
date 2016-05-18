<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="hm.Web.store.Add" Title="增加页" ValidateRequest="false"  %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
    .fl{width:250px;float:left}
.sel-ads{min-width:80px!important;max-width:30%!important;float:left!important;margin-right:5px!important}
</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    添加店铺</h5>
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
                            <asp:TextBox id="txtStoreName" runat="server" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            企业类型：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddrCat" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            所属区域：</label>
                        <div class="col-sm-8">
                            <select id="province" class="form-control sel-ads" onchange="showCity()">
                            <%=provinceHtml %>
                            </select>
                            <select id="city" class="form-control sel-ads hide" onchange="showDistinct()">
                            </select>
                            <select id="distinct" class="form-control sel-ads hide" onchange="showLast()"></select>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            详细地址：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            主营：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtSale" runat="server" CssClass="form-control" required="" aria-required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            Logo：</label>
                        <div class="col-sm-8">
                            <asp:FileUpload ID="flLogo" runat="server" CssClass="form-control fl" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            保证金：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtCashPrice" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            联系人：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtContact" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            QQ：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtQQ" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            电话：</label>
                        <div class="col-sm-8">
                            <asp:TextBox id="txtTel" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            详细介绍：</label>
                        <div class="col-sm-8">
                            <CKEditor:CKEditorControl ID="txtContent" runat="server" Height="300px"></CKEditor:CKEditorControl>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <asp:Button ID="btnSave" runat="server" Text="保存" OnClientClick="return check()"
                    OnClick="btnSave_Click" class="inputbutton" CssClass="btn btn-warning"></asp:Button>
                            
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
        var code = $("#addressVal").val();
        if (code == "0") {
            layer.msg('请选择所属区域！');
            return false;
        }
        var type = $("#ctl00_content_ddrCat").val();
        if (type == "0") {
            layer.msg('请选择企业类型！');
            return false;
        }
        
    }
    function showCity() {
        var code = $("#province").val();
        var pars = { code: code };
        ajax("/admin/store/Add.aspx?act=showCity&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#city").html(ret.result);
                $("#city").removeClass("hide");
                $("#distinct").addClass("hide");
                $("#addressVal").val("0");
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function showDistinct() {
        var code = $("#city").val();
        var pars = { code: code };
        ajax("/admin/store/Add.aspx?act=showDistinct&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#distinct").html(ret.result);
                $("#distinct").removeClass("hide");
                $("#addressVal").val("0");
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function showLast() {
        var code = $("#distinct").val();
        $("#addressVal").val(code);
    }
</script>
</asp:Content>
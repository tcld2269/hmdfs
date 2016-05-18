<%@ Page Title="商品表" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="goodsStands.aspx.cs" Inherits="hm.Web.goods.goodsStands" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
    .fl{width:250px;float:left}
.sel-ads{min-width:80px!important;max-width:30%!important;float:left!important;margin-right:5px!important}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="addpanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    规格添加</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            规格名称：</label>
                        <div class="col-sm-8">
                            <select id="stand1" class="form-control sel-ads" data-placeholder="选择规格..." style="width: 200px;" onchange="showSecond()">
                            <%=stand1 %>
                            </select>
                            <select id="stand2" class="form-control sel-ads hide" data-placeholder="选择规格..." style="width: 200px;" onchange="showLast()">
                            </select>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            市场价：</label>
                        <div class="col-sm-8">
                            <input id="market_price" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商城价：</label>
                        <div class="col-sm-8">
                            <input id="store_price" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            积分购买：</label>
                        <div class="col-sm-8">
                            <input id="buy_score" type="text" class="form-control" value="0"
                                required="" aria-required="true">购买此商品所需积分，填0为不允许积分购买
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            库存：</label>
                        <div class="col-sm-8">
                            <input id="stock" type="text" class="form-control" value="1"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            排序：</label>
                        <div class="col-sm-8">
                           <input id="orders" type="text" class="form-control" value="10"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <button id="btnsubmit" class="btn btn-warning" type="button" onclick="addRole()">
                                添加</button>
                            <button id="btncancle" class="btn btn-default" type="button" onclick="cancleaddpanel()">
                                取消</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="editPanel" class="col-sm-12 hidden">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    规格编辑</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            规格ID：</label>
                        <div class="col-sm-8">
                            <input id="id_edit" type="text" class="form-control" style="border:0;background-color:#fff" readonly="true">
                        </div>
                    </div>
                   <div class="form-group">
                        <label class="col-sm-3 control-label">
                            规格名称：</label>
                        <div class="col-sm-8">
                            <select id="stand1_edit" class="form-control sel-ads" data-placeholder="选择规格..." style="width: 200px;" onchange="showSecondEdit()">
                            <%=stand1 %>
                            </select>
                            <select id="stand2_edit" class="form-control sel-ads hide" data-placeholder="选择规格..." style="width: 200px;" onchange="showLastEdit()">
                            </select>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            市场价：</label>
                        <div class="col-sm-8">
                            <input id="market_price_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            商城价：</label>
                        <div class="col-sm-8">
                            <input id="store_price_edit" minlength="2" type="text" class="form-control"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            积分购买：</label>
                        <div class="col-sm-8">
                            <input id="buy_score_edit" type="text" class="form-control" value="0"
                                required="" aria-required="true">购买此商品所需积分，填0为不允许积分购买
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            库存：</label>
                        <div class="col-sm-8">
                            <input id="stock_edit" type="text" class="form-control" value="1"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            排序：</label>
                        <div class="col-sm-8">
                           <input id="orders_edit" type="text" class="form-control" value="10"
                                required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-8 col-sm-offset-3">
                            <button id="Button1" class="btn btn-warning" type="button" onclick="editRole()">
                                修改</button>
                            <button id="Button2" class="btn btn-default" type="button" onclick="cancleEditpanel()">
                                取消</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
<div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    商品规格管理 </h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <table class="table table-striped table-bordered table-hover dataTables-example">
                    <thead>
                        <tr>
                            <th>
                                ID
                            </th>
                            <th>
                                规格
                            </th>
                            <th>
                                价格
                            </th>
                            <th>
                                积分
                            </th>
                            <th>
                                库存
                            </th>
                           <th>
                                排序
                            </th>
                            <th>
                                编辑
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptList" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%#Eval("id")%>
                                    </td>
                                    <td>
                                        <%#Eval("name")%>
                                    </td>
                                    <td>
                                        <%#Eval("storePrice")%>
                                    </td>
                                    <td>
                                        <%#Eval("buyScore")%>
                                    </td>
                                    <td>
                                        <%#Eval("stock")%>
                                    </td>
                                    <td id="orders_<%#Eval("id")%>">
                                        <%#Eval("orders")%>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick="editShow(<%#Eval("id")%>)">编辑</a>
                                        <a href="javascript:void(0)" onclick="editOrders(<%#Eval("id")%>,<%#Eval("orders")%>)">排序</a>
                                        <a href="javascript:void(0)" onclick="del(<%#Eval("id")%>)">删除</a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
                <button class="btn btn-warning" type="button" onclick="showaddpanel()">添加规格</button>
                <button class="btn btn-default" type="button" onclick="history.back()">返回</button>
            </div>
            
        </div>
        
    </div>
    <input id="goodsId" type="hidden" value="<%=goodsId %>" />
    <input id="standsValue" type="hidden" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
<script>
    function showaddpanel() {
        $("#addpanel").attr("class", "col-sm-12");
    }
    function cancleaddpanel() {
        $("#addpanel").attr("class", "col-sm-12 hidden");
    }
    function showEditpanel() {
        $("#editPanel").attr("class", "col-sm-12");
    }
    function cancleEditpanel() {
        $("#editPanel").attr("class", "col-sm-12 hidden");
    }


    function addRole() {
        var goodsId = $("#goodsId").val();
        var standsValue = $("#standsValue").val();
        var marketPrice = $("#market_price").val();
        var storePrice = $("#store_price").val();
        var buyScore = $("#buy_score").val();
        var stock = $("#stock").val();
        var orders = $("#orders").val();
        if (standsValue == "") {
            layer.msg("请输入规格名称！");
            return;
        }
        if (!$.isNumeric(marketPrice)) {
            layer.msg("市场价输入错误！");
            return;
        }
        if (!$.isNumeric(storePrice)) {
            layer.msg("商城价格输入错误！");
            return;
        }
        if (!$.isNumeric(buyScore)) {
            layer.msg("积分输入错误！");
            return;
        }
        if (!$.isNumeric(stock)) {
            layer.msg("库存输入错误！");
            return;
        }
        if (!$.isNumeric(orders)) {
            layer.msg("排序输入错误！");
            return;
        }
        var pars = { goodsId:goodsId,standsValue: standsValue, marketPrice: marketPrice, storePrice: storePrice, buyScore: buyScore, stock: stock, orders: orders };
        ajax("/admin/goods/goodsStands.aspx?act=add&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function editShow(id) {
        var pars = { id: id };
        ajax("/admin/goods/goodsStands.aspx?act=editshow&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#id_edit").val(id);
                $("#market_price_edit").val(ret.marketPrice);
                $("#store_price_edit").val(ret.storePrice);
                $("#buy_score_edit").val(ret.buyScore);
                $("#stock_edit").val(ret.stock);
                $("#orders_edit").val(ret.orders);

                $("#stand1_edit").val(ret.stand1);
                showSecondEdit();
                $("#stand2_edit").val(ret.stand2);

                $("#standsValue").val(ret.stand1 + "," + ret.stand2);
                showEditpanel();
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }

    function editRole() {
        var id = $("#id_edit").val();
        var standsValue = $("#standsValue").val();
        var marketPrice = $("#market_price_edit").val();
        var storePrice = $("#store_price_edit").val();
        var buyScore = $("#buy_score_edit").val();
        var stock = $("#stock_edit").val();
        var orders = $("#orders_edit").val();
        if (standsValue == "") {
            layer.msg("请输入规格名称！");
            return;
        }
        if (!$.isNumeric(marketPrice)) {
            layer.msg("市场价输入错误！");
            return;
        }
        if (!$.isNumeric(storePrice)) {
            layer.msg("商城价格输入错误！");
            return;
        }
        if (!$.isNumeric(buyScore)) {
            layer.msg("积分输入错误！");
            return;
        }
        if (!$.isNumeric(stock)) {
            layer.msg("库存输入错误！");
            return;
        }
        if (!$.isNumeric(orders)) {
            layer.msg("排序输入错误！");
            return;
        }
        var pars = { id: id, standsValue: standsValue, marketPrice: marketPrice, storePrice: storePrice, buyScore: buyScore, stock: stock, orders: orders };
        ajax("/admin/goods/goodsStands.aspx?act=editsubmit&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                location.href = location.href;
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function editOrders(id,orderstr) {
        layer.prompt({
            title: '请输入排序号',
            value:orderstr,
            formType: 0
        }, function (data) {
            var pars = { id: id,orders:data };
            ajax("/admin/goods/goodsStands.aspx?act=editOrders&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    $("#orders_" + id).html(data);
                    layer.msg('修改成功！');
                }
                else {
                    layer.msg('修改失败！');
                }
            });
            
        });
    }
    function del(id) {
        if (confirm('是否删除？')) {
            var goodsId = $("#goodsId").val();
            var pars = { id: id, goodsId: goodsId };
            ajax("/admin/goods/goodsStands.aspx?act=del&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    location.href = location.href;
                }
                else {
                    layer.msg(ret.msg)
                }
            });
        }
    }

    function showSecond() {
        var id = $("#stand1").val();
        var pars = { id: id };
        ajax("/admin/goods/goodsStands.aspx?act=showSecond&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#stand2").html(ret.result);
                $("#stand2").removeClass("hide");
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function showLast() {
        var stand1 = $("#stand1").val();
        var stand2 = $("#stand2").val();
        $("#standsValue").val(stand1 + "," + stand2);
    }

    function showSecondEdit() {
        var id = $("#stand1_edit").val();
        var pars = { id: id };
        ajax("/admin/goods/goodsStands.aspx?act=showSecond&t=" + Math.random(), pars, function (ret) {
            if (ret.status == 1) {
                $("#stand2_edit").html(ret.result);
                $("#stand2_edit").removeClass("hide");
            }
            else {
                layer.msg(ret.msg)
            }
        });
    }
    function showLastEdit() {
        var stand1 = $("#stand1_edit").val();
        var stand2 = $("#stand2_edit").val();
        $("#standsValue").val(stand1 + "," + stand2);
    }
</script>
</asp:Content>

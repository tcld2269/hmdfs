<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="hm.Web.admin.common.ContactUs" %>
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
                        联系我们</h5>
                    <div class="ibox-tools">
                        <a class="collapse-link"><i class="fa fa-chevron-up"></i></a><a class="dropdown-toggle"
                            data-toggle="dropdown" href="form_editors.html#"></a>
                    </div>
                </div>
                <div class="ibox-content">
                <p>山东易惠天下技术有限公司</p>
                <p><i class="fa fa-send-o"></i> 地址：<a href="http://www.ehtx.cn/" target="_blank">http://www.ehtx.cn</a>
                        </p>
                    <p><i class="fa fa-send-o"></i> 官方网站：<a href="http://www.ehtx.cn/" target="_blank">http://www.ehtx.cn</a>
                        </p>
                        <p><i class="fa fa-qq"></i> QQ：<a href="http://wpa.qq.com/msgrd?v=3&amp;uin=712711508&amp;site=qq&amp;menu=yes" target="_blank">712711508</a>
                        </p>
                        <p><i class="fa fa-weixin"></i> 微信：<a href="javascript:;">ehtx</a>
                        </p>
                        <p><i class="fa fa-credit-card"></i> 支付宝：<a href="javascript:;" class="支付宝信息"></a>
                        </p>
                </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
</asp:Content>

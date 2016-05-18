using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace hm.Web.store
{
    public partial class VerifyShow : AdminPage
    {
        hm.BLL.store bll = new hm.BLL.store();
        public string provinceHtml = "";
        public string provinceString = "", cityString = "", distinctString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["act"] == null)
                {
                    provinceHtml = ClassHelper.getProvinceOptions();

                    if (Request.QueryString["id"] == null)
                    {
                        MessageBox.ShowAndRedirect(this, "缺少参数", "/admin/users/userlist.aspx");
                        return;
                    }
                    else
                    {
                        string id = Request.QueryString["id"].ToString();
                        Model.store model = bll.GetModel(int.Parse(id));
                        txtStoreName.Text = model.storeName;
                        lblType.Text = model.typeName;
                        txtAddress.Text = model.address;
                        txtSale.Text = model.sale;
                        imgLog.ImageUrl = model.logo;
                        txtCashPrice.Text = model.cashPrice.ToString();
                        txtContact.Text = model.contact;
                        txtQQ.Text = model.qq;
                        txtTel.Text = model.tel;
                        lblContent.Text = model.remark;
                        lblAddressNo.Text = ClassHelper.getAddressNoString(model.addressNo);
                        lblIdcard.Text = model.ownerCard;
                        lblImg.Text = "<a target='_blank' href='" + model.cardPic + "'><img class=\"cardPic\" src='" + model.cardPic + "' /></a>";
                        txtFeedBack.Text = model.feedBack;

                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
            int id = int.Parse(Request.QueryString["id"].ToString());

            hm.Model.store model = bll.GetModel(id);
            model.feedBack = txtFeedBack.Text;
            model.status = StatusHelpercs.Store_Status_Normal;
			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "审核通过！", "verifylist.aspx");
            ///TODO 可以加推送
            
		}
        protected void btnBack_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            hm.Model.store model = bll.GetModel(id);
            model.feedBack = txtFeedBack.Text;
            model.status = StatusHelpercs.Store_Status_FeedBack;
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "审核驳回！", "verifylist.aspx");
        }
    }
}

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
    public partial class Add : AdminPage
    {
        hm.BLL.store bll = new hm.BLL.store();
        public string provinceHtml="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["act"] == null)
                {
                    if (Request.QueryString["userId"] == null)
                    {
                        MessageBox.ShowAndRedirect(this, "缺少参数", "/admin/users/userlist.aspx");
                        return;
                    }
                    else
                    {
                        string userId = Request.QueryString["userId"].ToString();
                        if (bll.GetList("userId=" + userId).Tables[0].Rows.Count > 0)
                        {
                            MessageBox.ShowAndRedirect(this, "此用户已经开通过店铺！", "/admin/users/userlist.aspx");
                            return;
                        }
                        hm.BLL.users ubll = new hm.BLL.users();
                        if (ubll.GetList("userId=" + userId).Tables[0].Rows.Count == 0)
                        {
                            MessageBox.ShowAndRedirect(this, "无此用户！", "/admin/users/userlist.aspx");
                            return;
                        }
                    }
                    BLL.sysItem catBll = new BLL.sysItem();
                    ddrCat.DataTextField = "itemName";
                    ddrCat.DataValueField = "siId";
                    ddrCat.DataSource = ClassHelper.GetSystemItem(StatusHelpercs.Default_Item_StoreType);
                    ddrCat.DataBind();
                    ddrCat.Items.Insert(0, new ListItem("请选择", "0"));

                    provinceHtml = ClassHelper.getProvinceOptions();
                }
            }

            if (RequsetAjax("showCity"))
            {
                //
                try
                {
                    string code = Request.Form["code"].ToString();
                    string result = ClassHelper.getCityOptions(code);

                    Response.Write("{\"status\":1,\"result\":\"" + result + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("showDistinct"))
            {
                //
                try
                {
                    string code = Request.Form["code"].ToString();
                    string result = ClassHelper.getDistinceOptions(code);

                    Response.Write("{\"status\":1,\"result\":\"" + result + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStoreName.Text.Trim().Length==0)
			{
				strErr+="标题不能为空！\\n";	
			}
            if (this.ddrCat.SelectedValue == "0")
            {
                strErr += "请选择企业类型！\\n";
            }

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}

            string logo = StatusHelpercs.Default_Store_Logo;
            if (flLogo.HasFile)
            {
                string result = Common.CommonHelper.Imageupload(flLogo, "logo");
                if (result.IndexOf('|') > -1)
                {
                    logo = result.Split('|')[2];
                }
            }

            int userId = int.Parse(Request.QueryString["userId"].ToString());
            Model.users umodel = new BLL.users().GetModel(userId);

            hm.Model.store model = new hm.Model.store();
			model.storeName=txtStoreName.Text;
            model.userId = userId;
            model.userName = umodel.userName;
            model.storeType = int.Parse(ddrCat.SelectedValue);
            model.typeName = ddrCat.SelectedItem.Text;
            model.ownerCard = "";
            model.cardPic = "";
            model.addressNo = Request.Form["addressVal"].ToString();
            model.address = txtAddress.Text;
            model.logo = logo;
            model.banner = "";
            model.sale = txtSale.Text;
            model.cashPrice = decimal.Parse(txtCashPrice.Text);
            model.contact = txtContact.Text;
            model.qq = txtQQ.Text;
            model.tel = txtTel.Text;
            model.summary = "";
            model.remark = txtContent.Text;
            model.isRecommend = 0;
            model.evaluateService = 0;
            model.evaluateDesc = 0;
            model.evaluateDeliver = 0;
            model.favCount = 0;
            model.clickCount = 0;
            model.feedBack = "";
            model.lat = "";
            model.lon = "";
            model.addTime = DateTime.Now;
            model.orders = 1000;
            model.status = StatusHelpercs.Store_Status_Normal;

            
			bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}

    }
}

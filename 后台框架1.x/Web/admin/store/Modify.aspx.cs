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
    public partial class Modify : AdminPage
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
                    
                    BLL.sysItem catBll = new BLL.sysItem();
                    ddrCat.DataTextField = "itemName";
                    ddrCat.DataValueField = "siId";
                    ddrCat.DataSource = ClassHelper.GetSystemItem(StatusHelpercs.Default_Item_StoreType);
                    ddrCat.DataBind();
                    ddrCat.Items.Insert(0, new ListItem("请选择", "0"));

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
                        ddrCat.SelectedValue = model.storeType.ToString();
                        txtAddress.Text = model.address;
                        txtSale.Text = model.sale;
                        imgLog.ImageUrl = model.logo;
                        txtCashPrice.Text = model.cashPrice.ToString();
                        txtContact.Text = model.contact;
                        txtQQ.Text = model.qq;
                        txtTel.Text = model.tel;
                        txtContent.Text = model.remark;

                        provinceString = model.addressNo.Substring(0, 2) + "0000";
                        cityString = model.addressNo.Substring(0, 4) + "00";
                        distinctString = model.addressNo;
                    }
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

            string logo = imgLog.ImageUrl;
            if (flLogo.HasFile)
            {
                string result = Common.CommonHelper.Imageupload(flLogo, "logo");
                if (result.IndexOf('|') > -1)
                {
                    logo = result.Split('|')[2];
                }
            }

            int id = int.Parse(Request.QueryString["id"].ToString());

            hm.Model.store model = bll.GetModel(id);
			model.storeName=txtStoreName.Text;
            model.storeType = int.Parse(ddrCat.SelectedValue);
            model.typeName = ddrCat.SelectedItem.Text;
            model.addressNo = Request.Form["addressVal"].ToString();
            model.address = txtAddress.Text;
            model.logo = logo;
            model.sale = txtSale.Text;
            model.cashPrice = decimal.Parse(txtCashPrice.Text);
            model.contact = txtContact.Text;
            model.qq = txtQQ.Text;
            model.tel = txtTel.Text;
            model.remark = txtContent.Text;
            
			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}

    }
}

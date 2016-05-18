using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hm.Web.admin.common
{
    public partial class siteConfig : System.Web.UI.Page
    {
        BLL.siteConfig bll = new BLL.siteConfig();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {
            Model.siteConfig model = bll.GetModelList("")[0];
            txtName.Text = model.name;
            txtUrl.Text = model.url;
            txtTitle.Text = model.seoTitle;
            txtKeywords.Text = model.seoKeywords;
            txtDes.Text = model.seoDescription;
            txtCopyright.Text = model.copyright;
            txtContact.Text = model.contact;
            txtEmail.Text = model.email;
            txtQQ.Text = model.qq;
            txtPhone.Text = model.phone;
            txtFax.Text = model.fax;
            txtAddress.Text = model.address;
            txtIcp.Text = model.icp;
            litLogo.Text = "<a target=\"_blank\" href=\"" + model.logo + "\"><img style=\"float:left;margin-left:20px\" height=\"35px\" src=\"" + model.logo + "\" /></a>";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Model.siteConfig model = bll.GetModelList("")[0];
            model.name = txtName.Text;
            model.url = txtUrl.Text;
            model.seoTitle = txtTitle.Text;
            model.seoKeywords = txtKeywords.Text;
            model.seoDescription = txtDes.Text;
            model.copyright = txtCopyright.Text;
            model.contact = txtContact.Text;
            model.email = txtEmail.Text;
            model.qq = txtQQ.Text;
            model.phone = txtPhone.Text;
            model.fax = txtFax.Text;
            model.address = txtAddress.Text;
            model.icp = txtIcp.Text;
            if (flLogo.HasFile)
            {
                string result = Common.CommonHelper.Imageupload(flLogo, "logo");
                if (result.IndexOf('|') > -1)
                {
                    model.logo = result.Split('|')[2];
                }
            }
            bll.Update(model);
            bind();
        }
    }
}
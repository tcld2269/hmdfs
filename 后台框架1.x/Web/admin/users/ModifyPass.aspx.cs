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
namespace hm.Web.users
{
    public partial class ModifyPass : AdminPage
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				
			}
		}
			
	

		public void btnSave_Click(object sender, EventArgs e)
		{
            hm.BLL.users bllUser = new hm.BLL.users();
            string userId = Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId);
            if (string.IsNullOrEmpty(userId))
            {
                Response.Write("<script language=javascript>window.parent.location='../Login.aspx';</script>");//
            }
            else
            {
                string oldPass = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(txtPassword.Text.Trim(), ConfigHelper.GetConfigString("PassWordEncrypt"));
                string newPass = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(txtNewPass.Text.Trim(), ConfigHelper.GetConfigString("PassWordEncrypt"));
                string reNewPass = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(txtReNewPass.Text.Trim(), ConfigHelper.GetConfigString("PassWordEncrypt"));
                if (!newPass.Equals(reNewPass))
                {
                    MessageBox.Show(this, "新密码两次输入的不一致！");
                    return;
                }

                DataSet ds = bllUser.GetList("userId='" + userId + "' and password='" + oldPass + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Model.users model = bllUser.GetModel(int.Parse(userId));
                    if (model != null)
                    {
                        model.password = newPass;
                        bllUser.Update(model);
                        MessageBox.Show(this, "修改成功！");
                    }
                }
                else
                {
                    MessageBox.Show(this, "密码输入错误，请重新输入！");
                }
            }

		}

    }
}

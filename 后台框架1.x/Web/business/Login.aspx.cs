using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Common.DEncrypt;

namespace hm.Web.business
{
    public partial class Login : System.Web.UI.Page
    {
        public string siteName = "", copyright = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Model.siteConfig model = new BLL.siteConfig().GetModelList("")[0];
                if (model != null)
                {
                    siteName = model.name;
                    copyright = model.copyright;
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BLL.users userService = new BLL.users();
            string userName = txtUserName.Text.Trim();
            string password = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(txtPassword.Text.Trim(), ConfigHelper.GetConfigString("PassWordEncrypt"));
            //string password = txtPassword.Text.Trim();
            DataTable userList = userService.GetList("userName='" + userName + "' and password='" + password + "' and roleId in (4,10,11)").Tables[0];
            if (userList.Rows.Count > 0)
            {

                if (userList.Rows[0]["status"].ToString() == "0")
                {
                    MessageBox.Show(this, "此用户名已被冻结，无法登陆！");
                    return;
                }
                //写入Cookie 
                try
                {
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_UserId, 2, userList.Rows[0]["userId"].ToString());
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_UserName, 2, txtUserName.Text.Trim());
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_TrueName, 2, DESEncrypt.Encrypt(userList.Rows[0]["trueName"].ToString()));
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_RoleId, 2, userList.Rows[0]["roleId"].ToString());
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_RoleName, 2, DESEncrypt.Encrypt(userList.Rows[0]["roleName"].ToString()));
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_DeptId, 2, userList.Rows[0]["deptId"].ToString());
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_IsAdmin, 2, userList.Rows[0]["isAdmin"].ToString());
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_Avatar, 2, userList.Rows[0]["avatar_small"].ToString());
                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_LastLoginTime, 2, DateTime.Parse(userList.Rows[0]["lastLoginTime"].ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
                }
                catch
                {
                    //Session["userName"] = txtUserName.Text.Trim();
                    //Session["userType"] = ddrUserTyp.SelectedValue;
                    //Session["orgId"] = userList.Rows[0]["orgId"].ToString();
                }
                //更新最后登陆时间
                Model.users userModel = userService.GetModel(int.Parse(userList.Rows[0]["userId"].ToString()));
                userModel.lastLoginTime = DateTime.Now;
                userService.Update(userModel);

                Response.Redirect("index.aspx");
                //MessageBox.ShowAndRedirect(this, "登录成功！", "index.html");
            }
            else
            {
                MessageBox.Show(this, "用户名或密码错误！");
            }
        }
    }
}
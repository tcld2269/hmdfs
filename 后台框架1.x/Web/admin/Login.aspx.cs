using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Common.DEncrypt;

namespace hm.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BLL.users userService = new BLL.users();
            string userName = txtUserName.Text.Trim();
            string password = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(txtPassword.Text.Trim(), ConfigHelper.GetConfigString("PassWordEncrypt"));
            //string password = txtPassword.Text.Trim();
            DataTable userList = userService.GetList("userName='" + userName + "' and password='" + password + "'").Tables[0];
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
                    Common.Cookie.SetObject("userName", 2, txtUserName.Text.Trim());
                    Common.Cookie.SetObject("roleId", 2, userList.Rows[0]["roleId"].ToString());
                    Common.Cookie.SetObject("roleName", 2, DESEncrypt.Encrypt(userList.Rows[0]["roleName"].ToString()));
                    Common.Cookie.SetObject("userId", 2, userList.Rows[0]["userId"].ToString());
                    Common.Cookie.SetObject("deptId", 2, userList.Rows[0]["deptId"].ToString());
                    Common.Cookie.SetObject("trueName", 2, DESEncrypt.Encrypt(userList.Rows[0]["trueName"].ToString()));
                    Common.Cookie.SetObject("isAdmin", 2, userList.Rows[0]["isAdmin"].ToString());
                    Common.Cookie.SetObject("lastLoginTime", 2, DateTime.Parse(userList.Rows[0]["lastLoginTime"].ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
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

                Response.Redirect("index.html");
                //MessageBox.ShowAndRedirect(this, "登录成功！", "index.html");
            }
            else
            {
                MessageBox.Show(this, "用户名或密码错误！");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }


    }
}
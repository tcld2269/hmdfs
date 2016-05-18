using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;

namespace hm.Web.admin.users
{
    public partial class UserInfo : System.Web.UI.Page
    {
        BLL.users bll = new BLL.users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                Model.users model=bll.GetModel(int.Parse(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId)));
                txtUserName.Text = model.userName;
                txtTruename.Text = model.trueName;
                txtNickname.Text = model.nickName;
                txtTel.Text = model.tel;
                txtEmail.Text = model.email;
                txtQQ.Text = model.qq;
                lblAccount.Text = "可用余额：" + model.account + " 冻结余额：" + model.accountFrozen;
                lblScore.Text = "可用积分：" + model.score + " 冻结积分：" + model.scoreFrozen;
                lblStatus.Text = StatusHelpercs.User_Status_Arr[model.status.Value];
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Model.users model = bll.GetModel(int.Parse(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId)));
            model.userName = txtUserName.Text;
            model.trueName = txtTruename.Text ;
            model.nickName = txtNickname.Text ;
            model.tel = txtTel.Text;
            model.email = txtEmail.Text;
            model.qq = txtQQ.Text;
            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                model.password = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(txtPassword.Text.Trim(), ConfigHelper.GetConfigString("PassWordEncrypt"));
            }
            bll.Update(model);
        }
    }
}
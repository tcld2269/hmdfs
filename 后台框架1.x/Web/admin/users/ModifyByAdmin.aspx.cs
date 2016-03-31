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
    public partial class ModifyByAdmin : AdminPage
    {
        hm.BLL.users bll = new hm.BLL.users();
        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int userId=(Convert.ToInt32(Request.Params["id"]));
                    hm.Model.users model = bll.GetModel(userId);

					ShowInfo(userId);
				}
			}
		}
			
	private void ShowInfo(int userId)
	{
		
		hm.Model.users model=bll.GetModel(userId);
		this.lbluserId.Text=model.userId.ToString();
		this.txtuserName.Text=model.userName;
        this.txtTrueName.Text = model.trueName;
        
        rblSex.SelectedValue = model.sex.ToString();
		this.txttel.Text=model.tel;
		this.txtemail.Text=model.email;
		this.txtqq.Text=model.qq;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
            hm.BLL.users bll = new hm.BLL.users();
			string strErr="";
            if (this.txtuserName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            }
            if (this.txtTrueName.Text.Trim().Length == 0)
            {
                strErr += "真实姓名不能为空！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userId=int.Parse(this.lbluserId.Text);
            string userName = this.txtuserName.Text;
            string trueName = this.txtTrueName.Text;
            int sex = int.Parse(this.rblSex.SelectedValue);
            string tel = this.txttel.Text;
            string email = this.txtemail.Text;
            string qq = this.txtqq.Text;
            DateTime addTime = DateTime.Now;
            DateTime lastLoginTime = DateTime.Now;


            hm.Model.users model = bll.GetModel(userId);
			model.userName=userName;
            model.trueName = trueName;
			model.sex=sex;
			model.tel=tel;
			model.email=email;
			model.qq=qq;
			model.addTime=addTime;
			model.lastLoginTime=lastLoginTime;

			
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","studentList.aspx");

		}

    }
}

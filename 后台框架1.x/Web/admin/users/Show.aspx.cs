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
namespace hm.Web.users
{
	public partial class Show : AdminPage
	{        
				public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int userId=(Convert.ToInt32(strid));
					ShowInfo(userId);
				}
			}
		}
		
	private void ShowInfo(int userId)
	{
		hm.BLL.users bll=new hm.BLL.users();
		hm.Model.users model=bll.GetModel(userId);
		this.lbluserId.Text=model.userId.ToString();
		this.lbluserName.Text=model.userName;
		this.lblpassword.Text = "******";
        if (string.IsNullOrEmpty(model.roleName))
        {
            this.lblroleName.Text = "用户";
        }
        else
        {
            this.lblroleName.Text = model.roleName;
        }
		string sex = "男";
		if ("0".Equals(model.sex.ToString()))
		{
			sex = "女";
		}
        lbldeptName.Text = model.deptName;
		this.lblsex.Text = sex;
		this.lbltel.Text=model.tel;
		this.lblemail.Text=model.email;
		this.lblqq.Text=model.qq;
		this.lbladdTime.Text=model.addTime.ToString();
		this.lbllastLoginTime.Text=model.lastLoginTime.ToString();
		//this.lblstatus.Text = ClassHelper.GetSystemItemName(model.status.ToString());//(这个是读码表的，现在不存在码表)
		if (model.status.ToString() == "1")
		{
			this.lblstatus.Text = "正常";
		}
		else
		{
			this.lblstatus.Text = "冻结";
		}
		lblTrueName.Text = model.trueName;
	}


	}
}

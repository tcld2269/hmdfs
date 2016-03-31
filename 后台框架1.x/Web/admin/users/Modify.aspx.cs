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
	public partial class Modify : AdminPage
	{       

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int userId=(Convert.ToInt32(Request.Params["id"]));

                    BLL.dept placeBll = new BLL.dept();
                    ddrPlace.DataTextField = "deptName";
                    ddrPlace.DataValueField = "deptId";
					ddrPlace.DataSource = placeBll.GetList("");
					ddrPlace.DataBind();
                    ddrPlace.Items.Insert(0,new ListItem("请选择","0"));

					BLL.role roleBll = new BLL.role();
					ddrRole.DataTextField = "roleName";
					ddrRole.DataValueField = "roleId";
					ddrRole.DataSource = roleBll.GetList("roleId<>1");
					ddrRole.DataBind();

                    try
                    {
                        ShowInfo(userId);
                    }
                    catch (Exception ex)
                    { }
					
				}
			}
		}
			
	private void ShowInfo(int userId)
	{
		hm.BLL.users bll=new hm.BLL.users();
		hm.Model.users model=bll.GetModel(userId);
		this.lbluserId.Text=model.userId.ToString();
		this.txtuserName.Text=model.userName;
		this.txtTrueName.Text = model.trueName;
		ddrRole.SelectedValue = model.roleId.ToString();
		rblSex.SelectedValue = model.sex.ToString();
		this.txtemail.Text=model.email;
		this.txtqq.Text=model.qq;
		ddrStatus.SelectedValue = model.status.ToString();
        ddrPlace.SelectedValue = model.deptId.Value.ToString();
        txttel.Text = model.tel;

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
            if (this.ddrPlace.SelectedValue == "0")
            {
                strErr += "请选择所属区域！\\n";
            }
            if (this.ddrRole.SelectedValue == "0")
            {
                strErr += "请选择角色！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userId=int.Parse(this.lbluserId.Text);
			string userName = this.txtuserName.Text;
			string trueName = this.txtTrueName.Text;
			int placeId = int.Parse(this.ddrPlace.SelectedValue);
			string placeName = this.ddrPlace.Items[ddrPlace.SelectedIndex].Text;
			int roleId = int.Parse(this.ddrRole.SelectedValue);
			string roleName = this.ddrRole.Items[ddrRole.SelectedIndex].Text;
			int sex = int.Parse(this.rblSex.SelectedValue);
            string tel = this.txtuserName.Text;
			string email = this.txtemail.Text;
			string qq = this.txtqq.Text;
			int status = int.Parse(this.ddrStatus.SelectedValue);

			hm.Model.users model = bll.GetModel(userId);
			model.userName=userName;
			model.trueName = trueName;
            model.deptId = placeId;
            model.deptName = placeName;
			model.roleId=roleId;
			model.roleName=roleName;
			model.sex=sex;
			model.tel=tel;
			model.email=email;
			model.qq=qq;
			model.status=status;
            model.tel = txttel.Text;
			
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}

	}
}

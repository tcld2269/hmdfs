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
    public partial class ModifyMe : AdminPage
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
                HttpCookie cookie = Request.Cookies["userId"];
                if (null == cookie)
                {
                    Response.Write("<script language=javascript>window.parent.location='../Login.aspx';</script>");//
                }
                else
                {
                    int userId = (Convert.ToInt32(cookie.Value));

                    ddrDept.DataTextField = "itemName";
                    ddrDept.DataValueField = "siId";
                    ddrDept.DataSource = ClassHelper.GetSystemItem("DEPT");
                    ddrDept.DataBind();

                    ddrStatus.DataTextField = "itemName";
                    ddrStatus.DataValueField = "siId";
                    ddrStatus.DataSource = ClassHelper.GetSystemItem("USER_STATUS");
                    ddrStatus.DataBind();

                    BLL.role roleBll = new BLL.role();
                    ddrRole.DataTextField = "roleName";
                    ddrRole.DataValueField = "roleId";
                    ddrRole.DataSource = roleBll.GetList("roleId<>1");
                    ddrRole.DataBind();

					ShowInfo(userId);
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
		this.txttel.Text=model.tel;
		this.txtemail.Text=model.email;
		this.txtqq.Text=model.qq;
        ddrStatus.SelectedValue = model.status.ToString();

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
                strErr += "用户名不能为空！\\n";
            }

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userId=int.Parse(this.lbluserId.Text);
            string userName = this.txtuserName.Text;
            string trueName = this.txtTrueName.Text;
            int deptId = int.Parse(this.ddrDept.SelectedValue);
            string deptName = this.ddrDept.Items[ddrDept.SelectedIndex].Text;
            int roleId = int.Parse(this.ddrRole.SelectedValue);
            string roleName = this.ddrRole.Items[ddrRole.SelectedIndex].Text;
            int sex = int.Parse(this.rblSex.SelectedValue);
            string tel = this.txttel.Text;
            string email = this.txtemail.Text;
            string qq = this.txtqq.Text;
            DateTime addTime = DateTime.Now;
            DateTime lastLoginTime = DateTime.Now;
            int status = int.Parse(this.ddrStatus.SelectedValue);


            hm.Model.users model = bll.GetModel(userId);
			model.userName=userName;
            model.trueName = trueName;
			model.roleId=roleId;
			model.roleName=roleName;
			model.sex=sex;
			model.tel=tel;
			model.email=email;
			model.qq=qq;
			model.addTime=addTime;
			model.lastLoginTime=lastLoginTime;
			model.status=status;

			
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}

    }
}

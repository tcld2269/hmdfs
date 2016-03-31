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
    public partial class Add : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.dept pBll = new BLL.dept();
                string placeSql = "";
                string roleSql = "roleId<>1";
                if (Request.Cookies["isAdmin"].Value != "1")
                {
                    placeSql = " deptId in (" + pBll.GetAllChild(int.Parse(Request.Cookies["deptId"].Value)) + ") ";
                    roleSql = "roleId>2";
                }


                ClassHelper.AddDeptList(ddrPlace);

                BLL.role roleBll = new BLL.role();
                ddrRole.DataTextField = "roleName";
                ddrRole.DataValueField = "roleId";
                ddrRole.DataSource = roleBll.GetList(roleSql);
                ddrRole.DataBind();
                ddrRole.Items.Insert(0, new ListItem("请选择", "0"));

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
            hm.BLL.users bll = new hm.BLL.users();
			string strErr="";
			if(this.txtuserName.Text.Trim().Length==0)
			{
				strErr+="用户名不能为空！\\n";	
			}
            if (this.txtTrueName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            }
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="密码不能为空！\\n";	
			}
            if (this.ddrPlace.SelectedValue == "0")
            {
                strErr += "请选择所属区域！\\n";
            }
            if (this.ddrRole.SelectedValue == "0")
            {
                strErr += "请选择角色！\\n";
            }
            if (bll.GetList("userName='" + txtuserName.Text.Trim() + "'").Tables[0].Rows.Count > 0)
            {
                strErr += "用户名重复！\\n";
            }

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string userName=this.txtuserName.Text;
			string password=this.txtpassword.Text;
            string trueName = this.txtTrueName.Text;
            int placeId = int.Parse(this.ddrPlace.SelectedValue);
            string placeName = this.ddrPlace.Items[ddrPlace.SelectedIndex].Text.Replace("┣", "").Replace("╍", "").Replace("?", "");
            int roleId = int.Parse(this.ddrRole.SelectedValue);
            string roleName = this.ddrRole.Items[ddrRole.SelectedIndex].Text;
			int sex=int.Parse(this.rblSex.SelectedValue);
            string tel = this.txttel.Text;
			string email=this.txtemail.Text;
			string qq=this.txtqq.Text;
            DateTime addTime = DateTime.Now;
            DateTime lastLoginTime = DateTime.Now;
            int status = int.Parse(this.ddrStatus.SelectedValue);

			hm.Model.users model=new hm.Model.users();
			model.userName=userName;
            model.password = Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(password, ConfigHelper.GetConfigString("PassWordEncrypt"));
            model.trueName = trueName;
            model.deptId = placeId;
            model.deptName = placeName;
			model.roleId=roleId;
			model.roleName=roleName;
			model.sex=sex;
			model.tel=tel;
			model.email=email;
			model.qq=qq;
			model.addTime=addTime;
			model.lastLoginTime=lastLoginTime;
			model.status=status;
            //model.address = txtAddress.Text;
            if (this.ddrRole.Items[ddrRole.SelectedIndex].Text.Equals("管理员"))
            {
                model.isAdmin = 1;
            }
            model.score = 0;

			
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

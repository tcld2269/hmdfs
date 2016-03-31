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
namespace hm.Web.role
{
	public partial class Add : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
					   
		}

				protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtroleName.Text.Trim().Length==0)
			{
				strErr+="roleName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string roleName=this.txtroleName.Text;

			hm.Model.role model=new hm.Model.role();
			model.roleName=roleName;

			hm.BLL.role bll=new hm.BLL.role();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}


		public void btnCancle_Click(object sender, EventArgs e)
		{
			Response.Redirect("list.aspx");
		}
	}
}

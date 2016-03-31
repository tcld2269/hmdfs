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
namespace hm.Web.sysItemCategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int sicId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(sicId);
				}
			}
		}
			
	private void ShowInfo(int sicId)
	{
		hm.BLL.sysItemCategory bll=new hm.BLL.sysItemCategory();
		hm.Model.sysItemCategory model=bll.GetModel(sicId);
		this.lblsicId.Text=model.sicId.ToString();
		this.txtinnerName.Text=model.innerName;
		this.txtcatName.Text=model.catName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtinnerName.Text.Trim().Length==0)
			{
				strErr+="innerName不能为空！\\n";	
			}
			if(this.txtcatName.Text.Trim().Length==0)
			{
				strErr+="catName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int sicId=int.Parse(this.lblsicId.Text);
			string innerName=this.txtinnerName.Text;
			string catName=this.txtcatName.Text;


			hm.Model.sysItemCategory model=new hm.Model.sysItemCategory();
			model.sicId=sicId;
			model.innerName=innerName;
			model.catName=catName;

			hm.BLL.sysItemCategory bll=new hm.BLL.sysItemCategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

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
namespace hm.Web.sysItem
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int siId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(siId);
				}
			}
		}
			
	private void ShowInfo(int siId)
	{
		hm.BLL.sysItem bll=new hm.BLL.sysItem();
		hm.Model.sysItem model=bll.GetModel(siId);
		this.lblsiId.Text=model.siId.ToString();
		this.txtitemName.Text=model.itemName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtitemName.Text.Trim().Length==0)
			{
				strErr+="码表项不能为空！\\n";	
			}
            if (!PageValidate.IsNumber(txtOrders.Text))
            {
                strErr += "排序必须填写数字！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int siId=int.Parse(this.lblsiId.Text);
			string itemName=this.txtitemName.Text;
            int orders = int.Parse(this.txtOrders.Text);

            hm.BLL.sysItem bll = new hm.BLL.sysItem();
            hm.Model.sysItem model = bll.GetModel(siId);
			model.siId=siId;
			model.itemName=itemName;
            model.orders = orders;
			
			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx?id=" + model.sicId);

		}


    }
}

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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    MessageBox.ShowAndRedirect(this, "参数丢失！", "../sysItemCategory/List.aspx");
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
            if (this.txtitemName.Text.Trim().Length == 0)
            {
                strErr += "码表项不能为空！\\n";
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

            int sicId = int.Parse(Request.QueryString["id"].ToString());
			string itemName=this.txtitemName.Text;
            int orders = int.Parse(this.txtOrders.Text);

			hm.Model.sysItem model=new hm.Model.sysItem();
			model.sicId=sicId;
			model.itemName=itemName;
            model.orders = orders;

			hm.BLL.sysItem bll=new hm.BLL.sysItem();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx?id="+sicId);

		}


    }
}

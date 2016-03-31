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
namespace hm.Web.newsCat
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int catId=(Convert.ToInt32(strid));
					ShowInfo(catId);
				}
			}
		}
		
	private void ShowInfo(int catId)
	{
		hm.BLL.newsCat bll=new hm.BLL.newsCat();
		hm.Model.newsCat model=bll.GetModel(catId);
		this.lblcatId.Text=model.catId.ToString();
		this.lblparentId.Text=model.parentId.ToString();
		this.lblcatName.Text=model.catName;
		this.lbltype.Text=model.type.ToString();
		this.lblorders.Text=model.orders.ToString();
		this.lblbackCol.Text=model.backCol;

	}


    }
}

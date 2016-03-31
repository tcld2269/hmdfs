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
namespace hm.Web.news
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
					int newsId=(Convert.ToInt32(strid));
					ShowInfo(newsId);
				}
			}
		}
		
	private void ShowInfo(int newsId)
	{
		hm.BLL.news bll=new hm.BLL.news();
		hm.Model.news model=bll.GetModel(newsId);
		this.lblnewsId.Text=model.newsId.ToString();
		this.lbluserName.Text=model.userName;
		
		this.lblnewsTitle.Text=model.newsTitle;

		this.lblnewsContent.Text=model.newsContent;
		
		this.lbladdTime.Text=model.addTime.ToString();
		this.lblmodifyTime.Text=model.modifyTime.ToString();
		

	}


    }
}

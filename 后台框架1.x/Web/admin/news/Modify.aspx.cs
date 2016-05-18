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
namespace hm.Web.news
{
    public partial class Modify : Page
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
                    BLL.newsCat catBll = new BLL.newsCat();
                    ddrCat.DataTextField = "catName";
                    ddrCat.DataValueField = "catId";
                    ddrCat.DataSource = catBll.GetList("");
                    ddrCat.DataBind();
                    ddrCat.Items.Insert(0, new ListItem("请选择", "0"));

					int newsId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(newsId);
				}
			}
		}
			
	private void ShowInfo(int newsId)
	{
		hm.BLL.news bll=new hm.BLL.news();
		hm.Model.news model=bll.GetModel(newsId);
        this.lblNewsId.Text = model.newsId.ToString();
		
		this.txtnewsTitle.Text=model.newsTitle;
		this.txtContent.Text=model.newsContent;
        ddrCat.SelectedValue = model.catId.Value.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
            if (this.txtnewsTitle.Text.Trim().Length == 0)
            {
                strErr += "标题不能为空！\\n";
            }
            if (this.txtContent.Text.Trim().Length == 0)
            {
                strErr += "新闻内容不能为空！\\n";
            }
            if (this.ddrCat.SelectedValue == "0")
            {
                strErr += "请选择所属分类！\\n";
            }

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int newsId=int.Parse(this.lblNewsId.Text);
            int catId = int.Parse(this.ddrCat.SelectedValue);
            string catName = this.ddrCat.Items[ddrCat.SelectedIndex].Text;
            int userId = int.Parse(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId));
            string userName = Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserName);
            int deptId = int.Parse(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_DeptId));
            string newsTitle = this.txtnewsTitle.Text;
            string summary = "";
            string newsContent = this.txtContent.Text;
            string contentSource = "";
            string author = "";
            DateTime addTime = DateTime.Now;
            DateTime modifyTime = DateTime.Now;
            int isHomePage = 0;
            int isSlide = 0;
            isHomePage = 0;

            hm.BLL.news bll = new hm.BLL.news();
            hm.Model.news model = bll.GetModel(newsId);
			model.newsId=newsId;
			model.catId=catId;
			model.catName=catName;
			model.userId=userId;
			model.userName=userName;
			model.deptId=deptId;
			model.newsTitle=newsTitle;
			model.summary=summary;
			model.newsContent=newsContent;
			model.contentSource=contentSource;
			model.author=author;
			model.addTime=addTime;
			model.modifyTime=modifyTime;
			model.isHomePage=isHomePage;
			model.isSlide=isSlide;

			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }


    }
}

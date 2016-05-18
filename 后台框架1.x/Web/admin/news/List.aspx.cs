using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
namespace hm.Web.news
{
    public partial class List : AdminPage
    {
		hm.BLL.news bll = new hm.BLL.news();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
            if (RequsetAjax("del"))
            {
                //删除
                try
                {
                    string newsId = Request.Form["newsId"].ToString();
                    bll.Delete(int.Parse(newsId));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }
        
        public void BindData()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" status=1 ");
            
            ds = bll.GetList(strWhere.ToString() + " order by addTime desc");

           
            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

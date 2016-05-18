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
namespace hm.Web.store
{
    public partial class List : AdminPage
    {
        hm.BLL.store bll = new hm.BLL.store();

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
                    string id = Request.Form["id"].ToString();
                    bll.Delete(int.Parse(id));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }
        
        public void BindData()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" status>0 ");

            DataTable dt = bll.GetList(strWhere.ToString() + " order by addTime desc").Tables[0];
            Common.CommonHelper.AddDtColumns(dt, "status", StatusHelpercs.Store_Status_Arr);
           
            rptList.DataSource = dt;
            rptList.DataBind();
        }

    }
}

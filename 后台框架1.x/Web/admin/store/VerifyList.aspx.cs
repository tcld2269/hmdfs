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
    public partial class VerifyList : AdminPage
    {
        hm.BLL.store bll = new hm.BLL.store();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
            if (RequsetAjax("pass"))
            {
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.store model = bll.GetModel(int.Parse(id));
                    model.status = StatusHelpercs.Store_Status_Normal;
                    model.feedBack = StatusHelpercs.Default_Store_Verify_Success;
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }
        
        public void BindData()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" status=0 ");

            DataTable dt = bll.GetList(strWhere.ToString() + " order by addTime desc").Tables[0];
            Common.CommonHelper.AddDtColumns(dt, "status", StatusHelpercs.Store_Status_Arr);
           
            rptList.DataSource = dt;
            rptList.DataBind();
        }

    }
}

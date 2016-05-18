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
namespace hm.Web.common
{
    public partial class MessageList : AdminPage
    {
        hm.BLL.message bll = new hm.BLL.message();

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
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" receiverId="+Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId)+" ");
            
            ds = bll.GetList(strWhere.ToString() + " order by addTime desc");
            Common.CommonHelper.AddDtColumns(ds.Tables[0], "type", StatusHelpercs.Message_Type_Arr);
            Common.CommonHelper.AddDtColumns(ds.Tables[0], "status", StatusHelpercs.Message_Status_Arr);
            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

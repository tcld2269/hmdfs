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
namespace hm.Web.goods
{
    public partial class List : AdminPage
    {
        hm.BLL.goods bll = new hm.BLL.goods();

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
                    Model.goods model = bll.GetModel(int.Parse(id));
                    model.status = StatusHelpercs.Goods_Status_Del;
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }

            if (RequsetAjax("editOrders"))
            {
                try
                {
                    string id = Request.Form["id"].ToString();
                    string orders = Request.Form["orders"].ToString();
                    Model.goods model = bll.GetModel(int.Parse(id));
                    model.orders = int.Parse(orders);
                    bll.Update(model);

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
            
            ds = bll.GetList(strWhere.ToString() + " order by orders asc,id desc");

           
            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

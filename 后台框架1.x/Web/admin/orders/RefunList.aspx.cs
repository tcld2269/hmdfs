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
namespace hm.Web.orders
{
    public partial class RefunList : AdminPage
    {
        hm.BLL.shoppingOrder bll = new hm.BLL.shoppingOrder();

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

            if (RequsetAjax("editOrders"))
            {
                try
                {
                    string id = Request.Form["id"].ToString();
                    string orders = Request.Form["orders"].ToString();
                    Model.shoppingOrder model = bll.GetModel(int.Parse(id));
                    
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
            strWhere.AppendFormat("status in ({0},{1},{2})", StatusHelpercs.Order_Status_RefundReq, StatusHelpercs.Order_Status_RefundIng, StatusHelpercs.Order_Status_Refunded);
            
            ds = bll.GetList(strWhere.ToString() + " order by id desc");
            Common.CommonHelper.AddDtColumns(ds.Tables[0], "status", StatusHelpercs.Order_Status_Arr);

            BLL.shoppingCart cbll = new BLL.shoppingCart();
            ds.Tables[0].Columns.Add("goodsHtml");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                StringBuilder goodsHtml = new StringBuilder();
                DataTable cartdt = cbll.GetList("orderId=" + ds.Tables[0].Rows[i]["id"].ToString()).Tables[0];
                foreach (DataRow dr in cartdt.Rows)
                {
                    goodsHtml.AppendFormat("<img height='35px' class='order-goods' src='{0}' />", dr["goodsPic"]);
                }
                ds.Tables[0].Rows[i]["goodsHtml"] = goodsHtml.ToString();
            }

            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

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
    public partial class goodsStands : AdminPage
    {
        hm.BLL.goodsStandPrice bll = new hm.BLL.goodsStandPrice();
        BLL.goodsStand sbll = new BLL.goodsStand();
        BLL.goods gbll = new BLL.goods();
        public string goodsId = "", stand1 = "", stand2 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    goodsId = Request.QueryString["id"];
                }
                if (Request.QueryString["act"] == null)
                {
                    BindData();
                }
            }
            if (RequsetAjax("add"))
            {
                try
                {
                    string goodsId = Request.Form["goodsId"].ToString();
                    string standsValue = Request.Form["standsValue"].ToString();
                    string marketPrice = Request.Form["marketPrice"].ToString();
                    string storePrice = Request.Form["storePrice"].ToString();
                    string buyScore = Request.Form["buyScore"].ToString();
                    string stock = Request.Form["stock"].ToString();
                    string orders = Request.Form["orders"].ToString();

                    string stand1 = standsValue.Split(',')[0];
                    string stand2 = standsValue.Split(',')[1];

                    Model.goodsStandPrice model = new Model.goodsStandPrice();
                    model.goodsId = int.Parse(goodsId);
                    model.standId = int.Parse(stand1);
                    model.standSecondId = int.Parse(stand2);
                    model.standThirdId = 0;
                    model.marketPrice = decimal.Parse(marketPrice);
                    model.storePrice = decimal.Parse(storePrice);
                    model.buyScore = int.Parse(buyScore);
                    model.stock = int.Parse(stock);
                    model.orders = int.Parse(orders);
                    bll.Add(model);

                    //SKU商品
                    Model.goods gmodel = gbll.GetModel(int.Parse(goodsId));
                    gmodel.isSku = 1;
                    gbll.Update(gmodel);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editshow"))
            {
                //编辑显示
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.goodsStandPrice model = bll.GetModel(int.Parse(id));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"stand1\":\"" + model.standId + "\",\"stand2\":\"" + model.standSecondId + "\",\"marketPrice\":\"" + model.marketPrice + "\",\"storePrice\":\"" + model.storePrice + "\",\"buyScore\":\"" + model.buyScore + "\",\"stock\":\"" + model.stock + "\",\"orders\":\"" + model.orders + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                try
                {
                    string id = Request.Form["id"].ToString();
                    string standsValue = Request.Form["standsValue"].ToString();
                    string marketPrice = Request.Form["marketPrice"].ToString();
                    string storePrice = Request.Form["storePrice"].ToString();
                    string buyScore = Request.Form["buyScore"].ToString();
                    string stock = Request.Form["stock"].ToString();
                    string orders = Request.Form["orders"].ToString();

                    string stand1 = standsValue.Split(',')[0];
                    string stand2 = standsValue.Split(',')[1];

                    Model.goodsStandPrice model = bll.GetModel(int.Parse(id));
                    model.standId = int.Parse(stand1);
                    model.standSecondId = int.Parse(stand2);
                    model.marketPrice = decimal.Parse(marketPrice);
                    model.storePrice = decimal.Parse(storePrice);
                    model.buyScore = int.Parse(buyScore);
                    model.stock = int.Parse(stock);
                    model.orders = int.Parse(orders);
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //删除
                try
                {
                    string id = Request.Form["id"].ToString();
                    bll.Delete(int.Parse(id));

                    string goodsId = Request.Form["goodsId"].ToString();
                    //SKU商品
                    if (bll.GetList("goodsId=" + goodsId).Tables[0].Rows.Count == 0)
                    {
                        Model.goods gmodel = gbll.GetModel(int.Parse(goodsId));
                        gmodel.isSku = 0;
                        gbll.Update(gmodel);
                    }
                    
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
                    Model.goodsStandPrice model = bll.GetModel(int.Parse(id));
                    model.orders = int.Parse(orders);
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }

            if (RequsetAjax("showSecond"))
            {
                try
                {
                    string id = Request.Form["id"].ToString();
                    StringBuilder sb = new StringBuilder();
                    DataTable dt = sbll.GetList("parentId="+id).Tables[0];
                    sb.Append("<option value='0'>请选择</option>");
                    foreach (DataRow dr in dt.Rows)
                    {
                        sb.AppendFormat("<option value='{0}'>{1}</option>", dr["id"].ToString(), dr["name"].ToString());
                    }
                    stand2 = sb.ToString();

                    Response.Write("{\"status\":1,\"result\":\"" + stand2 + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }
        
        public void BindData()
        {
            string pId = "";
            if (Request.QueryString["id"] != null)
            {
                pId = Request.QueryString["id"];
            }
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" goodsId="+pId);
            
            ds = bll.GetList(strWhere.ToString() + " order by orders asc,id desc");
            ds.Tables[0].Columns.Add("name");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stand1str = sbll.GetModel(int.Parse(ds.Tables[0].Rows[i]["standId"].ToString())).name;
                string stand2str = sbll.GetModel(int.Parse(ds.Tables[0].Rows[i]["standSecondId"].ToString())).name;
                ds.Tables[0].Rows[i]["name"] = stand1str + "-" + stand2str;
            }
           
            rptList.DataSource = ds;
            rptList.DataBind();

            Model.goods gmodel = gbll.GetModel(int.Parse(pId));

            StringBuilder sb = new StringBuilder();
            DataTable dt = sbll.GetList("catId=" + gmodel.catId + " and parentId=0").Tables[0];
            sb.Append("<option value='0'>请选择</option>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.AppendFormat("<option value='{0}'>{1}</option>", dr["id"].ToString(), dr["name"].ToString());
            }
            stand1 = sb.ToString();
        }

    }
}

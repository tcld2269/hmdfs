using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
using System.Data;
using System.Text;

namespace hm.Web.admin.goods
{
    public partial class CatList : AdminPage
    {
        hm.BLL.sysItem bll = new hm.BLL.sysItem();
        public string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["act"] == null)
                {
                    BindData();
                }
            }
            if (RequsetAjax("add"))
            {
                //添加
                try
                {
                    string id = Request.Form["id"].ToString();
                    string itemName = Request.Form["itemName"].ToString();
                    string orders = Request.Form["orders"].ToString();
                    Model.sysItem model = new Model.sysItem();
                    model.sicId = int.Parse(id);
                    model.itemName = itemName;
                    model.itemPath = "";
                    model.back1 = "";
                    model.back2 = "";
                    model.back3 = "";
                    model.back4 = "";
                    model.orders = int.Parse(orders);
                    bll.Add(model);

                    Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"添加失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editshow"))
            {
                //编辑
                try
                {
                    string siId = Request.Form["siId"].ToString();
                    Model.sysItem model = bll.GetModel(int.Parse(siId));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"itemName\":\"" + model.itemName + "\",\"orders\":\"" + model.orders + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                try
                {
                    string siId = Request.Form["siId"].ToString();
                    string itemName = Request.Form["itemName"].ToString();
                    string orders = Request.Form["orders"].ToString();
                    Model.sysItem model = bll.GetModel(int.Parse(siId));
                    model.itemName = itemName;
                    model.itemPath = "";
                    model.back1 = "";
                    model.back2 = "";
                    model.back3 = "";
                    model.back4 = "";
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
                    string catId = Request.Form["catId"].ToString();
                    bll.Delete(int.Parse(catId));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }

        public void BindData()
        {

            string catId = "";
            if (Request.QueryString["id"] != null)
            {
                catId = Request.QueryString["id"];
            }
            id = catId;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("sicId=" + catId);
            ds = bll.GetList(strWhere.ToString() + " order by orders asc");
            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

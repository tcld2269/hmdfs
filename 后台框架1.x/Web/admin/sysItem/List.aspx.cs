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
namespace hm.Web.sysItem
{
    public partial class List : AdminPage
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
                    string itemPath = Request.Form["itemPath"].ToString();
                    string back1 = Request.Form["back1"].ToString();
                    string back2 = Request.Form["back2"].ToString();
                    string back3 = Request.Form["back3"].ToString();
                    string back4 = Request.Form["back4"].ToString();
                    string orders = Request.Form["orders"].ToString();
                    Model.sysItem model = new Model.sysItem();
                    model.sicId = int.Parse(id);
                    model.itemName = itemName;
                    model.itemPath = itemPath;
                    model.back1 = back1;
                    model.back2 = back2;
                    model.back3 = back3;
                    model.back4 = back4;
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

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"itemName\":\"" + model.itemName + "\",\"itemPath\":\"" + model.itemPath + "\",\"back1\":\"" + model.back1 + "\",\"back2\":\"" + model.back2 + "\",\"back3\":\"" + model.back3 + "\",\"back4\":\"" + model.back4 + "\",\"orders\":\"" + model.orders + "\"}");
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
                    string itemPath = Request.Form["itemPath"].ToString();
                    string back1 = Request.Form["back1"].ToString();
                    string back2 = Request.Form["back2"].ToString();
                    string back3 = Request.Form["back3"].ToString();
                    string back4 = Request.Form["back4"].ToString();
                    string orders = Request.Form["orders"].ToString();
                    Model.sysItem model = bll.GetModel(int.Parse(siId));
                    model.itemName = itemName;
                    model.itemPath = itemPath;
                    model.back1 = back1;
                    model.back2 = back2;
                    model.back3 = back3;
                    model.back4 = back4;
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

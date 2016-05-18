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
    public partial class PicList : AdminPage
    {
        hm.BLL.goodsPic bll = new hm.BLL.goodsPic();
        public string goodsId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["act"] == null)
                {
                    BindData();
                }
                string pId = "";
                if (Request.QueryString["id"] != null)
                {
                    goodsId = Request.QueryString["id"];
                }
            }
            if (RequsetAjax("addPic"))
            {
                try
                {
                    string goodsId = Request.Form["goodsId"].ToString();
                    string pic = Request.Form["pic"].ToString();
                    Model.goodsPic model = new Model.goodsPic();
                    model.goodsId = int.Parse(goodsId);
                    model.goodsName = new BLL.goods().GetModel(int.Parse(goodsId)).name;
                    model.picBig = pic;
                    model.picNormal = pic;
                    model.picSmall = pic.Replace(".jpg", "_small.jpg");
                    model.orders = 10;
                    model.isShow = 1;
                    model.isDefault = 0;
                    model.addTime = DateTime.Now;
                    bll.Add(model);

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
                    Model.goodsPic model = bll.GetModel(int.Parse(id));
                    model.orders = int.Parse(orders);
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editDefault"))
            {
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.goodsPic model = bll.GetModel(int.Parse(id));

                    BLL.sqlHelper.ExecSql("update goodsPic set isDefault=0 where goodsId=" + model.goodsId.ToString());

                    model.isDefault = 1;
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

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
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
            strWhere.Append(" goodsId=" + pId);
            
            ds = bll.GetList(strWhere.ToString() + " order by orders asc,id desc");

           
            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

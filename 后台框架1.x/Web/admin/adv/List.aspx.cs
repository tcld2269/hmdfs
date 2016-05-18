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

namespace hm.Web.admin.adv
{
    public partial class List : AdminPage
    {
        hm.BLL.advPos apbll = new hm.BLL.advPos();
        hm.BLL.adv bll = new hm.BLL.adv();
        public string id = "", advPosthtml="";
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
                    string apId = Request.Form["apId"].ToString();
                    string adTitle = Request.Form["adTitle"].ToString();
                    string adUrl = Request.Form["adUrl"].ToString();
                    string adPic = Request.Form["adPic"].ToString();
                    string adRemark = Request.Form["adRemark"].ToString();
                    string adStartDate = Request.Form["adStartDate"].ToString();
                    string adEndDate = Request.Form["adEndDate"].ToString();
                    string adPrice = Request.Form["adPrice"].ToString();
                    string adOrders = Request.Form["adOrders"].ToString();
                    Model.adv model = new Model.adv();
                    model.title = adTitle;
                    model.apId = int.Parse(apId);
                    model.url = adUrl;
                    model.pic = adPic;
                    model.remark = adRemark;
                    if (!string.IsNullOrEmpty(adStartDate))
                    {
                        model.startDate = DateTime.Parse(adStartDate);
                    }
                    if (!string.IsNullOrEmpty(adEndDate))
                    {
                        model.endDate = DateTime.Parse(adEndDate);
                    }
                    model.price = decimal.Parse(adPrice);
                    model.clickCount = 0;
                    model.orders = int.Parse(adOrders);
                    model.addTime = DateTime.Now;
                    model.status = StatusHelpercs.AdvPos_Status_Normal;
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
                    string id = Request.Form["id"].ToString();
                    Model.adv model = bll.GetModel(int.Parse(id));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"apId\":\"" + model.apId + "\",\"title\":\"" + model.title + "\",\"url\":\"" + model.url + "\",\"pic\":\"" + model.pic + "\",\"remark\":\"" + model.remark + "\",\"startDate\":\"" + model.startDate + "\",\"endDate\":\"" + model.endDate + "\",\"price\":\"" + model.price + "\",\"orders\":\"" + model.orders + "\"}");
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
                    string apId = Request.Form["apId"].ToString();
                    string adTitle = Request.Form["adTitle"].ToString();
                    string adUrl = Request.Form["adUrl"].ToString();
                    string adPic = Request.Form["adPic"].ToString();
                    string adRemark = Request.Form["adRemark"].ToString();
                    string adStartDate = Request.Form["adStartDate"].ToString();
                    string adEndDate = Request.Form["adEndDate"].ToString();
                    string adPrice = Request.Form["adPrice"].ToString();
                    string adOrders = Request.Form["adOrders"].ToString();
                    Model.adv model = bll.GetModel(int.Parse(id));
                    model.title = adTitle;
                    model.apId = int.Parse(apId);
                    model.url = adUrl;
                    model.pic = adPic;
                    model.remark = adRemark;
                    if (!string.IsNullOrEmpty(adStartDate))
                    {
                        model.startDate = DateTime.Parse(adStartDate);
                    }
                    if (!string.IsNullOrEmpty(adEndDate))
                    {
                        model.endDate = DateTime.Parse(adEndDate);
                    }
                    model.price = decimal.Parse(adPrice);
                    model.orders = int.Parse(adOrders);
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
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("1=1");
            ds = bll.GetList(strWhere.ToString() + " order by id desc");
            rptList.DataSource = ds;
            rptList.DataBind();

            StringBuilder sbAp = new StringBuilder();
            DataTable dt0 = apbll.GetList("status="+StatusHelpercs.AdvPos_Status_Normal+" order by id desc").Tables[0];
            foreach (DataRow dr0 in dt0.Rows)
            {
                sbAp.AppendFormat("<option value=\"{0}\" hassubinfo=\"true\">{1}</option>", dr0["id"].ToString(), dr0["name"].ToString());
            }
            advPosthtml = sbAp.ToString();
        }

    }
}

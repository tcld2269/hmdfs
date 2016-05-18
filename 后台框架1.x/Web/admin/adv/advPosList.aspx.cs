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
    public partial class advPosList : AdminPage
    {
        hm.BLL.advPos bll = new hm.BLL.advPos();
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
                    string apName = Request.Form["apName"].ToString();
                    string apWidth = Request.Form["apWidth"].ToString();
                    string apHeight = Request.Form["apHeight"].ToString();
                    string apSummary = Request.Form["apSummary"].ToString();
                    string apTemp = Request.Form["apTemp"].ToString();
                    Model.advPos model = new Model.advPos();
                    model.name = apName;
                    model.width = apWidth;
                    model.height = apHeight;
                    model.summary = apSummary;
                    model.template = apTemp;
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
                    Model.advPos model = bll.GetModel(int.Parse(id));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"name\":\"" + model.name + "\",\"width\":\"" + model.width + "\",\"height\":\"" + model.height + "\",\"summary\":\"" + model.summary + "\",\"template\":\"" + model.template + "\"}");
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
                    string apName = Request.Form["apName"].ToString();
                    string apWidth = Request.Form["apWidth"].ToString();
                    string apHeight = Request.Form["apHeight"].ToString();
                    string apSummary = Request.Form["apSummary"].ToString();
                    string apTemp = Request.Form["apTemp"].ToString();
                    Model.advPos model = bll.GetModel(int.Parse(id));
                    model.name = apName;
                    model.width = apWidth;
                    model.height = apHeight;
                    model.summary = apSummary;
                    model.template = apTemp;
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
        }

    }
}

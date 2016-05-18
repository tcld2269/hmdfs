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
namespace hm.Web.sysItemCategory
{
    public partial class List : AdminPage
    {
        
		hm.BLL.sysItemCategory bll = new hm.BLL.sysItemCategory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
            if (RequsetAjax("add"))
            {
                //添加
                try
                {
                    string innerName = Request.Form["innerName"].ToString();
                    string catName = Request.Form["catName"].ToString();
                    Model.sysItemCategory model = new Model.sysItemCategory();
                    model.innerName = innerName;
                    model.catName = catName;
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
                    string catId = Request.Form["catId"].ToString();
                    Model.sysItemCategory model = bll.GetModel(int.Parse(catId));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"innerName\":\"" + model.innerName + "\",\"catName\":\"" + model.catName + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                try
                {
                    string catId = Request.Form["catId"].ToString();
                    string innerName = Request.Form["innerName"].ToString();
                    string catName = Request.Form["catName"].ToString();
                    Model.sysItemCategory model = bll.GetModel(int.Parse(catId));
                    model.innerName = innerName;
                    model.catName = catName;
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
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("");
            ds = bll.GetList(strWhere.ToString());
            rptList.DataSource = ds;
            rptList.DataBind();
        }
    }
}

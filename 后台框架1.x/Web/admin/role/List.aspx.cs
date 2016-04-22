using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web.admin.role
{
    public partial class List : AdminPage
    {
        hm.BLL.role bll = new hm.BLL.role();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataTable dt = bll.GetList("roleId<>1").Tables[0];
                rptList.DataSource = dt;
                rptList.DataBind();
            }
            if (RequsetAjax("add"))
            {
                //添加
                try
                {
                    string roleName = Request.Form["roleName"].ToString();
                    Model.role model = new Model.role();
                    model.roleName = roleName;
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
                    string roleId = Request.Form["roleId"].ToString();
                    Model.role model = bll.GetModel(int.Parse(roleId));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"roleName\":\"" + model.roleName + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                try
                {
                    string roleId = Request.Form["roleId"].ToString();
                    string roleName = Request.Form["roleName"].ToString();
                    Model.role model = bll.GetModel(int.Parse(roleId));
                    model.roleName = roleName;
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //编辑
                try
                {
                    string roleId = Request.Form["roleId"].ToString();
                    bll.Delete(int.Parse(roleId));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }
    }
}
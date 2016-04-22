using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;
using System.Data;
using System.Text;

namespace hm.Web.admin.dept
{
    public partial class List : AdminPage
    {
        hm.BLL.dept bll = new hm.BLL.dept();
        public string menuhtml = "", addhtml = "", edithtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindMenuTree();
            }

            if (RequsetAjax("edit"))
            {
                int deptId = int.Parse(Request.Form["deptId"].ToString());
                Model.dept model = bll.GetModel(deptId);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\",\"deptId\":\"" + model.deptId + "\",\"deptName\":\"" + model.deptName + "\",\"parentId\":\"" + model.parentId + "\"}");
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                int deptId = int.Parse(Request.Form["deptId"].ToString());
                string deptName = Request.Form["deptName"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.dept model = bll.GetModel(deptId);
                model.parentId = int.Parse(parentId);
                model.deptName = deptName;
                bll.Update(model);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\"}");
                Response.End();
            }
            if (RequsetAjax("add"))
            {
                //添加
                string deptName = Request.Form["deptName"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.dept model = new Model.dept();
                model.parentId = int.Parse(parentId);
                model.deptName = deptName;
                model.userId = 0;
                model.manager = "";
                bll.Add(model);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //删除
                int deptId = int.Parse(Request.Form["deptId"].ToString());
                bll.Delete(deptId);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }
            
        }

        private void bindMenuTree()
        {
            StringBuilder sbMenu = new StringBuilder();
            StringBuilder sbEdit = new StringBuilder();
            DataTable dt0 = bll.GetList("parentId=0").Tables[0];
            foreach (DataRow dr0 in dt0.Rows)
            {
                sbMenu.Append("{ text: \"" + dr0["deptName"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr0["deptId"].ToString() + "\"]");
                DataTable dt1 = bll.GetList("parentId=" + dr0["deptId"].ToString() + "").Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    sbMenu.Append(",nodes:[");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        sbMenu.Append("{ text: \"" + dr1["deptName"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr1["deptId"].ToString() + "\"] },");
                    }
                    sbMenu.Remove(sbMenu.Length - 1, 1);
                    sbMenu.Append("]");
                }
                
                sbMenu.Append("},");

                sbEdit.AppendFormat("<option value=\"{0}\" hassubinfo=\"true\">{1}</option>", dr0["deptId"].ToString(), dr0["deptName"].ToString());
            }
            sbMenu.Remove(sbMenu.Length - 1, 1);
            menuhtml = sbMenu.ToString();
            edithtml = sbEdit.ToString();
        }
    }
}
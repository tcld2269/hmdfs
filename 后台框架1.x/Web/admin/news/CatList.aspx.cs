using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace hm.Web.admin.news
{
    public partial class CatList : AdminPage
    {
        hm.BLL.newsCat bll = new hm.BLL.newsCat();
        public string menuhtml = "", addhtml = "", edithtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindMenuTree();
            }

            if (RequsetAjax("edit"))
            {
                int catId = int.Parse(Request.Form["catId"].ToString());
                Model.newsCat model = bll.GetModel(catId);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\",\"catId\":\"" + model.catId + "\",\"catName\":\"" + model.catName + "\",\"parentId\":\"" + model.parentId + "\"}");
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                int catId = int.Parse(Request.Form["catId"].ToString());
                string catName = Request.Form["catName"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.newsCat model = bll.GetModel(catId);
                model.parentId = int.Parse(parentId);
                model.catName = catName;
                bll.Update(model);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\"}");
                Response.End();
            }
            if (RequsetAjax("add"))
            {
                //添加
                string catName = Request.Form["catName"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.newsCat model = new Model.newsCat();
                model.parentId = int.Parse(parentId);
                model.catName = catName;
                model.type = 1;
                model.orders = 1;
                bll.Add(model);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //删除
                int catId = int.Parse(Request.Form["catId"].ToString());
                bll.Delete(catId);

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
                sbMenu.Append("{ text: \"" + dr0["catName"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr0["catId"].ToString() + "\"]");
                DataTable dt1 = bll.GetList("parentId=" + dr0["catId"].ToString() + "").Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    sbMenu.Append(",nodes:[");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        sbMenu.Append("{ text: \"" + dr1["catName"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr1["catId"].ToString() + "\"] },");
                    }
                    sbMenu.Remove(sbMenu.Length - 1, 1);
                    sbMenu.Append("]");
                }

                sbMenu.Append("},");

                sbEdit.AppendFormat("<option value=\"{0}\" hassubinfo=\"true\">{1}</option>", dr0["catId"].ToString(), dr0["catName"].ToString());
            }
            sbMenu.Remove(sbMenu.Length - 1, 1);
            menuhtml = sbMenu.ToString();
            edithtml = sbEdit.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;
using System.Data;
using System.Text;

namespace hm.Web.admin.menu
{
    public partial class List : AdminPage
    {
        hm.BLL.menu bll = new hm.BLL.menu();
        public string menuhtml = "", addhtml = "", edithtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindMenuTree();
            }

            if (RequsetAjax("edit"))
            {
                int menuId = int.Parse(Request.Form["menuid"].ToString());
                Model.menu model = bll.GetModel(menuId);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\",\"menuId\":\"" + model.menuId + "\",\"menuName\":\"" + model.menuName + "\",\"parentId\":\"" + model.parentId + "\",\"orders\":\"" + model.orders + "\",\"url\":\"" + model.url + "\"}");
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                int menuId = int.Parse(Request.Form["menuid"].ToString());
                string menuName = Request.Form["menuname"].ToString();
                string menuOrder = Request.Form["menuorder"].ToString();
                string menuUrl = Request.Form["menuurl"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.menu model = bll.GetModel(menuId);
                model.parentId = int.Parse(parentId);
                model.menuName = menuName;
                model.orders = int.Parse(menuOrder);
                model.url = menuUrl;
                bll.Update(model);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\"}");
                Response.End();
            }
            if (RequsetAjax("add"))
            {
                //添加
                string menuName = Request.Form["menuname"].ToString();
                string menuOrder = Request.Form["menuorder"].ToString();
                string menuUrl = Request.Form["menuurl"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.menu model = new Model.menu();
                model.parentId = int.Parse(parentId);
                model.menuName = menuName;
                model.orders = int.Parse(menuOrder);
                model.url = menuUrl;
                bll.Add(model);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //添加
                int menuId = int.Parse(Request.Form["menuid"].ToString());
                bll.Delete(menuId);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }
            
        }

        private void bindMenuTree()
        {
            StringBuilder sbMenu = new StringBuilder();
            StringBuilder sbEdit = new StringBuilder();
            DataTable dt0 = bll.GetList("parentId=0 order by orders asc").Tables[0];
            foreach (DataRow dr0 in dt0.Rows)
            {
                sbMenu.Append("{ text: \"" + dr0["menuName"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr0["menuId"].ToString() + "\"]");
                DataTable dt1 = bll.GetList("parentId=" + dr0["menuId"].ToString() + " order by orders asc").Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    sbMenu.Append(",nodes:[");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        sbMenu.Append("{ text: \"" + dr1["menuName"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr1["menuId"].ToString() + "\"] },");
                    }
                    sbMenu.Remove(sbMenu.Length - 1, 1);
                    sbMenu.Append("]");
                }
                
                sbMenu.Append("},");

                sbEdit.AppendFormat("<option value=\"{0}\" hassubinfo=\"true\">{1}</option>", dr0["menuId"].ToString(), dr0["menuName"].ToString());
            }
            sbMenu.Remove(sbMenu.Length - 1, 1);
            menuhtml = sbMenu.ToString();
            edithtml = sbEdit.ToString();
        }
    }
}
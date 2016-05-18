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
    public partial class standList : AdminPage
    {
        hm.BLL.goodsStand bll = new hm.BLL.goodsStand();
        public string standhtml = "", addhtml = "", edithtml = "", cathtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddrCat.DataTextField = "itemName";
                ddrCat.DataValueField = "siId";
                ddrCat.DataSource = ClassHelper.GetSystemItem(StatusHelpercs.Default_Item_StoreCat);
                ddrCat.DataBind();
                if (Request.QueryString["catId"] != null)
                {
                    ddrCat.SelectedValue = Request.QueryString["catId"].ToString();
                }
                bindstandTree(ddrCat.SelectedValue);
                bindEditTree(ddrCat.SelectedValue);

            }
            if (RequsetAjax("edit"))
            {
                int standId = int.Parse(Request.Form["standid"].ToString());
                Model.goodsStand model = bll.GetModel(standId);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\",\"id\":\"" + model.id + "\",\"name\":\"" + model.name + "\",\"parentId\":\"" + model.parentId + "\",\"orders\":\"" + model.orders + "\"}");
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                int standId = int.Parse(Request.Form["standid"].ToString());
                string name = Request.Form["standname"].ToString();
                string standOrder = Request.Form["standorder"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.goodsStand model = bll.GetModel(standId);
                model.parentId = int.Parse(parentId);
                model.name = name;
                model.orders = int.Parse(standOrder);
                model.path = "";
                bll.Update(model);

                Response.Write("{\"status\":1,\"msg\":\"修改成功！\"}");
                Response.End();
            }
            if (RequsetAjax("add"))
            {
                //添加
                string catId = Request.Form["catId"].ToString();
                string name = Request.Form["standname"].ToString();
                string standOrder = Request.Form["standorder"].ToString();
                string parentId = Request.Form["parentId"].ToString();

                Model.goodsStand model = new Model.goodsStand();
                model.catId = int.Parse(catId);
                model.parentId = int.Parse(parentId);
                model.name = name;
                model.orders = int.Parse(standOrder);
                model.path = "";
                bll.Add(model);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //
                int standId = int.Parse(Request.Form["standid"].ToString());
                bll.Delete(standId);

                Response.Write("{\"status\":1,\"msg\":\"添加成功！\"}");
                Response.End();
            }

        }

        private string bindstandTree(string catId)
        {
            StringBuilder sbstand = new StringBuilder();
            DataTable dt0 = bll.GetList("catId=" + catId + " and parentId=0 order by orders asc").Tables[0];
            foreach (DataRow dr0 in dt0.Rows)
            {
                sbstand.Append("{ text: \"" + dr0["name"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr0["id"].ToString() + "\"]");
                DataTable dt1 = bll.GetList("parentId=" + dr0["id"].ToString() + " order by orders asc").Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    sbstand.Append(",nodes:[");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        sbstand.Append("{ text: \"" + dr1["name"].ToString() + "\", href: \"#parent1\", tags: [\"" + dr1["id"].ToString() + "\"] },");
                    }
                    sbstand.Remove(sbstand.Length - 1, 1);
                    sbstand.Append("]");
                }

                sbstand.Append("},");

            }
            if (!string.IsNullOrEmpty(sbstand.ToString()))
            {
                sbstand.Remove(sbstand.Length - 1, 1);
                standhtml = sbstand.ToString();
            }
            return standhtml;
        }
        private string bindEditTree(string catId)
        {
            StringBuilder sbEdit = new StringBuilder();
            DataTable dt0 = bll.GetList("catId=" + catId + " and parentId=0 order by orders asc").Tables[0];
            foreach (DataRow dr0 in dt0.Rows)
            {
                sbEdit.AppendFormat("<option value=\"{0}\" hassubinfo=\"true\">{1}</option>", dr0["id"].ToString(), dr0["name"].ToString());
            }
            edithtml = sbEdit.ToString();
            return edithtml;
        }

        protected void ddrCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindstandTree(ddrCat.SelectedValue);
            bindEditTree(ddrCat.SelectedValue);
        }
    }
}
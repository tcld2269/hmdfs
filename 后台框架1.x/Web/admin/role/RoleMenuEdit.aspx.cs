using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
using System.Collections.Generic;
namespace hm.Web.role
{
    public partial class RoleMenuEdit : Page
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
                if (Request.Params["roleId"] != null && Request.Params["roleId"].Trim() != "")
                {
                    litRoleId.Text = "<input type='hidden' id='roleId' value='" + Request.QueryString["roleId"].ToString() + "' />";
                    BLL.roleMenu rmBll = new BLL.roleMenu();
                    List<Model.roleMenu> list = rmBll.GetModelList("roleId=" + Request.QueryString["roleId"].ToString());
                    if (list.Count > 0)
                    {
                        string idstring = "";
                        foreach (Model.roleMenu menu in list)
                        {
                            idstring += menu.menuId + ",";
                        }
                        string[] ids = idstring.Substring(0, idstring.Length - 1).Split(',');

                        string execString = "";
                        for (int i = 0; i < ids.Length; i++)
                        {
                            execString += "document.getElementById('checkMenu" + ids[i] + "').checked=true;";
                        }
                        this.ClientScript.RegisterStartupScript(this.GetType(), "message", "<script  language='javascript' defer>" + execString + "</script>");
                    }

                }
                StringBuilder sb = new StringBuilder();
                string menuIds = "";
                BLL.menu menuBll = new BLL.menu();
                DataTable dt1 = menuBll.GetList("parentId=0 order by orders").Tables[0];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    sb.Append("<tr style='background-color:#ddd'><td style='background-color:#ddd'><input type='checkbox' id='checkMenu" + dt1.Rows[i]["menuId"].ToString() + "' value='" + dt1.Rows[i]["menuId"].ToString() + "' onclick='checkAll(" + dt1.Rows[i]["menuId"].ToString() + ")'/>" + dt1.Rows[i]["menuname"].ToString() + "</td></tr>");
                    menuIds += dt1.Rows[i]["menuId"].ToString() + ",";
                    DataTable dt2 = menuBll.GetList("parentId=" + dt1.Rows[i]["menuId"].ToString()+" order by orders").Tables[0];
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        sb.Append("<tr><td><input type='checkbox' id='checkMenu" + dt2.Rows[j]["menuId"].ToString() + "' name='menu" + dt1.Rows[i]["menuId"].ToString() + "' value='" + dt2.Rows[j]["menuId"].ToString() + "' onclick='checkParent(" + dt1.Rows[i]["menuId"].ToString() + ")'/>" + dt2.Rows[j]["menuname"].ToString() + "</td></tr>");
                    }
                    
                }
                litMenu.Text = sb.ToString();
                menuIds = menuIds.Substring(0, menuIds.Length - 1);
                litMenuIds.Text = "<input type='hidden' id='menuIds' value='" + menuIds + "' />";
			}
		}
    }
}

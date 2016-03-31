using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;
using System.Data;
using System.Text;

namespace hm.Web.Controls
{
    public partial class left1 : System.Web.UI.Page
    {
        public string menuHtml;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                HttpCookie roleId = Request.Cookies["roleId"];
                if (null == roleId)
                {
                    MessageBox.ShowAndRedirects(this, "ss", "../Login.aspx");
                }
                else
                {
                    string isAdmin = Request.Cookies["isAdmin"].Value;
                    StringBuilder sb = new StringBuilder();
                    BLL.menu mBll = new BLL.menu();
                    string sql1 = " parentId=0 ";
                    if (isAdmin != "1")
                    {
                        sql1 += " and menuId in (select menuId from [roleMenu] where roleId=" + roleId.Value + ") ";
                    }
                    sql1 += " order by orders asc";
                    DataTable dt = mBll.GetList(sql1).Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<h1 class=\"type\"><a href=\"javascript:void(0)\">" + dt.Rows[i]["menuName"].ToString() + "</a></h1>");
                        sb.Append("<div class=\"content\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td><img src=\"../images/menu_topline.gif\" width=\"182\" height=\"5\" /></td></tr></table><ul class=\"MM\">");

                        string sql2 = " parentId=" + dt.Rows[i]["menuId"].ToString();
                        if (isAdmin != "1")
                        {
                            sql2 += " and menuId in (select menuId from [roleMenu] where roleId=" + roleId.Value + ") ";
                        }
                        sql2 += " order by orders asc";
                        DataTable dt2 = mBll.GetList(sql2).Tables[0];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            sb.Append("<li><a href=\""+ dt2.Rows[j]["url"].ToString() +"\" target=\"main\">" + dt2.Rows[j]["menuName"].ToString() + "</a></li>");
                        }
                        sb.Append("</ul></div>");
                    }
                    menuHtml = sb.ToString();
                }

               
            }
        }
    }
}
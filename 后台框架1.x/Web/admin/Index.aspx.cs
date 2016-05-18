using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.Common;
using System.Text;
using Maticsoft.Common.DEncrypt;

namespace hm.Web.admin
{
    public partial class Index : AdminPage
    {
        public string menuHtml;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId)))
                {
                    MessageBox.ShowAndRedirects(this, "请重新登录！", "/admin/Login.aspx");
                }
                else
                {
                    bindMenu();
                    litAvatar.Text = "<img id=\"user_avatar\" alt=\"image\" width=\"64px\" height=\"64px\" class=\"img-circle\" src=\"" + Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_Avatar) + "\" />";
                    litUserInfo.Text = "<span class=\"block m-t-xs\"><strong class=\"font-bold\">" + DESEncrypt.Decrypt(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_TrueName)) + "</strong></span><span class=\"text-muted text-xs block\">" + DESEncrypt.Decrypt(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_RoleName)) + "<b class=\"caret\"></b></span>";
                    litTopinfo.Text = "今天是" + DateTime.Now.ToString("yyyy年MM月dd日") + Common.CommonHelper.getDayOfWeek(DateTime.Now) + " 欢迎您！<span>您上次的登录日期是：" + Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_LastLoginTime) + "</span>";

                    BLL.message mbll = new BLL.message();
                    int unreadCount = mbll.GetList("receiverId=" + Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId) + " and status=" + StatusHelpercs.Message_Status_UnRead).Tables[0].Rows.Count;
                    int readCount = mbll.GetList("receiverId=" + Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId) + " and status=" + StatusHelpercs.Message_Status_Read).Tables[0].Rows.Count;
                    litMessageCount.Text = unreadCount.ToString();
                    litUnReadCount.Text = unreadCount.ToString();
                    litReadCount.Text = readCount.ToString();
                    
                }
            }
        }

        

        private void bindMenu()
        {
            string roleId = Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_RoleId);
            string isAdmin = Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_IsAdmin);
            StringBuilder sb = new StringBuilder();
            BLL.menu mBll = new BLL.menu();
            string sql1 = " parentId=0 ";
            if (isAdmin != "1")
            {
                sql1 += " and menuId in (select menuId from [roleMenu] where roleId=" + roleId + ") ";
            }
            sql1 += " order by orders asc";
            DataTable dt = mBll.GetList(sql1).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sql2 = " parentId=" + dt.Rows[i]["menuId"].ToString();
                if (isAdmin != "1")
                {
                    sql2 += " and menuId in (select menuId from [roleMenu] where roleId=" + roleId + ") ";
                }
                sql2 += " order by orders asc";
                DataTable dt2 = mBll.GetList(sql2).Tables[0];
                //有下级菜单
                if (dt.Rows.Count > 0)
                {
                    sb.AppendFormat("<li><a href=\"#\"><i class=\"fa fa-home\"></i><span class=\"nav-label\">{0}</span><span class=\"fa arrow\"></span></a>", dt.Rows[i]["menuName"].ToString());
                    sb.Append("<ul class=\"nav nav-second-level\">");
                }
                else
                {
                    sb.AppendFormat("<li><a href=\"{0}\"><i class=\"fa fa-home\"></i><span class=\"nav-label\">{1}</span></a>", dt.Rows[i]["url"].ToString(), dt.Rows[i]["menuName"].ToString());
                }
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    sb.AppendFormat("<li><a class=\"J_menuItem\" href=\"{0}\">{1}</a></li>", dt2.Rows[j]["url"].ToString(), dt2.Rows[j]["menuName"].ToString());
                }
                if (dt.Rows.Count > 0)
                {
                    sb.Append("</ul>");
                }
                sb.Append("</li>");
            }
            menuHtml = sb.ToString();
        }
    }
}
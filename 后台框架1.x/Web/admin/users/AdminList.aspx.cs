using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace hm.Web.admin.users
{
    public partial class AdminList : System.Web.UI.Page
    {
        hm.BLL.users bll = new hm.BLL.users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append("roleId=2 ");
                if (Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_IsAdmin) != "1")
                {
                    BLL.dept pBll = new BLL.dept();
                    strWhere.Append(" and deptId in (" + pBll.GetAllChild(int.Parse(Request.Cookies["deptId"].Value)) + ") ");
                }
                rptList.DataSource = bll.GetList(strWhere.ToString() + " order by addTime desc");
                rptList.DataBind();
            }
        }
    }
}
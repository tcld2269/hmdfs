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
namespace hm.Web.users
{
    public partial class UserList : AdminPage
    {

        public string roleName = "";
        
		hm.BLL.users bll = new hm.BLL.users();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }   
        public void BindData()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            string roleId = "";
            if (Request.QueryString["roleId"] != null)
            {
                roleId = Request.QueryString["roleId"].ToString();
                string rId = "";
                if (roleId.IndexOf(',') >= 0)
                {
                    rId = roleId.Split(',')[0];
                }
                else
                {
                    rId = roleId;
                }
                try
                {
                    roleName = new BLL.role().GetModel(int.Parse(rId)).roleName;
                }
                catch { }
                strWhere.Append("roleid in (" + roleId + ")");
            }
            else
            {
                strWhere.Append("roleid not in (1,2)");
            }

            
            //if (txtKeyword.Text.Trim() != "")
            //{      
            //    strWhere.AppendFormat(" and userName like '%{0}%'", txtKeyword.Text.Trim());
            //}            
            ds = bll.GetList(strWhere.ToString());
            rptList.DataSource = ds;
            rptList.DataBind();
        }
    }
}

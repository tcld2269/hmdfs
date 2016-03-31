using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web.Controls
{
    public partial class main : AdminPage
    {
        BLL.users uBll = new BLL.users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDate();


            }
        }
        private void bindDate()
        {
            string dateString = "";
            int hour = int.Parse(DateTime.Now.ToString("HH"));
            if (hour >= 9 & hour <= 10)
            {
                dateString = "上午";
            }
            else if (hour >= 5 & hour <= 8)
            {
                dateString = "早晨";
            }
            else if (hour >= 11 & hour <= 13)
            {
                dateString = "中午";
            }
            else if (hour >= 13 & hour <= 17)
            {
                dateString = "下午";
            }
            else if (hour >= 18 & hour <= 23)
            {
                dateString = "晚上";
            }
            else if (hour >= 0 & hour <= 4)
            {
                dateString = "凌晨";
            }

            HttpCookie cookie = Request.Cookies["trueName"];
            if (null == cookie)
            {
                Response.Write("<script language=javascript>window.parent.location='../Login.aspx';</script>");//
            }
            else
            {
                litLogInfo.Text = dateString + "好，<span style='color:red'>" + Maticsoft.Common.DEncrypt.DESEncrypt.Decrypt(cookie.Value) + "</span>，欢迎登陆系统！";
            }
        }
    }
}
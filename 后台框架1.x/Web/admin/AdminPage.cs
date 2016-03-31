using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Maticsoft.Common;

namespace hm.Web
{
    public class AdminPage : Page
    {
        public AdminPage()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["userId"];
            if (null == cookie || String.IsNullOrEmpty(cookie.Value))
            {
                HttpContext.Current.Response.Write("<script language=javascript>alert('登录已失效,请重新登录！');window.parent.location='../Login.aspx';</script>");//
            }
        }
    }
}
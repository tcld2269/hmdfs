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
            if (string.IsNullOrEmpty(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId)))
            {
                HttpContext.Current.Response.Write("<script language=javascript>alert('登录已失效,请重新登录！');window.parent.location='/admin/Login.aspx';</script>");//
            }
        }
        /// <summary>
        /// 接受ajax请求并验证
        /// </summary>
        /// <param name="act"></param>
        /// <returns></returns>
        public bool RequsetAjax(string act)
        {
            if (Request.QueryString["act"] != null)
            {
                if (act == Request.QueryString["act"].ToString())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
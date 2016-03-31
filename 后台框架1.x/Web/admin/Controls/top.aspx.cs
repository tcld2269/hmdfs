using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hm.Web.Controls
{
    public partial class top1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["trueName"];
                if (null == cookie)
                {
                    Response.Write("<script language=javascript>window.parent.location='../Login.aspx';</script>");//
                }
                else
                {
                    litUserName.Text = Maticsoft.Common.DEncrypt.DESEncrypt.Decrypt(cookie.Value);
                }
            }
        }
    }
}
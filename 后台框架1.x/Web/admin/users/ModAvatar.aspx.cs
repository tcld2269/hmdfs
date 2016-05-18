using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hm.Web.admin.users
{
    public partial class ModAvatar : AdminPage
    {
        BLL.users bll = new BLL.users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RequsetAjax("mod"))
            {
                //编辑
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.users model = bll.GetModel(int.Parse(Common.Cookie.GetValue(StatusHelpercs.Cookie_Admin_UserId)));
                    model.avatar_small = "/img/avatar/avatar" + id + ".png";
                    model.avatar_big = "/img/avatar/avatar" + id + ".png";
                    bll.Update(model);

                    Common.Cookie.SetObject(StatusHelpercs.Cookie_Admin_Avatar, model.avatar_small);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
        }
    }
}
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
    public partial class SaveRoleMenu : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["ids"] != null && Request.Params["ids"].Trim() != "")
                {
                    if (Request.Params["roleId"] != null && Request.Params["roleId"].Trim() != "")
                    {
                        hm.BLL.roleMenu bll = new hm.BLL.roleMenu();
                        int roleId = int.Parse(Request.QueryString["roleId"].ToString());
                        bll.DeleteByRoleId(roleId);
                        string ids = Request.QueryString["ids"].ToString();
                        if (ids.Split(',').Length > 0)
                        {
                            ids = ids.Substring(0, ids.Length - 1);
                            string[] idArray = ids.Split(',');
                            for (int i = 0; i < idArray.Length; i++)
                            {
                                List<Model.roleMenu> list = bll.GetModelList("roleId=" + roleId + " and menuId=" + idArray[i]);
                                if (list.Count == 0)
                                {
                                    hm.Model.roleMenu model = new Model.roleMenu();
                                    model.roleId = roleId;
                                    model.menuId = int.Parse(idArray[i]);
                                    bll.Add(model);
                                }
                            }
                        }
                        Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "RoleMenuEdit.aspx?roleId=" + roleId + "&id=" + Request.QueryString["ids"].ToString());
                    }
                    
                }
            }
        }
    }
}

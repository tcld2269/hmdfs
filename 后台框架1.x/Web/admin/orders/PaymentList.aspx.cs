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
namespace hm.Web.orders
{
    public partial class PaymentList : AdminPage
    {
        hm.BLL.shoppingPayment bll = new hm.BLL.shoppingPayment();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
            if (RequsetAjax("add"))
            {
                try
                {
                    string name = Request.Form["name"].ToString();
                    string code = Request.Form["code"].ToString();
                    string summary = Request.Form["summary"].ToString();
                    string returnUrl = Request.Form["returnUrl"].ToString();
                    string notifyUrl = Request.Form["notifyUrl"].ToString();
                    string gateUrl = Request.Form["gateUrl"].ToString();
                    string filePath = Request.Form["filePath"].ToString();
                    string parm1 = Request.Form["parm1"].ToString();
                    string parm2 = Request.Form["parm2"].ToString();
                    string parm3 = Request.Form["parm3"].ToString();
                    string parm4 = Request.Form["parm4"].ToString();
                    string parm5 = Request.Form["parm5"].ToString();
                    Model.shoppingPayment model = new Model.shoppingPayment();
                    model.name = name;
                    model.code = code;
                    model.summary = summary;
                    model.returnUrl = returnUrl;
                    model.notifyUrl = notifyUrl;
                    model.ico = "";
                    model.gateUrl = gateUrl;
                    model.filePath = filePath;
                    model.parm1 = parm1;
                    model.parm2 = parm2;
                    model.parm3 = parm3;
                    model.parm4 = parm4;
                    model.parm5 = parm5;
                    model.status = StatusHelpercs.Payment_Status_Normal;
                    bll.Add(model);
                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editshow"))
            {
                //编辑
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.shoppingPayment model = bll.GetModel(int.Parse(id));

                    Response.Write("{\"status\":1,\"msg\":\"成功！\",\"name\":\"" + model.name + "\",\"code\":\"" + model.code + "\",\"summary\":\"" + model.summary + "\",\"notifyUrl\":\"" + model.notifyUrl + "\",\"returnUrl\":\"" + model.returnUrl + "\",\"gateUrl\":\"" + model.gateUrl + "\",\"filePath\":\"" + model.filePath + "\",\"parm1\":\"" + model.parm1 + "\",\"parm2\":\"" + model.parm2 + "\",\"parm3\":\"" + model.parm3 + "\",\"parm4\":\"" + model.parm4 + "\",\"parm5\":\"" + model.parm5 + "\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editsubmit"))
            {
                //编辑
                try
                {
                    string id = Request.Form["id"].ToString();
                    string name = Request.Form["name"].ToString();
                    string code = Request.Form["code"].ToString();
                    string summary = Request.Form["summary"].ToString();
                    string returnUrl = Request.Form["returnUrl"].ToString();
                    string notifyUrl = Request.Form["notifyUrl"].ToString();
                    string gateUrl = Request.Form["gateUrl"].ToString();
                    string filePath = Request.Form["filePath"].ToString();
                    string parm1 = Request.Form["parm1"].ToString();
                    string parm2 = Request.Form["parm2"].ToString();
                    string parm3 = Request.Form["parm3"].ToString();
                    string parm4 = Request.Form["parm4"].ToString();
                    string parm5 = Request.Form["parm5"].ToString();
                    Model.shoppingPayment model = bll.GetModel(int.Parse(id));
                    model.name = name;
                    model.code = code;
                    model.summary = summary;
                    model.returnUrl = returnUrl;
                    model.notifyUrl = notifyUrl;
                    model.gateUrl = gateUrl;
                    model.filePath = filePath;
                    model.parm1 = parm1;
                    model.parm2 = parm2;
                    model.parm3 = parm3;
                    model.parm4 = parm4;
                    model.parm5 = parm5;
                    bll.Update(model);

                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("del"))
            {
                //删除
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.shoppingPayment model = bll.GetModel(int.Parse(id));
                    if (model.status == StatusHelpercs.Payment_Status_Lock)
                    {
                        bll.Delete(int.Parse(id));
                        Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                    }
                    else
                    {
                        Response.Write("{\"status\":0,\"msg\":\"请先停用！\"}");
                    }
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            if (RequsetAjax("editStatus"))
            {
                try
                {
                    string id = Request.Form["id"].ToString();
                    Model.shoppingPayment model = bll.GetModel(int.Parse(id));
                    if (model.status == StatusHelpercs.Payment_Status_Lock)
                    {
                        model.status = StatusHelpercs.Payment_Status_Normal;
                    }
                    else
                    {
                        model.status = StatusHelpercs.Payment_Status_Lock;
                    }
                    bll.Update(model);
                    Response.Write("{\"status\":1,\"msg\":\"成功！\"}");
                }
                catch { Response.Write("{\"status\":0,\"msg\":\"失败！\"}"); }
                Response.End();
            }
            
        }
        
        public void BindData()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            ds = bll.GetList("");
            Common.CommonHelper.AddDtColumns(ds.Tables[0], "status", StatusHelpercs.Payment_Status_Arr);
            

            rptList.DataSource = ds;
            rptList.DataBind();
        }

    }
}

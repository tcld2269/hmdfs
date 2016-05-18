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
namespace hm.Web.common
{
    public partial class MessageShow : Page
    {        
        public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
                    int id = (Convert.ToInt32(strid));
                    ShowInfo(id);
				}
			}
		}

        private void ShowInfo(int id)
        {
            hm.BLL.message bll = new hm.BLL.message();
            hm.Model.message model = bll.GetModel(id);
            model.status = StatusHelpercs.Message_Status_Read;
            bll.Update(model);
            lblId.Text = model.id.ToString();
            lblTitle.Text = model.title;
            lblSender.Text = model.senderName;
            lblReceiver.Text = model.receiverName;
            lblRemark.Text = model.remark;
            lblAddTime.Text = model.addTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            lblType.Text = StatusHelpercs.Message_Type_Arr[model.type.Value];
            lblStatus.Text = StatusHelpercs.Message_Status_Arr[model.status.Value];

        }


    }
}

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
namespace hm.Web.newsCat
{
    public partial class Modify : Page
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int catId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(catId);
				}
			}
		}
			
	private void ShowInfo(int catId)
	{
		hm.BLL.newsCat bll=new hm.BLL.newsCat();
		hm.Model.newsCat model=bll.GetModel(catId);

        bindCat();
		this.ddlCat.SelectedValue=model.parentId.ToString();
		this.txtcatName.Text=model.catName;
		this.txtorders.Text=model.orders.ToString();


	}

    private void bindCat()
    {

        ddlCat.Items.Clear();
        BLL.newsCat bll = new BLL.newsCat();
        ddlCat.Items.Add(new ListItem("作为根菜单", "0"));
        DataTable dt1 = bll.GetList("parentId=0 ").Tables[0];
        for (int i = 0; i < dt1.Rows.Count; i++)
        {
            ddlCat.Items.Add(new ListItem("—" + dt1.Rows[i]["catName"].ToString(), dt1.Rows[i]["catId"].ToString()));
        }
        
    }

		public void btnSave_Click(object sender, EventArgs e)
		{

            string strErr = "";
            if (this.txtcatName.Text.Trim().Length == 0)
            {
                strErr += "分类名称不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtorders.Text))
            {
                strErr += "排序格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int parentId = int.Parse(ddlCat.SelectedValue);
            string catName = this.txtcatName.Text;
            int type = 1;
            int orders = int.Parse(this.txtorders.Text);

            hm.BLL.newsCat bll = new hm.BLL.newsCat();
            hm.Model.newsCat model = bll.GetModel((Convert.ToInt32(Request.Params["id"])));
			model.parentId=parentId;
			model.catName=catName;
			model.type=type;
			model.orders=orders;

			
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }


    }
}

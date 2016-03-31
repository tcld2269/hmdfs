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
namespace hm.Web.menu
{
    public partial class List : Page
    {
		hm.BLL.menu bll = new hm.BLL.menu();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindParentMenuAdd();
                BindData();
            }
        }

        public void BindData()
        {
            DataSet ds = new DataSet();

            ds = bll.GetList("1=1 order by orders asc");

            string[] arr = { "parentId", "menuName", "menuId" };
            Common.CommonHelper.AddTopTreeViewNodes(TreeView1, ds.Tables[0], arr);
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode t = this.TreeView1.SelectedNode;
            int deptId = int.Parse(t.Value);
            Model.menu model = bll.GetModel(deptId);

            bindParentMenu();
            lblpId.Text = model.menuId.ToString();
            ddrParent.SelectedValue = model.parentId.ToString();
            txtMenuName.Text = model.menuName;
            txtOrder.Text=model.orders.ToString();
            txtUrl.Text=model.url;

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtMenuNameAdd.Text.Trim().Length == 0)
            {
                strErr += "名称不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtOrderAdd.Text))
            {
                strErr += "排序格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string placeName = this.txtMenuNameAdd.Text;
            int parentId = int.Parse(this.ddrMenuAdd.SelectedValue);
            int orders = int.Parse(txtOrderAdd.Text);
            string url=txtUrlAdd.Text;

            hm.Model.menu model = new hm.Model.menu();
            model.menuName = placeName;
            model.parentId = parentId;
            model.orders=orders;
            model.url=url;

            bll.Add(model);
            bindParentMenuAdd();
            BindData();
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            string id = lblpId.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(this, "请选择修改的菜单！");
                return;
            }
            string strErr = "";
            if (this.txtMenuName.Text.Trim().Length == 0)
            {
                strErr += "名称不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtOrderAdd.Text))
            {
                strErr += "排序格式错误！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string placeName = this.txtMenuName.Text;
            int parentId = int.Parse(this.ddrParent.SelectedValue);
            int orders = int.Parse(txtOrder.Text);
            string url = txtUrl.Text;

            hm.Model.menu model = bll.GetModel(int.Parse(lblpId.Text));
            model.menuName = placeName;
            model.parentId = parentId;
            model.orders = orders;
            model.url = url;
            bll.Update(model);
            bindParentMenuAdd();
            BindData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lblpId.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(this, "请选择要删除的菜单！");
                return;
            }
            bll.Delete(int.Parse(id));
            lblpId.Text = "";
            txtMenuName.Text = "";
            ddrParent.SelectedValue = "0";
            txtOrder.Text = "";
            txtUrl.Text = "";
            bindParentMenuAdd();
            BindData();
        }

        private void bindParentMenuAdd()
        {
            ddrMenuAdd.Items.Clear();
            BLL.menu deptBll = new BLL.menu();
            DataTable dt = deptBll.GetList("parentId=0   order by orders asc").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddrMenuAdd.Items.Add(new ListItem(dt.Rows[i]["menuName"].ToString(), dt.Rows[i]["menuId"].ToString()));
            }
            ddrMenuAdd.Items.Insert(0, new ListItem("根菜单", "0"));
        }
        private void bindParentMenu()
        {
            ddrParent.Items.Clear();
            BLL.menu deptBll = new BLL.menu();
            DataTable dt = deptBll.GetList("parentId=0 order by orders asc").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddrParent.Items.Add(new ListItem(dt.Rows[i]["menuName"].ToString(), dt.Rows[i]["menuId"].ToString()));
            }
            ddrParent.Items.Insert(0, new ListItem("根菜单", "0"));
        }
    }
}

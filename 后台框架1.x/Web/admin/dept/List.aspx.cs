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
namespace hm.Web.place
{
    public partial class List : Page
    {



        hm.BLL.dept bll = new hm.BLL.dept();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtDept.Text.Trim().Length == 0)
            {
                strErr += "名称不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string placeName = this.txtDept.Text;
            int parentId = int.Parse(this.ddrDept.SelectedValue);

            hm.Model.dept model = new hm.Model.dept();
            model.deptName = placeName;
            model.parentId = parentId;


            bll.Add(model);
            BindData();
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            string id = lblpId.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(this,"请选择修改的部门！");
                return;
            }
            string strErr = "";
            if (this.txtDeptName.Text.Trim().Length == 0)
            {
                strErr += "名称不能为空！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string placeName = this.txtDeptName.Text;
            int parentId = int.Parse(this.ddrParent.SelectedValue);
            hm.Model.dept model = bll.GetModel(int.Parse(lblpId.Text));
            model.deptName = placeName;
            model.parentId = parentId;
            bll.Update(model);
            BindData();
        }
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lblpId.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(this, "请选择要删除的部门！");
                return;
            }
            bll.Delete(int.Parse(id));
            lblpId.Text = "";
            txtDeptName.Text = "";
            ddrParent.SelectedValue = "0";
            BindData();
        }
        
        #region gridView
                        
        public void BindData()
        {
            #region
            //if (!Context.User.Identity.IsAuthenticated)
            //{
            //    return;
            //}
            //AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            //if (user.HasPermissionID(PermId_Modify))
            //{
            //    gridView.Columns[6].Visible = true;
            //}
            //if (user.HasPermissionID(PermId_Delete))
            //{
            //    gridView.Columns[7].Visible = true;
            //}
            #endregion
            bindDept();
            DataSet ds = new DataSet();
            ds = bll.GetList("");

            string[] arr = { "parentId", "deptName", "deptId" };
            Common.CommonHelper.AddTopTreeViewNodes(TreeView1, ds.Tables[0], arr);
        }

        

        #endregion

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode t = this.TreeView1.SelectedNode;
            int deptId = int.Parse(t.Value);
            Model.dept model = bll.GetModel(deptId);

            bindDeptList();
            lblpId.Text = model.deptId.ToString();
            ddrParent.SelectedValue = model.parentId.ToString();
            txtDeptName.Text = model.deptName;

        }

        private void bindDept()
        {
            ClassHelper.AddDeptPaeent(ddrDept);
        }
        private void bindDeptList()
        {
            ClassHelper.AddDeptPaeent(ddrParent);
        }





    }
}

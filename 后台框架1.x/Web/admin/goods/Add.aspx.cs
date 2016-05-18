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
namespace hm.Web.goods
{
    public partial class Add : AdminPage
    {
        hm.BLL.goods bll = new hm.BLL.goods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddrCat.DataTextField = "itemName";
                ddrCat.DataValueField = "siId";
                ddrCat.DataSource = ClassHelper.GetSystemItem(StatusHelpercs.Default_Item_StoreCat);
                ddrCat.DataBind();
                ddrCat.Items.Insert(0, new ListItem("请选择", "0"));

                int count = bll.GetList("SUBSTRING(sn,5,6)=convert(char(10),getdate(),12)").Tables[0].Rows.Count + 1;
                txtSn.Text = "PN" + DateTime.Now.ToString("yyyyMMdd") + count;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="商品名称不能为空！\\n";	
			}
            if (this.ddrCat.SelectedValue == "0")
            {
                strErr += "请选择所属分类！\\n";
            }

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}

            string picSmall = "", picNormal = "", picBig = "";
            if (flPic.HasFile)
            {
                string result = Common.CommonHelper.Imageupload(flPic, "goods");
                if (result.IndexOf('|') > -1)
                {
                    picSmall = result.Split('|')[3];
                    picNormal = result.Split('|')[2];
                    picBig = result.Split('|')[1];
                }
            }
            int isShow = 0, isNew = 0, isRecommend = 0, isHot = 0;
            foreach (ListItem item in cbl.Items)
            {
                if (item.Value == "show" & item.Selected == true)
                {
                    isShow = 1;
                }
                if (item.Value == "new" & item.Selected == true)
                {
                    isNew = 1;
                }
                if (item.Value == "recommend" & item.Selected == true)
                {
                    isRecommend = 1;
                }
                if (item.Value == "hot" & item.Selected == true)
                {
                    isHot = 1;
                }
            }
            

            hm.Model.goods model = new hm.Model.goods();
            model.storeId = 1;
            model.storeName = "测试商家";
            model.name = txtTitle.Text;
            model.sn = txtSn.Text;
            model.catId = int.Parse(this.ddrCat.SelectedValue);
            model.catName = this.ddrCat.Items[ddrCat.SelectedIndex].Text; 
            model.marketPrice = decimal.Parse(txtMarketPrice.Text);
            model.storePrice = decimal.Parse(txtStorePrice.Text);
            model.freightPrice = decimal.Parse(txtFreightPrice.Text);
            model.buyScore = int.Parse(txtBuyScore.Text);
            model.giveScore = 0;///TODO 赠送积分待完善
            model.picSmall = picSmall;
            model.picNormal = picNormal;
            model.picBig = picBig;
            model.summary = txtSummary.Text;
            model.remark = content.Value;
            model.favCount = 0;
            model.stock = int.Parse(txtStock.Text);
            model.clickNum = 0;
            model.saleNum = 0;
            model.isSku = 0;
            model.isShow = isShow;
            model.isNew = isNew;
            model.isRecommend = isRecommend;
            model.isHot = isHot;
            model.addTime = DateTime.Now;
            model.updateTime = DateTime.Now;
            model.orders = 1000;
            model.status = StatusHelpercs.Goods_Status_Normal;

			int goodsId = bll.Add(model);
            //录入默认图片
            BLL.goodsPic pbll = new BLL.goodsPic();
            Model.goodsPic gmodel = new Model.goodsPic();
            gmodel.goodsId = goodsId;
            gmodel.goodsName = txtTitle.Text;
            gmodel.picBig = picBig;
            gmodel.picNormal = picNormal;
            gmodel.picSmall = picSmall;
            gmodel.orders = 1;
            gmodel.isShow = 1;
            gmodel.isDefault = 1;
            gmodel.addTime = DateTime.Now;
            pbll.Add(gmodel);


            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}

    }
}

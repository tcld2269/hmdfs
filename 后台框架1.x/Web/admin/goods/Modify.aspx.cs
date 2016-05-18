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
    public partial class Modify : AdminPage
    {
        hm.BLL.goods bll = new hm.BLL.goods();
        public string remark = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    lblId.Text = Request.Params["id"].ToString();

                    BLL.newsCat catBll = new BLL.newsCat();
                    ddrCat.DataTextField = "itemName";
                    ddrCat.DataValueField = "siId";
                    ddrCat.DataSource = ClassHelper.GetSystemItem(StatusHelpercs.Default_Item_StoreCat);
                    ddrCat.DataBind();
                    ddrCat.Items.Insert(0, new ListItem("请选择", "0"));


                    Model.goods model = bll.GetModel(int.Parse(lblId.Text));
                    txtTitle.Text = model.name;
                    txtSn.Text = model.sn;
                    ddrCat.SelectedValue = model.catId.ToString();
                    txtMarketPrice.Text = model.marketPrice.ToString();
                    txtStorePrice.Text = model.storePrice.ToString();
                    txtFreightPrice.Text = model.freightPrice.ToString();
                    txtBuyScore.Text = model.buyScore.ToString();
                    txtStock.Text = model.stock.ToString();
                    litPicShow.Text = "<a target='_blank' href='" + model.picNormal + "'><img height='35px' src='" + model.picSmall + "'/></a>";
                    lblPicSmall.Text = model.picSmall;
                    lblPicNormal.Text = model.picNormal;
                    lblPicBig.Text = model.picBig;
                    txtSummary.Text = model.summary;
                    remark = model.remark;

                    foreach (ListItem item in cbl.Items)
                    {
                        if (item.Value == "show")
                        {
                            if (model.isShow.Value == 1)
                            {
                                item.Selected = true;
                            }
                        }
                        if (item.Value == "new")
                        {
                            if (model.isNew.Value == 1)
                            {
                                item.Selected = true;
                            }
                        }
                        if (item.Value == "recommend")
                        {
                            if (model.isRecommend.Value == 1)
                            {
                                item.Selected = true;
                            }
                        }
                        if (item.Value == "hot")
                        {
                            if (model.isHot.Value == 1)
                            {
                                item.Selected = true;
                            }
                        }
                    }

                }
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

            string picSmall = lblPicSmall.Text, picNormal = lblPicNormal.Text, picBig = lblPicBig.Text;
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
            

            hm.Model.goods model = bll.GetModel(int.Parse(lblId.Text));
            model.name = txtTitle.Text;
            model.sn = txtSn.Text;
            model.catId = int.Parse(this.ddrCat.SelectedValue);
            model.catName = this.ddrCat.Items[ddrCat.SelectedIndex].Text; 
            model.marketPrice = decimal.Parse(txtMarketPrice.Text);
            model.storePrice = decimal.Parse(txtStorePrice.Text);
            model.freightPrice = decimal.Parse(txtFreightPrice.Text);
            model.buyScore = int.Parse(txtBuyScore.Text);
            model.picSmall = picSmall;
            model.picNormal = picNormal;
            model.picBig = picBig;
            model.summary = txtSummary.Text;
            model.remark = content.Value;
            model.stock = int.Parse(txtStock.Text);
            model.isShow = isShow;
            model.isNew = isNew;
            model.isRecommend = isRecommend;
            model.isHot = isHot;
            model.updateTime = DateTime.Now;
            
			bll.Update(model);

            if (flPic.HasFile)
            {
                try
                {
                    //修改默认图片
                    BLL.goodsPic pbll = new BLL.goodsPic();
                    Model.goodsPic gmodel = pbll.GetModelList("goodsId=" + lblId.Text + " and isDefault=1")[0];
                    gmodel.picBig = picBig;
                    gmodel.picNormal = picNormal;
                    gmodel.picSmall = picSmall;
                    gmodel.addTime = DateTime.Now;
                    pbll.Update(gmodel);
                }
                catch { }
            }

            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}

    }
}

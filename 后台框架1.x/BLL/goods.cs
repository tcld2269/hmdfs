using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// goods
	/// </summary>
	public partial class goods
	{
		private readonly hm.DAL.goods dal=new hm.DAL.goods();
		public goods()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.goods model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.goods model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.goods GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.goods GetModelByCache(int id)
		{
			
			string CacheKey = "goodsModel-" + id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.goods)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.goods> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.goods> DataTableToList(DataTable dt)
		{
			List<hm.Model.goods> modelList = new List<hm.Model.goods>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.goods model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.goods();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["storeId"]!=null && dt.Rows[n]["storeId"].ToString()!="")
					{
						model.storeId=int.Parse(dt.Rows[n]["storeId"].ToString());
					}
					if(dt.Rows[n]["storeName"]!=null && dt.Rows[n]["storeName"].ToString()!="")
					{
					model.storeName=dt.Rows[n]["storeName"].ToString();
					}
					if(dt.Rows[n]["name"]!=null && dt.Rows[n]["name"].ToString()!="")
					{
					model.name=dt.Rows[n]["name"].ToString();
					}
					if(dt.Rows[n]["sn"]!=null && dt.Rows[n]["sn"].ToString()!="")
					{
					model.sn=dt.Rows[n]["sn"].ToString();
					}
					if(dt.Rows[n]["catId"]!=null && dt.Rows[n]["catId"].ToString()!="")
					{
						model.catId=int.Parse(dt.Rows[n]["catId"].ToString());
					}
					if(dt.Rows[n]["catName"]!=null && dt.Rows[n]["catName"].ToString()!="")
					{
					model.catName=dt.Rows[n]["catName"].ToString();
					}
					if(dt.Rows[n]["marketPrice"]!=null && dt.Rows[n]["marketPrice"].ToString()!="")
					{
						model.marketPrice=decimal.Parse(dt.Rows[n]["marketPrice"].ToString());
					}
					if(dt.Rows[n]["storePrice"]!=null && dt.Rows[n]["storePrice"].ToString()!="")
					{
						model.storePrice=decimal.Parse(dt.Rows[n]["storePrice"].ToString());
					}
					if(dt.Rows[n]["freightPrice"]!=null && dt.Rows[n]["freightPrice"].ToString()!="")
					{
						model.freightPrice=decimal.Parse(dt.Rows[n]["freightPrice"].ToString());
					}
					if(dt.Rows[n]["buyScore"]!=null && dt.Rows[n]["buyScore"].ToString()!="")
					{
						model.buyScore=int.Parse(dt.Rows[n]["buyScore"].ToString());
					}
					if(dt.Rows[n]["giveScore"]!=null && dt.Rows[n]["giveScore"].ToString()!="")
					{
						model.giveScore=int.Parse(dt.Rows[n]["giveScore"].ToString());
					}
					if(dt.Rows[n]["picSmall"]!=null && dt.Rows[n]["picSmall"].ToString()!="")
					{
					model.picSmall=dt.Rows[n]["picSmall"].ToString();
					}
					if(dt.Rows[n]["picNormal"]!=null && dt.Rows[n]["picNormal"].ToString()!="")
					{
					model.picNormal=dt.Rows[n]["picNormal"].ToString();
					}
					if(dt.Rows[n]["picBig"]!=null && dt.Rows[n]["picBig"].ToString()!="")
					{
					model.picBig=dt.Rows[n]["picBig"].ToString();
					}
					if(dt.Rows[n]["summary"]!=null && dt.Rows[n]["summary"].ToString()!="")
					{
					model.summary=dt.Rows[n]["summary"].ToString();
					}
					if(dt.Rows[n]["remark"]!=null && dt.Rows[n]["remark"].ToString()!="")
					{
					model.remark=dt.Rows[n]["remark"].ToString();
					}
					if(dt.Rows[n]["favCount"]!=null && dt.Rows[n]["favCount"].ToString()!="")
					{
						model.favCount=int.Parse(dt.Rows[n]["favCount"].ToString());
					}
					if(dt.Rows[n]["stock"]!=null && dt.Rows[n]["stock"].ToString()!="")
					{
						model.stock=int.Parse(dt.Rows[n]["stock"].ToString());
					}
					if(dt.Rows[n]["clickNum"]!=null && dt.Rows[n]["clickNum"].ToString()!="")
					{
						model.clickNum=int.Parse(dt.Rows[n]["clickNum"].ToString());
					}
					if(dt.Rows[n]["saleNum"]!=null && dt.Rows[n]["saleNum"].ToString()!="")
					{
						model.saleNum=int.Parse(dt.Rows[n]["saleNum"].ToString());
					}
					if(dt.Rows[n]["isSku"]!=null && dt.Rows[n]["isSku"].ToString()!="")
					{
						model.isSku=int.Parse(dt.Rows[n]["isSku"].ToString());
					}
					if(dt.Rows[n]["isShow"]!=null && dt.Rows[n]["isShow"].ToString()!="")
					{
						model.isShow=int.Parse(dt.Rows[n]["isShow"].ToString());
					}
					if(dt.Rows[n]["isNew"]!=null && dt.Rows[n]["isNew"].ToString()!="")
					{
						model.isNew=int.Parse(dt.Rows[n]["isNew"].ToString());
					}
					if(dt.Rows[n]["isRecommend"]!=null && dt.Rows[n]["isRecommend"].ToString()!="")
					{
						model.isRecommend=int.Parse(dt.Rows[n]["isRecommend"].ToString());
					}
					if(dt.Rows[n]["isHot"]!=null && dt.Rows[n]["isHot"].ToString()!="")
					{
						model.isHot=int.Parse(dt.Rows[n]["isHot"].ToString());
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
					}
					if(dt.Rows[n]["updateTime"]!=null && dt.Rows[n]["updateTime"].ToString()!="")
					{
						model.updateTime=DateTime.Parse(dt.Rows[n]["updateTime"].ToString());
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
					}
					if(dt.Rows[n]["status"]!=null && dt.Rows[n]["status"].ToString()!="")
					{
						model.status=int.Parse(dt.Rows[n]["status"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}


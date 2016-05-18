using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// goodsStandPrice
	/// </summary>
	public partial class goodsStandPrice
	{
		private readonly hm.DAL.goodsStandPrice dal=new hm.DAL.goodsStandPrice();
		public goodsStandPrice()
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
		public int  Add(hm.Model.goodsStandPrice model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.goodsStandPrice model)
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
		public hm.Model.goodsStandPrice GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.goodsStandPrice GetModelByCache(int id)
		{
			
			string CacheKey = "goodsStandPriceModel-" + id;
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
			return (hm.Model.goodsStandPrice)objModel;
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
		public List<hm.Model.goodsStandPrice> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.goodsStandPrice> DataTableToList(DataTable dt)
		{
			List<hm.Model.goodsStandPrice> modelList = new List<hm.Model.goodsStandPrice>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.goodsStandPrice model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.goodsStandPrice();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["goodsId"]!=null && dt.Rows[n]["goodsId"].ToString()!="")
					{
						model.goodsId=int.Parse(dt.Rows[n]["goodsId"].ToString());
					}
					if(dt.Rows[n]["standId"]!=null && dt.Rows[n]["standId"].ToString()!="")
					{
						model.standId=int.Parse(dt.Rows[n]["standId"].ToString());
					}
					if(dt.Rows[n]["standSecondId"]!=null && dt.Rows[n]["standSecondId"].ToString()!="")
					{
						model.standSecondId=int.Parse(dt.Rows[n]["standSecondId"].ToString());
					}
					if(dt.Rows[n]["standThirdId"]!=null && dt.Rows[n]["standThirdId"].ToString()!="")
					{
						model.standThirdId=int.Parse(dt.Rows[n]["standThirdId"].ToString());
					}
					if(dt.Rows[n]["marketPrice"]!=null && dt.Rows[n]["marketPrice"].ToString()!="")
					{
						model.marketPrice=decimal.Parse(dt.Rows[n]["marketPrice"].ToString());
					}
					if(dt.Rows[n]["storePrice"]!=null && dt.Rows[n]["storePrice"].ToString()!="")
					{
						model.storePrice=decimal.Parse(dt.Rows[n]["storePrice"].ToString());
					}
					if(dt.Rows[n]["buyScore"]!=null && dt.Rows[n]["buyScore"].ToString()!="")
					{
						model.buyScore=int.Parse(dt.Rows[n]["buyScore"].ToString());
					}
					if(dt.Rows[n]["stock"]!=null && dt.Rows[n]["stock"].ToString()!="")
					{
						model.stock=int.Parse(dt.Rows[n]["stock"].ToString());
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
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


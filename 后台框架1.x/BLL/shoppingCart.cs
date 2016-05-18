using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// shoppingCart
	/// </summary>
	public partial class shoppingCart
	{
		private readonly hm.DAL.shoppingCart dal=new hm.DAL.shoppingCart();
		public shoppingCart()
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
		public int  Add(hm.Model.shoppingCart model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.shoppingCart model)
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
		public hm.Model.shoppingCart GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.shoppingCart GetModelByCache(int id)
		{
			
			string CacheKey = "shoppingCartModel-" + id;
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
			return (hm.Model.shoppingCart)objModel;
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
		public List<hm.Model.shoppingCart> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.shoppingCart> DataTableToList(DataTable dt)
		{
			List<hm.Model.shoppingCart> modelList = new List<hm.Model.shoppingCart>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.shoppingCart model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.shoppingCart();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["orderId"]!=null && dt.Rows[n]["orderId"].ToString()!="")
					{
						model.orderId=int.Parse(dt.Rows[n]["orderId"].ToString());
					}
					if(dt.Rows[n]["userId"]!=null && dt.Rows[n]["userId"].ToString()!="")
					{
						model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
					}
					if(dt.Rows[n]["userName"]!=null && dt.Rows[n]["userName"].ToString()!="")
					{
					model.userName=dt.Rows[n]["userName"].ToString();
					}
					if(dt.Rows[n]["storeId"]!=null && dt.Rows[n]["storeId"].ToString()!="")
					{
						model.storeId=int.Parse(dt.Rows[n]["storeId"].ToString());
					}
					if(dt.Rows[n]["storeName"]!=null && dt.Rows[n]["storeName"].ToString()!="")
					{
					model.storeName=dt.Rows[n]["storeName"].ToString();
					}
					if(dt.Rows[n]["goodsId"]!=null && dt.Rows[n]["goodsId"].ToString()!="")
					{
						model.goodsId=int.Parse(dt.Rows[n]["goodsId"].ToString());
					}
					if(dt.Rows[n]["goodsName"]!=null && dt.Rows[n]["goodsName"].ToString()!="")
					{
					model.goodsName=dt.Rows[n]["goodsName"].ToString();
					}
					if(dt.Rows[n]["goodsNum"]!=null && dt.Rows[n]["goodsNum"].ToString()!="")
					{
						model.goodsNum=int.Parse(dt.Rows[n]["goodsNum"].ToString());
					}
					if(dt.Rows[n]["goodsPrice"]!=null && dt.Rows[n]["goodsPrice"].ToString()!="")
					{
						model.goodsPrice=decimal.Parse(dt.Rows[n]["goodsPrice"].ToString());
					}
					if(dt.Rows[n]["goodsPic"]!=null && dt.Rows[n]["goodsPic"].ToString()!="")
					{
					model.goodsPic=dt.Rows[n]["goodsPic"].ToString();
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
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


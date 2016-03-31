using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// sysItem
	/// </summary>
	public partial class sysItem
	{
		private readonly hm.DAL.sysItem dal=new hm.DAL.sysItem();
		public sysItem()
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
		public bool Exists(int siId)
		{
			return dal.Exists(siId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.sysItem model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.sysItem model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int siId)
		{
			
			return dal.Delete(siId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string siIdlist )
		{
			return dal.DeleteList(siIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.sysItem GetModel(int siId)
		{
			
			return dal.GetModel(siId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.sysItem GetModelByCache(int siId)
		{
			
			string CacheKey = "sysItemModel-" + siId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(siId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.sysItem)objModel;
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
		public List<hm.Model.sysItem> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.sysItem> DataTableToList(DataTable dt)
		{
			List<hm.Model.sysItem> modelList = new List<hm.Model.sysItem>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.sysItem model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.sysItem();
					if(dt.Rows[n]["siId"]!=null && dt.Rows[n]["siId"].ToString()!="")
					{
						model.siId=int.Parse(dt.Rows[n]["siId"].ToString());
					}
					if(dt.Rows[n]["sicId"]!=null && dt.Rows[n]["sicId"].ToString()!="")
					{
						model.sicId=int.Parse(dt.Rows[n]["sicId"].ToString());
					}
					if(dt.Rows[n]["itemName"]!=null && dt.Rows[n]["itemName"].ToString()!="")
					{
					model.itemName=dt.Rows[n]["itemName"].ToString();
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

        public int DeleteByCatId(int catId)
        {
            return dal.DeleteByCatId(catId);
        }

		#endregion  Method
	}
}


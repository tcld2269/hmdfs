using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// sysItemCategory
	/// </summary>
	public partial class sysItemCategory
	{
		private readonly hm.DAL.sysItemCategory dal=new hm.DAL.sysItemCategory();
		public sysItemCategory()
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
		public bool Exists(int sicId)
		{
			return dal.Exists(sicId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.sysItemCategory model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.sysItemCategory model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int sicId)
		{
			
			return dal.Delete(sicId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string sicIdlist )
		{
			return dal.DeleteList(sicIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.sysItemCategory GetModel(int sicId)
		{
			
			return dal.GetModel(sicId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.sysItemCategory GetModelByCache(int sicId)
		{
			
			string CacheKey = "sysItemCategoryModel-" + sicId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(sicId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.sysItemCategory)objModel;
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
		public List<hm.Model.sysItemCategory> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.sysItemCategory> DataTableToList(DataTable dt)
		{
			List<hm.Model.sysItemCategory> modelList = new List<hm.Model.sysItemCategory>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.sysItemCategory model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.sysItemCategory();
					if(dt.Rows[n]["sicId"]!=null && dt.Rows[n]["sicId"].ToString()!="")
					{
						model.sicId=int.Parse(dt.Rows[n]["sicId"].ToString());
					}
					if(dt.Rows[n]["innerName"]!=null && dt.Rows[n]["innerName"].ToString()!="")
					{
					model.innerName=dt.Rows[n]["innerName"].ToString();
					}
					if(dt.Rows[n]["catName"]!=null && dt.Rows[n]["catName"].ToString()!="")
					{
					model.catName=dt.Rows[n]["catName"].ToString();
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


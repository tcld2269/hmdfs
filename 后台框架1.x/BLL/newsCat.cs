using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// newsCat
	/// </summary>
	public partial class newsCat
	{
		private readonly hm.DAL.newsCat dal=new hm.DAL.newsCat();
		public newsCat()
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
		public bool Exists(int catId)
		{
			return dal.Exists(catId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.newsCat model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.newsCat model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int catId)
		{
			
			return dal.Delete(catId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string catIdlist )
		{
			return dal.DeleteList(catIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.newsCat GetModel(int catId)
		{
			
			return dal.GetModel(catId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.newsCat GetModelByCache(int catId)
		{
			
			string CacheKey = "newsCatModel-" + catId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(catId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.newsCat)objModel;
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
		public List<hm.Model.newsCat> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.newsCat> DataTableToList(DataTable dt)
		{
			List<hm.Model.newsCat> modelList = new List<hm.Model.newsCat>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.newsCat model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.newsCat();
					if(dt.Rows[n]["catId"]!=null && dt.Rows[n]["catId"].ToString()!="")
					{
						model.catId=int.Parse(dt.Rows[n]["catId"].ToString());
					}
					if(dt.Rows[n]["parentId"]!=null && dt.Rows[n]["parentId"].ToString()!="")
					{
						model.parentId=int.Parse(dt.Rows[n]["parentId"].ToString());
					}
					if(dt.Rows[n]["catName"]!=null && dt.Rows[n]["catName"].ToString()!="")
					{
					model.catName=dt.Rows[n]["catName"].ToString();
					}
					if(dt.Rows[n]["type"]!=null && dt.Rows[n]["type"].ToString()!="")
					{
						model.type=int.Parse(dt.Rows[n]["type"].ToString());
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
					}
					if(dt.Rows[n]["backCol"]!=null && dt.Rows[n]["backCol"].ToString()!="")
					{
					model.backCol=dt.Rows[n]["backCol"].ToString();
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


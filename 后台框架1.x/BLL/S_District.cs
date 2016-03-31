using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// S_District
	/// </summary>
	public partial class S_District
	{
		private readonly hm.DAL.S_District dal=new hm.DAL.S_District();
		public S_District()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long DistrictID)
		{
			return dal.Exists(DistrictID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(hm.Model.S_District model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.S_District model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long DistrictID)
		{
			
			return dal.Delete(DistrictID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string DistrictIDlist )
		{
			return dal.DeleteList(DistrictIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.S_District GetModel(long DistrictID)
		{
			
			return dal.GetModel(DistrictID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.S_District GetModelByCache(long DistrictID)
		{
			
			string CacheKey = "S_DistrictModel-" + DistrictID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DistrictID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.S_District)objModel;
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
		public List<hm.Model.S_District> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.S_District> DataTableToList(DataTable dt)
		{
			List<hm.Model.S_District> modelList = new List<hm.Model.S_District>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.S_District model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.S_District();
					if(dt.Rows[n]["DistrictID"]!=null && dt.Rows[n]["DistrictID"].ToString()!="")
					{
						model.DistrictID=long.Parse(dt.Rows[n]["DistrictID"].ToString());
					}
					if(dt.Rows[n]["DistrictName"]!=null && dt.Rows[n]["DistrictName"].ToString()!="")
					{
					model.DistrictName=dt.Rows[n]["DistrictName"].ToString();
					}
					if(dt.Rows[n]["CityID"]!=null && dt.Rows[n]["CityID"].ToString()!="")
					{
						model.CityID=long.Parse(dt.Rows[n]["CityID"].ToString());
					}
					if(dt.Rows[n]["DateCreated"]!=null && dt.Rows[n]["DateCreated"].ToString()!="")
					{
						model.DateCreated=DateTime.Parse(dt.Rows[n]["DateCreated"].ToString());
					}
					if(dt.Rows[n]["DateUpdated"]!=null && dt.Rows[n]["DateUpdated"].ToString()!="")
					{
						model.DateUpdated=DateTime.Parse(dt.Rows[n]["DateUpdated"].ToString());
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


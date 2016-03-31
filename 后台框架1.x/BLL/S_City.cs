using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// S_City
	/// </summary>
	public partial class S_City
	{
		private readonly hm.DAL.S_City dal=new hm.DAL.S_City();
		public S_City()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long CityID)
		{
			return dal.Exists(CityID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(hm.Model.S_City model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.S_City model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long CityID)
		{
			
			return dal.Delete(CityID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CityIDlist )
		{
			return dal.DeleteList(CityIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.S_City GetModel(long CityID)
		{
			
			return dal.GetModel(CityID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.S_City GetModelByCache(long CityID)
		{
			
			string CacheKey = "S_CityModel-" + CityID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CityID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.S_City)objModel;
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
		public List<hm.Model.S_City> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.S_City> DataTableToList(DataTable dt)
		{
			List<hm.Model.S_City> modelList = new List<hm.Model.S_City>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.S_City model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.S_City();
					if(dt.Rows[n]["CityID"]!=null && dt.Rows[n]["CityID"].ToString()!="")
					{
						model.CityID=long.Parse(dt.Rows[n]["CityID"].ToString());
					}
					if(dt.Rows[n]["CityName"]!=null && dt.Rows[n]["CityName"].ToString()!="")
					{
					model.CityName=dt.Rows[n]["CityName"].ToString();
					}
					if(dt.Rows[n]["ZipCode"]!=null && dt.Rows[n]["ZipCode"].ToString()!="")
					{
					model.ZipCode=dt.Rows[n]["ZipCode"].ToString();
					}
					if(dt.Rows[n]["ProvinceID"]!=null && dt.Rows[n]["ProvinceID"].ToString()!="")
					{
						model.ProvinceID=long.Parse(dt.Rows[n]["ProvinceID"].ToString());
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


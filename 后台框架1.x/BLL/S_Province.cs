using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// S_Province
	/// </summary>
	public partial class S_Province
	{
		private readonly hm.DAL.S_Province dal=new hm.DAL.S_Province();
		public S_Province()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ProvinceID)
		{
			return dal.Exists(ProvinceID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(hm.Model.S_Province model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.S_Province model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long ProvinceID)
		{
			
			return dal.Delete(ProvinceID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ProvinceIDlist )
		{
			return dal.DeleteList(ProvinceIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.S_Province GetModel(long ProvinceID)
		{
			
			return dal.GetModel(ProvinceID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.S_Province GetModelByCache(long ProvinceID)
		{
			
			string CacheKey = "S_ProvinceModel-" + ProvinceID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ProvinceID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.S_Province)objModel;
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
		public List<hm.Model.S_Province> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.S_Province> DataTableToList(DataTable dt)
		{
			List<hm.Model.S_Province> modelList = new List<hm.Model.S_Province>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.S_Province model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.S_Province();
					if(dt.Rows[n]["ProvinceID"]!=null && dt.Rows[n]["ProvinceID"].ToString()!="")
					{
						model.ProvinceID=long.Parse(dt.Rows[n]["ProvinceID"].ToString());
					}
					if(dt.Rows[n]["ProvinceName"]!=null && dt.Rows[n]["ProvinceName"].ToString()!="")
					{
					model.ProvinceName=dt.Rows[n]["ProvinceName"].ToString();
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


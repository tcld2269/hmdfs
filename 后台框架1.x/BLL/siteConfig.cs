using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// siteConfig
	/// </summary>
	public partial class siteConfig
	{
		private readonly hm.DAL.siteConfig dal=new hm.DAL.siteConfig();
		public siteConfig()
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
		public int  Add(hm.Model.siteConfig model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.siteConfig model)
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
		public hm.Model.siteConfig GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.siteConfig GetModelByCache(int id)
		{
			
			string CacheKey = "siteConfigModel-" + id;
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
			return (hm.Model.siteConfig)objModel;
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
		public List<hm.Model.siteConfig> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.siteConfig> DataTableToList(DataTable dt)
		{
			List<hm.Model.siteConfig> modelList = new List<hm.Model.siteConfig>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.siteConfig model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.siteConfig();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["name"]!=null && dt.Rows[n]["name"].ToString()!="")
					{
					model.name=dt.Rows[n]["name"].ToString();
					}
					if(dt.Rows[n]["logo"]!=null && dt.Rows[n]["logo"].ToString()!="")
					{
					model.logo=dt.Rows[n]["logo"].ToString();
					}
					if(dt.Rows[n]["seoTitle"]!=null && dt.Rows[n]["seoTitle"].ToString()!="")
					{
					model.seoTitle=dt.Rows[n]["seoTitle"].ToString();
					}
					if(dt.Rows[n]["seoKeywords"]!=null && dt.Rows[n]["seoKeywords"].ToString()!="")
					{
					model.seoKeywords=dt.Rows[n]["seoKeywords"].ToString();
					}
					if(dt.Rows[n]["seoDescription"]!=null && dt.Rows[n]["seoDescription"].ToString()!="")
					{
					model.seoDescription=dt.Rows[n]["seoDescription"].ToString();
					}
					if(dt.Rows[n]["copyright"]!=null && dt.Rows[n]["copyright"].ToString()!="")
					{
					model.copyright=dt.Rows[n]["copyright"].ToString();
					}
					if(dt.Rows[n]["contact"]!=null && dt.Rows[n]["contact"].ToString()!="")
					{
					model.contact=dt.Rows[n]["contact"].ToString();
					}
					if(dt.Rows[n]["email"]!=null && dt.Rows[n]["email"].ToString()!="")
					{
					model.email=dt.Rows[n]["email"].ToString();
					}
					if(dt.Rows[n]["qq"]!=null && dt.Rows[n]["qq"].ToString()!="")
					{
					model.qq=dt.Rows[n]["qq"].ToString();
					}
					if(dt.Rows[n]["phone"]!=null && dt.Rows[n]["phone"].ToString()!="")
					{
					model.phone=dt.Rows[n]["phone"].ToString();
					}
					if(dt.Rows[n]["fax"]!=null && dt.Rows[n]["fax"].ToString()!="")
					{
					model.fax=dt.Rows[n]["fax"].ToString();
					}
					if(dt.Rows[n]["address"]!=null && dt.Rows[n]["address"].ToString()!="")
					{
					model.address=dt.Rows[n]["address"].ToString();
					}
					if(dt.Rows[n]["icp"]!=null && dt.Rows[n]["icp"].ToString()!="")
					{
					model.icp=dt.Rows[n]["icp"].ToString();
					}
					if(dt.Rows[n]["url"]!=null && dt.Rows[n]["url"].ToString()!="")
					{
					model.url=dt.Rows[n]["url"].ToString();
					}
					if(dt.Rows[n]["updateTime"]!=null && dt.Rows[n]["updateTime"].ToString()!="")
					{
						model.updateTime=DateTime.Parse(dt.Rows[n]["updateTime"].ToString());
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


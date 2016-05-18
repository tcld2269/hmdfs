using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// userAddress
	/// </summary>
	public partial class userAddress
	{
		private readonly hm.DAL.userAddress dal=new hm.DAL.userAddress();
		public userAddress()
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
		public int  Add(hm.Model.userAddress model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.userAddress model)
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
		public hm.Model.userAddress GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.userAddress GetModelByCache(int id)
		{
			
			string CacheKey = "userAddressModel-" + id;
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
			return (hm.Model.userAddress)objModel;
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
		public List<hm.Model.userAddress> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.userAddress> DataTableToList(DataTable dt)
		{
			List<hm.Model.userAddress> modelList = new List<hm.Model.userAddress>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.userAddress model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.userAddress();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["userId"]!=null && dt.Rows[n]["userId"].ToString()!="")
					{
						model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
					}
					if(dt.Rows[n]["contacts"]!=null && dt.Rows[n]["contacts"].ToString()!="")
					{
					model.contacts=dt.Rows[n]["contacts"].ToString();
					}
					if(dt.Rows[n]["tel"]!=null && dt.Rows[n]["tel"].ToString()!="")
					{
					model.tel=dt.Rows[n]["tel"].ToString();
					}
					if(dt.Rows[n]["addressNo"]!=null && dt.Rows[n]["addressNo"].ToString()!="")
					{
					model.addressNo=dt.Rows[n]["addressNo"].ToString();
					}
					if(dt.Rows[n]["addressInfo"]!=null && dt.Rows[n]["addressInfo"].ToString()!="")
					{
					model.addressInfo=dt.Rows[n]["addressInfo"].ToString();
					}
					if(dt.Rows[n]["isDefault"]!=null && dt.Rows[n]["isDefault"].ToString()!="")
					{
						model.isDefault=int.Parse(dt.Rows[n]["isDefault"].ToString());
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


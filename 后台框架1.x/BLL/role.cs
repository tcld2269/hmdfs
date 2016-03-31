using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// role
	/// </summary>
	public partial class role
	{
		private readonly hm.DAL.role dal=new hm.DAL.role();
		public role()
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
		public bool Exists(int roleId)
		{
			return dal.Exists(roleId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.role model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.role model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int roleId)
		{
			
			return dal.Delete(roleId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string roleIdlist )
		{
			return dal.DeleteList(roleIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.role GetModel(int roleId)
		{
			
			return dal.GetModel(roleId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.role GetModelByCache(int roleId)
		{
			
			string CacheKey = "roleModel-" + roleId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(roleId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.role)objModel;
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
		public List<hm.Model.role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.role> DataTableToList(DataTable dt)
		{
			List<hm.Model.role> modelList = new List<hm.Model.role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.role();
					if(dt.Rows[n]["roleId"]!=null && dt.Rows[n]["roleId"].ToString()!="")
					{
						model.roleId=int.Parse(dt.Rows[n]["roleId"].ToString());
					}
					if(dt.Rows[n]["roleName"]!=null && dt.Rows[n]["roleName"].ToString()!="")
					{
					model.roleName=dt.Rows[n]["roleName"].ToString();
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


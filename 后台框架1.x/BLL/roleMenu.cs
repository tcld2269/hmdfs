using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// roleMenu
	/// </summary>
	public partial class roleMenu
	{
		private readonly hm.DAL.roleMenu dal=new hm.DAL.roleMenu();
		public roleMenu()
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
		public bool Exists(int rmId)
		{
			return dal.Exists(rmId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.roleMenu model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.roleMenu model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int rmId)
		{
			
			return dal.Delete(rmId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string rmIdlist )
		{
			return dal.DeleteList(rmIdlist );
		}

        public bool DeleteByRoleId(int roleId)
        {

            return dal.DeleteByRoleId(roleId);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.roleMenu GetModel(int rmId)
		{
			
			return dal.GetModel(rmId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.roleMenu GetModelByCache(int rmId)
		{
			
			string CacheKey = "roleMenuModel-" + rmId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(rmId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.roleMenu)objModel;
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
		public List<hm.Model.roleMenu> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.roleMenu> DataTableToList(DataTable dt)
		{
			List<hm.Model.roleMenu> modelList = new List<hm.Model.roleMenu>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.roleMenu model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.roleMenu();
					if(dt.Rows[n]["rmId"]!=null && dt.Rows[n]["rmId"].ToString()!="")
					{
						model.rmId=int.Parse(dt.Rows[n]["rmId"].ToString());
					}
					if(dt.Rows[n]["roleId"]!=null && dt.Rows[n]["roleId"].ToString()!="")
					{
						model.roleId=int.Parse(dt.Rows[n]["roleId"].ToString());
					}
					if(dt.Rows[n]["menuId"]!=null && dt.Rows[n]["menuId"].ToString()!="")
					{
						model.menuId=int.Parse(dt.Rows[n]["menuId"].ToString());
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


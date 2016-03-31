using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// 合同
	/// </summary>
	public partial class menu
	{
		private readonly hm.DAL.menu dal=new hm.DAL.menu();
		public menu()
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
		public bool Exists(int menuId)
		{
			return dal.Exists(menuId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.menu model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.menu model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int menuId)
		{
			
			return dal.Delete(menuId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string menuIdlist )
		{
			return dal.DeleteList(menuIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.menu GetModel(int menuId)
		{
			
			return dal.GetModel(menuId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.menu GetModelByCache(int menuId)
		{
			
			string CacheKey = "menuModel-" + menuId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(menuId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.menu)objModel;
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
		public List<hm.Model.menu> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.menu> DataTableToList(DataTable dt)
		{
			List<hm.Model.menu> modelList = new List<hm.Model.menu>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.menu model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.menu();
					if(dt.Rows[n]["menuId"]!=null && dt.Rows[n]["menuId"].ToString()!="")
					{
						model.menuId=int.Parse(dt.Rows[n]["menuId"].ToString());
					}
					if(dt.Rows[n]["parentId"]!=null && dt.Rows[n]["parentId"].ToString()!="")
					{
						model.parentId=int.Parse(dt.Rows[n]["parentId"].ToString());
					}
					if(dt.Rows[n]["menuName"]!=null && dt.Rows[n]["menuName"].ToString()!="")
					{
					model.menuName=dt.Rows[n]["menuName"].ToString();
					}
					if(dt.Rows[n]["level"]!=null && dt.Rows[n]["level"].ToString()!="")
					{
						model.level=int.Parse(dt.Rows[n]["level"].ToString());
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
					}
					if(dt.Rows[n]["url"]!=null && dt.Rows[n]["url"].ToString()!="")
					{
					model.url=dt.Rows[n]["url"].ToString();
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


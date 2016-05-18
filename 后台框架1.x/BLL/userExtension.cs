using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// userExtension
	/// </summary>
	public partial class userExtension
	{
		private readonly hm.DAL.userExtension dal=new hm.DAL.userExtension();
		public userExtension()
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
		public bool Exists(int userId)
		{
			return dal.Exists(userId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.userExtension model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.userExtension model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userId)
		{
			
			return dal.Delete(userId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string userIdlist )
		{
			return dal.DeleteList(userIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.userExtension GetModel(int userId)
		{
			
			return dal.GetModel(userId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.userExtension GetModelByCache(int userId)
		{
			
			string CacheKey = "userExtensionModel-" + userId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(userId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.userExtension)objModel;
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
		public List<hm.Model.userExtension> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.userExtension> DataTableToList(DataTable dt)
		{
			List<hm.Model.userExtension> modelList = new List<hm.Model.userExtension>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.userExtension model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.userExtension();
					if(dt.Rows[n]["userId"]!=null && dt.Rows[n]["userId"].ToString()!="")
					{
						model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
					}
					if(dt.Rows[n]["ext1"]!=null && dt.Rows[n]["ext1"].ToString()!="")
					{
					model.ext1=dt.Rows[n]["ext1"].ToString();
					}
					if(dt.Rows[n]["ext2"]!=null && dt.Rows[n]["ext2"].ToString()!="")
					{
					model.ext2=dt.Rows[n]["ext2"].ToString();
					}
					if(dt.Rows[n]["ext3"]!=null && dt.Rows[n]["ext3"].ToString()!="")
					{
					model.ext3=dt.Rows[n]["ext3"].ToString();
					}
					if(dt.Rows[n]["ext4"]!=null && dt.Rows[n]["ext4"].ToString()!="")
					{
					model.ext4=dt.Rows[n]["ext4"].ToString();
					}
					if(dt.Rows[n]["ext5"]!=null && dt.Rows[n]["ext5"].ToString()!="")
					{
					model.ext5=dt.Rows[n]["ext5"].ToString();
					}
					if(dt.Rows[n]["ext6"]!=null && dt.Rows[n]["ext6"].ToString()!="")
					{
					model.ext6=dt.Rows[n]["ext6"].ToString();
					}
					if(dt.Rows[n]["ext7"]!=null && dt.Rows[n]["ext7"].ToString()!="")
					{
					model.ext7=dt.Rows[n]["ext7"].ToString();
					}
					if(dt.Rows[n]["ext8"]!=null && dt.Rows[n]["ext8"].ToString()!="")
					{
					model.ext8=dt.Rows[n]["ext8"].ToString();
					}
					if(dt.Rows[n]["ext9"]!=null && dt.Rows[n]["ext9"].ToString()!="")
					{
					model.ext9=dt.Rows[n]["ext9"].ToString();
					}
					if(dt.Rows[n]["ext10"]!=null && dt.Rows[n]["ext10"].ToString()!="")
					{
					model.ext10=dt.Rows[n]["ext10"].ToString();
					}
					if(dt.Rows[n]["ext11"]!=null && dt.Rows[n]["ext11"].ToString()!="")
					{
					model.ext11=dt.Rows[n]["ext11"].ToString();
					}
					if(dt.Rows[n]["ext12"]!=null && dt.Rows[n]["ext12"].ToString()!="")
					{
					model.ext12=dt.Rows[n]["ext12"].ToString();
					}
					if(dt.Rows[n]["ext13"]!=null && dt.Rows[n]["ext13"].ToString()!="")
					{
					model.ext13=dt.Rows[n]["ext13"].ToString();
					}
					if(dt.Rows[n]["ext14"]!=null && dt.Rows[n]["ext14"].ToString()!="")
					{
					model.ext14=dt.Rows[n]["ext14"].ToString();
					}
					if(dt.Rows[n]["ext15"]!=null && dt.Rows[n]["ext15"].ToString()!="")
					{
					model.ext15=dt.Rows[n]["ext15"].ToString();
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


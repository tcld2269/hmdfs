using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// users
	/// </summary>
	public partial class users
	{
		private readonly hm.DAL.users dal=new hm.DAL.users();
		public users()
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
		public int  Add(hm.Model.users model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.users model)
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
		public hm.Model.users GetModel(int userId)
		{
			
			return dal.GetModel(userId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.users GetModelByCache(int userId)
		{
			
			string CacheKey = "usersModel-" + userId;
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
			return (hm.Model.users)objModel;
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
		public List<hm.Model.users> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.users> DataTableToList(DataTable dt)
		{
			List<hm.Model.users> modelList = new List<hm.Model.users>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.users model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.users();
					if(dt.Rows[n]["userId"]!=null && dt.Rows[n]["userId"].ToString()!="")
					{
						model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
					}
					if(dt.Rows[n]["userName"]!=null && dt.Rows[n]["userName"].ToString()!="")
					{
					model.userName=dt.Rows[n]["userName"].ToString();
					}
					if(dt.Rows[n]["password"]!=null && dt.Rows[n]["password"].ToString()!="")
					{
					model.password=dt.Rows[n]["password"].ToString();
					}
					if(dt.Rows[n]["trueName"]!=null && dt.Rows[n]["trueName"].ToString()!="")
					{
					model.trueName=dt.Rows[n]["trueName"].ToString();
					}
					if(dt.Rows[n]["nickName"]!=null && dt.Rows[n]["nickName"].ToString()!="")
					{
					model.nickName=dt.Rows[n]["nickName"].ToString();
					}
					if(dt.Rows[n]["addressCode"]!=null && dt.Rows[n]["addressCode"].ToString()!="")
					{
					model.addressCode=dt.Rows[n]["addressCode"].ToString();
					}
					if(dt.Rows[n]["address"]!=null && dt.Rows[n]["address"].ToString()!="")
					{
					model.address=dt.Rows[n]["address"].ToString();
					}
					if(dt.Rows[n]["avatar_small"]!=null && dt.Rows[n]["avatar_small"].ToString()!="")
					{
					model.avatar_small=dt.Rows[n]["avatar_small"].ToString();
					}
					if(dt.Rows[n]["avatar_big"]!=null && dt.Rows[n]["avatar_big"].ToString()!="")
					{
					model.avatar_big=dt.Rows[n]["avatar_big"].ToString();
					}
					if(dt.Rows[n]["deptId"]!=null && dt.Rows[n]["deptId"].ToString()!="")
					{
						model.deptId=int.Parse(dt.Rows[n]["deptId"].ToString());
					}
					if(dt.Rows[n]["deptName"]!=null && dt.Rows[n]["deptName"].ToString()!="")
					{
					model.deptName=dt.Rows[n]["deptName"].ToString();
					}
					if(dt.Rows[n]["roleId"]!=null && dt.Rows[n]["roleId"].ToString()!="")
					{
						model.roleId=int.Parse(dt.Rows[n]["roleId"].ToString());
					}
					if(dt.Rows[n]["roleName"]!=null && dt.Rows[n]["roleName"].ToString()!="")
					{
					model.roleName=dt.Rows[n]["roleName"].ToString();
					}
					if(dt.Rows[n]["sex"]!=null && dt.Rows[n]["sex"].ToString()!="")
					{
						model.sex=int.Parse(dt.Rows[n]["sex"].ToString());
					}
					if(dt.Rows[n]["tel"]!=null && dt.Rows[n]["tel"].ToString()!="")
					{
					model.tel=dt.Rows[n]["tel"].ToString();
					}
					if(dt.Rows[n]["email"]!=null && dt.Rows[n]["email"].ToString()!="")
					{
					model.email=dt.Rows[n]["email"].ToString();
					}
					if(dt.Rows[n]["qq"]!=null && dt.Rows[n]["qq"].ToString()!="")
					{
					model.qq=dt.Rows[n]["qq"].ToString();
					}
					if(dt.Rows[n]["score"]!=null && dt.Rows[n]["score"].ToString()!="")
					{
						model.score=int.Parse(dt.Rows[n]["score"].ToString());
					}
					if(dt.Rows[n]["scoreFrozen"]!=null && dt.Rows[n]["scoreFrozen"].ToString()!="")
					{
						model.scoreFrozen=int.Parse(dt.Rows[n]["scoreFrozen"].ToString());
					}
					if(dt.Rows[n]["account"]!=null && dt.Rows[n]["account"].ToString()!="")
					{
						model.account=decimal.Parse(dt.Rows[n]["account"].ToString());
					}
					if(dt.Rows[n]["accountFrozen"]!=null && dt.Rows[n]["accountFrozen"].ToString()!="")
					{
						model.accountFrozen=decimal.Parse(dt.Rows[n]["accountFrozen"].ToString());
					}
					if(dt.Rows[n]["regType"]!=null && dt.Rows[n]["regType"].ToString()!="")
					{
					model.regType=dt.Rows[n]["regType"].ToString();
					}
					if(dt.Rows[n]["regFrom"]!=null && dt.Rows[n]["regFrom"].ToString()!="")
					{
					model.regFrom=dt.Rows[n]["regFrom"].ToString();
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
					}
					if(dt.Rows[n]["lastLoginTime"]!=null && dt.Rows[n]["lastLoginTime"].ToString()!="")
					{
						model.lastLoginTime=DateTime.Parse(dt.Rows[n]["lastLoginTime"].ToString());
					}
					if(dt.Rows[n]["loginCount"]!=null && dt.Rows[n]["loginCount"].ToString()!="")
					{
						model.loginCount=int.Parse(dt.Rows[n]["loginCount"].ToString());
					}
					if(dt.Rows[n]["isAdmin"]!=null && dt.Rows[n]["isAdmin"].ToString()!="")
					{
						model.isAdmin=int.Parse(dt.Rows[n]["isAdmin"].ToString());
					}
					if(dt.Rows[n]["wxOpenId"]!=null && dt.Rows[n]["wxOpenId"].ToString()!="")
					{
					model.wxOpenId=dt.Rows[n]["wxOpenId"].ToString();
					}
					if(dt.Rows[n]["status"]!=null && dt.Rows[n]["status"].ToString()!="")
					{
						model.status=int.Parse(dt.Rows[n]["status"].ToString());
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


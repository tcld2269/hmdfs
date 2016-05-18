using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// store
	/// </summary>
	public partial class store
	{
		private readonly hm.DAL.store dal=new hm.DAL.store();
		public store()
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
		public int  Add(hm.Model.store model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.store model)
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
		public hm.Model.store GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.store GetModelByCache(int id)
		{
			
			string CacheKey = "storeModel-" + id;
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
			return (hm.Model.store)objModel;
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
		public List<hm.Model.store> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.store> DataTableToList(DataTable dt)
		{
			List<hm.Model.store> modelList = new List<hm.Model.store>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.store model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.store();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["storeName"]!=null && dt.Rows[n]["storeName"].ToString()!="")
					{
					model.storeName=dt.Rows[n]["storeName"].ToString();
					}
					if(dt.Rows[n]["userId"]!=null && dt.Rows[n]["userId"].ToString()!="")
					{
						model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
					}
					if(dt.Rows[n]["userName"]!=null && dt.Rows[n]["userName"].ToString()!="")
					{
					model.userName=dt.Rows[n]["userName"].ToString();
					}
					if(dt.Rows[n]["storeType"]!=null && dt.Rows[n]["storeType"].ToString()!="")
					{
						model.storeType=int.Parse(dt.Rows[n]["storeType"].ToString());
					}
					if(dt.Rows[n]["typeName"]!=null && dt.Rows[n]["typeName"].ToString()!="")
					{
					model.typeName=dt.Rows[n]["typeName"].ToString();
					}
					if(dt.Rows[n]["ownerCard"]!=null && dt.Rows[n]["ownerCard"].ToString()!="")
					{
					model.ownerCard=dt.Rows[n]["ownerCard"].ToString();
					}
					if(dt.Rows[n]["cardPic"]!=null && dt.Rows[n]["cardPic"].ToString()!="")
					{
					model.cardPic=dt.Rows[n]["cardPic"].ToString();
					}
					if(dt.Rows[n]["addressNo"]!=null && dt.Rows[n]["addressNo"].ToString()!="")
					{
					model.addressNo=dt.Rows[n]["addressNo"].ToString();
					}
					if(dt.Rows[n]["address"]!=null && dt.Rows[n]["address"].ToString()!="")
					{
					model.address=dt.Rows[n]["address"].ToString();
					}
					if(dt.Rows[n]["logo"]!=null && dt.Rows[n]["logo"].ToString()!="")
					{
					model.logo=dt.Rows[n]["logo"].ToString();
					}
					if(dt.Rows[n]["banner"]!=null && dt.Rows[n]["banner"].ToString()!="")
					{
					model.banner=dt.Rows[n]["banner"].ToString();
					}
					if(dt.Rows[n]["sale"]!=null && dt.Rows[n]["sale"].ToString()!="")
					{
					model.sale=dt.Rows[n]["sale"].ToString();
					}
					if(dt.Rows[n]["cashPrice"]!=null && dt.Rows[n]["cashPrice"].ToString()!="")
					{
						model.cashPrice=decimal.Parse(dt.Rows[n]["cashPrice"].ToString());
					}
					if(dt.Rows[n]["contact"]!=null && dt.Rows[n]["contact"].ToString()!="")
					{
					model.contact=dt.Rows[n]["contact"].ToString();
					}
					if(dt.Rows[n]["qq"]!=null && dt.Rows[n]["qq"].ToString()!="")
					{
					model.qq=dt.Rows[n]["qq"].ToString();
					}
					if(dt.Rows[n]["tel"]!=null && dt.Rows[n]["tel"].ToString()!="")
					{
					model.tel=dt.Rows[n]["tel"].ToString();
					}
					if(dt.Rows[n]["summary"]!=null && dt.Rows[n]["summary"].ToString()!="")
					{
					model.summary=dt.Rows[n]["summary"].ToString();
					}
					if(dt.Rows[n]["remark"]!=null && dt.Rows[n]["remark"].ToString()!="")
					{
					model.remark=dt.Rows[n]["remark"].ToString();
					}
					if(dt.Rows[n]["isRecommend"]!=null && dt.Rows[n]["isRecommend"].ToString()!="")
					{
						model.isRecommend=int.Parse(dt.Rows[n]["isRecommend"].ToString());
					}
					if(dt.Rows[n]["evaluateService"]!=null && dt.Rows[n]["evaluateService"].ToString()!="")
					{
						model.evaluateService=int.Parse(dt.Rows[n]["evaluateService"].ToString());
					}
					if(dt.Rows[n]["evaluateDesc"]!=null && dt.Rows[n]["evaluateDesc"].ToString()!="")
					{
						model.evaluateDesc=int.Parse(dt.Rows[n]["evaluateDesc"].ToString());
					}
					if(dt.Rows[n]["evaluateDeliver"]!=null && dt.Rows[n]["evaluateDeliver"].ToString()!="")
					{
						model.evaluateDeliver=int.Parse(dt.Rows[n]["evaluateDeliver"].ToString());
					}
					if(dt.Rows[n]["favCount"]!=null && dt.Rows[n]["favCount"].ToString()!="")
					{
						model.favCount=int.Parse(dt.Rows[n]["favCount"].ToString());
					}
					if(dt.Rows[n]["clickCount"]!=null && dt.Rows[n]["clickCount"].ToString()!="")
					{
						model.clickCount=int.Parse(dt.Rows[n]["clickCount"].ToString());
					}
					if(dt.Rows[n]["feedBack"]!=null && dt.Rows[n]["feedBack"].ToString()!="")
					{
					model.feedBack=dt.Rows[n]["feedBack"].ToString();
					}
					if(dt.Rows[n]["lat"]!=null && dt.Rows[n]["lat"].ToString()!="")
					{
					model.lat=dt.Rows[n]["lat"].ToString();
					}
					if(dt.Rows[n]["lon"]!=null && dt.Rows[n]["lon"].ToString()!="")
					{
					model.lon=dt.Rows[n]["lon"].ToString();
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
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


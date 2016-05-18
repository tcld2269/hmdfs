using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// goodsPic
	/// </summary>
	public partial class goodsPic
	{
		private readonly hm.DAL.goodsPic dal=new hm.DAL.goodsPic();
		public goodsPic()
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
		public int  Add(hm.Model.goodsPic model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.goodsPic model)
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
		public hm.Model.goodsPic GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.goodsPic GetModelByCache(int id)
		{
			
			string CacheKey = "goodsPicModel-" + id;
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
			return (hm.Model.goodsPic)objModel;
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
		public List<hm.Model.goodsPic> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.goodsPic> DataTableToList(DataTable dt)
		{
			List<hm.Model.goodsPic> modelList = new List<hm.Model.goodsPic>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.goodsPic model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.goodsPic();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["goodsId"]!=null && dt.Rows[n]["goodsId"].ToString()!="")
					{
						model.goodsId=int.Parse(dt.Rows[n]["goodsId"].ToString());
					}
					if(dt.Rows[n]["goodsName"]!=null && dt.Rows[n]["goodsName"].ToString()!="")
					{
					model.goodsName=dt.Rows[n]["goodsName"].ToString();
					}
					if(dt.Rows[n]["picSmall"]!=null && dt.Rows[n]["picSmall"].ToString()!="")
					{
					model.picSmall=dt.Rows[n]["picSmall"].ToString();
					}
					if(dt.Rows[n]["picNormal"]!=null && dt.Rows[n]["picNormal"].ToString()!="")
					{
					model.picNormal=dt.Rows[n]["picNormal"].ToString();
					}
					if(dt.Rows[n]["picBig"]!=null && dt.Rows[n]["picBig"].ToString()!="")
					{
					model.picBig=dt.Rows[n]["picBig"].ToString();
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
					}
					if(dt.Rows[n]["isDefault"]!=null && dt.Rows[n]["isDefault"].ToString()!="")
					{
						model.isDefault=int.Parse(dt.Rows[n]["isDefault"].ToString());
					}
					if(dt.Rows[n]["isShow"]!=null && dt.Rows[n]["isShow"].ToString()!="")
					{
						model.isShow=int.Parse(dt.Rows[n]["isShow"].ToString());
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
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


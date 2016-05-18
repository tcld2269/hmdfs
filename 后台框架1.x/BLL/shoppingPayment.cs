using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// shoppingPayment
	/// </summary>
	public partial class shoppingPayment
	{
		private readonly hm.DAL.shoppingPayment dal=new hm.DAL.shoppingPayment();
		public shoppingPayment()
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
		public int  Add(hm.Model.shoppingPayment model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.shoppingPayment model)
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
		public hm.Model.shoppingPayment GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.shoppingPayment GetModelByCache(int id)
		{
			
			string CacheKey = "shoppingPaymentModel-" + id;
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
			return (hm.Model.shoppingPayment)objModel;
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
		public List<hm.Model.shoppingPayment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.shoppingPayment> DataTableToList(DataTable dt)
		{
			List<hm.Model.shoppingPayment> modelList = new List<hm.Model.shoppingPayment>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.shoppingPayment model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.shoppingPayment();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["name"]!=null && dt.Rows[n]["name"].ToString()!="")
					{
					model.name=dt.Rows[n]["name"].ToString();
					}
					if(dt.Rows[n]["code"]!=null && dt.Rows[n]["code"].ToString()!="")
					{
					model.code=dt.Rows[n]["code"].ToString();
					}
					if(dt.Rows[n]["summary"]!=null && dt.Rows[n]["summary"].ToString()!="")
					{
					model.summary=dt.Rows[n]["summary"].ToString();
					}
					if(dt.Rows[n]["returnUrl"]!=null && dt.Rows[n]["returnUrl"].ToString()!="")
					{
					model.returnUrl=dt.Rows[n]["returnUrl"].ToString();
					}
					if(dt.Rows[n]["notifyUrl"]!=null && dt.Rows[n]["notifyUrl"].ToString()!="")
					{
					model.notifyUrl=dt.Rows[n]["notifyUrl"].ToString();
					}
					if(dt.Rows[n]["ico"]!=null && dt.Rows[n]["ico"].ToString()!="")
					{
					model.ico=dt.Rows[n]["ico"].ToString();
					}
					if(dt.Rows[n]["gateUrl"]!=null && dt.Rows[n]["gateUrl"].ToString()!="")
					{
					model.gateUrl=dt.Rows[n]["gateUrl"].ToString();
					}
					if(dt.Rows[n]["filePath"]!=null && dt.Rows[n]["filePath"].ToString()!="")
					{
					model.filePath=dt.Rows[n]["filePath"].ToString();
					}
					if(dt.Rows[n]["parm1"]!=null && dt.Rows[n]["parm1"].ToString()!="")
					{
					model.parm1=dt.Rows[n]["parm1"].ToString();
					}
					if(dt.Rows[n]["parm2"]!=null && dt.Rows[n]["parm2"].ToString()!="")
					{
					model.parm2=dt.Rows[n]["parm2"].ToString();
					}
					if(dt.Rows[n]["parm3"]!=null && dt.Rows[n]["parm3"].ToString()!="")
					{
					model.parm3=dt.Rows[n]["parm3"].ToString();
					}
					if(dt.Rows[n]["parm4"]!=null && dt.Rows[n]["parm4"].ToString()!="")
					{
					model.parm4=dt.Rows[n]["parm4"].ToString();
					}
					if(dt.Rows[n]["parm5"]!=null && dt.Rows[n]["parm5"].ToString()!="")
					{
					model.parm5=dt.Rows[n]["parm5"].ToString();
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


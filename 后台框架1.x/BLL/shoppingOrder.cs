using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// shoppingOrder
	/// </summary>
	public partial class shoppingOrder
	{
		private readonly hm.DAL.shoppingOrder dal=new hm.DAL.shoppingOrder();
		public shoppingOrder()
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
		public int  Add(hm.Model.shoppingOrder model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.shoppingOrder model)
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
		public hm.Model.shoppingOrder GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.shoppingOrder GetModelByCache(int id)
		{
			
			string CacheKey = "shoppingOrderModel-" + id;
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
			return (hm.Model.shoppingOrder)objModel;
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
		public List<hm.Model.shoppingOrder> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.shoppingOrder> DataTableToList(DataTable dt)
		{
			List<hm.Model.shoppingOrder> modelList = new List<hm.Model.shoppingOrder>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.shoppingOrder model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.shoppingOrder();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["orderNo"]!=null && dt.Rows[n]["orderNo"].ToString()!="")
					{
					model.orderNo=dt.Rows[n]["orderNo"].ToString();
					}
					if(dt.Rows[n]["sellerId"]!=null && dt.Rows[n]["sellerId"].ToString()!="")
					{
						model.sellerId=int.Parse(dt.Rows[n]["sellerId"].ToString());
					}
					if(dt.Rows[n]["sellerName"]!=null && dt.Rows[n]["sellerName"].ToString()!="")
					{
					model.sellerName=dt.Rows[n]["sellerName"].ToString();
					}
					if(dt.Rows[n]["storeId"]!=null && dt.Rows[n]["storeId"].ToString()!="")
					{
						model.storeId=int.Parse(dt.Rows[n]["storeId"].ToString());
					}
					if(dt.Rows[n]["storeName"]!=null && dt.Rows[n]["storeName"].ToString()!="")
					{
					model.storeName=dt.Rows[n]["storeName"].ToString();
					}
					if(dt.Rows[n]["buyerId"]!=null && dt.Rows[n]["buyerId"].ToString()!="")
					{
						model.buyerId=int.Parse(dt.Rows[n]["buyerId"].ToString());
					}
					if(dt.Rows[n]["buyerName"]!=null && dt.Rows[n]["buyerName"].ToString()!="")
					{
					model.buyerName=dt.Rows[n]["buyerName"].ToString();
					}
					if(dt.Rows[n]["type"]!=null && dt.Rows[n]["type"].ToString()!="")
					{
						model.type=int.Parse(dt.Rows[n]["type"].ToString());
					}
					if(dt.Rows[n]["addressId"]!=null && dt.Rows[n]["addressId"].ToString()!="")
					{
						model.addressId=int.Parse(dt.Rows[n]["addressId"].ToString());
					}
					if(dt.Rows[n]["paymentId"]!=null && dt.Rows[n]["paymentId"].ToString()!="")
					{
						model.paymentId=int.Parse(dt.Rows[n]["paymentId"].ToString());
					}
					if(dt.Rows[n]["paymentName"]!=null && dt.Rows[n]["paymentName"].ToString()!="")
					{
					model.paymentName=dt.Rows[n]["paymentName"].ToString();
					}
					if(dt.Rows[n]["payTime"]!=null && dt.Rows[n]["payTime"].ToString()!="")
					{
						model.payTime=DateTime.Parse(dt.Rows[n]["payTime"].ToString());
					}
					if(dt.Rows[n]["payRemark"]!=null && dt.Rows[n]["payRemark"].ToString()!="")
					{
					model.payRemark=dt.Rows[n]["payRemark"].ToString();
					}
					if(dt.Rows[n]["goodsPrice"]!=null && dt.Rows[n]["goodsPrice"].ToString()!="")
					{
						model.goodsPrice=decimal.Parse(dt.Rows[n]["goodsPrice"].ToString());
					}
					if(dt.Rows[n]["freightPrice"]!=null && dt.Rows[n]["freightPrice"].ToString()!="")
					{
						model.freightPrice=decimal.Parse(dt.Rows[n]["freightPrice"].ToString());
					}
					if(dt.Rows[n]["orderPrice"]!=null && dt.Rows[n]["orderPrice"].ToString()!="")
					{
						model.orderPrice=decimal.Parse(dt.Rows[n]["orderPrice"].ToString());
					}
					if(dt.Rows[n]["freightSn"]!=null && dt.Rows[n]["freightSn"].ToString()!="")
					{
					model.freightSn=dt.Rows[n]["freightSn"].ToString();
					}
					if(dt.Rows[n]["remark"]!=null && dt.Rows[n]["remark"].ToString()!="")
					{
					model.remark=dt.Rows[n]["remark"].ToString();
					}
					if(dt.Rows[n]["refundType"]!=null && dt.Rows[n]["refundType"].ToString()!="")
					{
						model.refundType=int.Parse(dt.Rows[n]["refundType"].ToString());
					}
					if(dt.Rows[n]["refundRemark"]!=null && dt.Rows[n]["refundRemark"].ToString()!="")
					{
					model.refundRemark=dt.Rows[n]["refundRemark"].ToString();
					}
					if(dt.Rows[n]["refundTime"]!=null && dt.Rows[n]["refundTime"].ToString()!="")
					{
						model.refundTime=DateTime.Parse(dt.Rows[n]["refundTime"].ToString());
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
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


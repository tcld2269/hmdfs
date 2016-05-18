using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:shoppingOrder
	/// </summary>
	public partial class shoppingOrder
	{
		public shoppingOrder()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "shoppingOrder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shoppingOrder");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.shoppingOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shoppingOrder(");
			strSql.Append("orderNo,sellerId,sellerName,storeId,storeName,buyerId,buyerName,type,addressId,paymentId,paymentName,payTime,payRemark,goodsPrice,freightPrice,orderPrice,freightSn,remark,refundType,refundRemark,refundTime,addTime,status)");
			strSql.Append(" values (");
			strSql.Append("@orderNo,@sellerId,@sellerName,@storeId,@storeName,@buyerId,@buyerName,@type,@addressId,@paymentId,@paymentName,@payTime,@payRemark,@goodsPrice,@freightPrice,@orderPrice,@freightSn,@remark,@refundType,@refundRemark,@refundTime,@addTime,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@orderNo", SqlDbType.VarChar,200),
					new SqlParameter("@sellerId", SqlDbType.Int,4),
					new SqlParameter("@sellerName", SqlDbType.VarChar,200),
					new SqlParameter("@storeId", SqlDbType.Int,4),
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@buyerId", SqlDbType.Int,4),
					new SqlParameter("@buyerName", SqlDbType.VarChar,200),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@addressId", SqlDbType.Int,4),
					new SqlParameter("@paymentId", SqlDbType.Int,4),
					new SqlParameter("@paymentName", SqlDbType.VarChar,200),
					new SqlParameter("@payTime", SqlDbType.DateTime),
					new SqlParameter("@payRemark", SqlDbType.VarChar,500),
					new SqlParameter("@goodsPrice", SqlDbType.Decimal,9),
					new SqlParameter("@freightPrice", SqlDbType.Decimal,9),
					new SqlParameter("@orderPrice", SqlDbType.Decimal,9),
					new SqlParameter("@freightSn", SqlDbType.VarChar,500),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@refundType", SqlDbType.Int,4),
					new SqlParameter("@refundRemark", SqlDbType.VarChar,500),
					new SqlParameter("@refundTime", SqlDbType.DateTime),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.orderNo;
			parameters[1].Value = model.sellerId;
			parameters[2].Value = model.sellerName;
			parameters[3].Value = model.storeId;
			parameters[4].Value = model.storeName;
			parameters[5].Value = model.buyerId;
			parameters[6].Value = model.buyerName;
			parameters[7].Value = model.type;
			parameters[8].Value = model.addressId;
			parameters[9].Value = model.paymentId;
			parameters[10].Value = model.paymentName;
			parameters[11].Value = model.payTime;
			parameters[12].Value = model.payRemark;
			parameters[13].Value = model.goodsPrice;
			parameters[14].Value = model.freightPrice;
			parameters[15].Value = model.orderPrice;
			parameters[16].Value = model.freightSn;
			parameters[17].Value = model.remark;
			parameters[18].Value = model.refundType;
			parameters[19].Value = model.refundRemark;
			parameters[20].Value = model.refundTime;
			parameters[21].Value = model.addTime;
			parameters[22].Value = model.status;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.shoppingOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shoppingOrder set ");
			strSql.Append("orderNo=@orderNo,");
			strSql.Append("sellerId=@sellerId,");
			strSql.Append("sellerName=@sellerName,");
			strSql.Append("storeId=@storeId,");
			strSql.Append("storeName=@storeName,");
			strSql.Append("buyerId=@buyerId,");
			strSql.Append("buyerName=@buyerName,");
			strSql.Append("type=@type,");
			strSql.Append("addressId=@addressId,");
			strSql.Append("paymentId=@paymentId,");
			strSql.Append("paymentName=@paymentName,");
			strSql.Append("payTime=@payTime,");
			strSql.Append("payRemark=@payRemark,");
			strSql.Append("goodsPrice=@goodsPrice,");
			strSql.Append("freightPrice=@freightPrice,");
			strSql.Append("orderPrice=@orderPrice,");
			strSql.Append("freightSn=@freightSn,");
			strSql.Append("remark=@remark,");
			strSql.Append("refundType=@refundType,");
			strSql.Append("refundRemark=@refundRemark,");
			strSql.Append("refundTime=@refundTime,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@orderNo", SqlDbType.VarChar,200),
					new SqlParameter("@sellerId", SqlDbType.Int,4),
					new SqlParameter("@sellerName", SqlDbType.VarChar,200),
					new SqlParameter("@storeId", SqlDbType.Int,4),
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@buyerId", SqlDbType.Int,4),
					new SqlParameter("@buyerName", SqlDbType.VarChar,200),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@addressId", SqlDbType.Int,4),
					new SqlParameter("@paymentId", SqlDbType.Int,4),
					new SqlParameter("@paymentName", SqlDbType.VarChar,200),
					new SqlParameter("@payTime", SqlDbType.DateTime),
					new SqlParameter("@payRemark", SqlDbType.VarChar,500),
					new SqlParameter("@goodsPrice", SqlDbType.Decimal,9),
					new SqlParameter("@freightPrice", SqlDbType.Decimal,9),
					new SqlParameter("@orderPrice", SqlDbType.Decimal,9),
					new SqlParameter("@freightSn", SqlDbType.VarChar,500),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@refundType", SqlDbType.Int,4),
					new SqlParameter("@refundRemark", SqlDbType.VarChar,500),
					new SqlParameter("@refundTime", SqlDbType.DateTime),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.orderNo;
			parameters[1].Value = model.sellerId;
			parameters[2].Value = model.sellerName;
			parameters[3].Value = model.storeId;
			parameters[4].Value = model.storeName;
			parameters[5].Value = model.buyerId;
			parameters[6].Value = model.buyerName;
			parameters[7].Value = model.type;
			parameters[8].Value = model.addressId;
			parameters[9].Value = model.paymentId;
			parameters[10].Value = model.paymentName;
			parameters[11].Value = model.payTime;
			parameters[12].Value = model.payRemark;
			parameters[13].Value = model.goodsPrice;
			parameters[14].Value = model.freightPrice;
			parameters[15].Value = model.orderPrice;
			parameters[16].Value = model.freightSn;
			parameters[17].Value = model.remark;
			parameters[18].Value = model.refundType;
			parameters[19].Value = model.refundRemark;
			parameters[20].Value = model.refundTime;
			parameters[21].Value = model.addTime;
			parameters[22].Value = model.status;
			parameters[23].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shoppingOrder ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shoppingOrder ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.shoppingOrder GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,orderNo,sellerId,sellerName,storeId,storeName,buyerId,buyerName,type,addressId,paymentId,paymentName,payTime,payRemark,goodsPrice,freightPrice,orderPrice,freightSn,remark,refundType,refundRemark,refundTime,addTime,status from shoppingOrder ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.shoppingOrder model=new hm.Model.shoppingOrder();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orderNo"]!=null && ds.Tables[0].Rows[0]["orderNo"].ToString()!="")
				{
					model.orderNo=ds.Tables[0].Rows[0]["orderNo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sellerId"]!=null && ds.Tables[0].Rows[0]["sellerId"].ToString()!="")
				{
					model.sellerId=int.Parse(ds.Tables[0].Rows[0]["sellerId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sellerName"]!=null && ds.Tables[0].Rows[0]["sellerName"].ToString()!="")
				{
					model.sellerName=ds.Tables[0].Rows[0]["sellerName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["storeId"]!=null && ds.Tables[0].Rows[0]["storeId"].ToString()!="")
				{
					model.storeId=int.Parse(ds.Tables[0].Rows[0]["storeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storeName"]!=null && ds.Tables[0].Rows[0]["storeName"].ToString()!="")
				{
					model.storeName=ds.Tables[0].Rows[0]["storeName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buyerId"]!=null && ds.Tables[0].Rows[0]["buyerId"].ToString()!="")
				{
					model.buyerId=int.Parse(ds.Tables[0].Rows[0]["buyerId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["buyerName"]!=null && ds.Tables[0].Rows[0]["buyerName"].ToString()!="")
				{
					model.buyerName=ds.Tables[0].Rows[0]["buyerName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null && ds.Tables[0].Rows[0]["type"].ToString()!="")
				{
					model.type=int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addressId"]!=null && ds.Tables[0].Rows[0]["addressId"].ToString()!="")
				{
					model.addressId=int.Parse(ds.Tables[0].Rows[0]["addressId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["paymentId"]!=null && ds.Tables[0].Rows[0]["paymentId"].ToString()!="")
				{
					model.paymentId=int.Parse(ds.Tables[0].Rows[0]["paymentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["paymentName"]!=null && ds.Tables[0].Rows[0]["paymentName"].ToString()!="")
				{
					model.paymentName=ds.Tables[0].Rows[0]["paymentName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["payTime"]!=null && ds.Tables[0].Rows[0]["payTime"].ToString()!="")
				{
					model.payTime=DateTime.Parse(ds.Tables[0].Rows[0]["payTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["payRemark"]!=null && ds.Tables[0].Rows[0]["payRemark"].ToString()!="")
				{
					model.payRemark=ds.Tables[0].Rows[0]["payRemark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goodsPrice"]!=null && ds.Tables[0].Rows[0]["goodsPrice"].ToString()!="")
				{
					model.goodsPrice=decimal.Parse(ds.Tables[0].Rows[0]["goodsPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["freightPrice"]!=null && ds.Tables[0].Rows[0]["freightPrice"].ToString()!="")
				{
					model.freightPrice=decimal.Parse(ds.Tables[0].Rows[0]["freightPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orderPrice"]!=null && ds.Tables[0].Rows[0]["orderPrice"].ToString()!="")
				{
					model.orderPrice=decimal.Parse(ds.Tables[0].Rows[0]["orderPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["freightSn"]!=null && ds.Tables[0].Rows[0]["freightSn"].ToString()!="")
				{
					model.freightSn=ds.Tables[0].Rows[0]["freightSn"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["refundType"]!=null && ds.Tables[0].Rows[0]["refundType"].ToString()!="")
				{
					model.refundType=int.Parse(ds.Tables[0].Rows[0]["refundType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["refundRemark"]!=null && ds.Tables[0].Rows[0]["refundRemark"].ToString()!="")
				{
					model.refundRemark=ds.Tables[0].Rows[0]["refundRemark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["refundTime"]!=null && ds.Tables[0].Rows[0]["refundTime"].ToString()!="")
				{
					model.refundTime=DateTime.Parse(ds.Tables[0].Rows[0]["refundTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["status"]!=null && ds.Tables[0].Rows[0]["status"].ToString()!="")
				{
					model.status=int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,orderNo,sellerId,sellerName,storeId,storeName,buyerId,buyerName,type,addressId,paymentId,paymentName,payTime,payRemark,goodsPrice,freightPrice,orderPrice,freightSn,remark,refundType,refundRemark,refundTime,addTime,status ");
			strSql.Append(" FROM shoppingOrder ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,orderNo,sellerId,sellerName,storeId,storeName,buyerId,buyerName,type,addressId,paymentId,paymentName,payTime,payRemark,goodsPrice,freightPrice,orderPrice,freightSn,remark,refundType,refundRemark,refundTime,addTime,status ");
			strSql.Append(" FROM shoppingOrder ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "shoppingOrder";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}


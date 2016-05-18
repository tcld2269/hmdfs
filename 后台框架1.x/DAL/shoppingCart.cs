using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:shoppingCart
	/// </summary>
	public partial class shoppingCart
	{
		public shoppingCart()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "shoppingCart"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shoppingCart");
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
		public int Add(hm.Model.shoppingCart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shoppingCart(");
			strSql.Append("orderId,userId,userName,storeId,storeName,goodsId,goodsName,goodsNum,goodsPrice,goodsPic,addTime,status)");
			strSql.Append(" values (");
			strSql.Append("@orderId,@userId,@userName,@storeId,@storeName,@goodsId,@goodsName,@goodsNum,@goodsPrice,@goodsPic,@addTime,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@orderId", SqlDbType.Int,4),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.VarChar,200),
					new SqlParameter("@storeId", SqlDbType.Int,4),
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@goodsId", SqlDbType.Int,4),
					new SqlParameter("@goodsName", SqlDbType.VarChar,200),
					new SqlParameter("@goodsNum", SqlDbType.Int,4),
					new SqlParameter("@goodsPrice", SqlDbType.Decimal,9),
					new SqlParameter("@goodsPic", SqlDbType.VarChar,200),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.orderId;
			parameters[1].Value = model.userId;
			parameters[2].Value = model.userName;
			parameters[3].Value = model.storeId;
			parameters[4].Value = model.storeName;
			parameters[5].Value = model.goodsId;
			parameters[6].Value = model.goodsName;
			parameters[7].Value = model.goodsNum;
			parameters[8].Value = model.goodsPrice;
			parameters[9].Value = model.goodsPic;
			parameters[10].Value = model.addTime;
			parameters[11].Value = model.status;

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
		public bool Update(hm.Model.shoppingCart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shoppingCart set ");
			strSql.Append("orderId=@orderId,");
			strSql.Append("userId=@userId,");
			strSql.Append("userName=@userName,");
			strSql.Append("storeId=@storeId,");
			strSql.Append("storeName=@storeName,");
			strSql.Append("goodsId=@goodsId,");
			strSql.Append("goodsName=@goodsName,");
			strSql.Append("goodsNum=@goodsNum,");
			strSql.Append("goodsPrice=@goodsPrice,");
			strSql.Append("goodsPic=@goodsPic,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@orderId", SqlDbType.Int,4),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.VarChar,200),
					new SqlParameter("@storeId", SqlDbType.Int,4),
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@goodsId", SqlDbType.Int,4),
					new SqlParameter("@goodsName", SqlDbType.VarChar,200),
					new SqlParameter("@goodsNum", SqlDbType.Int,4),
					new SqlParameter("@goodsPrice", SqlDbType.Decimal,9),
					new SqlParameter("@goodsPic", SqlDbType.VarChar,200),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.orderId;
			parameters[1].Value = model.userId;
			parameters[2].Value = model.userName;
			parameters[3].Value = model.storeId;
			parameters[4].Value = model.storeName;
			parameters[5].Value = model.goodsId;
			parameters[6].Value = model.goodsName;
			parameters[7].Value = model.goodsNum;
			parameters[8].Value = model.goodsPrice;
			parameters[9].Value = model.goodsPic;
			parameters[10].Value = model.addTime;
			parameters[11].Value = model.status;
			parameters[12].Value = model.id;

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
			strSql.Append("delete from shoppingCart ");
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
			strSql.Append("delete from shoppingCart ");
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
		public hm.Model.shoppingCart GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,orderId,userId,userName,storeId,storeName,goodsId,goodsName,goodsNum,goodsPrice,goodsPic,addTime,status from shoppingCart ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.shoppingCart model=new hm.Model.shoppingCart();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orderId"]!=null && ds.Tables[0].Rows[0]["orderId"].ToString()!="")
				{
					model.orderId=int.Parse(ds.Tables[0].Rows[0]["orderId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["storeId"]!=null && ds.Tables[0].Rows[0]["storeId"].ToString()!="")
				{
					model.storeId=int.Parse(ds.Tables[0].Rows[0]["storeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storeName"]!=null && ds.Tables[0].Rows[0]["storeName"].ToString()!="")
				{
					model.storeName=ds.Tables[0].Rows[0]["storeName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goodsId"]!=null && ds.Tables[0].Rows[0]["goodsId"].ToString()!="")
				{
					model.goodsId=int.Parse(ds.Tables[0].Rows[0]["goodsId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goodsName"]!=null && ds.Tables[0].Rows[0]["goodsName"].ToString()!="")
				{
					model.goodsName=ds.Tables[0].Rows[0]["goodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goodsNum"]!=null && ds.Tables[0].Rows[0]["goodsNum"].ToString()!="")
				{
					model.goodsNum=int.Parse(ds.Tables[0].Rows[0]["goodsNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goodsPrice"]!=null && ds.Tables[0].Rows[0]["goodsPrice"].ToString()!="")
				{
					model.goodsPrice=decimal.Parse(ds.Tables[0].Rows[0]["goodsPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goodsPic"]!=null && ds.Tables[0].Rows[0]["goodsPic"].ToString()!="")
				{
					model.goodsPic=ds.Tables[0].Rows[0]["goodsPic"].ToString();
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
			strSql.Append("select id,orderId,userId,userName,storeId,storeName,goodsId,goodsName,goodsNum,goodsPrice,goodsPic,addTime,status ");
			strSql.Append(" FROM shoppingCart ");
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
			strSql.Append(" id,orderId,userId,userName,storeId,storeName,goodsId,goodsName,goodsNum,goodsPrice,goodsPic,addTime,status ");
			strSql.Append(" FROM shoppingCart ");
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
			parameters[0].Value = "shoppingCart";
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


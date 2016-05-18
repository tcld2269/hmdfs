using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:goodsStandPrice
	/// </summary>
	public partial class goodsStandPrice
	{
		public goodsStandPrice()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "goodsStandPrice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from goodsStandPrice");
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
		public int Add(hm.Model.goodsStandPrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into goodsStandPrice(");
			strSql.Append("goodsId,standId,standSecondId,standThirdId,marketPrice,storePrice,buyScore,stock,orders)");
			strSql.Append(" values (");
			strSql.Append("@goodsId,@standId,@standSecondId,@standThirdId,@marketPrice,@storePrice,@buyScore,@stock,@orders)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@goodsId", SqlDbType.Int,4),
					new SqlParameter("@standId", SqlDbType.Int,4),
					new SqlParameter("@standSecondId", SqlDbType.Int,4),
					new SqlParameter("@standThirdId", SqlDbType.Int,4),
					new SqlParameter("@marketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@storePrice", SqlDbType.Decimal,9),
					new SqlParameter("@buyScore", SqlDbType.Int,4),
					new SqlParameter("@stock", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4)};
			parameters[0].Value = model.goodsId;
			parameters[1].Value = model.standId;
			parameters[2].Value = model.standSecondId;
			parameters[3].Value = model.standThirdId;
			parameters[4].Value = model.marketPrice;
			parameters[5].Value = model.storePrice;
			parameters[6].Value = model.buyScore;
			parameters[7].Value = model.stock;
			parameters[8].Value = model.orders;

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
		public bool Update(hm.Model.goodsStandPrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update goodsStandPrice set ");
			strSql.Append("goodsId=@goodsId,");
			strSql.Append("standId=@standId,");
			strSql.Append("standSecondId=@standSecondId,");
			strSql.Append("standThirdId=@standThirdId,");
			strSql.Append("marketPrice=@marketPrice,");
			strSql.Append("storePrice=@storePrice,");
			strSql.Append("buyScore=@buyScore,");
			strSql.Append("stock=@stock,");
			strSql.Append("orders=@orders");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@goodsId", SqlDbType.Int,4),
					new SqlParameter("@standId", SqlDbType.Int,4),
					new SqlParameter("@standSecondId", SqlDbType.Int,4),
					new SqlParameter("@standThirdId", SqlDbType.Int,4),
					new SqlParameter("@marketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@storePrice", SqlDbType.Decimal,9),
					new SqlParameter("@buyScore", SqlDbType.Int,4),
					new SqlParameter("@stock", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.goodsId;
			parameters[1].Value = model.standId;
			parameters[2].Value = model.standSecondId;
			parameters[3].Value = model.standThirdId;
			parameters[4].Value = model.marketPrice;
			parameters[5].Value = model.storePrice;
			parameters[6].Value = model.buyScore;
			parameters[7].Value = model.stock;
			parameters[8].Value = model.orders;
			parameters[9].Value = model.id;

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
			strSql.Append("delete from goodsStandPrice ");
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
			strSql.Append("delete from goodsStandPrice ");
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
		public hm.Model.goodsStandPrice GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,goodsId,standId,standSecondId,standThirdId,marketPrice,storePrice,buyScore,stock,orders from goodsStandPrice ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.goodsStandPrice model=new hm.Model.goodsStandPrice();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goodsId"]!=null && ds.Tables[0].Rows[0]["goodsId"].ToString()!="")
				{
					model.goodsId=int.Parse(ds.Tables[0].Rows[0]["goodsId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["standId"]!=null && ds.Tables[0].Rows[0]["standId"].ToString()!="")
				{
					model.standId=int.Parse(ds.Tables[0].Rows[0]["standId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["standSecondId"]!=null && ds.Tables[0].Rows[0]["standSecondId"].ToString()!="")
				{
					model.standSecondId=int.Parse(ds.Tables[0].Rows[0]["standSecondId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["standThirdId"]!=null && ds.Tables[0].Rows[0]["standThirdId"].ToString()!="")
				{
					model.standThirdId=int.Parse(ds.Tables[0].Rows[0]["standThirdId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["marketPrice"]!=null && ds.Tables[0].Rows[0]["marketPrice"].ToString()!="")
				{
					model.marketPrice=decimal.Parse(ds.Tables[0].Rows[0]["marketPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storePrice"]!=null && ds.Tables[0].Rows[0]["storePrice"].ToString()!="")
				{
					model.storePrice=decimal.Parse(ds.Tables[0].Rows[0]["storePrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["buyScore"]!=null && ds.Tables[0].Rows[0]["buyScore"].ToString()!="")
				{
					model.buyScore=int.Parse(ds.Tables[0].Rows[0]["buyScore"].ToString());
				}
				if(ds.Tables[0].Rows[0]["stock"]!=null && ds.Tables[0].Rows[0]["stock"].ToString()!="")
				{
					model.stock=int.Parse(ds.Tables[0].Rows[0]["stock"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
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
			strSql.Append("select id,goodsId,standId,standSecondId,standThirdId,marketPrice,storePrice,buyScore,stock,orders ");
			strSql.Append(" FROM goodsStandPrice ");
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
			strSql.Append(" id,goodsId,standId,standSecondId,standThirdId,marketPrice,storePrice,buyScore,stock,orders ");
			strSql.Append(" FROM goodsStandPrice ");
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
			parameters[0].Value = "goodsStandPrice";
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


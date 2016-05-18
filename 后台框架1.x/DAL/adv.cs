using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:adv
	/// </summary>
	public partial class adv
	{
		public adv()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "adv"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from adv");
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
		public int Add(hm.Model.adv model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into adv(");
			strSql.Append("title,apId,url,pic,remark,startDate,endDate,price,clickCount,orders,addTime,status)");
			strSql.Append(" values (");
			strSql.Append("@title,@apId,@url,@pic,@remark,@startDate,@endDate,@price,@clickCount,@orders,@addTime,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@apId", SqlDbType.Int,4),
					new SqlParameter("@url", SqlDbType.VarChar,200),
					new SqlParameter("@pic", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar),
					new SqlParameter("@startDate", SqlDbType.DateTime),
					new SqlParameter("@endDate", SqlDbType.DateTime),
					new SqlParameter("@price", SqlDbType.Decimal,9),
					new SqlParameter("@clickCount", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.apId;
			parameters[2].Value = model.url;
			parameters[3].Value = model.pic;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.startDate;
			parameters[6].Value = model.endDate;
			parameters[7].Value = model.price;
			parameters[8].Value = model.clickCount;
			parameters[9].Value = model.orders;
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
		public bool Update(hm.Model.adv model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update adv set ");
			strSql.Append("title=@title,");
			strSql.Append("apId=@apId,");
			strSql.Append("url=@url,");
			strSql.Append("pic=@pic,");
			strSql.Append("remark=@remark,");
			strSql.Append("startDate=@startDate,");
			strSql.Append("endDate=@endDate,");
			strSql.Append("price=@price,");
			strSql.Append("clickCount=@clickCount,");
			strSql.Append("orders=@orders,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@apId", SqlDbType.Int,4),
					new SqlParameter("@url", SqlDbType.VarChar,200),
					new SqlParameter("@pic", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar),
					new SqlParameter("@startDate", SqlDbType.DateTime),
					new SqlParameter("@endDate", SqlDbType.DateTime),
					new SqlParameter("@price", SqlDbType.Decimal,9),
					new SqlParameter("@clickCount", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.apId;
			parameters[2].Value = model.url;
			parameters[3].Value = model.pic;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.startDate;
			parameters[6].Value = model.endDate;
			parameters[7].Value = model.price;
			parameters[8].Value = model.clickCount;
			parameters[9].Value = model.orders;
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
			strSql.Append("delete from adv ");
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
			strSql.Append("delete from adv ");
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
		public hm.Model.adv GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,title,apId,url,pic,remark,startDate,endDate,price,clickCount,orders,addTime,status from adv ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.adv model=new hm.Model.adv();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["apId"]!=null && ds.Tables[0].Rows[0]["apId"].ToString()!="")
				{
					model.apId=int.Parse(ds.Tables[0].Rows[0]["apId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["url"]!=null && ds.Tables[0].Rows[0]["url"].ToString()!="")
				{
					model.url=ds.Tables[0].Rows[0]["url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pic"]!=null && ds.Tables[0].Rows[0]["pic"].ToString()!="")
				{
					model.pic=ds.Tables[0].Rows[0]["pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["startDate"]!=null && ds.Tables[0].Rows[0]["startDate"].ToString()!="")
				{
					model.startDate=DateTime.Parse(ds.Tables[0].Rows[0]["startDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["endDate"]!=null && ds.Tables[0].Rows[0]["endDate"].ToString()!="")
				{
					model.endDate=DateTime.Parse(ds.Tables[0].Rows[0]["endDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["price"]!=null && ds.Tables[0].Rows[0]["price"].ToString()!="")
				{
					model.price=decimal.Parse(ds.Tables[0].Rows[0]["price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["clickCount"]!=null && ds.Tables[0].Rows[0]["clickCount"].ToString()!="")
				{
					model.clickCount=int.Parse(ds.Tables[0].Rows[0]["clickCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
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
			strSql.Append("select id,title,apId,url,pic,remark,startDate,endDate,price,clickCount,orders,addTime,status ");
			strSql.Append(" FROM adv ");
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
			strSql.Append(" id,title,apId,url,pic,remark,startDate,endDate,price,clickCount,orders,addTime,status ");
			strSql.Append(" FROM adv ");
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
			parameters[0].Value = "adv";
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


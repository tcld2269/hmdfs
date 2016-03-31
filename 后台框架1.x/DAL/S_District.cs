using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:S_District
	/// </summary>
	public partial class S_District
	{
		public S_District()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long DistrictID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from S_District");
			strSql.Append(" where DistrictID=@DistrictID");
			SqlParameter[] parameters = {
					new SqlParameter("@DistrictID", SqlDbType.BigInt)
};
			parameters[0].Value = DistrictID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(hm.Model.S_District model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into S_District(");
			strSql.Append("DistrictName,CityID,DateCreated,DateUpdated)");
			strSql.Append(" values (");
			strSql.Append("@DistrictName,@CityID,@DateCreated,@DateUpdated)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DistrictName", SqlDbType.NVarChar,50),
					new SqlParameter("@CityID", SqlDbType.BigInt,8),
					new SqlParameter("@DateCreated", SqlDbType.DateTime),
					new SqlParameter("@DateUpdated", SqlDbType.DateTime)};
			parameters[0].Value = model.DistrictName;
			parameters[1].Value = model.CityID;
			parameters[2].Value = model.DateCreated;
			parameters[3].Value = model.DateUpdated;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.S_District model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update S_District set ");
			strSql.Append("DistrictName=@DistrictName,");
			strSql.Append("CityID=@CityID,");
			strSql.Append("DateCreated=@DateCreated,");
			strSql.Append("DateUpdated=@DateUpdated");
			strSql.Append(" where DistrictID=@DistrictID");
			SqlParameter[] parameters = {
					new SqlParameter("@DistrictName", SqlDbType.NVarChar,50),
					new SqlParameter("@CityID", SqlDbType.BigInt,8),
					new SqlParameter("@DateCreated", SqlDbType.DateTime),
					new SqlParameter("@DateUpdated", SqlDbType.DateTime),
					new SqlParameter("@DistrictID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.DistrictName;
			parameters[1].Value = model.CityID;
			parameters[2].Value = model.DateCreated;
			parameters[3].Value = model.DateUpdated;
			parameters[4].Value = model.DistrictID;

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
		public bool Delete(long DistrictID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_District ");
			strSql.Append(" where DistrictID=@DistrictID");
			SqlParameter[] parameters = {
					new SqlParameter("@DistrictID", SqlDbType.BigInt)
};
			parameters[0].Value = DistrictID;

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
		public bool DeleteList(string DistrictIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_District ");
			strSql.Append(" where DistrictID in ("+DistrictIDlist + ")  ");
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
		public hm.Model.S_District GetModel(long DistrictID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DistrictID,DistrictName,CityID,DateCreated,DateUpdated from S_District ");
			strSql.Append(" where DistrictID=@DistrictID");
			SqlParameter[] parameters = {
					new SqlParameter("@DistrictID", SqlDbType.BigInt)
};
			parameters[0].Value = DistrictID;

			hm.Model.S_District model=new hm.Model.S_District();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["DistrictID"]!=null && ds.Tables[0].Rows[0]["DistrictID"].ToString()!="")
				{
					model.DistrictID=long.Parse(ds.Tables[0].Rows[0]["DistrictID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DistrictName"]!=null && ds.Tables[0].Rows[0]["DistrictName"].ToString()!="")
				{
					model.DistrictName=ds.Tables[0].Rows[0]["DistrictName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CityID"]!=null && ds.Tables[0].Rows[0]["CityID"].ToString()!="")
				{
					model.CityID=long.Parse(ds.Tables[0].Rows[0]["CityID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateCreated"]!=null && ds.Tables[0].Rows[0]["DateCreated"].ToString()!="")
				{
					model.DateCreated=DateTime.Parse(ds.Tables[0].Rows[0]["DateCreated"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateUpdated"]!=null && ds.Tables[0].Rows[0]["DateUpdated"].ToString()!="")
				{
					model.DateUpdated=DateTime.Parse(ds.Tables[0].Rows[0]["DateUpdated"].ToString());
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
			strSql.Append("select DistrictID,DistrictName,CityID,DateCreated,DateUpdated ");
			strSql.Append(" FROM S_District ");
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
			strSql.Append(" DistrictID,DistrictName,CityID,DateCreated,DateUpdated ");
			strSql.Append(" FROM S_District ");
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
			parameters[0].Value = "S_District";
			parameters[1].Value = "DistrictID";
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


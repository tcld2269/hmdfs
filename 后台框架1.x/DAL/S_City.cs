using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:S_City
	/// </summary>
	public partial class S_City
	{
		public S_City()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long CityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from S_City");
			strSql.Append(" where CityID=@CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.BigInt)
};
			parameters[0].Value = CityID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(hm.Model.S_City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into S_City(");
			strSql.Append("CityName,ZipCode,ProvinceID,DateCreated,DateUpdated)");
			strSql.Append(" values (");
			strSql.Append("@CityName,@ZipCode,@ProvinceID,@DateCreated,@DateUpdated)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CityName", SqlDbType.NVarChar,50),
					new SqlParameter("@ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@ProvinceID", SqlDbType.BigInt,8),
					new SqlParameter("@DateCreated", SqlDbType.DateTime),
					new SqlParameter("@DateUpdated", SqlDbType.DateTime)};
			parameters[0].Value = model.CityName;
			parameters[1].Value = model.ZipCode;
			parameters[2].Value = model.ProvinceID;
			parameters[3].Value = model.DateCreated;
			parameters[4].Value = model.DateUpdated;

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
		public bool Update(hm.Model.S_City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update S_City set ");
			strSql.Append("CityName=@CityName,");
			strSql.Append("ZipCode=@ZipCode,");
			strSql.Append("ProvinceID=@ProvinceID,");
			strSql.Append("DateCreated=@DateCreated,");
			strSql.Append("DateUpdated=@DateUpdated");
			strSql.Append(" where CityID=@CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@CityName", SqlDbType.NVarChar,50),
					new SqlParameter("@ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@ProvinceID", SqlDbType.BigInt,8),
					new SqlParameter("@DateCreated", SqlDbType.DateTime),
					new SqlParameter("@DateUpdated", SqlDbType.DateTime),
					new SqlParameter("@CityID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.CityName;
			parameters[1].Value = model.ZipCode;
			parameters[2].Value = model.ProvinceID;
			parameters[3].Value = model.DateCreated;
			parameters[4].Value = model.DateUpdated;
			parameters[5].Value = model.CityID;

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
		public bool Delete(long CityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_City ");
			strSql.Append(" where CityID=@CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.BigInt)
};
			parameters[0].Value = CityID;

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
		public bool DeleteList(string CityIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_City ");
			strSql.Append(" where CityID in ("+CityIDlist + ")  ");
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
		public hm.Model.S_City GetModel(long CityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CityID,CityName,ZipCode,ProvinceID,DateCreated,DateUpdated from S_City ");
			strSql.Append(" where CityID=@CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.BigInt)
};
			parameters[0].Value = CityID;

			hm.Model.S_City model=new hm.Model.S_City();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["CityID"]!=null && ds.Tables[0].Rows[0]["CityID"].ToString()!="")
				{
					model.CityID=long.Parse(ds.Tables[0].Rows[0]["CityID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CityName"]!=null && ds.Tables[0].Rows[0]["CityName"].ToString()!="")
				{
					model.CityName=ds.Tables[0].Rows[0]["CityName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ZipCode"]!=null && ds.Tables[0].Rows[0]["ZipCode"].ToString()!="")
				{
					model.ZipCode=ds.Tables[0].Rows[0]["ZipCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProvinceID"]!=null && ds.Tables[0].Rows[0]["ProvinceID"].ToString()!="")
				{
					model.ProvinceID=long.Parse(ds.Tables[0].Rows[0]["ProvinceID"].ToString());
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
			strSql.Append("select CityID,CityName,ZipCode,ProvinceID,DateCreated,DateUpdated ");
			strSql.Append(" FROM S_City ");
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
			strSql.Append(" CityID,CityName,ZipCode,ProvinceID,DateCreated,DateUpdated ");
			strSql.Append(" FROM S_City ");
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
			parameters[0].Value = "S_City";
			parameters[1].Value = "CityID";
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


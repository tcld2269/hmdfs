using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:sysItemCategory
	/// </summary>
	public partial class sysItemCategory
	{
		public sysItemCategory()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("sicId", "sysItemCategory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int sicId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sysItemCategory");
			strSql.Append(" where sicId=@sicId");
			SqlParameter[] parameters = {
					new SqlParameter("@sicId", SqlDbType.Int,4)
};
			parameters[0].Value = sicId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.sysItemCategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sysItemCategory(");
			strSql.Append("innerName,catName)");
			strSql.Append(" values (");
			strSql.Append("@innerName,@catName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@innerName", SqlDbType.VarChar,100),
					new SqlParameter("@catName", SqlDbType.VarChar,100)};
			parameters[0].Value = model.innerName;
			parameters[1].Value = model.catName;

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
		public bool Update(hm.Model.sysItemCategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sysItemCategory set ");
			strSql.Append("innerName=@innerName,");
			strSql.Append("catName=@catName");
			strSql.Append(" where sicId=@sicId");
			SqlParameter[] parameters = {
					new SqlParameter("@innerName", SqlDbType.VarChar,100),
					new SqlParameter("@catName", SqlDbType.VarChar,100),
					new SqlParameter("@sicId", SqlDbType.Int,4)};
			parameters[0].Value = model.innerName;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.sicId;

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
		public bool Delete(int sicId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysItemCategory ");
			strSql.Append(" where sicId=@sicId");
			SqlParameter[] parameters = {
					new SqlParameter("@sicId", SqlDbType.Int,4)
};
			parameters[0].Value = sicId;

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
		public bool DeleteList(string sicIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysItemCategory ");
			strSql.Append(" where sicId in ("+sicIdlist + ")  ");
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
		public hm.Model.sysItemCategory GetModel(int sicId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 sicId,innerName,catName from sysItemCategory ");
			strSql.Append(" where sicId=@sicId");
			SqlParameter[] parameters = {
					new SqlParameter("@sicId", SqlDbType.Int,4)
};
			parameters[0].Value = sicId;

			hm.Model.sysItemCategory model=new hm.Model.sysItemCategory();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["sicId"]!=null && ds.Tables[0].Rows[0]["sicId"].ToString()!="")
				{
					model.sicId=int.Parse(ds.Tables[0].Rows[0]["sicId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["innerName"]!=null && ds.Tables[0].Rows[0]["innerName"].ToString()!="")
				{
					model.innerName=ds.Tables[0].Rows[0]["innerName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["catName"]!=null && ds.Tables[0].Rows[0]["catName"].ToString()!="")
				{
					model.catName=ds.Tables[0].Rows[0]["catName"].ToString();
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
			strSql.Append("select sicId,innerName,catName ");
			strSql.Append(" FROM sysItemCategory ");
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
			strSql.Append(" sicId,innerName,catName ");
			strSql.Append(" FROM sysItemCategory ");
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
			parameters[0].Value = "sysItemCategory";
			parameters[1].Value = "sicId";
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


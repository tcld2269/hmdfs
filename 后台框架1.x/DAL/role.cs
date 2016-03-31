using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:role
	/// </summary>
	public partial class role
	{
		public role()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("roleId", "role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int roleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from role");
			strSql.Append(" where roleId=@roleId");
			SqlParameter[] parameters = {
					new SqlParameter("@roleId", SqlDbType.Int,4)
};
			parameters[0].Value = roleId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into role(");
			strSql.Append("roleName)");
			strSql.Append(" values (");
			strSql.Append("@roleName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@roleName", SqlDbType.VarChar,100)};
			parameters[0].Value = model.roleName;

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
		public bool Update(hm.Model.role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update role set ");
			strSql.Append("roleName=@roleName");
			strSql.Append(" where roleId=@roleId");
			SqlParameter[] parameters = {
					new SqlParameter("@roleName", SqlDbType.VarChar,100),
					new SqlParameter("@roleId", SqlDbType.Int,4)};
			parameters[0].Value = model.roleName;
			parameters[1].Value = model.roleId;

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
		public bool Delete(int roleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from role ");
			strSql.Append(" where roleId=@roleId");
			SqlParameter[] parameters = {
					new SqlParameter("@roleId", SqlDbType.Int,4)
};
			parameters[0].Value = roleId;

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
		public bool DeleteList(string roleIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from role ");
			strSql.Append(" where roleId in ("+roleIdlist + ")  ");
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
		public hm.Model.role GetModel(int roleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 roleId,roleName from role ");
			strSql.Append(" where roleId=@roleId");
			SqlParameter[] parameters = {
					new SqlParameter("@roleId", SqlDbType.Int,4)
};
			parameters[0].Value = roleId;

			hm.Model.role model=new hm.Model.role();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["roleId"]!=null && ds.Tables[0].Rows[0]["roleId"].ToString()!="")
				{
					model.roleId=int.Parse(ds.Tables[0].Rows[0]["roleId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["roleName"]!=null && ds.Tables[0].Rows[0]["roleName"].ToString()!="")
				{
					model.roleName=ds.Tables[0].Rows[0]["roleName"].ToString();
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
			strSql.Append("select roleId,roleName ");
			strSql.Append(" FROM role ");
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
			strSql.Append(" roleId,roleName ");
			strSql.Append(" FROM role ");
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
			parameters[0].Value = "role";
			parameters[1].Value = "roleId";
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


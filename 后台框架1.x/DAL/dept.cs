using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:dept
	/// </summary>
	public partial class dept
	{
		public dept()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("deptId", "dept"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int deptId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from dept");
			strSql.Append(" where deptId=@deptId");
			SqlParameter[] parameters = {
					new SqlParameter("@deptId", SqlDbType.Int,4)
};
			parameters[0].Value = deptId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.dept model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dept(");
			strSql.Append("parentId,deptName,userId,manager)");
			strSql.Append(" values (");
			strSql.Append("@parentId,@deptName,@userId,@manager)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@deptName", SqlDbType.VarChar,100),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@manager", SqlDbType.VarChar,100)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.deptName;
			parameters[2].Value = model.userId;
			parameters[3].Value = model.manager;

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
		public bool Update(hm.Model.dept model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dept set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("deptName=@deptName,");
			strSql.Append("userId=@userId,");
			strSql.Append("manager=@manager");
			strSql.Append(" where deptId=@deptId");
			SqlParameter[] parameters = {
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@deptName", SqlDbType.VarChar,100),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@manager", SqlDbType.VarChar,100),
					new SqlParameter("@deptId", SqlDbType.Int,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.deptName;
			parameters[2].Value = model.userId;
			parameters[3].Value = model.manager;
			parameters[4].Value = model.deptId;

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
		public bool Delete(int deptId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept ");
			strSql.Append(" where deptId=@deptId");
			SqlParameter[] parameters = {
					new SqlParameter("@deptId", SqlDbType.Int,4)
};
			parameters[0].Value = deptId;

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
		public bool DeleteList(string deptIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept ");
			strSql.Append(" where deptId in ("+deptIdlist + ")  ");
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
		public hm.Model.dept GetModel(int deptId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 deptId,parentId,deptName,userId,manager from dept ");
			strSql.Append(" where deptId=@deptId");
			SqlParameter[] parameters = {
					new SqlParameter("@deptId", SqlDbType.Int,4)
};
			parameters[0].Value = deptId;

			hm.Model.dept model=new hm.Model.dept();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["deptId"]!=null && ds.Tables[0].Rows[0]["deptId"].ToString()!="")
				{
					model.deptId=int.Parse(ds.Tables[0].Rows[0]["deptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["deptName"]!=null && ds.Tables[0].Rows[0]["deptName"].ToString()!="")
				{
					model.deptName=ds.Tables[0].Rows[0]["deptName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["manager"]!=null && ds.Tables[0].Rows[0]["manager"].ToString()!="")
				{
					model.manager=ds.Tables[0].Rows[0]["manager"].ToString();
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
			strSql.Append("select deptId,parentId,deptName,userId,manager ");
			strSql.Append(" FROM dept ");
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
			strSql.Append(" deptId,parentId,deptName,userId,manager ");
			strSql.Append(" FROM dept ");
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
			parameters[0].Value = "dept";
			parameters[1].Value = "deptId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
        /// <summary>
        /// 
        /// </summary>
        public DataTable GetAllChild(int placeId)
        {
            string sql = "select a.* from [dept] a , f_cplaceId(" + placeId + ") b where a.deptId = b.deptId order by a.deptId";
            return DbHelperSQL.Query(sql).Tables[0];
        }
	}
}


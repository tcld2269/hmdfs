using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:newsCat
	/// </summary>
	public partial class newsCat
	{
		public newsCat()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("catId", "newsCat"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int catId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from newsCat");
			strSql.Append(" where catId=@catId");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4)
};
			parameters[0].Value = catId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.newsCat model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into newsCat(");
			strSql.Append("parentId,catName,type,orders,backCol)");
			strSql.Append(" values (");
			strSql.Append("@parentId,@catName,@type,@orders,@backCol)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@catName", SqlDbType.VarChar,100),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@backCol", SqlDbType.VarChar,100)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.type;
			parameters[3].Value = model.orders;
			parameters[4].Value = model.backCol;

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
		public bool Update(hm.Model.newsCat model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update newsCat set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("catName=@catName,");
			strSql.Append("type=@type,");
			strSql.Append("orders=@orders,");
			strSql.Append("backCol=@backCol");
			strSql.Append(" where catId=@catId");
			SqlParameter[] parameters = {
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@catName", SqlDbType.VarChar,100),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@backCol", SqlDbType.VarChar,100),
					new SqlParameter("@catId", SqlDbType.Int,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.type;
			parameters[3].Value = model.orders;
			parameters[4].Value = model.backCol;
			parameters[5].Value = model.catId;

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
		public bool Delete(int catId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from newsCat ");
			strSql.Append(" where catId=@catId");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4)
};
			parameters[0].Value = catId;

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
		public bool DeleteList(string catIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from newsCat ");
			strSql.Append(" where catId in ("+catIdlist + ")  ");
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
		public hm.Model.newsCat GetModel(int catId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 catId,parentId,catName,type,orders,backCol from newsCat ");
			strSql.Append(" where catId=@catId");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4)
};
			parameters[0].Value = catId;

			hm.Model.newsCat model=new hm.Model.newsCat();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["catId"]!=null && ds.Tables[0].Rows[0]["catId"].ToString()!="")
				{
					model.catId=int.Parse(ds.Tables[0].Rows[0]["catId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catName"]!=null && ds.Tables[0].Rows[0]["catName"].ToString()!="")
				{
					model.catName=ds.Tables[0].Rows[0]["catName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null && ds.Tables[0].Rows[0]["type"].ToString()!="")
				{
					model.type=int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["backCol"]!=null && ds.Tables[0].Rows[0]["backCol"].ToString()!="")
				{
					model.backCol=ds.Tables[0].Rows[0]["backCol"].ToString();
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
			strSql.Append("select catId,parentId,catName,type,orders,backCol ");
			strSql.Append(" FROM newsCat ");
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
			strSql.Append(" catId,parentId,catName,type,orders,backCol ");
			strSql.Append(" FROM newsCat ");
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
			parameters[0].Value = "newsCat";
			parameters[1].Value = "catId";
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


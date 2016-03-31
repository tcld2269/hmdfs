using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:menu
	/// </summary>
	public partial class menu
	{
		public menu()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("menuId", "menu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int menuId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from menu");
			strSql.Append(" where menuId=@menuId");
			SqlParameter[] parameters = {
					new SqlParameter("@menuId", SqlDbType.Int,4)
};
			parameters[0].Value = menuId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into menu(");
			strSql.Append("parentId,menuName,level,orders,url)");
			strSql.Append(" values (");
			strSql.Append("@parentId,@menuName,@level,@orders,@url)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@menuName", SqlDbType.VarChar,100),
					new SqlParameter("@level", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@url", SqlDbType.VarChar,100)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.menuName;
			parameters[2].Value = model.level;
			parameters[3].Value = model.orders;
			parameters[4].Value = model.url;

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
		public bool Update(hm.Model.menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update menu set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("menuName=@menuName,");
			strSql.Append("level=@level,");
			strSql.Append("orders=@orders,");
			strSql.Append("url=@url");
			strSql.Append(" where menuId=@menuId");
			SqlParameter[] parameters = {
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@menuName", SqlDbType.VarChar,100),
					new SqlParameter("@level", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@url", SqlDbType.VarChar,100),
					new SqlParameter("@menuId", SqlDbType.Int,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.menuName;
			parameters[2].Value = model.level;
			parameters[3].Value = model.orders;
			parameters[4].Value = model.url;
			parameters[5].Value = model.menuId;

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
		public bool Delete(int menuId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from menu ");
			strSql.Append(" where menuId=@menuId");
			SqlParameter[] parameters = {
					new SqlParameter("@menuId", SqlDbType.Int,4)
};
			parameters[0].Value = menuId;

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
		public bool DeleteList(string menuIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from menu ");
			strSql.Append(" where menuId in ("+menuIdlist + ")  ");
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
		public hm.Model.menu GetModel(int menuId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 menuId,parentId,menuName,level,orders,url from menu ");
			strSql.Append(" where menuId=@menuId");
			SqlParameter[] parameters = {
					new SqlParameter("@menuId", SqlDbType.Int,4)
};
			parameters[0].Value = menuId;

			hm.Model.menu model=new hm.Model.menu();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["menuId"]!=null && ds.Tables[0].Rows[0]["menuId"].ToString()!="")
				{
					model.menuId=int.Parse(ds.Tables[0].Rows[0]["menuId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["menuName"]!=null && ds.Tables[0].Rows[0]["menuName"].ToString()!="")
				{
					model.menuName=ds.Tables[0].Rows[0]["menuName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["level"]!=null && ds.Tables[0].Rows[0]["level"].ToString()!="")
				{
					model.level=int.Parse(ds.Tables[0].Rows[0]["level"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["url"]!=null && ds.Tables[0].Rows[0]["url"].ToString()!="")
				{
					model.url=ds.Tables[0].Rows[0]["url"].ToString();
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
			strSql.Append("select menuId,parentId,menuName,level,orders,url ");
			strSql.Append(" FROM menu ");
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
			strSql.Append(" menuId,parentId,menuName,level,orders,url ");
			strSql.Append(" FROM menu ");
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
			parameters[0].Value = "menu";
			parameters[1].Value = "menuId";
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


using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:userAddress
	/// </summary>
	public partial class userAddress
	{
		public userAddress()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "userAddress"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userAddress");
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
		public int Add(hm.Model.userAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userAddress(");
			strSql.Append("userId,contacts,tel,addressNo,addressInfo,isDefault)");
			strSql.Append(" values (");
			strSql.Append("@userId,@contacts,@tel,@addressNo,@addressInfo,@isDefault)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@contacts", SqlDbType.VarChar,200),
					new SqlParameter("@tel", SqlDbType.VarChar,200),
					new SqlParameter("@addressNo", SqlDbType.NChar,10),
					new SqlParameter("@addressInfo", SqlDbType.NChar,10),
					new SqlParameter("@isDefault", SqlDbType.Int,4)};
			parameters[0].Value = model.userId;
			parameters[1].Value = model.contacts;
			parameters[2].Value = model.tel;
			parameters[3].Value = model.addressNo;
			parameters[4].Value = model.addressInfo;
			parameters[5].Value = model.isDefault;

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
		public bool Update(hm.Model.userAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userAddress set ");
			strSql.Append("userId=@userId,");
			strSql.Append("contacts=@contacts,");
			strSql.Append("tel=@tel,");
			strSql.Append("addressNo=@addressNo,");
			strSql.Append("addressInfo=@addressInfo,");
			strSql.Append("isDefault=@isDefault");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@contacts", SqlDbType.VarChar,200),
					new SqlParameter("@tel", SqlDbType.VarChar,200),
					new SqlParameter("@addressNo", SqlDbType.NChar,10),
					new SqlParameter("@addressInfo", SqlDbType.NChar,10),
					new SqlParameter("@isDefault", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.userId;
			parameters[1].Value = model.contacts;
			parameters[2].Value = model.tel;
			parameters[3].Value = model.addressNo;
			parameters[4].Value = model.addressInfo;
			parameters[5].Value = model.isDefault;
			parameters[6].Value = model.id;

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
			strSql.Append("delete from userAddress ");
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
			strSql.Append("delete from userAddress ");
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
		public hm.Model.userAddress GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,userId,contacts,tel,addressNo,addressInfo,isDefault from userAddress ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.userAddress model=new hm.Model.userAddress();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["contacts"]!=null && ds.Tables[0].Rows[0]["contacts"].ToString()!="")
				{
					model.contacts=ds.Tables[0].Rows[0]["contacts"].ToString();
				}
				if(ds.Tables[0].Rows[0]["tel"]!=null && ds.Tables[0].Rows[0]["tel"].ToString()!="")
				{
					model.tel=ds.Tables[0].Rows[0]["tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addressNo"]!=null && ds.Tables[0].Rows[0]["addressNo"].ToString()!="")
				{
					model.addressNo=ds.Tables[0].Rows[0]["addressNo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addressInfo"]!=null && ds.Tables[0].Rows[0]["addressInfo"].ToString()!="")
				{
					model.addressInfo=ds.Tables[0].Rows[0]["addressInfo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isDefault"]!=null && ds.Tables[0].Rows[0]["isDefault"].ToString()!="")
				{
					model.isDefault=int.Parse(ds.Tables[0].Rows[0]["isDefault"].ToString());
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
			strSql.Append("select id,userId,contacts,tel,addressNo,addressInfo,isDefault ");
			strSql.Append(" FROM userAddress ");
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
			strSql.Append(" id,userId,contacts,tel,addressNo,addressInfo,isDefault ");
			strSql.Append(" FROM userAddress ");
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
			parameters[0].Value = "userAddress";
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


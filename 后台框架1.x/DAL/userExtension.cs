using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:userExtension
	/// </summary>
	public partial class userExtension
	{
		public userExtension()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("userId", "userExtension"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userExtension");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)};
			parameters[0].Value = userId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.userExtension model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userExtension(");
			strSql.Append("userId,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15)");
			strSql.Append(" values (");
			strSql.Append("@userId,@ext1,@ext2,@ext3,@ext4,@ext5,@ext6,@ext7,@ext8,@ext9,@ext10,@ext11,@ext12,@ext13,@ext14,@ext15)");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@ext1", SqlDbType.VarChar,500),
					new SqlParameter("@ext2", SqlDbType.VarChar,500),
					new SqlParameter("@ext3", SqlDbType.VarChar,500),
					new SqlParameter("@ext4", SqlDbType.VarChar,500),
					new SqlParameter("@ext5", SqlDbType.VarChar,500),
					new SqlParameter("@ext6", SqlDbType.VarChar,500),
					new SqlParameter("@ext7", SqlDbType.VarChar,500),
					new SqlParameter("@ext8", SqlDbType.VarChar,500),
					new SqlParameter("@ext9", SqlDbType.VarChar,500),
					new SqlParameter("@ext10", SqlDbType.VarChar,500),
					new SqlParameter("@ext11", SqlDbType.VarChar,500),
					new SqlParameter("@ext12", SqlDbType.VarChar,500),
					new SqlParameter("@ext13", SqlDbType.VarChar,500),
					new SqlParameter("@ext14", SqlDbType.VarChar,500),
					new SqlParameter("@ext15", SqlDbType.VarChar,500)};
			parameters[0].Value = model.userId;
			parameters[1].Value = model.ext1;
			parameters[2].Value = model.ext2;
			parameters[3].Value = model.ext3;
			parameters[4].Value = model.ext4;
			parameters[5].Value = model.ext5;
			parameters[6].Value = model.ext6;
			parameters[7].Value = model.ext7;
			parameters[8].Value = model.ext8;
			parameters[9].Value = model.ext9;
			parameters[10].Value = model.ext10;
			parameters[11].Value = model.ext11;
			parameters[12].Value = model.ext12;
			parameters[13].Value = model.ext13;
			parameters[14].Value = model.ext14;
			parameters[15].Value = model.ext15;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.userExtension model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userExtension set ");
			strSql.Append("ext1=@ext1,");
			strSql.Append("ext2=@ext2,");
			strSql.Append("ext3=@ext3,");
			strSql.Append("ext4=@ext4,");
			strSql.Append("ext5=@ext5,");
			strSql.Append("ext6=@ext6,");
			strSql.Append("ext7=@ext7,");
			strSql.Append("ext8=@ext8,");
			strSql.Append("ext9=@ext9,");
			strSql.Append("ext10=@ext10,");
			strSql.Append("ext11=@ext11,");
			strSql.Append("ext12=@ext12,");
			strSql.Append("ext13=@ext13,");
			strSql.Append("ext14=@ext14,");
			strSql.Append("ext15=@ext15");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@ext1", SqlDbType.VarChar,500),
					new SqlParameter("@ext2", SqlDbType.VarChar,500),
					new SqlParameter("@ext3", SqlDbType.VarChar,500),
					new SqlParameter("@ext4", SqlDbType.VarChar,500),
					new SqlParameter("@ext5", SqlDbType.VarChar,500),
					new SqlParameter("@ext6", SqlDbType.VarChar,500),
					new SqlParameter("@ext7", SqlDbType.VarChar,500),
					new SqlParameter("@ext8", SqlDbType.VarChar,500),
					new SqlParameter("@ext9", SqlDbType.VarChar,500),
					new SqlParameter("@ext10", SqlDbType.VarChar,500),
					new SqlParameter("@ext11", SqlDbType.VarChar,500),
					new SqlParameter("@ext12", SqlDbType.VarChar,500),
					new SqlParameter("@ext13", SqlDbType.VarChar,500),
					new SqlParameter("@ext14", SqlDbType.VarChar,500),
					new SqlParameter("@ext15", SqlDbType.VarChar,500),
					new SqlParameter("@userId", SqlDbType.Int,4)};
			parameters[0].Value = model.ext1;
			parameters[1].Value = model.ext2;
			parameters[2].Value = model.ext3;
			parameters[3].Value = model.ext4;
			parameters[4].Value = model.ext5;
			parameters[5].Value = model.ext6;
			parameters[6].Value = model.ext7;
			parameters[7].Value = model.ext8;
			parameters[8].Value = model.ext9;
			parameters[9].Value = model.ext10;
			parameters[10].Value = model.ext11;
			parameters[11].Value = model.ext12;
			parameters[12].Value = model.ext13;
			parameters[13].Value = model.ext14;
			parameters[14].Value = model.ext15;
			parameters[15].Value = model.userId;

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
		public bool Delete(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userExtension ");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)};
			parameters[0].Value = userId;

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
		public bool DeleteList(string userIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userExtension ");
			strSql.Append(" where userId in ("+userIdlist + ")  ");
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
		public hm.Model.userExtension GetModel(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userId,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15 from userExtension ");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)};
			parameters[0].Value = userId;

			hm.Model.userExtension model=new hm.Model.userExtension();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ext1"]!=null && ds.Tables[0].Rows[0]["ext1"].ToString()!="")
				{
					model.ext1=ds.Tables[0].Rows[0]["ext1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext2"]!=null && ds.Tables[0].Rows[0]["ext2"].ToString()!="")
				{
					model.ext2=ds.Tables[0].Rows[0]["ext2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext3"]!=null && ds.Tables[0].Rows[0]["ext3"].ToString()!="")
				{
					model.ext3=ds.Tables[0].Rows[0]["ext3"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext4"]!=null && ds.Tables[0].Rows[0]["ext4"].ToString()!="")
				{
					model.ext4=ds.Tables[0].Rows[0]["ext4"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext5"]!=null && ds.Tables[0].Rows[0]["ext5"].ToString()!="")
				{
					model.ext5=ds.Tables[0].Rows[0]["ext5"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext6"]!=null && ds.Tables[0].Rows[0]["ext6"].ToString()!="")
				{
					model.ext6=ds.Tables[0].Rows[0]["ext6"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext7"]!=null && ds.Tables[0].Rows[0]["ext7"].ToString()!="")
				{
					model.ext7=ds.Tables[0].Rows[0]["ext7"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext8"]!=null && ds.Tables[0].Rows[0]["ext8"].ToString()!="")
				{
					model.ext8=ds.Tables[0].Rows[0]["ext8"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext9"]!=null && ds.Tables[0].Rows[0]["ext9"].ToString()!="")
				{
					model.ext9=ds.Tables[0].Rows[0]["ext9"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext10"]!=null && ds.Tables[0].Rows[0]["ext10"].ToString()!="")
				{
					model.ext10=ds.Tables[0].Rows[0]["ext10"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext11"]!=null && ds.Tables[0].Rows[0]["ext11"].ToString()!="")
				{
					model.ext11=ds.Tables[0].Rows[0]["ext11"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext12"]!=null && ds.Tables[0].Rows[0]["ext12"].ToString()!="")
				{
					model.ext12=ds.Tables[0].Rows[0]["ext12"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext13"]!=null && ds.Tables[0].Rows[0]["ext13"].ToString()!="")
				{
					model.ext13=ds.Tables[0].Rows[0]["ext13"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext14"]!=null && ds.Tables[0].Rows[0]["ext14"].ToString()!="")
				{
					model.ext14=ds.Tables[0].Rows[0]["ext14"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ext15"]!=null && ds.Tables[0].Rows[0]["ext15"].ToString()!="")
				{
					model.ext15=ds.Tables[0].Rows[0]["ext15"].ToString();
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
			strSql.Append("select userId,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15 ");
			strSql.Append(" FROM userExtension ");
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
			strSql.Append(" userId,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15 ");
			strSql.Append(" FROM userExtension ");
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
			parameters[0].Value = "userExtension";
			parameters[1].Value = "userId";
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


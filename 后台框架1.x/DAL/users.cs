using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:users
	/// </summary>
	public partial class users
	{
		public users()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("userId", "users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from users");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
};
			parameters[0].Value = userId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into users(");
			strSql.Append("userName,password,trueName,nickName,addressCode,address,avatar_small,avatar_big,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,scoreFrozen,account,accountFrozen,regType,regFrom,addTime,lastLoginTime,loginCount,isAdmin,wxOpenId,status)");
			strSql.Append(" values (");
			strSql.Append("@userName,@password,@trueName,@nickName,@addressCode,@address,@avatar_small,@avatar_big,@deptId,@deptName,@roleId,@roleName,@sex,@tel,@email,@qq,@score,@scoreFrozen,@account,@accountFrozen,@regType,@regFrom,@addTime,@lastLoginTime,@loginCount,@isAdmin,@wxOpenId,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.VarChar,100),
					new SqlParameter("@password", SqlDbType.VarChar,100),
					new SqlParameter("@trueName", SqlDbType.VarChar,100),
					new SqlParameter("@nickName", SqlDbType.VarChar,100),
					new SqlParameter("@addressCode", SqlDbType.VarChar,100),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@avatar_small", SqlDbType.VarChar,100),
					new SqlParameter("@avatar_big", SqlDbType.VarChar,100),
					new SqlParameter("@deptId", SqlDbType.Int,4),
					new SqlParameter("@deptName", SqlDbType.VarChar,100),
					new SqlParameter("@roleId", SqlDbType.Int,4),
					new SqlParameter("@roleName", SqlDbType.VarChar,100),
					new SqlParameter("@sex", SqlDbType.Int,4),
					new SqlParameter("@tel", SqlDbType.VarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,100),
					new SqlParameter("@qq", SqlDbType.VarChar,100),
					new SqlParameter("@score", SqlDbType.Int,4),
					new SqlParameter("@scoreFrozen", SqlDbType.Int,4),
					new SqlParameter("@account", SqlDbType.Decimal,9),
					new SqlParameter("@accountFrozen", SqlDbType.Decimal,9),
					new SqlParameter("@regType", SqlDbType.VarChar,100),
					new SqlParameter("@regFrom", SqlDbType.VarChar,100),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@lastLoginTime", SqlDbType.DateTime),
					new SqlParameter("@loginCount", SqlDbType.Int,4),
					new SqlParameter("@isAdmin", SqlDbType.Int,4),
					new SqlParameter("@wxOpenId", SqlDbType.VarChar,200),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.password;
			parameters[2].Value = model.trueName;
			parameters[3].Value = model.nickName;
			parameters[4].Value = model.addressCode;
			parameters[5].Value = model.address;
			parameters[6].Value = model.avatar_small;
			parameters[7].Value = model.avatar_big;
			parameters[8].Value = model.deptId;
			parameters[9].Value = model.deptName;
			parameters[10].Value = model.roleId;
			parameters[11].Value = model.roleName;
			parameters[12].Value = model.sex;
			parameters[13].Value = model.tel;
			parameters[14].Value = model.email;
			parameters[15].Value = model.qq;
			parameters[16].Value = model.score;
			parameters[17].Value = model.scoreFrozen;
			parameters[18].Value = model.account;
			parameters[19].Value = model.accountFrozen;
			parameters[20].Value = model.regType;
			parameters[21].Value = model.regFrom;
			parameters[22].Value = model.addTime;
			parameters[23].Value = model.lastLoginTime;
			parameters[24].Value = model.loginCount;
			parameters[25].Value = model.isAdmin;
			parameters[26].Value = model.wxOpenId;
			parameters[27].Value = model.status;

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
		public bool Update(hm.Model.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update users set ");
			strSql.Append("userName=@userName,");
			strSql.Append("password=@password,");
			strSql.Append("trueName=@trueName,");
			strSql.Append("nickName=@nickName,");
			strSql.Append("addressCode=@addressCode,");
			strSql.Append("address=@address,");
			strSql.Append("avatar_small=@avatar_small,");
			strSql.Append("avatar_big=@avatar_big,");
			strSql.Append("deptId=@deptId,");
			strSql.Append("deptName=@deptName,");
			strSql.Append("roleId=@roleId,");
			strSql.Append("roleName=@roleName,");
			strSql.Append("sex=@sex,");
			strSql.Append("tel=@tel,");
			strSql.Append("email=@email,");
			strSql.Append("qq=@qq,");
			strSql.Append("score=@score,");
			strSql.Append("scoreFrozen=@scoreFrozen,");
			strSql.Append("account=@account,");
			strSql.Append("accountFrozen=@accountFrozen,");
			strSql.Append("regType=@regType,");
			strSql.Append("regFrom=@regFrom,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("lastLoginTime=@lastLoginTime,");
			strSql.Append("loginCount=@loginCount,");
			strSql.Append("isAdmin=@isAdmin,");
			strSql.Append("wxOpenId=@wxOpenId,");
			strSql.Append("status=@status");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.VarChar,100),
					new SqlParameter("@password", SqlDbType.VarChar,100),
					new SqlParameter("@trueName", SqlDbType.VarChar,100),
					new SqlParameter("@nickName", SqlDbType.VarChar,100),
					new SqlParameter("@addressCode", SqlDbType.VarChar,100),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@avatar_small", SqlDbType.VarChar,100),
					new SqlParameter("@avatar_big", SqlDbType.VarChar,100),
					new SqlParameter("@deptId", SqlDbType.Int,4),
					new SqlParameter("@deptName", SqlDbType.VarChar,100),
					new SqlParameter("@roleId", SqlDbType.Int,4),
					new SqlParameter("@roleName", SqlDbType.VarChar,100),
					new SqlParameter("@sex", SqlDbType.Int,4),
					new SqlParameter("@tel", SqlDbType.VarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,100),
					new SqlParameter("@qq", SqlDbType.VarChar,100),
					new SqlParameter("@score", SqlDbType.Int,4),
					new SqlParameter("@scoreFrozen", SqlDbType.Int,4),
					new SqlParameter("@account", SqlDbType.Decimal,9),
					new SqlParameter("@accountFrozen", SqlDbType.Decimal,9),
					new SqlParameter("@regType", SqlDbType.VarChar,100),
					new SqlParameter("@regFrom", SqlDbType.VarChar,100),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@lastLoginTime", SqlDbType.DateTime),
					new SqlParameter("@loginCount", SqlDbType.Int,4),
					new SqlParameter("@isAdmin", SqlDbType.Int,4),
					new SqlParameter("@wxOpenId", SqlDbType.VarChar,200),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@userId", SqlDbType.Int,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.password;
			parameters[2].Value = model.trueName;
			parameters[3].Value = model.nickName;
			parameters[4].Value = model.addressCode;
			parameters[5].Value = model.address;
			parameters[6].Value = model.avatar_small;
			parameters[7].Value = model.avatar_big;
			parameters[8].Value = model.deptId;
			parameters[9].Value = model.deptName;
			parameters[10].Value = model.roleId;
			parameters[11].Value = model.roleName;
			parameters[12].Value = model.sex;
			parameters[13].Value = model.tel;
			parameters[14].Value = model.email;
			parameters[15].Value = model.qq;
			parameters[16].Value = model.score;
			parameters[17].Value = model.scoreFrozen;
			parameters[18].Value = model.account;
			parameters[19].Value = model.accountFrozen;
			parameters[20].Value = model.regType;
			parameters[21].Value = model.regFrom;
			parameters[22].Value = model.addTime;
			parameters[23].Value = model.lastLoginTime;
			parameters[24].Value = model.loginCount;
			parameters[25].Value = model.isAdmin;
			parameters[26].Value = model.wxOpenId;
			parameters[27].Value = model.status;
			parameters[28].Value = model.userId;

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
			strSql.Append("delete from users ");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
};
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
			strSql.Append("delete from users ");
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
		public hm.Model.users GetModel(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userId,userName,password,trueName,nickName,addressCode,address,avatar_small,avatar_big,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,scoreFrozen,account,accountFrozen,regType,regFrom,addTime,lastLoginTime,loginCount,isAdmin,wxOpenId,status from users ");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
};
			parameters[0].Value = userId;

			hm.Model.users model=new hm.Model.users();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["password"]!=null && ds.Tables[0].Rows[0]["password"].ToString()!="")
				{
					model.password=ds.Tables[0].Rows[0]["password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["trueName"]!=null && ds.Tables[0].Rows[0]["trueName"].ToString()!="")
				{
					model.trueName=ds.Tables[0].Rows[0]["trueName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["nickName"]!=null && ds.Tables[0].Rows[0]["nickName"].ToString()!="")
				{
					model.nickName=ds.Tables[0].Rows[0]["nickName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addressCode"]!=null && ds.Tables[0].Rows[0]["addressCode"].ToString()!="")
				{
					model.addressCode=ds.Tables[0].Rows[0]["addressCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["address"]!=null && ds.Tables[0].Rows[0]["address"].ToString()!="")
				{
					model.address=ds.Tables[0].Rows[0]["address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["avatar_small"]!=null && ds.Tables[0].Rows[0]["avatar_small"].ToString()!="")
				{
					model.avatar_small=ds.Tables[0].Rows[0]["avatar_small"].ToString();
				}
				if(ds.Tables[0].Rows[0]["avatar_big"]!=null && ds.Tables[0].Rows[0]["avatar_big"].ToString()!="")
				{
					model.avatar_big=ds.Tables[0].Rows[0]["avatar_big"].ToString();
				}
				if(ds.Tables[0].Rows[0]["deptId"]!=null && ds.Tables[0].Rows[0]["deptId"].ToString()!="")
				{
					model.deptId=int.Parse(ds.Tables[0].Rows[0]["deptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["deptName"]!=null && ds.Tables[0].Rows[0]["deptName"].ToString()!="")
				{
					model.deptName=ds.Tables[0].Rows[0]["deptName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["roleId"]!=null && ds.Tables[0].Rows[0]["roleId"].ToString()!="")
				{
					model.roleId=int.Parse(ds.Tables[0].Rows[0]["roleId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["roleName"]!=null && ds.Tables[0].Rows[0]["roleName"].ToString()!="")
				{
					model.roleName=ds.Tables[0].Rows[0]["roleName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					model.sex=int.Parse(ds.Tables[0].Rows[0]["sex"].ToString());
				}
				if(ds.Tables[0].Rows[0]["tel"]!=null && ds.Tables[0].Rows[0]["tel"].ToString()!="")
				{
					model.tel=ds.Tables[0].Rows[0]["tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null && ds.Tables[0].Rows[0]["email"].ToString()!="")
				{
					model.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["qq"]!=null && ds.Tables[0].Rows[0]["qq"].ToString()!="")
				{
					model.qq=ds.Tables[0].Rows[0]["qq"].ToString();
				}
				if(ds.Tables[0].Rows[0]["score"]!=null && ds.Tables[0].Rows[0]["score"].ToString()!="")
				{
					model.score=int.Parse(ds.Tables[0].Rows[0]["score"].ToString());
				}
				if(ds.Tables[0].Rows[0]["scoreFrozen"]!=null && ds.Tables[0].Rows[0]["scoreFrozen"].ToString()!="")
				{
					model.scoreFrozen=int.Parse(ds.Tables[0].Rows[0]["scoreFrozen"].ToString());
				}
				if(ds.Tables[0].Rows[0]["account"]!=null && ds.Tables[0].Rows[0]["account"].ToString()!="")
				{
					model.account=decimal.Parse(ds.Tables[0].Rows[0]["account"].ToString());
				}
				if(ds.Tables[0].Rows[0]["accountFrozen"]!=null && ds.Tables[0].Rows[0]["accountFrozen"].ToString()!="")
				{
					model.accountFrozen=decimal.Parse(ds.Tables[0].Rows[0]["accountFrozen"].ToString());
				}
				if(ds.Tables[0].Rows[0]["regType"]!=null && ds.Tables[0].Rows[0]["regType"].ToString()!="")
				{
					model.regType=ds.Tables[0].Rows[0]["regType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["regFrom"]!=null && ds.Tables[0].Rows[0]["regFrom"].ToString()!="")
				{
					model.regFrom=ds.Tables[0].Rows[0]["regFrom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["lastLoginTime"]!=null && ds.Tables[0].Rows[0]["lastLoginTime"].ToString()!="")
				{
					model.lastLoginTime=DateTime.Parse(ds.Tables[0].Rows[0]["lastLoginTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["loginCount"]!=null && ds.Tables[0].Rows[0]["loginCount"].ToString()!="")
				{
					model.loginCount=int.Parse(ds.Tables[0].Rows[0]["loginCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isAdmin"]!=null && ds.Tables[0].Rows[0]["isAdmin"].ToString()!="")
				{
					model.isAdmin=int.Parse(ds.Tables[0].Rows[0]["isAdmin"].ToString());
				}
				if(ds.Tables[0].Rows[0]["wxOpenId"]!=null && ds.Tables[0].Rows[0]["wxOpenId"].ToString()!="")
				{
					model.wxOpenId=ds.Tables[0].Rows[0]["wxOpenId"].ToString();
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
			strSql.Append("select userId,userName,password,trueName,nickName,addressCode,address,avatar_small,avatar_big,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,scoreFrozen,account,accountFrozen,regType,regFrom,addTime,lastLoginTime,loginCount,isAdmin,wxOpenId,status ");
			strSql.Append(" FROM users ");
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
			strSql.Append(" userId,userName,password,trueName,nickName,addressCode,address,avatar_small,avatar_big,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,scoreFrozen,account,accountFrozen,regType,regFrom,addTime,lastLoginTime,loginCount,isAdmin,wxOpenId,status ");
			strSql.Append(" FROM users ");
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
			parameters[0].Value = "users";
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


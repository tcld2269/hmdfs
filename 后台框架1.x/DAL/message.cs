using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:message
	/// </summary>
	public partial class message
	{
		public message()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from message");
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
		public int Add(hm.Model.message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into message(");
			strSql.Append("receiverId,receiverName,senderId,senderName,title,remark,type,addTime,status)");
			strSql.Append(" values (");
			strSql.Append("@receiverId,@receiverName,@senderId,@senderName,@title,@remark,@type,@addTime,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@receiverName", SqlDbType.VarChar,200),
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@senderName", SqlDbType.VarChar,200),
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.receiverId;
			parameters[1].Value = model.receiverName;
			parameters[2].Value = model.senderId;
			parameters[3].Value = model.senderName;
			parameters[4].Value = model.title;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.type;
			parameters[7].Value = model.addTime;
			parameters[8].Value = model.status;

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
		public bool Update(hm.Model.message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update message set ");
			strSql.Append("receiverId=@receiverId,");
			strSql.Append("receiverName=@receiverName,");
			strSql.Append("senderId=@senderId,");
			strSql.Append("senderName=@senderName,");
			strSql.Append("title=@title,");
			strSql.Append("remark=@remark,");
			strSql.Append("type=@type,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@receiverName", SqlDbType.VarChar,200),
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@senderName", SqlDbType.VarChar,200),
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.receiverId;
			parameters[1].Value = model.receiverName;
			parameters[2].Value = model.senderId;
			parameters[3].Value = model.senderName;
			parameters[4].Value = model.title;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.type;
			parameters[7].Value = model.addTime;
			parameters[8].Value = model.status;
			parameters[9].Value = model.id;

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
			strSql.Append("delete from message ");
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
			strSql.Append("delete from message ");
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
		public hm.Model.message GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,receiverId,receiverName,senderId,senderName,title,remark,type,addTime,status from message ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.message model=new hm.Model.message();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["receiverId"]!=null && ds.Tables[0].Rows[0]["receiverId"].ToString()!="")
				{
					model.receiverId=int.Parse(ds.Tables[0].Rows[0]["receiverId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["receiverName"]!=null && ds.Tables[0].Rows[0]["receiverName"].ToString()!="")
				{
					model.receiverName=ds.Tables[0].Rows[0]["receiverName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["senderId"]!=null && ds.Tables[0].Rows[0]["senderId"].ToString()!="")
				{
					model.senderId=int.Parse(ds.Tables[0].Rows[0]["senderId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["senderName"]!=null && ds.Tables[0].Rows[0]["senderName"].ToString()!="")
				{
					model.senderName=ds.Tables[0].Rows[0]["senderName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null && ds.Tables[0].Rows[0]["type"].ToString()!="")
				{
					model.type=int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
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
			strSql.Append("select id,receiverId,receiverName,senderId,senderName,title,remark,type,addTime,status ");
			strSql.Append(" FROM message ");
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
			strSql.Append(" id,receiverId,receiverName,senderId,senderName,title,remark,type,addTime,status ");
			strSql.Append(" FROM message ");
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
			parameters[0].Value = "message";
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


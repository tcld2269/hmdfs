using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:shoppingPayment
	/// </summary>
	public partial class shoppingPayment
	{
		public shoppingPayment()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "shoppingPayment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shoppingPayment");
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
		public int Add(hm.Model.shoppingPayment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shoppingPayment(");
			strSql.Append("name,code,summary,returnUrl,notifyUrl,ico,gateUrl,filePath,parm1,parm2,parm3,parm4,parm5,status)");
			strSql.Append(" values (");
			strSql.Append("@name,@code,@summary,@returnUrl,@notifyUrl,@ico,@gateUrl,@filePath,@parm1,@parm2,@parm3,@parm4,@parm5,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@code", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@returnUrl", SqlDbType.VarChar,500),
					new SqlParameter("@notifyUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ico", SqlDbType.VarChar,200),
					new SqlParameter("@gateUrl", SqlDbType.VarChar,500),
					new SqlParameter("@filePath", SqlDbType.VarChar,500),
					new SqlParameter("@parm1", SqlDbType.VarChar,500),
					new SqlParameter("@parm2", SqlDbType.VarChar,500),
					new SqlParameter("@parm3", SqlDbType.VarChar,500),
					new SqlParameter("@parm4", SqlDbType.VarChar,500),
					new SqlParameter("@parm5", SqlDbType.VarChar,500),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.code;
			parameters[2].Value = model.summary;
			parameters[3].Value = model.returnUrl;
			parameters[4].Value = model.notifyUrl;
			parameters[5].Value = model.ico;
			parameters[6].Value = model.gateUrl;
			parameters[7].Value = model.filePath;
			parameters[8].Value = model.parm1;
			parameters[9].Value = model.parm2;
			parameters[10].Value = model.parm3;
			parameters[11].Value = model.parm4;
			parameters[12].Value = model.parm5;
			parameters[13].Value = model.status;

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
		public bool Update(hm.Model.shoppingPayment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shoppingPayment set ");
			strSql.Append("name=@name,");
			strSql.Append("code=@code,");
			strSql.Append("summary=@summary,");
			strSql.Append("returnUrl=@returnUrl,");
			strSql.Append("notifyUrl=@notifyUrl,");
			strSql.Append("ico=@ico,");
			strSql.Append("gateUrl=@gateUrl,");
			strSql.Append("filePath=@filePath,");
			strSql.Append("parm1=@parm1,");
			strSql.Append("parm2=@parm2,");
			strSql.Append("parm3=@parm3,");
			strSql.Append("parm4=@parm4,");
			strSql.Append("parm5=@parm5,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@code", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@returnUrl", SqlDbType.VarChar,500),
					new SqlParameter("@notifyUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ico", SqlDbType.VarChar,200),
					new SqlParameter("@gateUrl", SqlDbType.VarChar,500),
					new SqlParameter("@filePath", SqlDbType.VarChar,500),
					new SqlParameter("@parm1", SqlDbType.VarChar,500),
					new SqlParameter("@parm2", SqlDbType.VarChar,500),
					new SqlParameter("@parm3", SqlDbType.VarChar,500),
					new SqlParameter("@parm4", SqlDbType.VarChar,500),
					new SqlParameter("@parm5", SqlDbType.VarChar,500),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.code;
			parameters[2].Value = model.summary;
			parameters[3].Value = model.returnUrl;
			parameters[4].Value = model.notifyUrl;
			parameters[5].Value = model.ico;
			parameters[6].Value = model.gateUrl;
			parameters[7].Value = model.filePath;
			parameters[8].Value = model.parm1;
			parameters[9].Value = model.parm2;
			parameters[10].Value = model.parm3;
			parameters[11].Value = model.parm4;
			parameters[12].Value = model.parm5;
			parameters[13].Value = model.status;
			parameters[14].Value = model.id;

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
			strSql.Append("delete from shoppingPayment ");
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
			strSql.Append("delete from shoppingPayment ");
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
		public hm.Model.shoppingPayment GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,code,summary,returnUrl,notifyUrl,ico,gateUrl,filePath,parm1,parm2,parm3,parm4,parm5,status from shoppingPayment ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.shoppingPayment model=new hm.Model.shoppingPayment();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["name"]!=null && ds.Tables[0].Rows[0]["name"].ToString()!="")
				{
					model.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["code"]!=null && ds.Tables[0].Rows[0]["code"].ToString()!="")
				{
					model.code=ds.Tables[0].Rows[0]["code"].ToString();
				}
				if(ds.Tables[0].Rows[0]["summary"]!=null && ds.Tables[0].Rows[0]["summary"].ToString()!="")
				{
					model.summary=ds.Tables[0].Rows[0]["summary"].ToString();
				}
				if(ds.Tables[0].Rows[0]["returnUrl"]!=null && ds.Tables[0].Rows[0]["returnUrl"].ToString()!="")
				{
					model.returnUrl=ds.Tables[0].Rows[0]["returnUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["notifyUrl"]!=null && ds.Tables[0].Rows[0]["notifyUrl"].ToString()!="")
				{
					model.notifyUrl=ds.Tables[0].Rows[0]["notifyUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ico"]!=null && ds.Tables[0].Rows[0]["ico"].ToString()!="")
				{
					model.ico=ds.Tables[0].Rows[0]["ico"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gateUrl"]!=null && ds.Tables[0].Rows[0]["gateUrl"].ToString()!="")
				{
					model.gateUrl=ds.Tables[0].Rows[0]["gateUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["filePath"]!=null && ds.Tables[0].Rows[0]["filePath"].ToString()!="")
				{
					model.filePath=ds.Tables[0].Rows[0]["filePath"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parm1"]!=null && ds.Tables[0].Rows[0]["parm1"].ToString()!="")
				{
					model.parm1=ds.Tables[0].Rows[0]["parm1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parm2"]!=null && ds.Tables[0].Rows[0]["parm2"].ToString()!="")
				{
					model.parm2=ds.Tables[0].Rows[0]["parm2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parm3"]!=null && ds.Tables[0].Rows[0]["parm3"].ToString()!="")
				{
					model.parm3=ds.Tables[0].Rows[0]["parm3"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parm4"]!=null && ds.Tables[0].Rows[0]["parm4"].ToString()!="")
				{
					model.parm4=ds.Tables[0].Rows[0]["parm4"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parm5"]!=null && ds.Tables[0].Rows[0]["parm5"].ToString()!="")
				{
					model.parm5=ds.Tables[0].Rows[0]["parm5"].ToString();
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
			strSql.Append("select id,name,code,summary,returnUrl,notifyUrl,ico,gateUrl,filePath,parm1,parm2,parm3,parm4,parm5,status ");
			strSql.Append(" FROM shoppingPayment ");
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
			strSql.Append(" id,name,code,summary,returnUrl,notifyUrl,ico,gateUrl,filePath,parm1,parm2,parm3,parm4,parm5,status ");
			strSql.Append(" FROM shoppingPayment ");
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
			parameters[0].Value = "shoppingPayment";
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


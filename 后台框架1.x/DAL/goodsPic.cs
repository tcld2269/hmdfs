using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:goodsPic
	/// </summary>
	public partial class goodsPic
	{
		public goodsPic()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "goodsPic"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from goodsPic");
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
		public int Add(hm.Model.goodsPic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into goodsPic(");
			strSql.Append("goodsId,goodsName,picSmall,picNormal,picBig,orders,isDefault,isShow,addTime)");
			strSql.Append(" values (");
			strSql.Append("@goodsId,@goodsName,@picSmall,@picNormal,@picBig,@orders,@isDefault,@isShow,@addTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@goodsId", SqlDbType.Int,4),
					new SqlParameter("@goodsName", SqlDbType.VarChar,200),
					new SqlParameter("@picSmall", SqlDbType.VarChar,200),
					new SqlParameter("@picNormal", SqlDbType.VarChar,200),
					new SqlParameter("@picBig", SqlDbType.VarChar,200),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@isDefault", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime)};
			parameters[0].Value = model.goodsId;
			parameters[1].Value = model.goodsName;
			parameters[2].Value = model.picSmall;
			parameters[3].Value = model.picNormal;
			parameters[4].Value = model.picBig;
			parameters[5].Value = model.orders;
			parameters[6].Value = model.isDefault;
			parameters[7].Value = model.isShow;
			parameters[8].Value = model.addTime;

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
		public bool Update(hm.Model.goodsPic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update goodsPic set ");
			strSql.Append("goodsId=@goodsId,");
			strSql.Append("goodsName=@goodsName,");
			strSql.Append("picSmall=@picSmall,");
			strSql.Append("picNormal=@picNormal,");
			strSql.Append("picBig=@picBig,");
			strSql.Append("orders=@orders,");
			strSql.Append("isDefault=@isDefault,");
			strSql.Append("isShow=@isShow,");
			strSql.Append("addTime=@addTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@goodsId", SqlDbType.Int,4),
					new SqlParameter("@goodsName", SqlDbType.VarChar,200),
					new SqlParameter("@picSmall", SqlDbType.VarChar,200),
					new SqlParameter("@picNormal", SqlDbType.VarChar,200),
					new SqlParameter("@picBig", SqlDbType.VarChar,200),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@isDefault", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.goodsId;
			parameters[1].Value = model.goodsName;
			parameters[2].Value = model.picSmall;
			parameters[3].Value = model.picNormal;
			parameters[4].Value = model.picBig;
			parameters[5].Value = model.orders;
			parameters[6].Value = model.isDefault;
			parameters[7].Value = model.isShow;
			parameters[8].Value = model.addTime;
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
			strSql.Append("delete from goodsPic ");
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
			strSql.Append("delete from goodsPic ");
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
		public hm.Model.goodsPic GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,goodsId,goodsName,picSmall,picNormal,picBig,orders,isDefault,isShow,addTime from goodsPic ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.goodsPic model=new hm.Model.goodsPic();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goodsId"]!=null && ds.Tables[0].Rows[0]["goodsId"].ToString()!="")
				{
					model.goodsId=int.Parse(ds.Tables[0].Rows[0]["goodsId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goodsName"]!=null && ds.Tables[0].Rows[0]["goodsName"].ToString()!="")
				{
					model.goodsName=ds.Tables[0].Rows[0]["goodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picSmall"]!=null && ds.Tables[0].Rows[0]["picSmall"].ToString()!="")
				{
					model.picSmall=ds.Tables[0].Rows[0]["picSmall"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picNormal"]!=null && ds.Tables[0].Rows[0]["picNormal"].ToString()!="")
				{
					model.picNormal=ds.Tables[0].Rows[0]["picNormal"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picBig"]!=null && ds.Tables[0].Rows[0]["picBig"].ToString()!="")
				{
					model.picBig=ds.Tables[0].Rows[0]["picBig"].ToString();
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isDefault"]!=null && ds.Tables[0].Rows[0]["isDefault"].ToString()!="")
				{
					model.isDefault=int.Parse(ds.Tables[0].Rows[0]["isDefault"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isShow"]!=null && ds.Tables[0].Rows[0]["isShow"].ToString()!="")
				{
					model.isShow=int.Parse(ds.Tables[0].Rows[0]["isShow"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
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
			strSql.Append("select id,goodsId,goodsName,picSmall,picNormal,picBig,orders,isDefault,isShow,addTime ");
			strSql.Append(" FROM goodsPic ");
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
			strSql.Append(" id,goodsId,goodsName,picSmall,picNormal,picBig,orders,isDefault,isShow,addTime ");
			strSql.Append(" FROM goodsPic ");
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
			parameters[0].Value = "goodsPic";
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


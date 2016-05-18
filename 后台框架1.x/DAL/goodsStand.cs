using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:goodsStand
	/// </summary>
	public partial class goodsStand
	{
		public goodsStand()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "goodsStand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from goodsStand");
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
		public int Add(hm.Model.goodsStand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into goodsStand(");
			strSql.Append("catId,name,parentId,isShow,orders,path,pic,summary)");
			strSql.Append(" values (");
			strSql.Append("@catId,@name,@parentId,@isShow,@orders,@path,@pic,@summary)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@path", SqlDbType.VarChar,200),
					new SqlParameter("@pic", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500)};
			parameters[0].Value = model.catId;
			parameters[1].Value = model.name;
			parameters[2].Value = model.parentId;
			parameters[3].Value = model.isShow;
			parameters[4].Value = model.orders;
			parameters[5].Value = model.path;
			parameters[6].Value = model.pic;
			parameters[7].Value = model.summary;

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
		public bool Update(hm.Model.goodsStand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update goodsStand set ");
			strSql.Append("catId=@catId,");
			strSql.Append("name=@name,");
			strSql.Append("parentId=@parentId,");
			strSql.Append("isShow=@isShow,");
			strSql.Append("orders=@orders,");
			strSql.Append("path=@path,");
			strSql.Append("pic=@pic,");
			strSql.Append("summary=@summary");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@parentId", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@path", SqlDbType.VarChar,200),
					new SqlParameter("@pic", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.catId;
			parameters[1].Value = model.name;
			parameters[2].Value = model.parentId;
			parameters[3].Value = model.isShow;
			parameters[4].Value = model.orders;
			parameters[5].Value = model.path;
			parameters[6].Value = model.pic;
			parameters[7].Value = model.summary;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from goodsStand ");
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
			strSql.Append("delete from goodsStand ");
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
		public hm.Model.goodsStand GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,catId,name,parentId,isShow,orders,path,pic,summary from goodsStand ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.goodsStand model=new hm.Model.goodsStand();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catId"]!=null && ds.Tables[0].Rows[0]["catId"].ToString()!="")
				{
					model.catId=int.Parse(ds.Tables[0].Rows[0]["catId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["name"]!=null && ds.Tables[0].Rows[0]["name"].ToString()!="")
				{
					model.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isShow"]!=null && ds.Tables[0].Rows[0]["isShow"].ToString()!="")
				{
					model.isShow=int.Parse(ds.Tables[0].Rows[0]["isShow"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["path"]!=null && ds.Tables[0].Rows[0]["path"].ToString()!="")
				{
					model.path=ds.Tables[0].Rows[0]["path"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pic"]!=null && ds.Tables[0].Rows[0]["pic"].ToString()!="")
				{
					model.pic=ds.Tables[0].Rows[0]["pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["summary"]!=null && ds.Tables[0].Rows[0]["summary"].ToString()!="")
				{
					model.summary=ds.Tables[0].Rows[0]["summary"].ToString();
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
			strSql.Append("select id,catId,name,parentId,isShow,orders,path,pic,summary ");
			strSql.Append(" FROM goodsStand ");
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
			strSql.Append(" id,catId,name,parentId,isShow,orders,path,pic,summary ");
			strSql.Append(" FROM goodsStand ");
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
			parameters[0].Value = "goodsStand";
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


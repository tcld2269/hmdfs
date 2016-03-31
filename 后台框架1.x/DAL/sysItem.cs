using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:sysItem
	/// </summary>
	public partial class sysItem
	{
		public sysItem()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("siId", "sysItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int siId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sysItem");
			strSql.Append(" where siId=@siId");
			SqlParameter[] parameters = {
					new SqlParameter("@siId", SqlDbType.Int,4)
};
			parameters[0].Value = siId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.sysItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sysItem(");
			strSql.Append("sicId,itemName,orders)");
			strSql.Append(" values (");
			strSql.Append("@sicId,@itemName,@orders)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@sicId", SqlDbType.Int,4),
					new SqlParameter("@itemName", SqlDbType.VarChar,100),
					new SqlParameter("@orders", SqlDbType.Int,4)};
			parameters[0].Value = model.sicId;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.orders;

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
		public bool Update(hm.Model.sysItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sysItem set ");
			strSql.Append("sicId=@sicId,");
			strSql.Append("itemName=@itemName,");
			strSql.Append("orders=@orders");
			strSql.Append(" where siId=@siId");
			SqlParameter[] parameters = {
					new SqlParameter("@sicId", SqlDbType.Int,4),
					new SqlParameter("@itemName", SqlDbType.VarChar,100),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@siId", SqlDbType.Int,4)};
			parameters[0].Value = model.sicId;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.orders;
			parameters[3].Value = model.siId;

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
		public bool Delete(int siId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysItem ");
			strSql.Append(" where siId=@siId");
			SqlParameter[] parameters = {
					new SqlParameter("@siId", SqlDbType.Int,4)
};
			parameters[0].Value = siId;

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
		public bool DeleteList(string siIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysItem ");
			strSql.Append(" where siId in ("+siIdlist + ")  ");
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
		public hm.Model.sysItem GetModel(int siId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 siId,sicId,itemName,orders from sysItem ");
			strSql.Append(" where siId=@siId");
			SqlParameter[] parameters = {
					new SqlParameter("@siId", SqlDbType.Int,4)
};
			parameters[0].Value = siId;

			hm.Model.sysItem model=new hm.Model.sysItem();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["siId"]!=null && ds.Tables[0].Rows[0]["siId"].ToString()!="")
				{
					model.siId=int.Parse(ds.Tables[0].Rows[0]["siId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sicId"]!=null && ds.Tables[0].Rows[0]["sicId"].ToString()!="")
				{
					model.sicId=int.Parse(ds.Tables[0].Rows[0]["sicId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["itemName"]!=null && ds.Tables[0].Rows[0]["itemName"].ToString()!="")
				{
					model.itemName=ds.Tables[0].Rows[0]["itemName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
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
			strSql.Append("select siId,sicId,itemName,orders ");
			strSql.Append(" FROM sysItem ");
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
			strSql.Append(" siId,sicId,itemName,orders ");
			strSql.Append(" FROM sysItem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

        public int DeleteByCatId(int catId)
        {
            string sql = "delete FROM sysItem where sicId=" + catId;
            return DbHelperSQL.ExecuteSql(sql);
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
			parameters[0].Value = "sysItem";
			parameters[1].Value = "siId";
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


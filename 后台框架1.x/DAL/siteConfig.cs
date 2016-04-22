using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:siteConfig
	/// </summary>
	public partial class siteConfig
	{
		public siteConfig()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "siteConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from siteConfig");
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
		public int Add(hm.Model.siteConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into siteConfig(");
			strSql.Append("name,logo,seoTitle,seoKeywords,seoDescription,copyright,contact,email,qq,phone,fax,address,icp,url,updateTime)");
			strSql.Append(" values (");
			strSql.Append("@name,@logo,@seoTitle,@seoKeywords,@seoDescription,@copyright,@contact,@email,@qq,@phone,@fax,@address,@icp,@url,@updateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@logo", SqlDbType.VarChar,200),
					new SqlParameter("@seoTitle", SqlDbType.VarChar,200),
					new SqlParameter("@seoKeywords", SqlDbType.VarChar,200),
					new SqlParameter("@seoDescription", SqlDbType.VarChar,500),
					new SqlParameter("@copyright", SqlDbType.VarChar),
					new SqlParameter("@contact", SqlDbType.VarChar,200),
					new SqlParameter("@email", SqlDbType.VarChar,200),
					new SqlParameter("@qq", SqlDbType.VarChar,200),
					new SqlParameter("@phone", SqlDbType.VarChar,200),
					new SqlParameter("@fax", SqlDbType.VarChar,200),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@icp", SqlDbType.VarChar,200),
					new SqlParameter("@url", SqlDbType.VarChar,200),
					new SqlParameter("@updateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.logo;
			parameters[2].Value = model.seoTitle;
			parameters[3].Value = model.seoKeywords;
			parameters[4].Value = model.seoDescription;
			parameters[5].Value = model.copyright;
			parameters[6].Value = model.contact;
			parameters[7].Value = model.email;
			parameters[8].Value = model.qq;
			parameters[9].Value = model.phone;
			parameters[10].Value = model.fax;
			parameters[11].Value = model.address;
			parameters[12].Value = model.icp;
			parameters[13].Value = model.url;
			parameters[14].Value = model.updateTime;

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
		public bool Update(hm.Model.siteConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update siteConfig set ");
			strSql.Append("name=@name,");
			strSql.Append("logo=@logo,");
			strSql.Append("seoTitle=@seoTitle,");
			strSql.Append("seoKeywords=@seoKeywords,");
			strSql.Append("seoDescription=@seoDescription,");
			strSql.Append("copyright=@copyright,");
			strSql.Append("contact=@contact,");
			strSql.Append("email=@email,");
			strSql.Append("qq=@qq,");
			strSql.Append("phone=@phone,");
			strSql.Append("fax=@fax,");
			strSql.Append("address=@address,");
			strSql.Append("icp=@icp,");
			strSql.Append("url=@url,");
			strSql.Append("updateTime=@updateTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@logo", SqlDbType.VarChar,200),
					new SqlParameter("@seoTitle", SqlDbType.VarChar,200),
					new SqlParameter("@seoKeywords", SqlDbType.VarChar,200),
					new SqlParameter("@seoDescription", SqlDbType.VarChar,500),
					new SqlParameter("@copyright", SqlDbType.VarChar),
					new SqlParameter("@contact", SqlDbType.VarChar,200),
					new SqlParameter("@email", SqlDbType.VarChar,200),
					new SqlParameter("@qq", SqlDbType.VarChar,200),
					new SqlParameter("@phone", SqlDbType.VarChar,200),
					new SqlParameter("@fax", SqlDbType.VarChar,200),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@icp", SqlDbType.VarChar,200),
					new SqlParameter("@url", SqlDbType.VarChar,200),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.logo;
			parameters[2].Value = model.seoTitle;
			parameters[3].Value = model.seoKeywords;
			parameters[4].Value = model.seoDescription;
			parameters[5].Value = model.copyright;
			parameters[6].Value = model.contact;
			parameters[7].Value = model.email;
			parameters[8].Value = model.qq;
			parameters[9].Value = model.phone;
			parameters[10].Value = model.fax;
			parameters[11].Value = model.address;
			parameters[12].Value = model.icp;
			parameters[13].Value = model.url;
			parameters[14].Value = model.updateTime;
			parameters[15].Value = model.id;

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
			strSql.Append("delete from siteConfig ");
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
			strSql.Append("delete from siteConfig ");
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
		public hm.Model.siteConfig GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,logo,seoTitle,seoKeywords,seoDescription,copyright,contact,email,qq,phone,fax,address,icp,url,updateTime from siteConfig ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.siteConfig model=new hm.Model.siteConfig();
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
				if(ds.Tables[0].Rows[0]["logo"]!=null && ds.Tables[0].Rows[0]["logo"].ToString()!="")
				{
					model.logo=ds.Tables[0].Rows[0]["logo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["seoTitle"]!=null && ds.Tables[0].Rows[0]["seoTitle"].ToString()!="")
				{
					model.seoTitle=ds.Tables[0].Rows[0]["seoTitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["seoKeywords"]!=null && ds.Tables[0].Rows[0]["seoKeywords"].ToString()!="")
				{
					model.seoKeywords=ds.Tables[0].Rows[0]["seoKeywords"].ToString();
				}
				if(ds.Tables[0].Rows[0]["seoDescription"]!=null && ds.Tables[0].Rows[0]["seoDescription"].ToString()!="")
				{
					model.seoDescription=ds.Tables[0].Rows[0]["seoDescription"].ToString();
				}
				if(ds.Tables[0].Rows[0]["copyright"]!=null && ds.Tables[0].Rows[0]["copyright"].ToString()!="")
				{
					model.copyright=ds.Tables[0].Rows[0]["copyright"].ToString();
				}
				if(ds.Tables[0].Rows[0]["contact"]!=null && ds.Tables[0].Rows[0]["contact"].ToString()!="")
				{
					model.contact=ds.Tables[0].Rows[0]["contact"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null && ds.Tables[0].Rows[0]["email"].ToString()!="")
				{
					model.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["qq"]!=null && ds.Tables[0].Rows[0]["qq"].ToString()!="")
				{
					model.qq=ds.Tables[0].Rows[0]["qq"].ToString();
				}
				if(ds.Tables[0].Rows[0]["phone"]!=null && ds.Tables[0].Rows[0]["phone"].ToString()!="")
				{
					model.phone=ds.Tables[0].Rows[0]["phone"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fax"]!=null && ds.Tables[0].Rows[0]["fax"].ToString()!="")
				{
					model.fax=ds.Tables[0].Rows[0]["fax"].ToString();
				}
				if(ds.Tables[0].Rows[0]["address"]!=null && ds.Tables[0].Rows[0]["address"].ToString()!="")
				{
					model.address=ds.Tables[0].Rows[0]["address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["icp"]!=null && ds.Tables[0].Rows[0]["icp"].ToString()!="")
				{
					model.icp=ds.Tables[0].Rows[0]["icp"].ToString();
				}
				if(ds.Tables[0].Rows[0]["url"]!=null && ds.Tables[0].Rows[0]["url"].ToString()!="")
				{
					model.url=ds.Tables[0].Rows[0]["url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["updateTime"]!=null && ds.Tables[0].Rows[0]["updateTime"].ToString()!="")
				{
					model.updateTime=DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
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
			strSql.Append("select id,name,logo,seoTitle,seoKeywords,seoDescription,copyright,contact,email,qq,phone,fax,address,icp,url,updateTime ");
			strSql.Append(" FROM siteConfig ");
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
			strSql.Append(" id,name,logo,seoTitle,seoKeywords,seoDescription,copyright,contact,email,qq,phone,fax,address,icp,url,updateTime ");
			strSql.Append(" FROM siteConfig ");
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
			parameters[0].Value = "siteConfig";
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


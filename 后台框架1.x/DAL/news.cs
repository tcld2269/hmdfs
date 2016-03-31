using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:news
	/// </summary>
	public partial class news
	{
		public news()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("newsId", "news"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int newsId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from news");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4)
};
			parameters[0].Value = newsId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(hm.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into news(");
			strSql.Append("catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3)");
			strSql.Append(" values (");
			strSql.Append("@catId,@catName,@userId,@userName,@deptId,@newsTitle,@summary,@newsContent,@picUrl,@videoUrl,@contentSource,@author,@addTime,@modifyTime,@status,@isHomePage,@isSlide,@isTop,@fileUrl1,@fileUrl2,@fileUrl3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4),
					new SqlParameter("@catName", SqlDbType.NVarChar,100),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,100),
					new SqlParameter("@deptId", SqlDbType.Int,4),
					new SqlParameter("@newsTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@summary", SqlDbType.NVarChar,500),
					new SqlParameter("@newsContent", SqlDbType.Text),
					new SqlParameter("@picUrl", SqlDbType.VarChar,100),
					new SqlParameter("@videoUrl", SqlDbType.VarChar,100),
					new SqlParameter("@contentSource", SqlDbType.NVarChar,50),
					new SqlParameter("@author", SqlDbType.NVarChar,32),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@modifyTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@isHomePage", SqlDbType.Int,4),
					new SqlParameter("@isSlide", SqlDbType.Int,4),
					new SqlParameter("@isTop", SqlDbType.Int,4),
					new SqlParameter("@fileUrl1", SqlDbType.VarChar,100),
					new SqlParameter("@fileUrl2", SqlDbType.VarChar,100),
					new SqlParameter("@fileUrl3", SqlDbType.VarChar,100)};
			parameters[0].Value = model.catId;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.userId;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.deptId;
			parameters[5].Value = model.newsTitle;
			parameters[6].Value = model.summary;
			parameters[7].Value = model.newsContent;
			parameters[8].Value = model.picUrl;
			parameters[9].Value = model.videoUrl;
			parameters[10].Value = model.contentSource;
			parameters[11].Value = model.author;
			parameters[12].Value = model.addTime;
			parameters[13].Value = model.modifyTime;
			parameters[14].Value = model.status;
			parameters[15].Value = model.isHomePage;
			parameters[16].Value = model.isSlide;
			parameters[17].Value = model.isTop;
			parameters[18].Value = model.fileUrl1;
			parameters[19].Value = model.fileUrl2;
			parameters[20].Value = model.fileUrl3;

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
		public bool Update(hm.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update news set ");
			strSql.Append("catId=@catId,");
			strSql.Append("catName=@catName,");
			strSql.Append("userId=@userId,");
			strSql.Append("userName=@userName,");
			strSql.Append("deptId=@deptId,");
			strSql.Append("newsTitle=@newsTitle,");
			strSql.Append("summary=@summary,");
			strSql.Append("newsContent=@newsContent,");
			strSql.Append("picUrl=@picUrl,");
			strSql.Append("videoUrl=@videoUrl,");
			strSql.Append("contentSource=@contentSource,");
			strSql.Append("author=@author,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("modifyTime=@modifyTime,");
			strSql.Append("status=@status,");
			strSql.Append("isHomePage=@isHomePage,");
			strSql.Append("isSlide=@isSlide,");
			strSql.Append("isTop=@isTop,");
			strSql.Append("fileUrl1=@fileUrl1,");
			strSql.Append("fileUrl2=@fileUrl2,");
			strSql.Append("fileUrl3=@fileUrl3");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@catId", SqlDbType.Int,4),
					new SqlParameter("@catName", SqlDbType.NVarChar,100),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,100),
					new SqlParameter("@deptId", SqlDbType.Int,4),
					new SqlParameter("@newsTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@summary", SqlDbType.NVarChar,500),
					new SqlParameter("@newsContent", SqlDbType.Text),
					new SqlParameter("@picUrl", SqlDbType.VarChar,100),
					new SqlParameter("@videoUrl", SqlDbType.VarChar,100),
					new SqlParameter("@contentSource", SqlDbType.NVarChar,50),
					new SqlParameter("@author", SqlDbType.NVarChar,32),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@modifyTime", SqlDbType.DateTime),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@isHomePage", SqlDbType.Int,4),
					new SqlParameter("@isSlide", SqlDbType.Int,4),
					new SqlParameter("@isTop", SqlDbType.Int,4),
					new SqlParameter("@fileUrl1", SqlDbType.VarChar,100),
					new SqlParameter("@fileUrl2", SqlDbType.VarChar,100),
					new SqlParameter("@fileUrl3", SqlDbType.VarChar,100),
					new SqlParameter("@newsId", SqlDbType.Int,4)};
			parameters[0].Value = model.catId;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.userId;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.deptId;
			parameters[5].Value = model.newsTitle;
			parameters[6].Value = model.summary;
			parameters[7].Value = model.newsContent;
			parameters[8].Value = model.picUrl;
			parameters[9].Value = model.videoUrl;
			parameters[10].Value = model.contentSource;
			parameters[11].Value = model.author;
			parameters[12].Value = model.addTime;
			parameters[13].Value = model.modifyTime;
			parameters[14].Value = model.status;
			parameters[15].Value = model.isHomePage;
			parameters[16].Value = model.isSlide;
			parameters[17].Value = model.isTop;
			parameters[18].Value = model.fileUrl1;
			parameters[19].Value = model.fileUrl2;
			parameters[20].Value = model.fileUrl3;
			parameters[21].Value = model.newsId;

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
		public bool Delete(int newsId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4)
};
			parameters[0].Value = newsId;

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
		public bool DeleteList(string newsIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where newsId in ("+newsIdlist + ")  ");
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
		public hm.Model.news GetModel(int newsId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 newsId,catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3 from news ");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4)
};
			parameters[0].Value = newsId;

			hm.Model.news model=new hm.Model.news();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["newsId"]!=null && ds.Tables[0].Rows[0]["newsId"].ToString()!="")
				{
					model.newsId=int.Parse(ds.Tables[0].Rows[0]["newsId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catId"]!=null && ds.Tables[0].Rows[0]["catId"].ToString()!="")
				{
					model.catId=int.Parse(ds.Tables[0].Rows[0]["catId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catName"]!=null && ds.Tables[0].Rows[0]["catName"].ToString()!="")
				{
					model.catName=ds.Tables[0].Rows[0]["catName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["deptId"]!=null && ds.Tables[0].Rows[0]["deptId"].ToString()!="")
				{
					model.deptId=int.Parse(ds.Tables[0].Rows[0]["deptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["newsTitle"]!=null && ds.Tables[0].Rows[0]["newsTitle"].ToString()!="")
				{
					model.newsTitle=ds.Tables[0].Rows[0]["newsTitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["summary"]!=null && ds.Tables[0].Rows[0]["summary"].ToString()!="")
				{
					model.summary=ds.Tables[0].Rows[0]["summary"].ToString();
				}
				if(ds.Tables[0].Rows[0]["newsContent"]!=null && ds.Tables[0].Rows[0]["newsContent"].ToString()!="")
				{
					model.newsContent=ds.Tables[0].Rows[0]["newsContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picUrl"]!=null && ds.Tables[0].Rows[0]["picUrl"].ToString()!="")
				{
					model.picUrl=ds.Tables[0].Rows[0]["picUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["videoUrl"]!=null && ds.Tables[0].Rows[0]["videoUrl"].ToString()!="")
				{
					model.videoUrl=ds.Tables[0].Rows[0]["videoUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["contentSource"]!=null && ds.Tables[0].Rows[0]["contentSource"].ToString()!="")
				{
					model.contentSource=ds.Tables[0].Rows[0]["contentSource"].ToString();
				}
				if(ds.Tables[0].Rows[0]["author"]!=null && ds.Tables[0].Rows[0]["author"].ToString()!="")
				{
					model.author=ds.Tables[0].Rows[0]["author"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["modifyTime"]!=null && ds.Tables[0].Rows[0]["modifyTime"].ToString()!="")
				{
					model.modifyTime=DateTime.Parse(ds.Tables[0].Rows[0]["modifyTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["status"]!=null && ds.Tables[0].Rows[0]["status"].ToString()!="")
				{
					model.status=int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isHomePage"]!=null && ds.Tables[0].Rows[0]["isHomePage"].ToString()!="")
				{
					model.isHomePage=int.Parse(ds.Tables[0].Rows[0]["isHomePage"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isSlide"]!=null && ds.Tables[0].Rows[0]["isSlide"].ToString()!="")
				{
					model.isSlide=int.Parse(ds.Tables[0].Rows[0]["isSlide"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isTop"]!=null && ds.Tables[0].Rows[0]["isTop"].ToString()!="")
				{
					model.isTop=int.Parse(ds.Tables[0].Rows[0]["isTop"].ToString());
				}
				if(ds.Tables[0].Rows[0]["fileUrl1"]!=null && ds.Tables[0].Rows[0]["fileUrl1"].ToString()!="")
				{
					model.fileUrl1=ds.Tables[0].Rows[0]["fileUrl1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fileUrl2"]!=null && ds.Tables[0].Rows[0]["fileUrl2"].ToString()!="")
				{
					model.fileUrl2=ds.Tables[0].Rows[0]["fileUrl2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fileUrl3"]!=null && ds.Tables[0].Rows[0]["fileUrl3"].ToString()!="")
				{
					model.fileUrl3=ds.Tables[0].Rows[0]["fileUrl3"].ToString();
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
			strSql.Append("select newsId,catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3 ");
			strSql.Append(" FROM news ");
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
			strSql.Append(" newsId,catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3 ");
			strSql.Append(" FROM news ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		
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
			parameters[0].Value = "news";
			parameters[1].Value = "newsId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 1;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  Method
	}
}


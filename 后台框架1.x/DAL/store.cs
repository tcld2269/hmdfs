using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:store
	/// </summary>
	public partial class store
	{
		public store()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "store"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from store");
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
		public int Add(hm.Model.store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into store(");
			strSql.Append("storeName,userId,userName,storeType,typeName,ownerCard,cardPic,addressNo,address,logo,banner,sale,cashPrice,contact,qq,tel,summary,remark,isRecommend,evaluateService,evaluateDesc,evaluateDeliver,favCount,clickCount,feedBack,lat,lon,addTime,orders,status)");
			strSql.Append(" values (");
			strSql.Append("@storeName,@userId,@userName,@storeType,@typeName,@ownerCard,@cardPic,@addressNo,@address,@logo,@banner,@sale,@cashPrice,@contact,@qq,@tel,@summary,@remark,@isRecommend,@evaluateService,@evaluateDesc,@evaluateDeliver,@favCount,@clickCount,@feedBack,@lat,@lon,@addTime,@orders,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.VarChar,200),
					new SqlParameter("@storeType", SqlDbType.Int,4),
					new SqlParameter("@typeName", SqlDbType.VarChar,200),
					new SqlParameter("@ownerCard", SqlDbType.VarChar,200),
					new SqlParameter("@cardPic", SqlDbType.VarChar,200),
					new SqlParameter("@addressNo", SqlDbType.VarChar,200),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@logo", SqlDbType.VarChar,200),
					new SqlParameter("@banner", SqlDbType.VarChar),
					new SqlParameter("@sale", SqlDbType.VarChar,500),
					new SqlParameter("@cashPrice", SqlDbType.Decimal,9),
					new SqlParameter("@contact", SqlDbType.VarChar,200),
					new SqlParameter("@qq", SqlDbType.VarChar,200),
					new SqlParameter("@tel", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@isRecommend", SqlDbType.Int,4),
					new SqlParameter("@evaluateService", SqlDbType.Int,4),
					new SqlParameter("@evaluateDesc", SqlDbType.Int,4),
					new SqlParameter("@evaluateDeliver", SqlDbType.Int,4),
					new SqlParameter("@favCount", SqlDbType.Int,4),
					new SqlParameter("@clickCount", SqlDbType.Int,4),
					new SqlParameter("@feedBack", SqlDbType.VarChar,500),
					new SqlParameter("@lat", SqlDbType.VarChar,200),
					new SqlParameter("@lon", SqlDbType.VarChar,200),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.storeName;
			parameters[1].Value = model.userId;
			parameters[2].Value = model.userName;
			parameters[3].Value = model.storeType;
			parameters[4].Value = model.typeName;
			parameters[5].Value = model.ownerCard;
			parameters[6].Value = model.cardPic;
			parameters[7].Value = model.addressNo;
			parameters[8].Value = model.address;
			parameters[9].Value = model.logo;
			parameters[10].Value = model.banner;
			parameters[11].Value = model.sale;
			parameters[12].Value = model.cashPrice;
			parameters[13].Value = model.contact;
			parameters[14].Value = model.qq;
			parameters[15].Value = model.tel;
			parameters[16].Value = model.summary;
			parameters[17].Value = model.remark;
			parameters[18].Value = model.isRecommend;
			parameters[19].Value = model.evaluateService;
			parameters[20].Value = model.evaluateDesc;
			parameters[21].Value = model.evaluateDeliver;
			parameters[22].Value = model.favCount;
			parameters[23].Value = model.clickCount;
			parameters[24].Value = model.feedBack;
			parameters[25].Value = model.lat;
			parameters[26].Value = model.lon;
			parameters[27].Value = model.addTime;
			parameters[28].Value = model.orders;
			parameters[29].Value = model.status;

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
		public bool Update(hm.Model.store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update store set ");
			strSql.Append("storeName=@storeName,");
			strSql.Append("userId=@userId,");
			strSql.Append("userName=@userName,");
			strSql.Append("storeType=@storeType,");
			strSql.Append("typeName=@typeName,");
			strSql.Append("ownerCard=@ownerCard,");
			strSql.Append("cardPic=@cardPic,");
			strSql.Append("addressNo=@addressNo,");
			strSql.Append("address=@address,");
			strSql.Append("logo=@logo,");
			strSql.Append("banner=@banner,");
			strSql.Append("sale=@sale,");
			strSql.Append("cashPrice=@cashPrice,");
			strSql.Append("contact=@contact,");
			strSql.Append("qq=@qq,");
			strSql.Append("tel=@tel,");
			strSql.Append("summary=@summary,");
			strSql.Append("remark=@remark,");
			strSql.Append("isRecommend=@isRecommend,");
			strSql.Append("evaluateService=@evaluateService,");
			strSql.Append("evaluateDesc=@evaluateDesc,");
			strSql.Append("evaluateDeliver=@evaluateDeliver,");
			strSql.Append("favCount=@favCount,");
			strSql.Append("clickCount=@clickCount,");
			strSql.Append("feedBack=@feedBack,");
			strSql.Append("lat=@lat,");
			strSql.Append("lon=@lon,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("orders=@orders,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.VarChar,200),
					new SqlParameter("@storeType", SqlDbType.Int,4),
					new SqlParameter("@typeName", SqlDbType.VarChar,200),
					new SqlParameter("@ownerCard", SqlDbType.VarChar,200),
					new SqlParameter("@cardPic", SqlDbType.VarChar,200),
					new SqlParameter("@addressNo", SqlDbType.VarChar,200),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@logo", SqlDbType.VarChar,200),
					new SqlParameter("@banner", SqlDbType.VarChar),
					new SqlParameter("@sale", SqlDbType.VarChar,500),
					new SqlParameter("@cashPrice", SqlDbType.Decimal,9),
					new SqlParameter("@contact", SqlDbType.VarChar,200),
					new SqlParameter("@qq", SqlDbType.VarChar,200),
					new SqlParameter("@tel", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@isRecommend", SqlDbType.Int,4),
					new SqlParameter("@evaluateService", SqlDbType.Int,4),
					new SqlParameter("@evaluateDesc", SqlDbType.Int,4),
					new SqlParameter("@evaluateDeliver", SqlDbType.Int,4),
					new SqlParameter("@favCount", SqlDbType.Int,4),
					new SqlParameter("@clickCount", SqlDbType.Int,4),
					new SqlParameter("@feedBack", SqlDbType.VarChar,500),
					new SqlParameter("@lat", SqlDbType.VarChar,200),
					new SqlParameter("@lon", SqlDbType.VarChar,200),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.storeName;
			parameters[1].Value = model.userId;
			parameters[2].Value = model.userName;
			parameters[3].Value = model.storeType;
			parameters[4].Value = model.typeName;
			parameters[5].Value = model.ownerCard;
			parameters[6].Value = model.cardPic;
			parameters[7].Value = model.addressNo;
			parameters[8].Value = model.address;
			parameters[9].Value = model.logo;
			parameters[10].Value = model.banner;
			parameters[11].Value = model.sale;
			parameters[12].Value = model.cashPrice;
			parameters[13].Value = model.contact;
			parameters[14].Value = model.qq;
			parameters[15].Value = model.tel;
			parameters[16].Value = model.summary;
			parameters[17].Value = model.remark;
			parameters[18].Value = model.isRecommend;
			parameters[19].Value = model.evaluateService;
			parameters[20].Value = model.evaluateDesc;
			parameters[21].Value = model.evaluateDeliver;
			parameters[22].Value = model.favCount;
			parameters[23].Value = model.clickCount;
			parameters[24].Value = model.feedBack;
			parameters[25].Value = model.lat;
			parameters[26].Value = model.lon;
			parameters[27].Value = model.addTime;
			parameters[28].Value = model.orders;
			parameters[29].Value = model.status;
			parameters[30].Value = model.id;

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
			strSql.Append("delete from store ");
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
			strSql.Append("delete from store ");
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
		public hm.Model.store GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,storeName,userId,userName,storeType,typeName,ownerCard,cardPic,addressNo,address,logo,banner,sale,cashPrice,contact,qq,tel,summary,remark,isRecommend,evaluateService,evaluateDesc,evaluateDeliver,favCount,clickCount,feedBack,lat,lon,addTime,orders,status from store ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.store model=new hm.Model.store();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storeName"]!=null && ds.Tables[0].Rows[0]["storeName"].ToString()!="")
				{
					model.storeName=ds.Tables[0].Rows[0]["storeName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["storeType"]!=null && ds.Tables[0].Rows[0]["storeType"].ToString()!="")
				{
					model.storeType=int.Parse(ds.Tables[0].Rows[0]["storeType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["typeName"]!=null && ds.Tables[0].Rows[0]["typeName"].ToString()!="")
				{
					model.typeName=ds.Tables[0].Rows[0]["typeName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ownerCard"]!=null && ds.Tables[0].Rows[0]["ownerCard"].ToString()!="")
				{
					model.ownerCard=ds.Tables[0].Rows[0]["ownerCard"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cardPic"]!=null && ds.Tables[0].Rows[0]["cardPic"].ToString()!="")
				{
					model.cardPic=ds.Tables[0].Rows[0]["cardPic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addressNo"]!=null && ds.Tables[0].Rows[0]["addressNo"].ToString()!="")
				{
					model.addressNo=ds.Tables[0].Rows[0]["addressNo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["address"]!=null && ds.Tables[0].Rows[0]["address"].ToString()!="")
				{
					model.address=ds.Tables[0].Rows[0]["address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["logo"]!=null && ds.Tables[0].Rows[0]["logo"].ToString()!="")
				{
					model.logo=ds.Tables[0].Rows[0]["logo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["banner"]!=null && ds.Tables[0].Rows[0]["banner"].ToString()!="")
				{
					model.banner=ds.Tables[0].Rows[0]["banner"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sale"]!=null && ds.Tables[0].Rows[0]["sale"].ToString()!="")
				{
					model.sale=ds.Tables[0].Rows[0]["sale"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cashPrice"]!=null && ds.Tables[0].Rows[0]["cashPrice"].ToString()!="")
				{
					model.cashPrice=decimal.Parse(ds.Tables[0].Rows[0]["cashPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["contact"]!=null && ds.Tables[0].Rows[0]["contact"].ToString()!="")
				{
					model.contact=ds.Tables[0].Rows[0]["contact"].ToString();
				}
				if(ds.Tables[0].Rows[0]["qq"]!=null && ds.Tables[0].Rows[0]["qq"].ToString()!="")
				{
					model.qq=ds.Tables[0].Rows[0]["qq"].ToString();
				}
				if(ds.Tables[0].Rows[0]["tel"]!=null && ds.Tables[0].Rows[0]["tel"].ToString()!="")
				{
					model.tel=ds.Tables[0].Rows[0]["tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["summary"]!=null && ds.Tables[0].Rows[0]["summary"].ToString()!="")
				{
					model.summary=ds.Tables[0].Rows[0]["summary"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isRecommend"]!=null && ds.Tables[0].Rows[0]["isRecommend"].ToString()!="")
				{
					model.isRecommend=int.Parse(ds.Tables[0].Rows[0]["isRecommend"].ToString());
				}
				if(ds.Tables[0].Rows[0]["evaluateService"]!=null && ds.Tables[0].Rows[0]["evaluateService"].ToString()!="")
				{
					model.evaluateService=int.Parse(ds.Tables[0].Rows[0]["evaluateService"].ToString());
				}
				if(ds.Tables[0].Rows[0]["evaluateDesc"]!=null && ds.Tables[0].Rows[0]["evaluateDesc"].ToString()!="")
				{
					model.evaluateDesc=int.Parse(ds.Tables[0].Rows[0]["evaluateDesc"].ToString());
				}
				if(ds.Tables[0].Rows[0]["evaluateDeliver"]!=null && ds.Tables[0].Rows[0]["evaluateDeliver"].ToString()!="")
				{
					model.evaluateDeliver=int.Parse(ds.Tables[0].Rows[0]["evaluateDeliver"].ToString());
				}
				if(ds.Tables[0].Rows[0]["favCount"]!=null && ds.Tables[0].Rows[0]["favCount"].ToString()!="")
				{
					model.favCount=int.Parse(ds.Tables[0].Rows[0]["favCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["clickCount"]!=null && ds.Tables[0].Rows[0]["clickCount"].ToString()!="")
				{
					model.clickCount=int.Parse(ds.Tables[0].Rows[0]["clickCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["feedBack"]!=null && ds.Tables[0].Rows[0]["feedBack"].ToString()!="")
				{
					model.feedBack=ds.Tables[0].Rows[0]["feedBack"].ToString();
				}
				if(ds.Tables[0].Rows[0]["lat"]!=null && ds.Tables[0].Rows[0]["lat"].ToString()!="")
				{
					model.lat=ds.Tables[0].Rows[0]["lat"].ToString();
				}
				if(ds.Tables[0].Rows[0]["lon"]!=null && ds.Tables[0].Rows[0]["lon"].ToString()!="")
				{
					model.lon=ds.Tables[0].Rows[0]["lon"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
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
			strSql.Append("select id,storeName,userId,userName,storeType,typeName,ownerCard,cardPic,addressNo,address,logo,banner,sale,cashPrice,contact,qq,tel,summary,remark,isRecommend,evaluateService,evaluateDesc,evaluateDeliver,favCount,clickCount,feedBack,lat,lon,addTime,orders,status ");
			strSql.Append(" FROM store ");
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
			strSql.Append(" id,storeName,userId,userName,storeType,typeName,ownerCard,cardPic,addressNo,address,logo,banner,sale,cashPrice,contact,qq,tel,summary,remark,isRecommend,evaluateService,evaluateDesc,evaluateDeliver,favCount,clickCount,feedBack,lat,lon,addTime,orders,status ");
			strSql.Append(" FROM store ");
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
			parameters[0].Value = "store";
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


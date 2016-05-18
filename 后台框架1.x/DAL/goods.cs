using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:goods
	/// </summary>
	public partial class goods
	{
		public goods()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "goods"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from goods");
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
		public int Add(hm.Model.goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into goods(");
			strSql.Append("storeId,storeName,name,sn,catId,catName,marketPrice,storePrice,freightPrice,buyScore,giveScore,picSmall,picNormal,picBig,summary,remark,favCount,stock,clickNum,saleNum,isSku,isShow,isNew,isRecommend,isHot,addTime,updateTime,orders,status)");
			strSql.Append(" values (");
			strSql.Append("@storeId,@storeName,@name,@sn,@catId,@catName,@marketPrice,@storePrice,@freightPrice,@buyScore,@giveScore,@picSmall,@picNormal,@picBig,@summary,@remark,@favCount,@stock,@clickNum,@saleNum,@isSku,@isShow,@isNew,@isRecommend,@isHot,@addTime,@updateTime,@orders,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@storeId", SqlDbType.Int,4),
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@sn", SqlDbType.VarChar,200),
					new SqlParameter("@catId", SqlDbType.Int,4),
					new SqlParameter("@catName", SqlDbType.VarChar,200),
					new SqlParameter("@marketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@storePrice", SqlDbType.Decimal,9),
					new SqlParameter("@freightPrice", SqlDbType.Decimal,9),
					new SqlParameter("@buyScore", SqlDbType.Int,4),
					new SqlParameter("@giveScore", SqlDbType.Int,4),
					new SqlParameter("@picSmall", SqlDbType.VarChar,200),
					new SqlParameter("@picNormal", SqlDbType.VarChar,200),
					new SqlParameter("@picBig", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@favCount", SqlDbType.Int,4),
					new SqlParameter("@stock", SqlDbType.Int,4),
					new SqlParameter("@clickNum", SqlDbType.Int,4),
					new SqlParameter("@saleNum", SqlDbType.Int,4),
					new SqlParameter("@isSku", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@isNew", SqlDbType.Int,4),
					new SqlParameter("@isRecommend", SqlDbType.Int,4),
					new SqlParameter("@isHot", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.Int,4)};
			parameters[0].Value = model.storeId;
			parameters[1].Value = model.storeName;
			parameters[2].Value = model.name;
			parameters[3].Value = model.sn;
			parameters[4].Value = model.catId;
			parameters[5].Value = model.catName;
			parameters[6].Value = model.marketPrice;
			parameters[7].Value = model.storePrice;
			parameters[8].Value = model.freightPrice;
			parameters[9].Value = model.buyScore;
			parameters[10].Value = model.giveScore;
			parameters[11].Value = model.picSmall;
			parameters[12].Value = model.picNormal;
			parameters[13].Value = model.picBig;
			parameters[14].Value = model.summary;
			parameters[15].Value = model.remark;
			parameters[16].Value = model.favCount;
			parameters[17].Value = model.stock;
			parameters[18].Value = model.clickNum;
			parameters[19].Value = model.saleNum;
			parameters[20].Value = model.isSku;
			parameters[21].Value = model.isShow;
			parameters[22].Value = model.isNew;
			parameters[23].Value = model.isRecommend;
			parameters[24].Value = model.isHot;
			parameters[25].Value = model.addTime;
			parameters[26].Value = model.updateTime;
			parameters[27].Value = model.orders;
			parameters[28].Value = model.status;

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
		public bool Update(hm.Model.goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update goods set ");
			strSql.Append("storeId=@storeId,");
			strSql.Append("storeName=@storeName,");
			strSql.Append("name=@name,");
			strSql.Append("sn=@sn,");
			strSql.Append("catId=@catId,");
			strSql.Append("catName=@catName,");
			strSql.Append("marketPrice=@marketPrice,");
			strSql.Append("storePrice=@storePrice,");
			strSql.Append("freightPrice=@freightPrice,");
			strSql.Append("buyScore=@buyScore,");
			strSql.Append("giveScore=@giveScore,");
			strSql.Append("picSmall=@picSmall,");
			strSql.Append("picNormal=@picNormal,");
			strSql.Append("picBig=@picBig,");
			strSql.Append("summary=@summary,");
			strSql.Append("remark=@remark,");
			strSql.Append("favCount=@favCount,");
			strSql.Append("stock=@stock,");
			strSql.Append("clickNum=@clickNum,");
			strSql.Append("saleNum=@saleNum,");
			strSql.Append("isSku=@isSku,");
			strSql.Append("isShow=@isShow,");
			strSql.Append("isNew=@isNew,");
			strSql.Append("isRecommend=@isRecommend,");
			strSql.Append("isHot=@isHot,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("updateTime=@updateTime,");
			strSql.Append("orders=@orders,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@storeId", SqlDbType.Int,4),
					new SqlParameter("@storeName", SqlDbType.VarChar,200),
					new SqlParameter("@name", SqlDbType.VarChar,200),
					new SqlParameter("@sn", SqlDbType.VarChar,200),
					new SqlParameter("@catId", SqlDbType.Int,4),
					new SqlParameter("@catName", SqlDbType.VarChar,200),
					new SqlParameter("@marketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@storePrice", SqlDbType.Decimal,9),
					new SqlParameter("@freightPrice", SqlDbType.Decimal,9),
					new SqlParameter("@buyScore", SqlDbType.Int,4),
					new SqlParameter("@giveScore", SqlDbType.Int,4),
					new SqlParameter("@picSmall", SqlDbType.VarChar,200),
					new SqlParameter("@picNormal", SqlDbType.VarChar,200),
					new SqlParameter("@picBig", SqlDbType.VarChar,200),
					new SqlParameter("@summary", SqlDbType.VarChar,500),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@favCount", SqlDbType.Int,4),
					new SqlParameter("@stock", SqlDbType.Int,4),
					new SqlParameter("@clickNum", SqlDbType.Int,4),
					new SqlParameter("@saleNum", SqlDbType.Int,4),
					new SqlParameter("@isSku", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@isNew", SqlDbType.Int,4),
					new SqlParameter("@isRecommend", SqlDbType.Int,4),
					new SqlParameter("@isHot", SqlDbType.Int,4),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.storeId;
			parameters[1].Value = model.storeName;
			parameters[2].Value = model.name;
			parameters[3].Value = model.sn;
			parameters[4].Value = model.catId;
			parameters[5].Value = model.catName;
			parameters[6].Value = model.marketPrice;
			parameters[7].Value = model.storePrice;
			parameters[8].Value = model.freightPrice;
			parameters[9].Value = model.buyScore;
			parameters[10].Value = model.giveScore;
			parameters[11].Value = model.picSmall;
			parameters[12].Value = model.picNormal;
			parameters[13].Value = model.picBig;
			parameters[14].Value = model.summary;
			parameters[15].Value = model.remark;
			parameters[16].Value = model.favCount;
			parameters[17].Value = model.stock;
			parameters[18].Value = model.clickNum;
			parameters[19].Value = model.saleNum;
			parameters[20].Value = model.isSku;
			parameters[21].Value = model.isShow;
			parameters[22].Value = model.isNew;
			parameters[23].Value = model.isRecommend;
			parameters[24].Value = model.isHot;
			parameters[25].Value = model.addTime;
			parameters[26].Value = model.updateTime;
			parameters[27].Value = model.orders;
			parameters[28].Value = model.status;
			parameters[29].Value = model.id;

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
			strSql.Append("delete from goods ");
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
			strSql.Append("delete from goods ");
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
		public hm.Model.goods GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,storeId,storeName,name,sn,catId,catName,marketPrice,storePrice,freightPrice,buyScore,giveScore,picSmall,picNormal,picBig,summary,remark,favCount,stock,clickNum,saleNum,isSku,isShow,isNew,isRecommend,isHot,addTime,updateTime,orders,status from goods ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			hm.Model.goods model=new hm.Model.goods();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storeId"]!=null && ds.Tables[0].Rows[0]["storeId"].ToString()!="")
				{
					model.storeId=int.Parse(ds.Tables[0].Rows[0]["storeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storeName"]!=null && ds.Tables[0].Rows[0]["storeName"].ToString()!="")
				{
					model.storeName=ds.Tables[0].Rows[0]["storeName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null && ds.Tables[0].Rows[0]["name"].ToString()!="")
				{
					model.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sn"]!=null && ds.Tables[0].Rows[0]["sn"].ToString()!="")
				{
					model.sn=ds.Tables[0].Rows[0]["sn"].ToString();
				}
				if(ds.Tables[0].Rows[0]["catId"]!=null && ds.Tables[0].Rows[0]["catId"].ToString()!="")
				{
					model.catId=int.Parse(ds.Tables[0].Rows[0]["catId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catName"]!=null && ds.Tables[0].Rows[0]["catName"].ToString()!="")
				{
					model.catName=ds.Tables[0].Rows[0]["catName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["marketPrice"]!=null && ds.Tables[0].Rows[0]["marketPrice"].ToString()!="")
				{
					model.marketPrice=decimal.Parse(ds.Tables[0].Rows[0]["marketPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storePrice"]!=null && ds.Tables[0].Rows[0]["storePrice"].ToString()!="")
				{
					model.storePrice=decimal.Parse(ds.Tables[0].Rows[0]["storePrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["freightPrice"]!=null && ds.Tables[0].Rows[0]["freightPrice"].ToString()!="")
				{
					model.freightPrice=decimal.Parse(ds.Tables[0].Rows[0]["freightPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["buyScore"]!=null && ds.Tables[0].Rows[0]["buyScore"].ToString()!="")
				{
					model.buyScore=int.Parse(ds.Tables[0].Rows[0]["buyScore"].ToString());
				}
				if(ds.Tables[0].Rows[0]["giveScore"]!=null && ds.Tables[0].Rows[0]["giveScore"].ToString()!="")
				{
					model.giveScore=int.Parse(ds.Tables[0].Rows[0]["giveScore"].ToString());
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
				if(ds.Tables[0].Rows[0]["summary"]!=null && ds.Tables[0].Rows[0]["summary"].ToString()!="")
				{
					model.summary=ds.Tables[0].Rows[0]["summary"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["favCount"]!=null && ds.Tables[0].Rows[0]["favCount"].ToString()!="")
				{
					model.favCount=int.Parse(ds.Tables[0].Rows[0]["favCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["stock"]!=null && ds.Tables[0].Rows[0]["stock"].ToString()!="")
				{
					model.stock=int.Parse(ds.Tables[0].Rows[0]["stock"].ToString());
				}
				if(ds.Tables[0].Rows[0]["clickNum"]!=null && ds.Tables[0].Rows[0]["clickNum"].ToString()!="")
				{
					model.clickNum=int.Parse(ds.Tables[0].Rows[0]["clickNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["saleNum"]!=null && ds.Tables[0].Rows[0]["saleNum"].ToString()!="")
				{
					model.saleNum=int.Parse(ds.Tables[0].Rows[0]["saleNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isSku"]!=null && ds.Tables[0].Rows[0]["isSku"].ToString()!="")
				{
					model.isSku=int.Parse(ds.Tables[0].Rows[0]["isSku"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isShow"]!=null && ds.Tables[0].Rows[0]["isShow"].ToString()!="")
				{
					model.isShow=int.Parse(ds.Tables[0].Rows[0]["isShow"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isNew"]!=null && ds.Tables[0].Rows[0]["isNew"].ToString()!="")
				{
					model.isNew=int.Parse(ds.Tables[0].Rows[0]["isNew"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isRecommend"]!=null && ds.Tables[0].Rows[0]["isRecommend"].ToString()!="")
				{
					model.isRecommend=int.Parse(ds.Tables[0].Rows[0]["isRecommend"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isHot"]!=null && ds.Tables[0].Rows[0]["isHot"].ToString()!="")
				{
					model.isHot=int.Parse(ds.Tables[0].Rows[0]["isHot"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["updateTime"]!=null && ds.Tables[0].Rows[0]["updateTime"].ToString()!="")
				{
					model.updateTime=DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
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
			strSql.Append("select id,storeId,storeName,name,sn,catId,catName,marketPrice,storePrice,freightPrice,buyScore,giveScore,picSmall,picNormal,picBig,summary,remark,favCount,stock,clickNum,saleNum,isSku,isShow,isNew,isRecommend,isHot,addTime,updateTime,orders,status ");
			strSql.Append(" FROM goods ");
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
			strSql.Append(" id,storeId,storeName,name,sn,catId,catName,marketPrice,storePrice,freightPrice,buyScore,giveScore,picSmall,picNormal,picBig,summary,remark,favCount,stock,clickNum,saleNum,isSku,isShow,isNew,isRecommend,isHot,addTime,updateTime,orders,status ");
			strSql.Append(" FROM goods ");
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
			parameters[0].Value = "goods";
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


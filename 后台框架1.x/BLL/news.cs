using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// 新闻表
	/// </summary>
	public partial class news
	{
		private readonly hm.DAL.news dal=new hm.DAL.news();
		public news()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int newsId)
		{
			return dal.Exists(newsId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(hm.Model.news model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.news model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int newsId)
		{
			
			return dal.Delete(newsId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string newsIdlist )
		{
			return dal.DeleteList(newsIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.news GetModel(int newsId)
		{
			
			return dal.GetModel(newsId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.news GetModelByCache(int newsId)
		{
			
			string CacheKey = "newsModel-" + newsId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(newsId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.news)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.news> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.news> DataTableToList(DataTable dt)
		{
			List<hm.Model.news> modelList = new List<hm.Model.news>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.news model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.news();
					if(dt.Rows[n]["newsId"]!=null && dt.Rows[n]["newsId"].ToString()!="")
					{
						model.newsId=int.Parse(dt.Rows[n]["newsId"].ToString());
					}
					if(dt.Rows[n]["catId"]!=null && dt.Rows[n]["catId"].ToString()!="")
					{
						model.catId=int.Parse(dt.Rows[n]["catId"].ToString());
					}
					if(dt.Rows[n]["catName"]!=null && dt.Rows[n]["catName"].ToString()!="")
					{
					model.catName=dt.Rows[n]["catName"].ToString();
					}
					if(dt.Rows[n]["userId"]!=null && dt.Rows[n]["userId"].ToString()!="")
					{
						model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
					}
					if(dt.Rows[n]["userName"]!=null && dt.Rows[n]["userName"].ToString()!="")
					{
					model.userName=dt.Rows[n]["userName"].ToString();
					}
					if(dt.Rows[n]["deptId"]!=null && dt.Rows[n]["deptId"].ToString()!="")
					{
						model.deptId=int.Parse(dt.Rows[n]["deptId"].ToString());
					}
					if(dt.Rows[n]["newsTitle"]!=null && dt.Rows[n]["newsTitle"].ToString()!="")
					{
					model.newsTitle=dt.Rows[n]["newsTitle"].ToString();
					}
					if(dt.Rows[n]["summary"]!=null && dt.Rows[n]["summary"].ToString()!="")
					{
					model.summary=dt.Rows[n]["summary"].ToString();
					}
					if(dt.Rows[n]["newsContent"]!=null && dt.Rows[n]["newsContent"].ToString()!="")
					{
					model.newsContent=dt.Rows[n]["newsContent"].ToString();
					}
					if(dt.Rows[n]["picUrl"]!=null && dt.Rows[n]["picUrl"].ToString()!="")
					{
					model.picUrl=dt.Rows[n]["picUrl"].ToString();
					}
					if(dt.Rows[n]["videoUrl"]!=null && dt.Rows[n]["videoUrl"].ToString()!="")
					{
					model.videoUrl=dt.Rows[n]["videoUrl"].ToString();
					}
					if(dt.Rows[n]["contentSource"]!=null && dt.Rows[n]["contentSource"].ToString()!="")
					{
					model.contentSource=dt.Rows[n]["contentSource"].ToString();
					}
					if(dt.Rows[n]["author"]!=null && dt.Rows[n]["author"].ToString()!="")
					{
					model.author=dt.Rows[n]["author"].ToString();
					}
					if(dt.Rows[n]["addTime"]!=null && dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
					}
					if(dt.Rows[n]["modifyTime"]!=null && dt.Rows[n]["modifyTime"].ToString()!="")
					{
						model.modifyTime=DateTime.Parse(dt.Rows[n]["modifyTime"].ToString());
					}
					if(dt.Rows[n]["status"]!=null && dt.Rows[n]["status"].ToString()!="")
					{
						model.status=int.Parse(dt.Rows[n]["status"].ToString());
					}
					if(dt.Rows[n]["isHomePage"]!=null && dt.Rows[n]["isHomePage"].ToString()!="")
					{
						model.isHomePage=int.Parse(dt.Rows[n]["isHomePage"].ToString());
					}
					if(dt.Rows[n]["isSlide"]!=null && dt.Rows[n]["isSlide"].ToString()!="")
					{
						model.isSlide=int.Parse(dt.Rows[n]["isSlide"].ToString());
					}
					if(dt.Rows[n]["isTop"]!=null && dt.Rows[n]["isTop"].ToString()!="")
					{
						model.isTop=int.Parse(dt.Rows[n]["isTop"].ToString());
					}
					if(dt.Rows[n]["fileUrl1"]!=null && dt.Rows[n]["fileUrl1"].ToString()!="")
					{
					model.fileUrl1=dt.Rows[n]["fileUrl1"].ToString();
					}
					if(dt.Rows[n]["fileUrl2"]!=null && dt.Rows[n]["fileUrl2"].ToString()!="")
					{
					model.fileUrl2=dt.Rows[n]["fileUrl2"].ToString();
					}
					if(dt.Rows[n]["fileUrl3"]!=null && dt.Rows[n]["fileUrl3"].ToString()!="")
					{
					model.fileUrl3=dt.Rows[n]["fileUrl3"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  Method
	}
}


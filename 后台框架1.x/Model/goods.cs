using System;
namespace hm.Model
{
	/// <summary>
	/// goods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class goods
	{
		public goods()
		{}
		#region Model
		private int _id;
		private int? _storeid;
		private string _storename;
		private string _name;
		private string _sn;
		private int? _catid;
		private string _catname;
		private decimal? _marketprice;
		private decimal? _storeprice;
		private decimal? _freightprice;
		private int? _buyscore;
		private int? _givescore;
		private string _picsmall;
		private string _picnormal;
		private string _picbig;
		private string _summary;
		private string _remark;
		private int? _favcount;
		private int? _stock;
		private int? _clicknum;
		private int? _salenum;
		private int? _issku;
		private int? _isshow;
		private int? _isnew;
		private int? _isrecommend;
		private int? _ishot;
		private DateTime? _addtime;
		private DateTime? _updatetime;
		private int? _orders;
		private int? _status;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 店铺ID
		/// </summary>
		public int? storeId
		{
			set{ _storeid=value;}
			get{return _storeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string storeName
		{
			set{ _storename=value;}
			get{return _storename;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 商品编号
		/// </summary>
		public string sn
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 商品分类
		/// </summary>
		public int? catId
		{
			set{ _catid=value;}
			get{return _catid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string catName
		{
			set{ _catname=value;}
			get{return _catname;}
		}
		/// <summary>
		/// 市场价
		/// </summary>
		public decimal? marketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 商城价
		/// </summary>
		public decimal? storePrice
		{
			set{ _storeprice=value;}
			get{return _storeprice;}
		}
		/// <summary>
		/// 运费
		/// </summary>
		public decimal? freightPrice
		{
			set{ _freightprice=value;}
			get{return _freightprice;}
		}
		/// <summary>
		/// 购买所需积分
		/// </summary>
		public int? buyScore
		{
			set{ _buyscore=value;}
			get{return _buyscore;}
		}
		/// <summary>
		/// 赠送积分
		/// </summary>
		public int? giveScore
		{
			set{ _givescore=value;}
			get{return _givescore;}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string picSmall
		{
			set{ _picsmall=value;}
			get{return _picsmall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picNormal
		{
			set{ _picnormal=value;}
			get{return _picnormal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picBig
		{
			set{ _picbig=value;}
			get{return _picbig;}
		}
		/// <summary>
		/// 简介
		/// </summary>
		public string summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 关注数量
		/// </summary>
		public int? favCount
		{
			set{ _favcount=value;}
			get{return _favcount;}
		}
		/// <summary>
		/// 库存
		/// </summary>
		public int? stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 点击次数
		/// </summary>
		public int? clickNum
		{
			set{ _clicknum=value;}
			get{return _clicknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? saleNum
		{
			set{ _salenum=value;}
			get{return _salenum;}
		}
		/// <summary>
		/// 是否是SKU商品，是的话读取goodsStandPrice的商品价格和库存，否的话读取本表价格和库存
		/// </summary>
		public int? isSku
		{
			set{ _issku=value;}
			get{return _issku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isNew
		{
			set{ _isnew=value;}
			get{return _isnew;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isRecommend
		{
			set{ _isrecommend=value;}
			get{return _isrecommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? updateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}


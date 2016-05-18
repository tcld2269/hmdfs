using System;
namespace hm.Model
{
	/// <summary>
	/// shoppingCart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shoppingCart
	{
		public shoppingCart()
		{}
		#region Model
		private int _id;
		private int? _orderid;
		private int? _userid;
		private string _username;
		private int? _storeid;
		private string _storename;
		private int? _goodsid;
		private string _goodsname;
		private int? _goodsnum;
		private decimal? _goodsprice;
		private string _goodspic;
		private DateTime? _addtime;
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
		/// 
		/// </summary>
		public int? orderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public int? goodsId
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string goodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? goodsNum
		{
			set{ _goodsnum=value;}
			get{return _goodsnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? goodsPrice
		{
			set{ _goodsprice=value;}
			get{return _goodsprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string goodsPic
		{
			set{ _goodspic=value;}
			get{return _goodspic;}
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
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}


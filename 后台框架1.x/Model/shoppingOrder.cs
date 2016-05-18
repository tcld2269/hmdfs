using System;
namespace hm.Model
{
	/// <summary>
	/// shoppingOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shoppingOrder
	{
		public shoppingOrder()
		{}
		#region Model
		private int _id;
		private string _orderno;
		private int? _sellerid;
		private string _sellername;
		private int? _storeid;
		private string _storename;
		private int? _buyerid;
		private string _buyername;
		private int? _type;
		private int? _addressid;
		private int? _paymentid;
		private string _paymentname;
		private DateTime? _paytime;
		private string _payremark;
		private decimal? _goodsprice;
		private decimal? _freightprice;
		private decimal? _orderprice;
		private string _freightsn;
		private string _remark;
		private int? _refundtype;
		private string _refundremark;
		private DateTime? _refundtime;
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
		/// 订单编号
		/// </summary>
		public string orderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 卖家ID
		/// </summary>
		public int? sellerId
		{
			set{ _sellerid=value;}
			get{return _sellerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sellerName
		{
			set{ _sellername=value;}
			get{return _sellername;}
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
		/// 买家ID
		/// </summary>
		public int? buyerId
		{
			set{ _buyerid=value;}
			get{return _buyerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string buyerName
		{
			set{ _buyername=value;}
			get{return _buyername;}
		}
		/// <summary>
		/// 订单类型 见代码Order_Type_
		/// </summary>
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 收货地址ID
		/// </summary>
		public int? addressId
		{
			set{ _addressid=value;}
			get{return _addressid;}
		}
		/// <summary>
		/// 支付方式ID
		/// </summary>
		public int? paymentId
		{
			set{ _paymentid=value;}
			get{return _paymentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paymentName
		{
			set{ _paymentname=value;}
			get{return _paymentname;}
		}
		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime? payTime
		{
			set{ _paytime=value;}
			get{return _paytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string payRemark
		{
			set{ _payremark=value;}
			get{return _payremark;}
		}
		/// <summary>
		/// 商品价格
		/// </summary>
		public decimal? goodsPrice
		{
			set{ _goodsprice=value;}
			get{return _goodsprice;}
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
		/// 订单价格
		/// </summary>
		public decimal? orderPrice
		{
			set{ _orderprice=value;}
			get{return _orderprice;}
		}
		/// <summary>
		/// 运单号
		/// </summary>
		public string freightSn
		{
			set{ _freightsn=value;}
			get{return _freightsn;}
		}
		/// <summary>
		/// 订单备注
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 退款类型
		/// </summary>
		public int? refundType
		{
			set{ _refundtype=value;}
			get{return _refundtype;}
		}
		/// <summary>
		/// 退款说明
		/// </summary>
		public string refundRemark
		{
			set{ _refundremark=value;}
			get{return _refundremark;}
		}
		/// <summary>
		/// 退款时间
		/// </summary>
		public DateTime? refundTime
		{
			set{ _refundtime=value;}
			get{return _refundtime;}
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
		/// 状态
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}


using System;
namespace hm.Model
{
	/// <summary>
	/// store:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class store
	{
		public store()
		{}
		#region Model
		private int _id;
		private string _storename;
		private int? _userid;
		private string _username;
		private int? _storetype;
		private string _typename;
		private string _ownercard;
		private string _cardpic;
		private string _addressno;
		private string _address;
		private string _logo;
		private string _banner;
		private string _sale;
		private decimal? _cashprice;
		private string _contact;
		private string _qq;
		private string _tel;
		private string _summary;
		private string _remark;
		private int? _isrecommend;
		private int? _evaluateservice;
		private int? _evaluatedesc;
		private int? _evaluatedeliver;
		private int? _favcount;
		private int? _clickcount;
		private string _feedback;
		private string _lat;
		private string _lon;
		private DateTime? _addtime;
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
		public int? storeType
		{
			set{ _storetype=value;}
			get{return _storetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string typeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ownerCard
		{
			set{ _ownercard=value;}
			get{return _ownercard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cardPic
		{
			set{ _cardpic=value;}
			get{return _cardpic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addressNo
		{
			set{ _addressno=value;}
			get{return _addressno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banner
		{
			set{ _banner=value;}
			get{return _banner;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sale
		{
			set{ _sale=value;}
			get{return _sale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? cashPrice
		{
			set{ _cashprice=value;}
			get{return _cashprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		public int? evaluateService
		{
			set{ _evaluateservice=value;}
			get{return _evaluateservice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? evaluateDesc
		{
			set{ _evaluatedesc=value;}
			get{return _evaluatedesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? evaluateDeliver
		{
			set{ _evaluatedeliver=value;}
			get{return _evaluatedeliver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? favCount
		{
			set{ _favcount=value;}
			get{return _favcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? clickCount
		{
			set{ _clickcount=value;}
			get{return _clickcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string feedBack
		{
			set{ _feedback=value;}
			get{return _feedback;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lat
		{
			set{ _lat=value;}
			get{return _lat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lon
		{
			set{ _lon=value;}
			get{return _lon;}
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


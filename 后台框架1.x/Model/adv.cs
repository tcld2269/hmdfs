using System;
namespace hm.Model
{
	/// <summary>
	/// adv:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class adv
	{
		public adv()
		{}
		#region Model
		private int _id;
		private string _title;
		private int? _apid;
		private string _url;
		private string _pic;
		private string _remark;
		private DateTime? _startdate;
		private DateTime? _enddate;
		private decimal? _price;
		private int? _clickcount;
		private int? _orders;
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
		/// 标题
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 所属广告位
		/// </summary>
		public int? apId
		{
			set{ _apid=value;}
			get{return _apid;}
		}
		/// <summary>
		/// 跳转链接
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string pic
		{
			set{ _pic=value;}
			get{return _pic;}
		}
		/// <summary>
		/// 文字内容
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime? startDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime? endDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 价格
		/// </summary>
		public decimal? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 点击次数
		/// </summary>
		public int? clickCount
		{
			set{ _clickcount=value;}
			get{return _clickcount;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 录入时间
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


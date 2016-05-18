using System;
namespace hm.Model
{
	/// <summary>
	/// goodsStandPrice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class goodsStandPrice
	{
		public goodsStandPrice()
		{}
		#region Model
		private int _id;
		private int? _goodsid;
		private int? _standid;
		private int? _standsecondid;
		private int? _standthirdid;
		private decimal? _marketprice;
		private decimal? _storeprice;
		private int? _buyscore;
		private int? _stock;
		private int? _orders;
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
		public int? goodsId
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? standId
		{
			set{ _standid=value;}
			get{return _standid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? standSecondId
		{
			set{ _standsecondid=value;}
			get{return _standsecondid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? standThirdId
		{
			set{ _standthirdid=value;}
			get{return _standthirdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? marketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? storePrice
		{
			set{ _storeprice=value;}
			get{return _storeprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? buyScore
		{
			set{ _buyscore=value;}
			get{return _buyscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		#endregion Model

	}
}


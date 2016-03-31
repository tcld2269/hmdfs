using System;
namespace hm.Model
{
	/// <summary>
	/// sysItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sysItem
	{
		public sysItem()
		{}
		#region Model
		private int _siid;
		private int? _sicid;
		private string _itemname;
		private int? _orders;
		/// <summary>
		/// 
		/// </summary>
		public int siId
		{
			set{ _siid=value;}
			get{return _siid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sicId
		{
			set{ _sicid=value;}
			get{return _sicid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
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


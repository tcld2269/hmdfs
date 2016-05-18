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
		private string _itempath;
		private string _back1;
		private string _back2;
		private string _back3;
		private string _back4;
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
		public string itemPath
		{
			set{ _itempath=value;}
			get{return _itempath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string back1
		{
			set{ _back1=value;}
			get{return _back1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string back2
		{
			set{ _back2=value;}
			get{return _back2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string back3
		{
			set{ _back3=value;}
			get{return _back3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string back4
		{
			set{ _back4=value;}
			get{return _back4;}
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


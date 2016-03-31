using System;
namespace hm.Model
{
	/// <summary>
	/// 合同
	/// </summary>
	[Serializable]
	public partial class menu
	{
		public menu()
		{}
		#region Model
		private int _menuid;
		private int? _parentid;
		private string _menuname;
		private int? _level;
		private int? _orders;
		private string _url;
		/// <summary>
		/// 
		/// </summary>
		public int menuId
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? parentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string menuName
		{
			set{ _menuname=value;}
			get{return _menuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? level
		{
			set{ _level=value;}
			get{return _level;}
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
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		#endregion Model

	}
}


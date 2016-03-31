using System;
namespace hm.Model
{
	/// <summary>
	/// newsCat:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class newsCat
	{
		public newsCat()
		{}
		#region Model
		private int _catid;
		private int? _parentid;
		private string _catname;
		private int? _type;
		private int? _orders;
		private string _backcol;
		/// <summary>
		/// 
		/// </summary>
		public int catId
		{
			set{ _catid=value;}
			get{return _catid;}
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
		public string catName
		{
			set{ _catname=value;}
			get{return _catname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
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
		public string backCol
		{
			set{ _backcol=value;}
			get{return _backcol;}
		}
		#endregion Model

	}
}


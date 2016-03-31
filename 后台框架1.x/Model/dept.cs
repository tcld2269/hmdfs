using System;
namespace hm.Model
{
	/// <summary>
	/// dept:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class dept
	{
		public dept()
		{}
		#region Model
		private int _deptid;
		private int? _parentid;
		private string _deptname;
		private int? _userid;
		private string _manager;
		/// <summary>
		/// 
		/// </summary>
		public int deptId
		{
			set{ _deptid=value;}
			get{return _deptid;}
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
		public string deptName
		{
			set{ _deptname=value;}
			get{return _deptname;}
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
		public string manager
		{
			set{ _manager=value;}
			get{return _manager;}
		}
		#endregion Model

	}
}


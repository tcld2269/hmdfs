using System;
namespace hm.Model
{
	/// <summary>
	/// roleMenu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class roleMenu
	{
		public roleMenu()
		{}
		#region Model
		private int _rmid;
		private int? _roleid;
		private int? _menuid;
		/// <summary>
		/// 
		/// </summary>
		public int rmId
		{
			set{ _rmid=value;}
			get{return _rmid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? roleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? menuId
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		#endregion Model

	}
}


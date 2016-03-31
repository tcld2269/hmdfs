using System;
namespace hm.Model
{
	/// <summary>
	/// role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class role
	{
		public role()
		{}
        public static int Admin_Role_ID = 1;
        public static int Gaoceng_Role_ID = 2;
        public static int Bangongshi_Role_ID = 3;
        public static int Cangku_Role_ID = 4;
        public static int Guanliyuan_Role_ID = 5;
		#region Model
		private int _roleid;
		private string _rolename;
		/// <summary>
		/// 
		/// </summary>
		public int roleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		#endregion Model

	}
}


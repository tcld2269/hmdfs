using System;
namespace hm.Model
{
	/// <summary>
	/// t_city:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_city
	{
		public t_city()
		{}
		#region Model
		private int _id;
		private string _code;
		private string _name;
		private string _provincecode;
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
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string provinceCode
		{
			set{ _provincecode=value;}
			get{return _provincecode;}
		}
		#endregion Model

	}
}


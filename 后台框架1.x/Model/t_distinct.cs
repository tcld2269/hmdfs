using System;
namespace hm.Model
{
	/// <summary>
	/// t_distinct:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_distinct
	{
		public t_distinct()
		{}
		#region Model
		private int _id;
		private string _code;
		private string _name;
		private string _citycode;
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
		public string cityCode
		{
			set{ _citycode=value;}
			get{return _citycode;}
		}
		#endregion Model

	}
}


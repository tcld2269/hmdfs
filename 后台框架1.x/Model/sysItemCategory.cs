using System;
namespace hm.Model
{
	/// <summary>
	/// sysItemCategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sysItemCategory
	{
		public sysItemCategory()
		{}
		#region Model
		private int _sicid;
		private string _innername;
		private string _catname;
		/// <summary>
		/// 
		/// </summary>
		public int sicId
		{
			set{ _sicid=value;}
			get{return _sicid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string innerName
		{
			set{ _innername=value;}
			get{return _innername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string catName
		{
			set{ _catname=value;}
			get{return _catname;}
		}
		#endregion Model

	}
}


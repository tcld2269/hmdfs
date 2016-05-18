using System;
namespace hm.Model
{
	/// <summary>
	/// advPos:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class advPos
	{
		public advPos()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _width;
		private string _height;
		private string _summary;
		private string _template;
		private DateTime? _addtime;
		private int? _status;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 广告位名称
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 宽度
		/// </summary>
		public string width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 高度
		/// </summary>
		public string height
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 简介
		/// </summary>
		public string summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 模板
		/// </summary>
		public string template
		{
			set{ _template=value;}
			get{return _template;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 状态见系统常量
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}


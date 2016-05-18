using System;
namespace hm.Model
{
	/// <summary>
	/// shoppingPayment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shoppingPayment
	{
		public shoppingPayment()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _code;
		private string _summary;
		private string _returnurl;
		private string _notifyurl;
		private string _ico;
		private string _gateurl;
		private string _filepath;
		private string _parm1;
		private string _parm2;
		private string _parm3;
		private string _parm4;
		private string _parm5;
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
		/// 支付名称
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 支付编码
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
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
		/// 
		/// </summary>
		public string returnUrl
		{
			set{ _returnurl=value;}
			get{return _returnurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string notifyUrl
		{
			set{ _notifyurl=value;}
			get{return _notifyurl;}
		}
		/// <summary>
		/// 图标
		/// </summary>
		public string ico
		{
			set{ _ico=value;}
			get{return _ico;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gateUrl
		{
			set{ _gateurl=value;}
			get{return _gateurl;}
		}
		/// <summary>
		/// 对应项目路径
		/// </summary>
		public string filePath
		{
			set{ _filepath=value;}
			get{return _filepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parm1
		{
			set{ _parm1=value;}
			get{return _parm1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parm2
		{
			set{ _parm2=value;}
			get{return _parm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parm3
		{
			set{ _parm3=value;}
			get{return _parm3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parm4
		{
			set{ _parm4=value;}
			get{return _parm4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parm5
		{
			set{ _parm5=value;}
			get{return _parm5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}


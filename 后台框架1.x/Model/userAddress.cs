using System;
namespace hm.Model
{
	/// <summary>
	/// userAddress:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userAddress
	{
		public userAddress()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private string _contacts;
		private string _tel;
		private string _addressno;
		private string _addressinfo;
		private int? _isdefault;
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
		public int? userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contacts
		{
			set{ _contacts=value;}
			get{return _contacts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addressNo
		{
			set{ _addressno=value;}
			get{return _addressno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addressInfo
		{
			set{ _addressinfo=value;}
			get{return _addressinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isDefault
		{
			set{ _isdefault=value;}
			get{return _isdefault;}
		}
		#endregion Model

	}
}


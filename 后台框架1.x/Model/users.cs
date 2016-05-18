﻿using System;
namespace hm.Model
{
	/// <summary>
	/// users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class users
	{
		public users()
		{}
		#region Model
		private int _userid;
		private string _username;
		private string _password;
		private string _truename;
		private string _nickname;
		private string _addresscode;
		private string _address;
		private string _avatar_small;
		private string _avatar_big;
		private int? _deptid;
		private string _deptname;
		private int? _roleid;
		private string _rolename;
		private int? _sex;
		private string _tel;
		private string _email;
		private string _qq;
		private int? _score;
		private int? _scorefrozen;
		private decimal? _account;
		private decimal? _accountfrozen;
		private string _regtype;
		private string _regfrom;
		private DateTime? _addtime;
		private DateTime? _lastlogintime;
		private int? _logincount;
		private int? _isadmin;
		private string _wxopenid;
		private int? _status;
		/// <summary>
		/// 
		/// </summary>
		public int userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trueName
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addressCode
		{
			set{ _addresscode=value;}
			get{return _addresscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avatar_small
		{
			set{ _avatar_small=value;}
			get{return _avatar_small;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avatar_big
		{
			set{ _avatar_big=value;}
			get{return _avatar_big;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? deptId
		{
			set{ _deptid=value;}
			get{return _deptid;}
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
		public int? roleId
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
		/// <summary>
		/// 
		/// </summary>
		public int? sex
		{
			set{ _sex=value;}
			get{return _sex;}
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
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? scoreFrozen
		{
			set{ _scorefrozen=value;}
			get{return _scorefrozen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? accountFrozen
		{
			set{ _accountfrozen=value;}
			get{return _accountfrozen;}
		}
		/// <summary>
		/// username,tel,email
		/// </summary>
		public string regType
		{
			set{ _regtype=value;}
			get{return _regtype;}
		}
		/// <summary>
		/// pc,app,wap
		/// </summary>
		public string regFrom
		{
			set{ _regfrom=value;}
			get{return _regfrom;}
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
		/// 
		/// </summary>
		public DateTime? lastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? loginCount
		{
			set{ _logincount=value;}
			get{return _logincount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isAdmin
		{
			set{ _isadmin=value;}
			get{return _isadmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wxOpenId
		{
			set{ _wxopenid=value;}
			get{return _wxopenid;}
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


using System;
namespace BES.Entities
{
	/// <summary>
	/// User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class User
	{
		public User()
		{}
		#region Model
        private Int32 _int;
        private String _username;
        private String _userpassword;
        private String _usertypename;
        private Int32 _usertype;
        private String _userCompanyCode;
        private String _userCompanyName;
		/// <summary>
		/// 用户编码
		/// </summary>
        public Int32 UserID
		{
			set{ _int=value;}
			get{return _int;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
        public String UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
        public String UserPassword
		{
			set{ _userpassword=value;}
			get{return _userpassword;}
		}
        public String UserTypeName
        {
            get { return _usertypename; }
            set { _usertypename = value; }
        }
        public Int32 UserType
        {
            get { return _usertype; }
            set { _usertype = value; }
        }
        public String UserCompanyCode
        {
            get { return _userCompanyCode; }
            set { _userCompanyCode = value; }
        }
        public String UserCompanyName
        {
            get { return _userCompanyName; }
            set { _userCompanyName = value; }
        }
		#endregion Model

	}
}


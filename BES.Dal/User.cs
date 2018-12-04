using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BES.Common;
namespace BES.DAL
{
	/// <summary>
	/// 数据访问类:User
	/// </summary>
	public partial class User
	{
		public User()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
            return DbHelperSQL.GetMaxID("userid", "t_User"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_User");
			strSql.Append(" where userid=@userid");
			SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4)
			};
			parameters[0].Value = userid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BES.Entities.User model)
		{
            if (!CheckUserName(model.UserName))
            {
                return 0;
            }
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_User(");
            strSql.Append("username,userpassword,usertype,companycode)");
			strSql.Append(" values (");
            strSql.Append("@username,@userpassword,@usertype,@companycode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,20),
					new SqlParameter("@userpassword", SqlDbType.VarChar,20),
                    new SqlParameter("@usertype", SqlDbType.Int,4),
                    new SqlParameter("@companycode", SqlDbType.VarChar,50)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.UserPassword;
            parameters[2].Value = model.UserType;
            parameters[3].Value = model.UserCompanyCode;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(BES.Entities.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_User set ");
			strSql.Append("username=@username,");
			strSql.Append("userpassword=@userpassword,");
            strSql.Append("usertype=@usertype,");
            strSql.Append("companycode=@companycode");
            strSql.Append(" where userid=@userid");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,20),
					new SqlParameter("@userpassword", SqlDbType.VarChar,20),
                    new SqlParameter("@usertype", SqlDbType.Int,4),
					new SqlParameter("@userid", SqlDbType.Int,4),
                    new SqlParameter("@companycode", SqlDbType.VarChar,50)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.UserPassword;
            parameters[2].Value = model.UserType;
            parameters[3].Value = model.UserID;
            parameters[4].Value = model.UserCompanyCode;
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_User ");
			strSql.Append(" where userid=@userid");
			SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4)
			};
			parameters[0].Value = userid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BES.Entities.User GetModel(int userid)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 userid,username,userpassword, case usertype when 1 then '管理员' else '出版公司' end as utype,usertype,companycode,COMPANY.SHORTNAME from t_User left join COMPANY on  t_User.companycode=COMPANY.CODE");
			strSql.Append(" where userid=@userid");
			SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4)
			};
			parameters[0].Value = userid;

            BES.Entities.User model = new BES.Entities.User();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                if (ds.Tables[0].Rows[0]["userid"] != null && ds.Tables[0].Rows[0]["userid"].ToString() != "")
				{
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["userid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["username"]!=null && ds.Tables[0].Rows[0]["username"].ToString()!="")
				{
					model.UserName=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userpassword"]!=null && ds.Tables[0].Rows[0]["userpassword"].ToString()!="")
				{
					model.UserPassword=ds.Tables[0].Rows[0]["userpassword"].ToString();
				}
                if (ds.Tables[0].Rows[0]["utype"] != null && ds.Tables[0].Rows[0]["utype"].ToString() != "")
                {
                    model.UserTypeName = ds.Tables[0].Rows[0]["utype"].ToString();
                }
                if (ds.Tables[0].Rows[0]["usertype"] != null && ds.Tables[0].Rows[0]["usertype"].ToString() != "")
                {
                    model.UserType = int.Parse(ds.Tables[0].Rows[0]["usertype"].ToString());
                }
                else
                {
                    model.UserType = 0;
                }
                if (ds.Tables[0].Rows[0]["companycode"] != null && ds.Tables[0].Rows[0]["companycode"].ToString() != "")
                {
                    model.UserCompanyCode = ds.Tables[0].Rows[0]["companycode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHORTNAME"] != null && ds.Tables[0].Rows[0]["SHORTNAME"].ToString() != "")
                {
                    model.UserCompanyName = ds.Tables[0].Rows[0]["SHORTNAME"].ToString();
                }
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// 通过用户名得到一个对象实体
        /// </summary>
        public BES.Entities.User GetModelByName(String UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userid,username,userpassword, case usertype when 1 then '管理员' else '出版公司' end as utype,usertype,companycode,COMPANY.SHORTNAME from t_User left join COMPANY on  t_User.companycode=COMPANY.CODE");
            strSql.Append(" where username=@username");
            SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,50)
			};
            parameters[0].Value = UserName;

            BES.Entities.User model = new BES.Entities.User();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["userid"] != null && ds.Tables[0].Rows[0]["userid"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["userid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["username"] != null && ds.Tables[0].Rows[0]["username"].ToString() != "")
                {
                    model.UserName = ds.Tables[0].Rows[0]["username"].ToString();
                }
                if (ds.Tables[0].Rows[0]["userpassword"] != null && ds.Tables[0].Rows[0]["userpassword"].ToString() != "")
                {
                    model.UserPassword = ds.Tables[0].Rows[0]["userpassword"].ToString();
                }
                if (ds.Tables[0].Rows[0]["utype"] != null && ds.Tables[0].Rows[0]["utype"].ToString() != "")
                {
                    model.UserTypeName = ds.Tables[0].Rows[0]["utype"].ToString();
                }
                if (ds.Tables[0].Rows[0]["usertype"] != null && ds.Tables[0].Rows[0]["usertype"].ToString() != "")
                {
                    model.UserType = int.Parse(ds.Tables[0].Rows[0]["usertype"].ToString());
                }
                else
                {
                    model.UserType = 0;
                }
                if (ds.Tables[0].Rows[0]["companycode"] != null && ds.Tables[0].Rows[0]["companycode"].ToString() != "")
                {
                    model.UserCompanyCode = ds.Tables[0].Rows[0]["companycode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHORTNAME"] != null && ds.Tables[0].Rows[0]["SHORTNAME"].ToString() != "")
                {
                    model.UserCompanyName = ds.Tables[0].Rows[0]["SHORTNAME"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select userid,username,userpassword, case usertype when 1 then '管理员' else '出版公司' end as usertype,COMPANY.SHORTNAME ");
            strSql.Append(" from t_User left join COMPANY on t_User.companycode=COMPANY.CODE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取用户类型
		/// </summary>
		public int GetUserType(string UserName)
		{
            string strSQL = string.Format("select usertype FROM t_User where username='{0}'", UserName);
            int iType = 2;
            try
            {
                iType = Convert.ToInt32(DbHelperSQL.Query(strSQL).Tables[0].Rows[0][0]);
            }
            catch
            { }
            return iType;
		}
        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        public bool CheckUserName(string UserName)
        {
            string Sql = string.Format("SELECT COUNT(*) FROM t_User where username='{0}'", UserName);
            //int i = 1;
            try
            {
                int i = Convert.ToInt32(DbHelperSQL.Query(Sql).Tables[0].Rows[0][0]);
                if (i > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        public bool UpdateUserPassword(string UserName,string UserPasswword)
        {
            string Sql = string.Format("update t_User set userpassword='{1}' where username='{0}'", UserName, UserPasswword);
            try
            {
                if (DbHelperSQL.ExecuteSql(Sql)>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
		
		#endregion  Method
	}
}


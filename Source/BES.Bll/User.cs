using System;
using System.Data;
using System.Collections.Generic;
using BES.Entities;
namespace BES.BLL
{
	/// <summary>
	/// User
	/// </summary>
	public partial class User
	{
		private readonly BES.DAL.User dal=new BES.DAL.User();
		public User()
		{}
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userid)
        {
            return dal.Exists(userid);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BES.Entities.User model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(BES.Entities.User model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int userid)
        {

            return dal.Delete(userid);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BES.Entities.User GetModel(int userid)
        {
            return dal.GetModel(userid);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }



        /// <summary>
        /// 获取用户类型
        /// </summary>
        public int GetUserType(string UserName)
        {
            return dal.GetUserType(UserName);
        }
        /// <summary>
        /// 检查用名是否存在
        /// </summary>
        public bool CheckUserName(string UserName)
        {
            return dal.CheckUserName(UserName);
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        public bool UpdateUserPassword(string UserName, string UserPasswword)
        {
            return dal.UpdateUserPassword(UserName, UserPasswword);
        }

        /// <summary>
        /// 通过用户名得到一个对象实体
        /// </summary>
        public BES.Entities.User GetModelByName(String UserName)
        {
            return dal.GetModelByName(UserName);
        }
	}
}


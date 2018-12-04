using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BES.Entities
{
    /// <summary>
    /// 数据缓存类
    /// </summary>
    [Serializable]
    public class DevCache
    {
        
        private DataSet devDataSet;
        private User devUser;
        private DateTime loginTime;

        /// <summary>
        /// 获取表类型缓存数据
        /// </summary>
        public DataSet DevDataSet
        {
            get
            {
                return devDataSet;
            }
            set
            {
                devDataSet = value;
            }
        }

        /// <summary>
        /// 登陆用户信息
        /// </summary>
        public User DevUser
        {
            get
            {
                return devUser;
            }
            set
            {
                devUser = value;
            }
        }

        /// <summary>
        /// 登陆时间
        /// </summary>
        public DateTime LoginTime
        {
            get
            {
                return loginTime;
            }
            set
            {
                loginTime = value;
            }
        }
    }
}

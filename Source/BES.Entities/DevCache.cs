using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BES.Entities
{
    /// <summary>
    /// ���ݻ�����
    /// </summary>
    [Serializable]
    public class DevCache
    {
        
        private DataSet devDataSet;
        private User devUser;
        private DateTime loginTime;

        /// <summary>
        /// ��ȡ�����ͻ�������
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
        /// ��½�û���Ϣ
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
        /// ��½ʱ��
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

using System;
using System.Collections.Generic;
using System.Text;
using BES.Entities;
using System.Data;

namespace BES.BLL
{
    public class Common
    {
        BES.DAL.Common dalCommon;
        public Common()
        {
            dalCommon = new BES.DAL.Common();
        }
        public DevCache GetCache(String UserName)
        {
            return dalCommon.GetCache(UserName);
        }

        public DataSet GetLocalCache()
        {
            return dalCommon.GetLocalCache();
        }

    }
}

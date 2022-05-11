using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BES.WebService
{
    /// <summary>
    /// CommonService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class CommonService : System.Web.Services.WebService
    {
        BES.BLL.Common bllCommon;
        public CommonService()
        {
            bllCommon = new BES.BLL.Common();
        }
        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public DateTime GetServerTime(string WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return DateTime.Now;
        }

        /// <summary>
        /// 获取系统缓存
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        [WebMethod]
        public String GetCache(String UserName, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return Common.CommonHelper.Serialize(bllCommon.GetCache(UserName));
        }

        /// <summary>
        /// 获取本地更新数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetLocalCache(String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return new BES.BLL.Common().GetLocalCache();
        }
    }
}

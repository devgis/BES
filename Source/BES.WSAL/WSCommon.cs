using System;
using System.Collections.Generic;
using System.Text;
using BES.Common;
using System.Data;

namespace BES.WSAL
{
    public class WSCommon
    {
        /// <summary>
        /// ��ȡ������ʱ��
        /// </summary>
        public static DateTime GetServerTime()
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "CommonService.asmx";
                    string[] args = new string[1];
                    args[0] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetServerTime", args);
                    return (DateTime)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ȡϵͳ����
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public static BES.Entities.DevCache GetCache(String UserName)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "CommonService.asmx";
                    object[] args = new object[2];
                    args[0] = UserName;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetCache", args);
                    return CommonHelper.DeSerialize(typeof(BES.Entities.DevCache), oResult.ToString()) as BES.Entities.DevCache;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ȡ���ظ�������
        /// </summary>
        /// <returns></returns>
        public static DataSet GetLocalCache()
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "CommonService.asmx";
                    object[] args = new object[1];
                    args[0] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetLocalCache", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

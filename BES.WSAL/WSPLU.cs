using System;
using System.Collections.Generic;
using System.Text;
using BES.Common;
using System.Data;

namespace BES.WSAL
{
    public class WSPLU
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool Add(BES.Entities.PLU model)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = CommonHelper.Serialize(model);
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "Add", args);
                    return (bool)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="strModel"></param>
        /// <returns></returns>
        public static bool Update(BES.Entities.PLU model)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = CommonHelper.Serialize(model);
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "Update", args);
                    return (bool)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <returns></returns>
        public static bool Delete(String PLUCODE)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = PLUCODE;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "Delete", args);
                    return (bool)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = strWhere;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetList", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取单个对象
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        public static BES.Entities.PLU GetModel(String PLUCODE)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = PLUCODE;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetModel", args);
                    return CommonHelper.DeSerialize(typeof(BES.Entities.PLU), oResult.ToString()) as BES.Entities.PLU;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取多个对象
        /// </summary>
        /// <param name="Where"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        public static List<BES.Entities.PLU> GetModelList(String Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = Where;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetModelList", args);
                    return CommonHelper.DeSerialize(typeof(List<BES.Entities.PLU>), oResult.ToString()) as List<BES.Entities.PLU>;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取多个数据集
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public static DataSet GetModelDataSet(String Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = Where;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetModelList", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查询ISBN号相同的书
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public static DataSet GetListByISBN(String ISBN)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = ISBN;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetListByISBN", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public static DataSet GetImageList(String BookID)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = BookID;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetImageList", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="listPhotoFile"></param>
        /// <returns></returns>
        public static bool AddImageList(List<BES.Entities.PhotoFile> listPhotoFile)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = Common.CommonHelper.Serialize(listPhotoFile);
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "AddImageList", args);
                    return (bool)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查询图书信息
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns>查询结果集</returns>
        public static DataSet SearchBook(string strWhere)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = strWhere;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "SearchBook", args);
                    return oResult as DataSet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取封面图片
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public static Byte[] GetCover(String BookID)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "PLUService.asmx";
                    string[] args = new string[2];
                    args[0] = BookID;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetCover", args);
                    return (Byte[])oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

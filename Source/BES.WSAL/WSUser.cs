using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BES.Common;

namespace BES.WSAL
{
    public class WSUser
    {
        /// <summary>
        /// 检查用户密码
        /// </summary>
        public static int CheckPassWord(string UserName,string UserPassword)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    string[] args = new string[3];
                    args[0] = UserName;
                    args[1] = UserPassword;
                    args[2] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "CheckPassWord", args);
                    return (int)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int Add(BES.Entities.User model)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    string[] args = new string[2];
                    args[0] = CommonHelper.Serialize(model);
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "Add", args);
                    return (int)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(BES.Entities.User model)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
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
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int userid)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    object[] args = new object[2];
                    args[0] = userid;
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
        /// 得到一个对象实体
        /// </summary>
        public static BES.Entities.User GetModel(int userid)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    object[] args = new object[2];
                    args[0] = userid;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetModel", args);
                    return CommonHelper.DeSerialize(typeof(BES.Entities.User), oResult.ToString()) as BES.Entities.User;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 通过用户名得到一个对象实体
        /// </summary>
        public static BES.Entities.User GetModelByName(String UserName)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    object[] args = new object[2];
                    args[0] = UserName;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetModelByName", args);
                    return CommonHelper.DeSerialize(typeof(BES.Entities.User), oResult.ToString()) as BES.Entities.User;
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
        public static DataTable GetList(string strWhere)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    object[] args = new object[2];
                    args[0] = strWhere;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetList", args);
                    return (oResult as DataSet).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取用户类型
        /// </summary>
        public static int GetUserType(string UserName)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    string[] args = new string[2];
                    args[0] = UserName;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "GetUserType", args);
                    return (int)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 检查用名是否存在
        /// </summary>
        public static bool CheckUserName(string UserName)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    string[] args = new string[2];
                    args[0] = UserName;
                    args[1] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "CheckUserName", args);
                    return (bool)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        public static bool UpdateUserPassword(string UserName, string UserPasswword)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("服务地址配置错误！");
                }
                else
                {
                    string WsFullURL = WSInfo.WsURL + "UserService.asmx";
                    string[] args = new string[3];
                    args[0] = UserName;
                    args[1] = UserPasswword;
                    args[2] = WSInfo.SPassword;
                    object oResult = BESService.InvokeWebService(WsFullURL, "UpdateUserPassword", args);
                    return (bool)oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}

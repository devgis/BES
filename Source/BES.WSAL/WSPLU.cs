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
        /// ����һ������
        /// </summary>
        public static bool Add(BES.Entities.PLU model)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ���²���
        /// </summary>
        /// <param name="strModel"></param>
        /// <returns></returns>
        public static bool Update(BES.Entities.PLU model)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ɾ������
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <returns></returns>
        public static bool Delete(String PLUCODE)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ��������б�
        /// </summary>
        public static DataSet GetList(string strWhere)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ��ȡ��������
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
                    throw new Exception("�����ַ���ô���");
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
        /// ��ȡ�������
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
                    throw new Exception("�����ַ���ô���");
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
        /// ��ȡ������ݼ�
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public static DataSet GetModelDataSet(String Where)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ��ѯISBN����ͬ����
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public static DataSet GetListByISBN(String ISBN)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ��ȡͼƬ�б�
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public static DataSet GetImageList(String BookID)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ����ͼƬ
        /// </summary>
        /// <param name="listPhotoFile"></param>
        /// <returns></returns>
        public static bool AddImageList(List<BES.Entities.PhotoFile> listPhotoFile)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ��ѯͼ����Ϣ
        /// </summary>
        /// <param name="strWhere">��ѯ����</param>
        /// <returns>��ѯ�����</returns>
        public static DataSet SearchBook(string strWhere)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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
        /// ��ȡ����ͼƬ
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public static Byte[] GetCover(String BookID)
        {
            try
            {
                if (WSInfo.WsURL.Trim() == "")
                {
                    throw new Exception("�����ַ���ô���");
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

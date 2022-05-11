using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BES.Common;
using BES.Entities;

namespace BES.DAL
{
    public class Common
    {
        public DevCache GetCache(String UserName)
        {
            DevCache devCache = new DevCache();
            devCache.DevDataSet = GetDataSet();
            devCache.DevUser = new BES.DAL.User().GetModelByName(UserName); //��ȡ�û���Ϣ
            devCache.LoginTime = DateTime.Now;
            return devCache;
        }

        private DataSet GetDataSet()
        {
            DataSet dsResult = new DataSet();
            //��������Ϣ��
            //String strSQL = "SELECT NAME,CODE,SHORTNAME FROM COMPANY WHERE TXNTYPE=1 ORDER BY NAME";
            //DataTable dtCOMPANY = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            //dtCOMPANY.TableName = "COMPANY";
            //dsResult.Tables.Add(dtCOMPANY);

            ////������
            //strSQL = "SELECT CODE,SHORTNAME FROM COMPANY WHERE TXNTYPE<>1";
            //DataTable dtCOMPANYSALE = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            //dtCOMPANYSALE.TableName = "SALECOMPANY";
            //dsResult.Tables.Add(dtCOMPANYSALE);

            ////С�� ��ͼ������
            //strSQL = "SELECT CLSCODE,CLSNAME FROM CLASS";
            //DataTable dtCLASS = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            //dtCLASS.TableName = "CLASS";
            //dsResult.Tables.Add(dtCLASS);
            String strSQL = String.Empty;
            //����� һ������
            strSQL = "SELECT DPTCODE,DPTNAME FROM DEPARTMENT";
            DataTable dtDEPARTMENT = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtDEPARTMENT.TableName = "DEPARTMENT";
            dsResult.Tables.Add(dtDEPARTMENT);

            //��Ʒ����
            strSQL = "SELECT PYSTYPE,DESCRIPT FROM PYSTYPE";
            DataTable dtPYSTYPE = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtPYSTYPE.TableName = "PYSTYPE";
            dsResult.Tables.Add(dtPYSTYPE);

            //װ֡��
            strSQL = "SELECT BINDING,DESCRIPT FROM BINDING";
            DataTable dtBINDING = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtBINDING.TableName = "BINDING";
            dsResult.Tables.Add(dtBINDING);

            //������
            strSQL = "SELECT BKSIZE,DESCRIPT FROM SIZE";
            DataTable dtSIZE = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtSIZE.TableName = "SIZE";
            dsResult.Tables.Add(dtSIZE);

            //ͼ���ѯ��Ϣ��
            strSQL = "SELECT TYPENAME,TYPEVALUE FROM T_DICT WHERE TYPEID=1";
            DataTable dtSEARCHBOOKFILTER = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtSEARCHBOOKFILTER.TableName = "SEARCHBOOKFILTER";
            dsResult.Tables.Add(dtSEARCHBOOKFILTER);

            return dsResult;
        }

        public DataSet GetLocalCache()
        {
            DataSet dsResult = new DataSet();
            //��������Ϣ��
            String strSQL = "SELECT NAME,CODE,SHORTNAME,TXNTYPE FROM COMPANY";
            DataTable dtCOMPANY = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtCOMPANY.TableName = "COMPANY";
            dsResult.Tables.Add(dtCOMPANY);

            //������
            strSQL = "SELECT CLSCODE,CLSNAME FROM CLASS";
            DataTable dtCOMPANYSALE = DbHelperSQL.Query(strSQL).Tables[0].Copy();
            dtCOMPANYSALE.TableName = "CLASS";
            dsResult.Tables.Add(dtCOMPANYSALE);

            return dsResult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BES.Common;
using System.Data;
using System.Data.OleDb;

namespace BES.WSAL
{
    public class WSInfo
    {
        public static string WsURL = "";
        public static string SPassword = "";
        static WSInfo()
        {
            WsURL = System.Configuration.ConfigurationManager.AppSettings["WSAddress"].ToString();
            SPassword = System.Configuration.ConfigurationManager.AppSettings["WSPassword"].ToString();
            SPassword = DesSecurity.Decrypt(SPassword);
        }
        private static string localConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\dict.db;Persist Security Info=True;User ID=admin;Jet OLEDB:Database Password=BES20130313";
        public static DataSet GetLocalTable()
        {
            OleDbConnection con = new OleDbConnection(localConStr); 
            //OleDbCommand conidcmd=new OleDbCommand(selconid,con);
            //con.Open();
            //OleDbDataReader reader = conidcmd.ExecuteReader();
            //reader.Read();
            //constrid = reader[0].ToString();
            //con.Close();
            DataSet dsTemp = new DataSet();
            //加载出版社信息
            String strSQL = "SELECT NAME,CODE,SHORTNAME FROM COMPANY WHERE TXNTYPE=1 ORDER BY NAME";
            OleDbDataAdapter oda = new OleDbDataAdapter(strSQL, con);
            oda.Fill(dsTemp, "COMPANY");

            //小类 中图法分类
            strSQL = "SELECT CLSCODE,CLSNAME FROM CLASS";
            oda = new OleDbDataAdapter(strSQL, con);
            oda.Fill(dsTemp, "CLASS");
            return dsTemp;
        }

        public static bool UpdateLocalTable()
        {
            DataSet ds = null;
            try
            {
                //获取数据
                ds = WSCommon.GetLocalCache();
                if (ds == null || ds.Tables.Count < 2)
                {
                    throw new Exception("获取数据失败！");
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(localConStr);
                    con.Open();
                    OleDbTransaction otran=con.BeginTransaction();
                    try
                    {
                        //otran.Begin();
                        String strSQL = "DELETE FROM COMPANY";
                        OleDbCommand cmd = new OleDbCommand(strSQL, con);
                        cmd.Transaction = otran;
                        cmd.ExecuteNonQuery();

                        //更新COMPANY表
                        foreach (DataRow dr in ds.Tables["COMPANY"].Rows)
                        {
                            strSQL = "INSERT INTO COMPANY (NAME,CODE,SHORTNAME,TXNTYPE)VALUES(@NAME,@CODE,@SHORTNAME,@TXNTYPE)";
                            cmd = new OleDbCommand(strSQL, con);
                            cmd.Parameters.Add(new OleDbParameter("@CODE", dr["CODE"]));
                            cmd.Parameters.Add(new OleDbParameter("@NAME", dr["NAME"]));
                            cmd.Parameters.Add(new OleDbParameter("@SHORTNAME", dr["SHORTNAME"]));
                            cmd.Parameters.Add(new OleDbParameter("@TXNTYPE", dr["TXNTYPE"]));
                            cmd.Transaction = otran;
                            cmd.ExecuteNonQuery();
                        }

                        //更新CLASS表
                        strSQL = "DELETE FROM CLASS";
                        cmd = new OleDbCommand(strSQL, con);
                        cmd.Transaction = otran;
                        cmd.ExecuteNonQuery();
                        foreach (DataRow dr in ds.Tables["CLASS"].Rows)
                        {
                            strSQL = "INSERT INTO CLASS (CLSCODE,CLSNAME)VALUES(@CLSCODE,@CLSNAME)";
                            cmd = new OleDbCommand(strSQL, con);
                            cmd.Parameters.Add(new OleDbParameter("@CLSCODE", dr["CLSCODE"]));
                            cmd.Parameters.Add(new OleDbParameter("@CLSNAME", dr["CLSNAME"]));
                            cmd.Transaction = otran;
                            cmd.ExecuteNonQuery();
                        }
                        otran.Commit();
                        con.Close();
                        return true;
                    }
                    catch(Exception ex)
                    {
                        otran.Rollback();
                        return false;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("ERROR:"+ex.Message);
            }
            return false;
        }
    }
}

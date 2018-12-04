using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
//using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace BES.Common
{
    public class CommonHelper
    {
        /// <summary>
        /// 表主键 自增值
        /// </summary>
        public const int NEXT_DISTANCE_ID = 1;

        #region 对话框

        ///// <summary>
        ///// 信息提示框
        ///// </summary>
        ///// <param name="message"></param>
        //public static DialogResult ConfirmInfo(string message)
        //{
        //    return ConfirmInfo(message, 0);
        //}
        ///// <summary>
        ///// 警告框
        ///// </summary>
        ///// <param name="message"></param>
        //public static DialogResult ConfirmError(string message)
        //{
        //    return ConfirmError(message, 0);
        //}
        /////// <summary>
        /////// 询问框
        /////// </summary>
        /////// <param name="message"></param>
        ////public static DialogResult ConfirmAsk(string message)
        ////{
        ////    return ConfirmAsk(message, 0);
        ////}

        ///// <summary>
        ///// 信息提示框
        ///// </summary>
        ///// <param name="message"></param>
        //public static DialogResult ConfirmInfo(string message, int id)
        //{
        //    return MessageBox.Show(message, "提示" + (id == 0 ? "" : "-" + id.ToString()), MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        ///// <summary>
        ///// 警告框
        ///// </summary>
        ///// <param name="message"></param>
        //public static DialogResult ConfirmError(string message, int id)
        //{
        //    return MessageBox.Show(message, "警告" + (id == 0 ? "" : "-" + id.ToString()), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        ///// <summary>
        ///// 询问框
        ///// </summary>
        ///// <param name="message"></param>
        //public static DialogResult ConfirmAsk(string message, int id)
        //{
        //    return MessageBox.Show(message, "咨询" + (id == 0 ? "" : "-" + id.ToString()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        //}

        #endregion

        #region 序列化 和 反序列化


        private static Dictionary<int, XmlSerializer> serializer_dict = new Dictionary<int, XmlSerializer>();

        private static XmlSerializer GetSerializer(Type t)
        {
            int type_hash = t.GetHashCode();
            if (!serializer_dict.ContainsKey(type_hash))
                serializer_dict.Add(type_hash, new XmlSerializer(t));
            return serializer_dict[type_hash];
        }

        /// <summary>
        /// 实体序列化成XML源文件
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>xml源文件字符串</returns>
        public static string Serialize(object obj)
        {
            string returnStr = "";
            XmlSerializer serializer = GetSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            XmlTextWriter xtw = null;
            StreamReader sr = null;
            try
            {
                xtw = new System.Xml.XmlTextWriter(ms, Encoding.UTF8);
                xtw.Formatting = System.Xml.Formatting.Indented; serializer.Serialize(xtw, obj); ms.Seek(0, SeekOrigin.Begin); sr = new StreamReader(ms); returnStr = sr.ReadToEnd();
            }
            catch (Exception ex) { throw ex; }
            finally { if (xtw != null) xtw.Close(); if (sr != null) sr.Close(); ms.Close(); } return returnStr.Substring(38, returnStr.Length - 38);
        }
        /// <summary> 
        /// XML源文件反序列化成实体
        /// </summary> 
        /// <param name="type">实体类型</param> 
        /// <param name="s">XML源文件</param> 
        /// <returns></returns> 
        public static object DeSerialize(Type type, string s)
        {
            byte[] b = System.Text.Encoding.UTF8.GetBytes(s);
            try
            {
                XmlSerializer serializer = GetSerializer(type);
                return serializer.Deserialize(new MemoryStream(b));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// 对象为null则返回DBNull.Value,否则不变
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object NullToDBNull(object obj)
        {
            if (obj == null)
                return DBNull.Value;
            return obj;
        }
    }
}

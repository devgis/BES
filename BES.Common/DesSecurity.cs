using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace BES.Common
{
    public class DesSecurity
    {
        private static string sKey = "1BEF0069";
        private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        public static String Encrypt(String str)
        {
            byte[] bKey = Encoding.UTF8.GetBytes(sKey.Substring(0, 8));
            byte[] bIV = IV;
            byte[] bStr = Encoding.UTF8.GetBytes(str);
            try
            {
                DESCryptoServiceProvider desc = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, desc.CreateEncryptor(bKey, bIV), CryptoStreamMode.Write);
                cStream.Write(bStr, 0, bStr.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return string.Empty;
            }
        }

        public static String Decrypt(String DecryptStr)
        {
            try
            {
                byte[] bKey = Encoding.UTF8.GetBytes(sKey.Substring(0, 8));
                byte[] bIV = IV;
                byte[] bStr = Convert.FromBase64String(DecryptStr);
                DESCryptoServiceProvider desc = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, desc.CreateDecryptor(bKey, bIV), CryptoStreamMode.Write);
                cStream.Write(bStr, 0, bStr.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BES.Common;

namespace BES.WebService
{
    public class WSHelper
    {
        private static string SPassword = "";
        static WSHelper()
        {
            try
            {
                //ªÒ»°WebService√‹¬Î
                SPassword = System.Configuration.ConfigurationManager.AppSettings["WSPassword"].ToString();
                SPassword = DesSecurity.Decrypt(SPassword);
            }
            catch
            { }
        }
        public static bool CheckPassword(String PassWord)
        {
            //PassWord = DesSecurity.Decrypt(SPassword);
            if (PassWord == SPassword)
            {
                return true;
            }
            return false;
        }
    }
}

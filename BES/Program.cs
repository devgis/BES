using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BES.Forms;

namespace BES
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TimeSpan tsTemp=DateTime.Now-new DateTime(2013,3,3);
            if (tsTemp.TotalDays > 40)
            {
                MessageBox.Show("产品已经过期！");
                throw new Exception("产品已经过期！");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BES.Forms.BookManager.AdvanceSearch());
            Application.Run(new LoginForm());
        }
    }
}
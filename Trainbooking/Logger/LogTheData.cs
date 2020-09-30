using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Trainbooking.Logger
{
    public class LogTheData
    {
        public static void WriteLog(string strFileName, IList<IWebElement> strMessage)
        {
           /* try
            {
                String path = @"C:\Users\rebel\source\repos\Trainbooking\Trainbooking\Logger\";
                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", path, strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                foreach (var i in strMessage)
                {
                    objStreamWriter.WriteLine(i.Text);
                   
                }
                 objStreamWriter.Close();
                    objFilestream.Close();
               
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }*/
        }
    }
}

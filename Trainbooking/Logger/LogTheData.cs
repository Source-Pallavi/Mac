using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Trainbooking.Logger
{
    public class LogTheData
    {
        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                String path = @"C:\Users\rebel\source\repos\Trainbooking\Trainbooking\Logger\";
                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", path, strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

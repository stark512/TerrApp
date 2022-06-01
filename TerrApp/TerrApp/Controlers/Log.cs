using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TerrApp.Controlers
{
    public class Log
    {
        private string _Path = string.Empty;

        public Log()
        {

        }
        
        
        public void WriteLog(string className, string logMessage, LogType logType, int userId)
        {
            _Path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter writer = File.AppendText(_Path + "\\" + "TerrAppLog.txt"))
                {
                    writer.Write(GenerateEntry(className, logMessage, logType, userId));
                }
            }
            catch (Exception) { }
        }

        private string GenerateEntry(string className, string logMessage, LogType logType, int userId)
        {
            return "\n" + DateTime.Now.ToString() + "(" + className + ")" + ", UserId = " + userId + ", Type: " + logType + ", Error message: " + logMessage; 
        }
    }
}

using System;
using System.Configuration;
using System.IO;

namespace EmployeeMangement.Utilities
{
    public class LoggingException
    {
        public static void SaveLogFile(string method)
        {
        
                string location = ConfigurationManager.AppSettings["LogLocation"];
                try
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(location + @"log.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)))
                    {
                        sw.WriteLine(String.Format("{0}  - Method: {1}", DateTime.Now.ToShortDateString(), method.ToString()));
                    }
                }
                catch (IOException)
                {
                }
        }
    }
}
        


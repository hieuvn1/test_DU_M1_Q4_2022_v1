using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTest.File_Factory
{
    internal class Log
    {
        public static bool ToLog(string Serial, string Result)
        {
            try
            {
                string time = DateTime.Now.ToString("ddMMyyyy hhmmss");
                //string directoryPath = @"F:\hieuvn1\DU\PreTest\result";
                string directoryPath = @"D:\HieuVN\Project\C#\PreTest";
                DirectoryInfo directory = new DirectoryInfo(directoryPath);
                directory.Create();
                string filepathlog = directoryPath + "\\" + Serial + "_" + time + ".txt";
                FileStream fs = new FileStream(filepathlog, FileMode.Append);
                StreamWriter sWriter = new StreamWriter(fs);
                sWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + ": " + "\n" + Result);
                sWriter.Flush();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}

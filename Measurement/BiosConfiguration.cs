using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTest.Measurement
{
    class BiosConfiguration
    {
        string log;
        public bool MeasRun(string Ip, string Username, string Password)
        {
            try
            {
                Process Biosconfig = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.WorkingDirectory = "C:\\Users\\CuongHM1\\sum_2.8.1_Win_x86_64";
                startInfo.WorkingDirectory = "D:\\HieuVN\\Project\\C#\\sum_2.8.1_Win_x86_64";
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = @"/c ""sum -i " + Ip + " -u " + Username + " -p " + Password + " -c changeBiosCfg --file newbios_cfg.xml --post_complete --reboot --skip_unknown ";
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                Biosconfig.StartInfo = startInfo;
                Biosconfig.Start();
                Biosconfig.StandardInput.Flush();
                Biosconfig.StandardInput.Close();
                Biosconfig.WaitForExit();
                log = Biosconfig.StandardOutput.ReadToEnd();
                if (log.Contains("is POST completed"))
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

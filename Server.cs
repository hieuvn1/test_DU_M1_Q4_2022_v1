using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSH = Renci.SshNet;

namespace PreTest
{
    public class Server
    {
        public static string Serial;
        public static string Ip { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public bool flagping;
        public bool flagConn;
        public string log;
        public bool flagGetFile;
        public string cmdcommand { get; set; }
        //public static SSH.SshClient newsv = new SshClient(Ip, Username, Password);
        public void Connection(out bool flagConn)
        {
            flagConn = false;
            try
            {
                SshClient newsv = new SshClient(Ip, Username, Password);
                newsv.ConnectionInfo.Timeout = TimeSpan.FromSeconds(3);
                newsv.Connect();
                flagConn = newsv.IsConnected;
            }
            catch { }
        }
        public void Pingsv(string ip, out bool flagping)
        {
            flagping = false;
            Process checkConnect = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            //startInfo.WorkingDirectory = "C:\\Users\\CuongHM1\\sum_2.8.1_Win_x86_64";
            //startInfo.WorkingDirectory = "D:\\5G\\DU\\tool DU\\sum_2.8.1_Win_x86_64_20220506";
            startInfo.WorkingDirectory = "D:\\HieuVN\\Project\\C#\\sum_2.8.1_Win_x86_64";
            startInfo.Arguments = @"/c ping " + Ip;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            checkConnect.StartInfo = startInfo;
            checkConnect.Start();
            checkConnect.StandardInput.Flush();
            checkConnect.StandardInput.Close();
            checkConnect.WaitForExit();
            log = checkConnect.StandardOutput.ReadToEnd();
            if (log.Contains("TTL="))
            {
                flagping = true;
            }
        }
        public void GetFile(string ip, string username, string password, out bool flagGetFile)
        {
            flagGetFile = false;
            Process Getfile = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.WorkingDirectory = "D:\\5G\\DU\\tool DU\\sum_2.8.1_Win_x86_64_20220506\\sum_2.8.1_Win_x86_64";
            //startInfo.WorkingDirectory = "C:\\Users\\CuongHM1\\sum_2.8.1_Win_x86_64";
            startInfo.WorkingDirectory = "D:\\HieuVN\\Project\\C#\\sum_2.8.1_Win_x86_64";
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/c ""sum -i " + Ip + " -u " + Username + " -p " + Password + " -c GetCurrentBiosCfg --file bios_cfg.xml --overwrite";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            Getfile.StartInfo = startInfo;
            Getfile.Start();
            Getfile.StandardInput.Flush();
            Getfile.StandardInput.Close();
            Getfile.WaitForExit();
            log = Getfile.StandardOutput.ReadToEnd();
            if (log.Contains("is created"))
            {
                flagGetFile = true;
            }
        }
    }
}

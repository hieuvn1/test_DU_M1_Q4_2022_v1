using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PreTest.Measurement
{
    internal class CheckDevice
    {
        Device device = new Device();
        XmlNodeList xmlList;
        string log;
        public bool GetFiles(string Ip, string Username, string Password)
        {
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
                return true;
            }
            else
            {
                return false;
            }
        }
         public void MeasRun(string ip, string username, string password, string mainlog)
        {
            try
            {
                if (GetFiles(ip, username, password))
                {
                    List<Device> listDevice = new List<Device>();
                    XmlDocument document = new XmlDocument();
                    //string path = @"C:\Users\CuongHM1\sum_2.8.1_Win_x86_64\bios_cfg.xml";
                    //string path = @"D:\5G\DU\tool DU\bios_cfg.xml";
                    string path = @"D:\HieuVN\Project\C#\bios_cfg.xml";
                    document.Load(path);
                    xmlList = document.DocumentElement.ChildNodes;
                    device.ScanXmlDocument(xmlList, listDevice);
                    for (int i = 0; i < listDevice.Count; i++)
                    {
                        mainlog += listDevice[i].Name + listDevice[i].DeviceStatus + "\r\n";
                    }
                }
                else
                {
                    mainlog += "không lấy được file cấu hình";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

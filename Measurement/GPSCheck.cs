using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSH = Renci.SshNet;

namespace PreTest.Measurement
{
    class GPSCheck
    {
        string ip;
        string username;
        string password;
        string log;
        SSH.SshClient sv;
        // Kiểm tra Timing card
        public bool TimingcardCheck()
        {
            sv = new SSH.SshClient(ip, username, password);
            SSH.SshCommand command = sv.CreateCommand("lspci | grep Asix");
            command.Execute();
            log = command.Result;
            if (log.Contains("Device 9100"))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
        // Cấu hình module GPS
        public bool GPSConfig()
        {
            return false;
        }
        // Kiểm tra hoạt động module GPS
        public bool GPSvalid()
        {
            return false;
        }
        // Kiểm tra hoạt động dây 1pps
        public bool PpsCheck()
        {
            return false;
        }
        public bool MeasRun()
        {
            if (GPSConfig() && GPSvalid() && PpsCheck())
                return true;
            else
                return false;
        }
    }
}

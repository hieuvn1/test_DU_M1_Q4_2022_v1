using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSH = Renci.SshNet;

namespace PreTest.Measurement
{
    class NICCheck
    {
        public bool MeasRun(string ip, string username, string password)
        {
            try
            {
                SSH.SshClient sv = new SSH.SshClient(ip, username, password);
                SSH.SshCommand command = sv.CreateCommand("lshw –c network -businfo");
                command.Execute();
                string result = command.Result;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

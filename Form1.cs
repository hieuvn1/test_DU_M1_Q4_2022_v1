using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;
using PreTest.Measurement;
namespace PreTest
{
    using File_Factory;
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Server sv = new Server();
        Device device = new Device();
        public static bool flagCheckBtn = false;
        public static bool flagSetupBtn = false;
        XmlNodeList xmlList;
        string log;
        bool flagTestcaseSelected;
        int time = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int stt = 0;
            string measurement = "";
            string result = "";
            Server.Ip = tbxIP.Text;
            Server.Username = tbxUser.Text;
            Server.Password = tbxPassword.Text;
            Check(stt, measurement, result);
            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Stop();
            if (e.Cancelled)
            {
                MessageBox.Show("Quá trình đo đã tạm dừng", "Stop");
            }
            else
            {
                MessageBox.Show("Quá trình đo kiểm đã hoàn tất", "Hoàn thành");
                Log.ToLog(tbxSerial.Text, tbxResult.Text);
                Excel.ToExcel(lvResult);
            }
        }
        public void BtnConnect_Click(object sender, EventArgs e)
        {
            Server.Serial = tbxSerial.Text;
            Server.Ip = tbxIP.Text;
            Server.Username = tbxUser.Text;
            Server.Password = tbxPassword.Text;
            if (Server.Serial != "")
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    tbxResult.Text += "Connecting to server . . . " + "\r\n";
                    lblStatus.Text = "STATUS: CONNECTING";
                    lblStatus.BackColor = Color.Yellow;
                    sv.Connection(out sv.flagConn);
                    if (sv.flagConn == true)
                    {
                        lblStatus.Text = "STATUS: CONNECTED";
                        lblStatus.BackColor = Color.Green;
                        //flagcheckConn = true;
                        tbxSerial.ReadOnly = true;
                        tbxIP.ReadOnly = true;
                        tbxUser.ReadOnly = true;
                        tbxPassword.ReadOnly = true;
                        tbxResult.Text += "Connected to server" + "\r\n";
                        BtnConnect.Enabled = false;
                    }
                    else
                    {
                        tbxResult.Text += "Can not connect to server" + "\r\n";
                        lblStatus.Text = "STATUS: DISCONNECTED";
                        lblStatus.BackColor = Color.Red;
                        MessageBox.Show("Kiểm tra lại thông tin login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                tbxSerial.Focus();
                MessageBox.Show("Serial Number không được bỏ trống", "Error", MessageBoxButtons.OK);
            }
        }

        private void NewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxSerial.ReadOnly = false;
            tbxIP.ReadOnly = false;
            tbxUser.ReadOnly = false;
            tbxPassword.ReadOnly = false;
            tbxSerial.Focus();
            sv.flagping = false;
            //flagcheckConn = false;
            tbxResult.Text = null;
            log = null;
            lblStatus.Text = "STATUS: DISCONNECTED";
            lblStatus.BackColor = Color.Red;
            BtnConnect.Enabled = true;
            btnPing.BackColor = Color.Silver;
            lvResult.Items.Clear();
            time = 0;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Thoát chương trình?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
            {
             string time = DateTime.Now.ToString("ddMMyyyy");
            //string directoryPath = @"F:\hieuvn1\DU\PreTest\result";
             string directoryPath = @"D:\HieuVN\Project\C#\PreTest";
            Log.ToLog(tbxSerial.Text, tbxResult.Text);
            Excel.ToExcel(lvResult);
            }
        public void tbxUser_Validating(object sender, CancelEventArgs e)
            {
                if (string.IsNullOrEmpty(tbxUser.Text))
                {
                    e.Cancel = true;
                    tbxUser.Focus();
                    errorProvider1.SetError(tbxUser, "Nhập username");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbxUser, null);
                }
            }
            private void btnChangePW_Click(object sender, EventArgs e)
            {
                Change_password changepw = new Change_password();
                changepw.ShowDialog();
            }

            private void btnPing_Click(object sender, EventArgs e)
            {
                tbxResult.Text += "Pinging to " + Server.Ip + ". . ." + "\r\n";
                sv.Pingsv(Server.Ip, out sv.flagping);
                if (sv.flagping == true)
                {
                  btnPing.BackColor = Color.GreenYellow;
                  tbxResult.Text += "Đã kết nối" + "\r\n";
                }
                else
                {
                 tbxResult.Text += "Không ping được server" + "\r\n";
                 btnPing.BackColor = Color.Red;
                 MessageBox.Show("Không ping được đến server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnStop_Click(object sender, EventArgs e)
            {
            backgroundWorker1.CancelAsync();
            timer1.Stop();
            }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
            //HienthiketqualenLv(STT, Measurement, result);
            //Hienthilog(log);
        }
        #region Bài đo
        private void Check(int STT, string Measurement, string result)
        {
            TreeNodeCollection node = tvTestcase.Nodes;
            result = "FAIL";
            //if (node.Contains("Lắp đặt timingcard và card NIC").Checked == true)
                if (node[0].Checked == true)
                {
                 flagTestcaseSelected = true;
                 STT = 1;
                 Measurement = "Lắp đặt timingcard và card NIC" + "\r\n";
                CheckDevice checkDevice = new CheckDevice();
                checkDevice.MeasRun(tbxIP.Text, tbxUser.Text, tbxPassword.Text, log);
                    if (device.flagCheckDevice == true)
                    {
                        log += "Lắp đặt timing card và card NIC thành công" + "\r\n";
                        result = "PASS";
                    }
                    else
                    {
                        log += "Thiếu timing card và card NIC";
                        result = "FAIL";
                    }
                HienthiketqualenLv(STT, Measurement, result);
                Hienthilog(log);
                }
                //if(node["Cấu hình Bios"].Checked == true)
                if (node[1].Checked == true)
                {
                STT = 2;
                Measurement = "Cấu hình Bios";
                BiosConfiguration biosConfiguration = new BiosConfiguration();
                biosConfiguration.MeasRun(tbxIP.Text, tbxUser.Text, tbxPassword.Text);
                if (biosConfiguration.MeasRun(tbxIP.Text,tbxUser.Text,tbxPassword.Text))
                {
                    log += "Cấu hình Bios thành công" + "\r\n";
                    result = "PASS";
                }
                else
                {
                    log += "Lỗi cấu hình Bios" + "\r\n";
                    result = "FAIL";
                }
                    flagTestcaseSelected = true;
                    HienthiketqualenLv(STT, Measurement, result);
                    Hienthilog(log);
                }
                //if(node["Cấu hình Raid"].Checked == true)
                if (node[2].Checked == true)
                {
                STT = 3;
                Measurement = "Cấu hình Raid";
                RaidConfiguration raidConfiguration = new RaidConfiguration();
                if (raidConfiguration.MeasRun())
                {
                    log += "Cấu hình Raid thành công" + "\r\n";
                    result = "PASS";
                }
                else
                {
                    log += "Lỗi cấu hình Raid" + "\r\n";
                    result = "FAIL";
                }
                    flagTestcaseSelected = true;
                    HienthiketqualenLv(STT, Measurement, result);
                    Hienthilog(log);
                }
                //if(node["Cài đặt OS"].Checked == true)
                if (node[3].Checked == true)
                {
                    STT = 4;
                    Measurement = "Cài đặt OS";
                OSInstallCheck OSinstall = new OSInstallCheck();
                    if (OSinstall.MeasRun())
                    {
                        log += "Cài đặt OS thành công" + "\r\n";
                    }
                    else
                    {
                        log += "Lỗi cài đặt OS" + "\r\n";
                    result = "FAIL";
                    } 
                    flagTestcaseSelected = true;
                    HienthiketqualenLv(STT, Measurement, result);
                    Hienthilog(log);
                }
                //if(node["Kiểm tra và update firmware NIC"].Checked == true)
                if (node[4].Checked == true)
                {
                STT = 5;
                Measurement = "Kiểm tra và update firmware NIC";
                NICCheck nicCheck = new NICCheck();
                if(nicCheck.MeasRun(tbxIP.Text,tbxUser.Text,tbxPassword.Text))
                {
                    log += "" + "\r\n";
                }
                else
                {
                    log += "" + "\r\n";
                    result = "FAIL";
                }    
                flagTestcaseSelected = true;
                HienthiketqualenLv(STT, Measurement, result);
                Hienthilog(log);
            }
                //if (node["Kiểm tra GPS"].Checked == true)
                if (node[5].Checked == true)
                {
                STT = 6;
                Measurement = "Kiểm tra module GPS";
                GPSCheck gpsCheck = new GPSCheck();
                gpsCheck.MeasRun();
                if(gpsCheck.MeasRun())
                {
                    log += "Module GPS hoạt động bình thường";
                }
                else
                {
                    log += "Lỗi module GPS";
                    result = "FAIL";
                }
                flagTestcaseSelected = true;
                HienthiketqualenLv(STT, Measurement, result);
                Hienthilog(log);
                }
                if (flagTestcaseSelected == false)
                {
                    MessageBox.Show("Chưa chọn bài đo", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                flagSetupBtn = false;
            
        }
        #endregion
        #region Kiểm tra ngoại vi
        //private void CheckAlldevice()
        //{             
        //        List<Device> listDevice = new List<Device>();
        //        XmlDocument document = new XmlDocument();
        //        //string path = @"C:\Users\CuongHM1\sum_2.8.1_Win_x86_64\bios_cfg.xml";
        //        //string path = @"D:\5G\DU\tool DU\bios_cfg.xml";
        //        string path = @"D:\HieuVN\Project\C#\bios_cfg.xml";
        //        document.Load(path);
        //        xmlList = document.DocumentElement.ChildNodes;
        //        device.ScanXmlDocument(xmlList, listDevice);
        //        for (int i = 0; i < listDevice.Count; i++)
        //        {
        //          log += listDevice[i].Name + listDevice[i].DeviceStatus + "\r\n";
        //        }
        //}
        #endregion
        public void HienthiketqualenLv(int STT, string Measurement, string result)
        {
            ListViewItem item = new ListViewItem();
            Invoke(new Action(() =>
            {
                item.Text = STT.ToString();
                item.SubItems.Add(Measurement);
                item.SubItems.Add(DateTime.Now.ToString("hh:mm:ss"));
                item.SubItems.Add(result);
                if (result == "PASS")
                {
                    item.BackColor = Color.Green;
                }
                if (result == "FAIL" || result == "ERROR")
                {
                    item.BackColor = Color.Red;
                }
                lvResult.Items.Add(item);
            }));
        }
        public void Hienthilog(string logg)
        {
            Invoke(new Action(() =>
            {
                logg = log;
                tbxResult.Text = log;
            }));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            lblTime.Text = timeSpan.ToString();
        }
    }         
}

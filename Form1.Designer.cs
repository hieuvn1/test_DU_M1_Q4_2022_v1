namespace PreTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Kiểm tra ngoại vi");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cấu hình Bios");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cấu hình Raid");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cài đặt OS");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Kiểm tra và update firmware NIC");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Kiểm tra module GPS");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cấu hình các tham số khác");
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxSerial = new System.Windows.Forms.TextBox();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tvTestcase = new System.Windows.Forms.TreeView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(8, 15);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(65, 19);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "SERIAL";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(8, 48);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(24, 19);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "&IP";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 114);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "&Password";
            // 
            // tbxSerial
            // 
            this.tbxSerial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSerial.Location = new System.Drawing.Point(115, 11);
            this.tbxSerial.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSerial.Name = "tbxSerial";
            this.tbxSerial.Size = new System.Drawing.Size(267, 26);
            this.tbxSerial.TabIndex = 0;
            this.tbxSerial.Text = "1";
            // 
            // tbxIP
            // 
            this.tbxIP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIP.Location = new System.Drawing.Point(115, 44);
            this.tbxIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(267, 26);
            this.tbxIP.TabIndex = 1;
            this.tbxIP.Text = "192.168.120.2";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(115, 111);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(267, 26);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.Text = "123456a@";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 25);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(208, 28);
            this.progressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1399, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTestToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewTestToolStripMenuItem
            // 
            this.NewTestToolStripMenuItem.Name = "NewTestToolStripMenuItem";
            this.NewTestToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.NewTestToolStripMenuItem.Text = "New Test";
            this.NewTestToolStripMenuItem.Click += new System.EventHandler(this.NewTestToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(4, 66);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 19);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "STATUS: DISCONNECTED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "User";
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(115, 78);
            this.tbxUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(267, 26);
            this.tbxUser.TabIndex = 2;
            this.tbxUser.Text = "ADMIN";
            this.tbxUser.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUser_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbxResult.Location = new System.Drawing.Point(4, 16);
            this.tbxResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(1355, 147);
            this.tbxResult.TabIndex = 7;
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.Silver;
            this.btnPing.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.ForeColor = System.Drawing.Color.Blue;
            this.btnPing.Location = new System.Drawing.Point(389, 44);
            this.btnPing.Margin = new System.Windows.Forms.Padding(4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(35, 27);
            this.btnPing.TabIndex = 17;
            this.btnPing.Text = "P";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.BtnCheck);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Location = new System.Drawing.Point(20, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(432, 86);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackgroundImage = global::PreTest.Properties.Resources.images1;
            this.BtnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConnect.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(25, 17);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(64, 55);
            this.BtnConnect.TabIndex = 4;
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::PreTest.Properties.Resources.istockphoto_1356460584_612x612;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(337, 17);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 55);
            this.btnStop.TabIndex = 19;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCheck.BackgroundImage = global::PreTest.Properties.Resources.images;
            this.BtnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(129, 17);
            this.BtnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(64, 55);
            this.BtnCheck.TabIndex = 5;
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackgroundImage = global::PreTest.Properties.Resources.images__1_1;
            this.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(233, 17);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(64, 55);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnSetup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblSerial);
            this.groupBox2.Controls.Add(this.lblIP);
            this.groupBox2.Controls.Add(this.btnChangePW);
            this.groupBox2.Controls.Add(this.tbxSerial);
            this.groupBox2.Controls.Add(this.btnPing);
            this.groupBox2.Controls.Add(this.tbxIP);
            this.groupBox2.Controls.Add(this.tbxPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.tbxUser);
            this.groupBox2.Location = new System.Drawing.Point(20, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(432, 165);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // btnChangePW
            // 
            this.btnChangePW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnChangePW.BackgroundImage = global::PreTest.Properties.Resources.reset_password_icon_29;
            this.btnChangePW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePW.Location = new System.Drawing.Point(389, 111);
            this.btnChangePW.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(35, 31);
            this.btnChangePW.TabIndex = 18;
            this.btnChangePW.UseVisualStyleBackColor = false;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tbxResult);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 698);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1368, 180);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOG";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.tvTestcase);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 281);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(489, 420);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TEST CASE";
            // 
            // tvTestcase
            // 
            this.tvTestcase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvTestcase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tvTestcase.CheckBoxes = true;
            this.tvTestcase.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvTestcase.Location = new System.Drawing.Point(4, 20);
            this.tvTestcase.Margin = new System.Windows.Forms.Padding(4);
            this.tvTestcase.Name = "tvTestcase";
            treeNode1.Checked = true;
            treeNode1.Name = "rootLapdat";
            treeNode1.Text = "Kiểm tra ngoại vi";
            treeNode2.Checked = true;
            treeNode2.Name = "rootBiosConfig";
            treeNode2.Text = "Cấu hình Bios";
            treeNode3.Checked = true;
            treeNode3.Name = "rootRaidConfig";
            treeNode3.Text = "Cấu hình Raid";
            treeNode4.Checked = true;
            treeNode4.Name = "rootOSinstall";
            treeNode4.Text = "Cài đặt OS";
            treeNode5.Checked = true;
            treeNode5.Name = "rootNICcard";
            treeNode5.Text = "Kiểm tra và update firmware NIC";
            treeNode6.Checked = true;
            treeNode6.Name = "roottiming";
            treeNode6.Text = "Kiểm tra module GPS";
            treeNode7.Checked = true;
            treeNode7.Name = "rootNICinterface";
            treeNode7.Text = "Cấu hình các tham số khác";
            this.tvTestcase.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.tvTestcase.Size = new System.Drawing.Size(476, 389);
            this.tvTestcase.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.lvResult);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(509, 281);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(879, 420);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RESULT";
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(4, 23);
            this.lvResult.Margin = new System.Windows.Forms.Padding(4);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(871, 393);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STT";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Item Name";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 327;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Time";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 127;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Result";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 133;
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.Width = 52;
            // 
            // clItem
            // 
            this.clItem.Text = "ITEM NAME";
            this.clItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clItem.Width = 345;
            // 
            // clTime
            // 
            this.clTime.Text = "TIME";
            this.clTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTime.Width = 98;
            // 
            // clResult
            // 
            this.clResult.Text = "RESULT";
            this.clResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clResult.Width = 147;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 298;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Result";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 119;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTime);
            this.groupBox6.Controls.Add(this.progressBar1);
            this.groupBox6.Controls.Add(this.lblStatus);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1072, 41);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(316, 239);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PROCESS";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(224, 31);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 18);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1399, 869);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxSerial;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public  System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView tvTestcase;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader clItem;
        private System.Windows.Forms.ColumnHeader clTime;
        private System.Windows.Forms.ColumnHeader clResult;
        //public static System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTime;
    }
}


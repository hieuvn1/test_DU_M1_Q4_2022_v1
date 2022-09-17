namespace PreTest
{
    partial class Change_password
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
            this.lblCrPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblOk = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Button();
            this.ckbShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCrPassword
            // 
            this.lblCrPassword.AutoSize = true;
            this.lblCrPassword.Location = new System.Drawing.Point(12, 35);
            this.lblCrPassword.Name = "lblCrPassword";
            this.lblCrPassword.Size = new System.Drawing.Size(92, 13);
            this.lblCrPassword.TabIndex = 0;
            this.lblCrPassword.Text = "Current password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 61);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(80, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New password:";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(12, 87);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(119, 13);
            this.lblConfirm.TabIndex = 2;
            this.lblConfirm.Text = "Confirm new password: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblOk
            // 
            this.lblOk.Location = new System.Drawing.Point(66, 130);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(75, 23);
            this.lblOk.TabIndex = 6;
            this.lblOk.Text = "OK";
            this.lblOk.UseVisualStyleBackColor = true;
            // 
            // lblCancel
            // 
            this.lblCancel.Location = new System.Drawing.Point(220, 130);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(75, 23);
            this.lblCancel.TabIndex = 7;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.UseVisualStyleBackColor = true;
            // 
            // ckbShow
            // 
            this.ckbShow.AutoSize = true;
            this.ckbShow.Location = new System.Drawing.Point(66, 107);
            this.ckbShow.Name = "ckbShow";
            this.ckbShow.Size = new System.Drawing.Size(53, 17);
            this.ckbShow.TabIndex = 8;
            this.ckbShow.Text = "Show";
            this.ckbShow.UseVisualStyleBackColor = true;
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 165);
            this.Controls.Add(this.ckbShow);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCrPassword);
            this.Name = "Change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button lblOk;
        private System.Windows.Forms.Button lblCancel;
        private System.Windows.Forms.CheckBox ckbShow;
    }
}
namespace WindowsFormsApp1
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lbIp = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btketqua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 61);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(439, 297);
            this.txtLog.TabIndex = 7;
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(26, 15);
            this.lbIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(61, 13);
            this.lbIp.TabIndex = 6;
            this.lbIp.Text = "IP Address:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(127, 12);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(234, 20);
            this.txtIp.TabIndex = 5;
            this.txtIp.Text = "127.0.0.1";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(369, 12);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(159, 25);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Khởi tạo kết nối";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btketqua
            // 
            this.btketqua.Location = new System.Drawing.Point(459, 61);
            this.btketqua.Name = "btketqua";
            this.btketqua.Size = new System.Drawing.Size(69, 80);
            this.btketqua.TabIndex = 8;
            this.btketqua.Text = "Tạo suất Phim";
            this.btketqua.UseVisualStyleBackColor = true;
            this.btketqua.Click += new System.EventHandler(this.btketqua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Góc trao đổi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btketqua);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lbIp);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnListen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btketqua;
        private System.Windows.Forms.Label label1;
    }
}


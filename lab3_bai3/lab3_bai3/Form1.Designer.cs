namespace lab3_bai3
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
            this.txtmess = new System.Windows.Forms.TextBox();
            this.btconnect = new System.Windows.Forms.Button();
            this.btsend = new System.Windows.Forms.Button();
            this.btdisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(7, 15);
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(458, 20);
            this.txtmess.TabIndex = 0;
            this.txtmess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlog_KeyPress);
            // 
            // btconnect
            // 
            this.btconnect.Location = new System.Drawing.Point(471, 41);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(75, 23);
            this.btconnect.TabIndex = 1;
            this.btconnect.Text = "Connect";
            this.btconnect.UseVisualStyleBackColor = true;
            this.btconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btsend
            // 
            this.btsend.Location = new System.Drawing.Point(471, 15);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(75, 23);
            this.btsend.TabIndex = 2;
            this.btsend.Text = "Send";
            this.btsend.UseVisualStyleBackColor = true;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // btdisconnect
            // 
            this.btdisconnect.Location = new System.Drawing.Point(471, 70);
            this.btdisconnect.Name = "btdisconnect";
            this.btdisconnect.Size = new System.Drawing.Size(75, 23);
            this.btdisconnect.TabIndex = 3;
            this.btdisconnect.Text = "Disconnect";
            this.btdisconnect.UseVisualStyleBackColor = true;
            this.btdisconnect.Click += new System.EventHandler(this.btdisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 120);
            this.Controls.Add(this.btdisconnect);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.btconnect);
            this.Controls.Add(this.txtmess);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmess;
        private System.Windows.Forms.Button btconnect;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Button btdisconnect;
    }
}


namespace lab3_bai1
{
    partial class Form3
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
            this.btUDP_server = new System.Windows.Forms.Button();
            this.btUDP_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUDP_server
            // 
            this.btUDP_server.Location = new System.Drawing.Point(12, 27);
            this.btUDP_server.Name = "btUDP_server";
            this.btUDP_server.Size = new System.Drawing.Size(75, 23);
            this.btUDP_server.TabIndex = 0;
            this.btUDP_server.Text = "UDP Server";
            this.btUDP_server.UseVisualStyleBackColor = true;
            this.btUDP_server.Click += new System.EventHandler(this.btUDP_server_Click);
            // 
            // btUDP_client
            // 
            this.btUDP_client.Location = new System.Drawing.Point(112, 27);
            this.btUDP_client.Name = "btUDP_client";
            this.btUDP_client.Size = new System.Drawing.Size(75, 23);
            this.btUDP_client.TabIndex = 1;
            this.btUDP_client.Text = "UDP Client";
            this.btUDP_client.UseVisualStyleBackColor = true;
            this.btUDP_client.Click += new System.EventHandler(this.btUDP_client_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 74);
            this.Controls.Add(this.btUDP_client);
            this.Controls.Add(this.btUDP_server);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUDP_server;
        private System.Windows.Forms.Button btUDP_client;
    }
}
namespace lab3_bai2
{
    partial class ServerForm
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
            this.btlisten = new System.Windows.Forms.Button();
            this.lbcommand = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btlisten
            // 
            this.btlisten.Location = new System.Drawing.Point(30, 11);
            this.btlisten.Name = "btlisten";
            this.btlisten.Size = new System.Drawing.Size(75, 23);
            this.btlisten.TabIndex = 0;
            this.btlisten.Text = "Listen";
            this.btlisten.UseVisualStyleBackColor = true;
            this.btlisten.Click += new System.EventHandler(this.btlisten_Click);
            // 
            // lbcommand
            // 
            this.lbcommand.FormattingEnabled = true;
            this.lbcommand.Location = new System.Drawing.Point(30, 53);
            this.lbcommand.Name = "lbcommand";
            this.lbcommand.Size = new System.Drawing.Size(291, 277);
            this.lbcommand.TabIndex = 1;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 338);
            this.Controls.Add(this.lbcommand);
            this.Controls.Add(this.btlisten);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btlisten;
        private System.Windows.Forms.ListBox lbcommand;
    }
}


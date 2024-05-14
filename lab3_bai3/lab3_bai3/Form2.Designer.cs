namespace lab3_bai3
{
    partial class Form2
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
            this.btlisten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(2, 49);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(464, 302);
            this.txtmess.TabIndex = 0;
            // 
            // btlisten
            // 
            this.btlisten.Location = new System.Drawing.Point(2, 20);
            this.btlisten.Name = "btlisten";
            this.btlisten.Size = new System.Drawing.Size(75, 23);
            this.btlisten.TabIndex = 1;
            this.btlisten.Text = "Listen";
            this.btlisten.UseVisualStyleBackColor = true;
            this.btlisten.Click += new System.EventHandler(this.btlisten_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 363);
            this.Controls.Add(this.btlisten);
            this.Controls.Add(this.txtmess);
            this.Name = "Form2";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmess;
        private System.Windows.Forms.Button btlisten;
    }
}
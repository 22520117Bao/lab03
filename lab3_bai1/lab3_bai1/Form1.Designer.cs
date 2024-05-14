namespace lab3_bai1
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
            this.txtport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btlisten = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(97, 20);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(200, 20);
            this.txtport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // btlisten
            // 
            this.btlisten.Location = new System.Drawing.Point(345, 18);
            this.btlisten.Name = "btlisten";
            this.btlisten.Size = new System.Drawing.Size(75, 23);
            this.btlisten.TabIndex = 2;
            this.btlisten.Text = "Listen";
            this.btlisten.UseVisualStyleBackColor = true;
            this.btlisten.Click += new System.EventHandler(this.btlisten_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received messages";
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(14, 69);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(546, 240);
            this.txtmess.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 330);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btlisten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtport);
            this.Name = "Form1";
            this.Text = "UDP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlisten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmess;
    }
}


namespace lab3_bai1
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
            this.btsend = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btsend
            // 
            this.btsend.Location = new System.Drawing.Point(484, 111);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(75, 23);
            this.btsend.TabIndex = 13;
            this.btsend.Text = "Send";
            this.btsend.UseVisualStyleBackColor = true;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(12, 111);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(462, 20);
            this.txtmessage.TabIndex = 12;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(403, 54);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(151, 20);
            this.txtport.TabIndex = 11;
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(12, 54);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(251, 20);
            this.txthost.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Remote host";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 138);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "UDP client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
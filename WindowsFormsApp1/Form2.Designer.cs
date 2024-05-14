namespace WindowsFormsApp1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bt3_Read = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbRoom3 = new System.Windows.Forms.CheckBox();
            this.cbRoom2 = new System.Windows.Forms.CheckBox();
            this.cbRoom1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtb1_Show = new System.Windows.Forms.RichTextBox();
            this.bt1_WtF = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(376, 271);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 19);
            this.progressBar1.TabIndex = 87;
            // 
            // bt3_Read
            // 
            this.bt3_Read.Location = new System.Drawing.Point(18, 226);
            this.bt3_Read.Margin = new System.Windows.Forms.Padding(2);
            this.bt3_Read.Name = "bt3_Read";
            this.bt3_Read.Size = new System.Drawing.Size(323, 32);
            this.bt3_Read.TabIndex = 85;
            this.bt3_Read.Text = "Thống kê";
            this.bt3_Read.UseVisualStyleBackColor = true;
            this.bt3_Read.Click += new System.EventHandler(this.bt3_Read_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 84;
            this.label8.Text = "Số lần nhập còn lại";
            // 
            // txtCount
            // 
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(153, 188);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(60, 20);
            this.txtCount.TabIndex = 83;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(244, 183);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 25);
            this.btAdd.TabIndex = 82;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbRoom3
            // 
            this.cbRoom3.AutoSize = true;
            this.cbRoom3.Location = new System.Drawing.Point(287, 115);
            this.cbRoom3.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoom3.Name = "cbRoom3";
            this.cbRoom3.Size = new System.Drawing.Size(39, 17);
            this.cbRoom3.TabIndex = 81;
            this.cbRoom3.Text = "P3";
            this.cbRoom3.UseVisualStyleBackColor = true;
            // 
            // cbRoom2
            // 
            this.cbRoom2.AutoSize = true;
            this.cbRoom2.Location = new System.Drawing.Point(205, 115);
            this.cbRoom2.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoom2.Name = "cbRoom2";
            this.cbRoom2.Size = new System.Drawing.Size(39, 17);
            this.cbRoom2.TabIndex = 80;
            this.cbRoom2.Text = "P2";
            this.cbRoom2.UseVisualStyleBackColor = true;
            // 
            // cbRoom1
            // 
            this.cbRoom1.AutoSize = true;
            this.cbRoom1.Location = new System.Drawing.Point(123, 115);
            this.cbRoom1.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoom1.Name = "cbRoom1";
            this.cbRoom1.Size = new System.Drawing.Size(39, 17);
            this.cbRoom1.TabIndex = 79;
            this.cbRoom1.Text = "P1";
            this.cbRoom1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Số lượng phim";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(140, 51);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(60, 20);
            this.txtTotal.TabIndex = 77;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Giá vé chuẩn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Phòng chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tên phim";
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(123, 147);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(231, 20);
            this.txtCost.TabIndex = 73;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(123, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 72;
            // 
            // rtb1_Show
            // 
            this.rtb1_Show.BackColor = System.Drawing.SystemColors.Menu;
            this.rtb1_Show.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtb1_Show.Location = new System.Drawing.Point(376, 11);
            this.rtb1_Show.Margin = new System.Windows.Forms.Padding(2);
            this.rtb1_Show.Name = "rtb1_Show";
            this.rtb1_Show.ReadOnly = true;
            this.rtb1_Show.Size = new System.Drawing.Size(260, 257);
            this.rtb1_Show.TabIndex = 71;
            this.rtb1_Show.Text = "";
            // 
            // bt1_WtF
            // 
            this.bt1_WtF.Location = new System.Drawing.Point(31, 11);
            this.bt1_WtF.Margin = new System.Windows.Forms.Padding(2);
            this.bt1_WtF.Name = "bt1_WtF";
            this.bt1_WtF.Size = new System.Drawing.Size(277, 24);
            this.bt1_WtF.TabIndex = 70;
            this.bt1_WtF.Text = "Khởi tạo";
            this.bt1_WtF.UseVisualStyleBackColor = true;
            this.bt1_WtF.Click += new System.EventHandler(this.bt1_WtF_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(60, 263);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(235, 23);
            this.btclose.TabIndex = 88;
            this.btclose.Text = "Thoát";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 298);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt3_Read);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbRoom3);
            this.Controls.Add(this.cbRoom2);
            this.Controls.Add(this.cbRoom1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rtb1_Show);
            this.Controls.Add(this.bt1_WtF);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bt3_Read;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.CheckBox cbRoom3;
        private System.Windows.Forms.CheckBox cbRoom2;
        private System.Windows.Forms.CheckBox cbRoom1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtb1_Show;
        private System.Windows.Forms.Button bt1_WtF;
        private System.Windows.Forms.Button btclose;
    }
}
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.bt3_Exit = new System.Windows.Forms.Button();
            this.bt2_Reset = new System.Windows.Forms.Button();
            this.lb4_Title = new System.Windows.Forms.Label();
            this.bt1_Confirm = new System.Windows.Forms.Button();
            this.Lb3_Theater = new System.Windows.Forms.Label();
            this.lb2_Movie = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb1_Name = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.ComboBox();
            this.clb1_Seats = new System.Windows.Forms.CheckedListBox();
            this.txtTheater = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Chọn chỗ ngồi";
            // 
            // bt3_Exit
            // 
            this.bt3_Exit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3_Exit.Location = new System.Drawing.Point(389, 170);
            this.bt3_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt3_Exit.Name = "bt3_Exit";
            this.bt3_Exit.Size = new System.Drawing.Size(161, 26);
            this.bt3_Exit.TabIndex = 56;
            this.bt3_Exit.Text = "Thoát";
            this.bt3_Exit.UseVisualStyleBackColor = true;
            this.bt3_Exit.Click += new System.EventHandler(this.bt3_Exit_Click);
            // 
            // bt2_Reset
            // 
            this.bt2_Reset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_Reset.Location = new System.Drawing.Point(206, 170);
            this.bt2_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.bt2_Reset.Name = "bt2_Reset";
            this.bt2_Reset.Size = new System.Drawing.Size(143, 26);
            this.bt2_Reset.TabIndex = 55;
            this.bt2_Reset.Text = "Xóa";
            this.bt2_Reset.UseVisualStyleBackColor = true;
            this.bt2_Reset.Click += new System.EventHandler(this.bt2_Reset_Click);
            // 
            // lb4_Title
            // 
            this.lb4_Title.AutoSize = true;
            this.lb4_Title.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lb4_Title.Location = new System.Drawing.Point(29, 5);
            this.lb4_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb4_Title.Name = "lb4_Title";
            this.lb4_Title.Size = new System.Drawing.Size(106, 20);
            this.lb4_Title.TabIndex = 54;
            this.lb4_Title.Text = "Thông tin vé";
            // 
            // bt1_Confirm
            // 
            this.bt1_Confirm.Enabled = false;
            this.bt1_Confirm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1_Confirm.Location = new System.Drawing.Point(17, 170);
            this.bt1_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.bt1_Confirm.Name = "bt1_Confirm";
            this.bt1_Confirm.Size = new System.Drawing.Size(148, 26);
            this.bt1_Confirm.TabIndex = 52;
            this.bt1_Confirm.Text = "Xác nhận";
            this.bt1_Confirm.UseVisualStyleBackColor = true;
            this.bt1_Confirm.Click += new System.EventHandler(this.bt1_Confirm_Click);
            // 
            // Lb3_Theater
            // 
            this.Lb3_Theater.AutoSize = true;
            this.Lb3_Theater.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3_Theater.Location = new System.Drawing.Point(21, 121);
            this.Lb3_Theater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb3_Theater.Name = "Lb3_Theater";
            this.Lb3_Theater.Size = new System.Drawing.Size(54, 19);
            this.Lb3_Theater.TabIndex = 51;
            this.Lb3_Theater.Text = "Phòng: ";
            // 
            // lb2_Movie
            // 
            this.lb2_Movie.AutoSize = true;
            this.lb2_Movie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2_Movie.Location = new System.Drawing.Point(21, 75);
            this.lb2_Movie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb2_Movie.Name = "lb2_Movie";
            this.lb2_Movie.Size = new System.Drawing.Size(46, 19);
            this.lb2_Movie.TabIndex = 50;
            this.lb2_Movie.Text = "Phim: ";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(94, 33);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 49;
            // 
            // lb1_Name
            // 
            this.lb1_Name.AutoSize = true;
            this.lb1_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1_Name.Location = new System.Drawing.Point(21, 33);
            this.lb1_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1_Name.Name = "lb1_Name";
            this.lb1_Name.Size = new System.Drawing.Size(57, 19);
            this.lb1_Name.TabIndex = 48;
            this.lb1_Name.Text = "Họ tên: ";
            // 
            // txtMovie
            // 
            this.txtMovie.FormattingEnabled = true;
            this.txtMovie.Location = new System.Drawing.Point(94, 74);
            this.txtMovie.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(179, 21);
            this.txtMovie.TabIndex = 47;
            this.txtMovie.SelectionChangeCommitted += new System.EventHandler(this.cb2_Movie_SelectionChangeCommitted);
            // 
            // clb1_Seats
            // 
            this.clb1_Seats.CheckOnClick = true;
            this.clb1_Seats.FormattingEnabled = true;
            this.clb1_Seats.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clb1_Seats.Location = new System.Drawing.Point(303, 52);
            this.clb1_Seats.Margin = new System.Windows.Forms.Padding(2);
            this.clb1_Seats.MultiColumn = true;
            this.clb1_Seats.Name = "clb1_Seats";
            this.clb1_Seats.ScrollAlwaysVisible = true;
            this.clb1_Seats.Size = new System.Drawing.Size(279, 79);
            this.clb1_Seats.TabIndex = 46;
            this.clb1_Seats.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb1_Seats_ItemCheck);
            // 
            // txtTheater
            // 
            this.txtTheater.Enabled = false;
            this.txtTheater.FormattingEnabled = true;
            this.txtTheater.Location = new System.Drawing.Point(94, 121);
            this.txtTheater.Margin = new System.Windows.Forms.Padding(2);
            this.txtTheater.Name = "txtTheater";
            this.txtTheater.Size = new System.Drawing.Size(179, 21);
            this.txtTheater.TabIndex = 45;
            this.txtTheater.SelectionChangeCommitted += new System.EventHandler(this.cb1_Theater_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 152);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt3_Exit);
            this.Controls.Add(this.bt2_Reset);
            this.Controls.Add(this.lb4_Title);
            this.Controls.Add(this.bt1_Confirm);
            this.Controls.Add(this.Lb3_Theater);
            this.Controls.Add(this.lb2_Movie);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb1_Name);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.clb1_Seats);
            this.Controls.Add(this.txtTheater);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt3_Exit;
        private System.Windows.Forms.Button bt2_Reset;
        private System.Windows.Forms.Label lb4_Title;
        private System.Windows.Forms.Button bt1_Confirm;
        private System.Windows.Forms.Label Lb3_Theater;
        private System.Windows.Forms.Label lb2_Movie;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lb1_Name;
        private System.Windows.Forms.ComboBox txtMovie;
        private System.Windows.Forms.CheckedListBox clb1_Seats;
        private System.Windows.Forms.ComboBox txtTheater;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
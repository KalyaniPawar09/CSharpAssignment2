﻿namespace SgmApp2022
{
    partial class frm_Search_Student_Details
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View_All_Student_List = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.tb_RollNo = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_RollNo = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Search_Student_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Search.Location = new System.Drawing.Point(803, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(158, 48);
            this.btn_Search.TabIndex = 39;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_New_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(12, 589);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(393, 48);
            this.btn_Add_New_Student.TabIndex = 38;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(353, 644);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(232, 48);
            this.btn_Refresh.TabIndex = 37;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_View_All_Student_List
            // 
            this.btn_View_All_Student_List.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_View_All_Student_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_All_Student_List.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Student_List.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_View_All_Student_List.Location = new System.Drawing.Point(526, 589);
            this.btn_View_All_Student_List.Name = "btn_View_All_Student_List";
            this.btn_View_All_Student_List.Size = new System.Drawing.Size(420, 48);
            this.btn_View_All_Student_List.TabIndex = 24;
            this.btn_View_All_Student_List.Text = "View All Student List ";
            this.btn_View_All_Student_List.UseVisualStyleBackColor = false;
            // 
            // cmb_Course
            // 
            this.cmb_Course.AccessibleName = "";
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "Bsc",
            "Bcs",
            "Bca",
            "Msc",
            "Mcs",
            "Mca",
            "Other"});
            this.cmb_Course.Location = new System.Drawing.Point(475, 504);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(291, 39);
            this.cmb_Course.TabIndex = 34;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.AccessibleName = "";
            this.dtp_DOB.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtp_DOB.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtp_DOB.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(475, 341);
            this.dtp_DOB.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(294, 39);
            this.dtp_DOB.TabIndex = 30;
            this.dtp_DOB.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.AccessibleName = "";
            this.tb_MobileNo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(475, 413);
            this.tb_MobileNo.MaxLength = 10;
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(294, 46);
            this.tb_MobileNo.TabIndex = 33;
            // 
            // tb_RollNo
            // 
            this.tb_RollNo.AccessibleName = "";
            this.tb_RollNo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RollNo.Location = new System.Drawing.Point(475, 166);
            this.tb_RollNo.MaxLength = 5;
            this.tb_RollNo.Name = "tb_RollNo";
            this.tb_RollNo.Size = new System.Drawing.Size(291, 46);
            this.tb_RollNo.TabIndex = 26;
            // 
            // tb_Name
            // 
            this.tb_Name.AccessibleName = "";
            this.tb_Name.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(475, 257);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(294, 46);
            this.tb_Name.TabIndex = 29;
            // 
            // btn_Logout
            // 
            this.btn_Logout.AccessibleName = "";
            this.btn_Logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(808, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(171, 47);
            this.btn_Logout.TabIndex = 36;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_Course
            // 
            this.lbl_Course.AccessibleName = "";
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Course.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Course.Location = new System.Drawing.Point(175, 502);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(128, 37);
            this.lbl_Course.TabIndex = 35;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AccessibleName = "";
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_MobileNo.Location = new System.Drawing.Point(135, 422);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(168, 37);
            this.lbl_MobileNo.TabIndex = 32;
            this.lbl_MobileNo.Text = "MobileNo";
            // 
            // lbl_RollNo
            // 
            this.lbl_RollNo.AccessibleName = "";
            this.lbl_RollNo.AutoSize = true;
            this.lbl_RollNo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_RollNo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RollNo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_RollNo.Location = new System.Drawing.Point(184, 175);
            this.lbl_RollNo.Name = "lbl_RollNo";
            this.lbl_RollNo.Size = new System.Drawing.Size(119, 37);
            this.lbl_RollNo.TabIndex = 31;
            this.lbl_RollNo.Text = "RollNo";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AccessibleName = "";
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_DOB.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_DOB.Location = new System.Drawing.Point(197, 341);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(106, 37);
            this.lbl_DOB.TabIndex = 28;
            this.lbl_DOB.Text = "D.O.B";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AccessibleName = "";
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Name.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Name.Location = new System.Drawing.Point(196, 260);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(107, 37);
            this.lbl_Name.TabIndex = 27;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Search_Student_Details
            // 
            this.lbl_Search_Student_Details.AccessibleName = "";
            this.lbl_Search_Student_Details.AutoSize = true;
            this.lbl_Search_Student_Details.BackColor = System.Drawing.Color.DarkOrchid;
            this.lbl_Search_Student_Details.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Student_Details.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Search_Student_Details.Location = new System.Drawing.Point(76, 62);
            this.lbl_Search_Student_Details.Name = "lbl_Search_Student_Details";
            this.lbl_Search_Student_Details.Size = new System.Drawing.Size(801, 68);
            this.lbl_Search_Student_Details.TabIndex = 25;
            this.lbl_Search_Student_Details.Text = "SEARCH STUDENT DETAILS";
            // 
            // frm_Search_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 704);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_View_All_Student_List);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_MobileNo);
            this.Controls.Add(this.tb_RollNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.lbl_RollNo);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Search_Student_Details);
            this.Name = "frm_Search_Student_Details";
            this.Text = "Search_Student_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View_All_Student_List;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.TextBox tb_RollNo;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_RollNo;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Search_Student_Details;
    }
}
﻿namespace PBL3.View.Admin
{
    partial class fManageClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndLesson2 = new System.Windows.Forms.TextBox();
            this.txtStartLesson2 = new System.Windows.Forms.TextBox();
            this.cbbDay2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEndLesson1 = new System.Windows.Forms.TextBox();
            this.txtStartLesson1 = new System.Windows.Forms.TextBox();
            this.cbbDay1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.cbbNameCourse = new System.Windows.Forms.ComboBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtMaxStudent = new System.Windows.Forms.TextBox();
            this.txtNumOfStudent = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStudent);
            this.panel1.Location = new System.Drawing.Point(8, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 581);
            this.panel1.TabIndex = 0;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(0, 2);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStudent.MinimumSize = new System.Drawing.Size(463, 525);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 82;
            this.dgvStudent.RowTemplate.Height = 33;
            this.dgvStudent.Size = new System.Drawing.Size(463, 577);
            this.dgvStudent.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmPayment);
            this.panel2.Controls.Add(this.btnDeleteStudent);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Location = new System.Drawing.Point(10, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 64);
            this.panel2.TabIndex = 1;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(147, 12);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(159, 36);
            this.btnConfirmPayment.TabIndex = 3;
            this.btnConfirmPayment.Text = "Xác nhận nộp tiền";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(325, 12);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(115, 36);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Xóa học viên";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(10, 12);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(115, 36);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Thêm học viên";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtStudentName);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(477, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 64);
            this.panel3.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(127, 20);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(241, 22);
            this.txtStudentName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnUpdateClass);
            this.panel4.Controls.Add(this.cbbNameCourse);
            this.panel4.Controls.Add(this.txtTeacherName);
            this.panel4.Controls.Add(this.txtMaxStudent);
            this.panel4.Controls.Add(this.txtNumOfStudent);
            this.panel4.Controls.Add(this.txtClassName);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(477, 76);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 581);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndLesson2);
            this.groupBox1.Controls.Add(this.txtStartLesson2);
            this.groupBox1.Controls.Add(this.cbbDay2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(27, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(362, 106);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buổi 2";
            // 
            // txtEndLesson2
            // 
            this.txtEndLesson2.Enabled = false;
            this.txtEndLesson2.Location = new System.Drawing.Point(206, 75);
            this.txtEndLesson2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndLesson2.Name = "txtEndLesson2";
            this.txtEndLesson2.Size = new System.Drawing.Size(109, 22);
            this.txtEndLesson2.TabIndex = 15;
            // 
            // txtStartLesson2
            // 
            this.txtStartLesson2.Enabled = false;
            this.txtStartLesson2.Location = new System.Drawing.Point(206, 49);
            this.txtStartLesson2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartLesson2.Name = "txtStartLesson2";
            this.txtStartLesson2.Size = new System.Drawing.Size(109, 22);
            this.txtStartLesson2.TabIndex = 11;
            // 
            // cbbDay2
            // 
            this.cbbDay2.Enabled = false;
            this.cbbDay2.FormattingEnabled = true;
            this.cbbDay2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbDay2.Location = new System.Drawing.Point(159, 20);
            this.cbbDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDay2.Name = "cbbDay2";
            this.cbbDay2.Size = new System.Drawing.Size(156, 24);
            this.cbbDay2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tiết kết thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tiết bắt đầu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Thứ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEndLesson1);
            this.groupBox2.Controls.Add(this.txtStartLesson1);
            this.groupBox2.Controls.Add(this.cbbDay1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(27, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(362, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buổi 1";
            // 
            // txtEndLesson1
            // 
            this.txtEndLesson1.Enabled = false;
            this.txtEndLesson1.Location = new System.Drawing.Point(206, 76);
            this.txtEndLesson1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndLesson1.Name = "txtEndLesson1";
            this.txtEndLesson1.Size = new System.Drawing.Size(109, 22);
            this.txtEndLesson1.TabIndex = 15;
            // 
            // txtStartLesson1
            // 
            this.txtStartLesson1.Enabled = false;
            this.txtStartLesson1.Location = new System.Drawing.Point(206, 44);
            this.txtStartLesson1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartLesson1.Name = "txtStartLesson1";
            this.txtStartLesson1.Size = new System.Drawing.Size(109, 22);
            this.txtStartLesson1.TabIndex = 11;
            // 
            // cbbDay1
            // 
            this.cbbDay1.Enabled = false;
            this.cbbDay1.FormattingEnabled = true;
            this.cbbDay1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbDay1.Location = new System.Drawing.Point(167, 15);
            this.cbbDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDay1.Name = "cbbDay1";
            this.cbbDay1.Size = new System.Drawing.Size(156, 24);
            this.cbbDay1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiết kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiết bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thứ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lịch dạy";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(259, 518);
            this.btnUpdateClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(113, 32);
            this.btnUpdateClass.TabIndex = 4;
            this.btnUpdateClass.Text = "Cập nhật";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // cbbNameCourse
            // 
            this.cbbNameCourse.Enabled = false;
            this.cbbNameCourse.ForeColor = System.Drawing.Color.Black;
            this.cbbNameCourse.FormattingEnabled = true;
            this.cbbNameCourse.Location = new System.Drawing.Point(127, 69);
            this.cbbNameCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNameCourse.Name = "cbbNameCourse";
            this.cbbNameCourse.Size = new System.Drawing.Size(247, 24);
            this.cbbNameCourse.TabIndex = 11;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Enabled = false;
            this.txtTeacherName.Location = new System.Drawing.Point(127, 189);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(247, 22);
            this.txtTeacherName.TabIndex = 9;
            // 
            // txtMaxStudent
            // 
            this.txtMaxStudent.Enabled = false;
            this.txtMaxStudent.Location = new System.Drawing.Point(268, 152);
            this.txtMaxStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxStudent.Name = "txtMaxStudent";
            this.txtMaxStudent.Size = new System.Drawing.Size(106, 22);
            this.txtMaxStudent.TabIndex = 8;
            // 
            // txtNumOfStudent
            // 
            this.txtNumOfStudent.Enabled = false;
            this.txtNumOfStudent.Location = new System.Drawing.Point(268, 110);
            this.txtNumOfStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumOfStudent.Name = "txtNumOfStudent";
            this.txtNumOfStudent.Size = new System.Drawing.Size(106, 22);
            this.txtNumOfStudent.TabIndex = 7;
            // 
            // txtClassName
            // 
            this.txtClassName.Enabled = false;
            this.txtClassName.Location = new System.Drawing.Point(127, 28);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(247, 22);
            this.txtClassName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng học viên tối đa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // fManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 664);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fManageClass";
            this.Text = "QUẢN LÝ LỚP HỌC";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtMaxStudent;
        private System.Windows.Forms.TextBox txtNumOfStudent;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNameCourse;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEndLesson2;
        private System.Windows.Forms.TextBox txtStartLesson2;
        private System.Windows.Forms.ComboBox cbbDay2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEndLesson1;
        private System.Windows.Forms.TextBox txtStartLesson1;
        private System.Windows.Forms.ComboBox cbbDay1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmPayment;
    }
}
namespace PBL3.View.Admin
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
            this.btnConfirmPayment = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 908);
            this.panel1.TabIndex = 0;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(0, 3);
            this.dgvStudent.MinimumSize = new System.Drawing.Size(695, 821);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 82;
            this.dgvStudent.RowTemplate.Height = 33;
            this.dgvStudent.Size = new System.Drawing.Size(695, 902);
            this.dgvStudent.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmPayment);
            this.panel2.Controls.Add(this.btnDeleteStudent);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(488, 19);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(172, 56);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Xóa học viên";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(15, 19);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(172, 56);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Thêm học viên";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtStudentName);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(716, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 100);
            this.panel3.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(190, 32);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(359, 31);
            this.txtStudentName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 42);
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
            this.panel4.Location = new System.Drawing.Point(716, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 908);
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
            this.groupBox1.Location = new System.Drawing.Point(40, 603);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buổi 2";
            // 
            // txtEndLesson2
            // 
            this.txtEndLesson2.Enabled = false;
            this.txtEndLesson2.Location = new System.Drawing.Point(309, 117);
            this.txtEndLesson2.Name = "txtEndLesson2";
            this.txtEndLesson2.Size = new System.Drawing.Size(162, 31);
            this.txtEndLesson2.TabIndex = 15;
            // 
            // txtStartLesson2
            // 
            this.txtStartLesson2.Enabled = false;
            this.txtStartLesson2.Location = new System.Drawing.Point(309, 77);
            this.txtStartLesson2.Name = "txtStartLesson2";
            this.txtStartLesson2.Size = new System.Drawing.Size(162, 31);
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
            this.cbbDay2.Location = new System.Drawing.Point(239, 32);
            this.cbbDay2.Name = "cbbDay2";
            this.cbbDay2.Size = new System.Drawing.Size(232, 33);
            this.cbbDay2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tiết kết thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tiết bắt đầu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(40, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 171);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buổi 1";
            // 
            // txtEndLesson1
            // 
            this.txtEndLesson1.Enabled = false;
            this.txtEndLesson1.Location = new System.Drawing.Point(309, 119);
            this.txtEndLesson1.Name = "txtEndLesson1";
            this.txtEndLesson1.Size = new System.Drawing.Size(162, 31);
            this.txtEndLesson1.TabIndex = 15;
            // 
            // txtStartLesson1
            // 
            this.txtStartLesson1.Enabled = false;
            this.txtStartLesson1.Location = new System.Drawing.Point(309, 69);
            this.txtStartLesson1.Name = "txtStartLesson1";
            this.txtStartLesson1.Size = new System.Drawing.Size(162, 31);
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
            this.cbbDay1.Location = new System.Drawing.Point(250, 24);
            this.cbbDay1.Name = "cbbDay1";
            this.cbbDay1.Size = new System.Drawing.Size(232, 33);
            this.cbbDay1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiết kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiết bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thứ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lịch dạy";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(389, 809);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(170, 50);
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
            this.cbbNameCourse.Location = new System.Drawing.Point(191, 108);
            this.cbbNameCourse.Name = "cbbNameCourse";
            this.cbbNameCourse.Size = new System.Drawing.Size(368, 33);
            this.cbbNameCourse.TabIndex = 11;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Enabled = false;
            this.txtTeacherName.Location = new System.Drawing.Point(191, 296);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(368, 31);
            this.txtTeacherName.TabIndex = 9;
            // 
            // txtMaxStudent
            // 
            this.txtMaxStudent.Enabled = false;
            this.txtMaxStudent.Location = new System.Drawing.Point(402, 238);
            this.txtMaxStudent.Name = "txtMaxStudent";
            this.txtMaxStudent.Size = new System.Drawing.Size(157, 31);
            this.txtMaxStudent.TabIndex = 8;
            // 
            // txtNumOfStudent
            // 
            this.txtNumOfStudent.Enabled = false;
            this.txtNumOfStudent.Location = new System.Drawing.Point(402, 172);
            this.txtNumOfStudent.Name = "txtNumOfStudent";
            this.txtNumOfStudent.Size = new System.Drawing.Size(157, 31);
            this.txtNumOfStudent.TabIndex = 7;
            // 
            // txtClassName
            // 
            this.txtClassName.Enabled = false;
            this.txtClassName.Location = new System.Drawing.Point(191, 43);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(368, 31);
            this.txtClassName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng học viên tối đa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
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
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(221, 19);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(238, 56);
            this.btnConfirmPayment.TabIndex = 3;
            this.btnConfirmPayment.Text = "Xác nhận nộp tiền";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // fManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1326, 1038);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fManageClass";
            this.Text = "Quản lý lớp học";
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
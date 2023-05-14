namespace PBL3.View.Admin
{
    partial class fAddClass
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNameCourse = new System.Windows.Forms.ComboBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtMaxStudent = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndLesson1 = new System.Windows.Forms.TextBox();
            this.txtStartLesson1 = new System.Windows.Forms.TextBox();
            this.cbbDay1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEndLesson2 = new System.Windows.Forms.TextBox();
            this.txtStartLesson2 = new System.Windows.Forms.TextBox();
            this.cbbDay2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnChoiceTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa";
            // 
            // cbbNameCourse
            // 
            this.cbbNameCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNameCourse.FormattingEnabled = true;
            this.cbbNameCourse.Location = new System.Drawing.Point(151, 98);
            this.cbbNameCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNameCourse.Name = "cbbNameCourse";
            this.cbbNameCourse.Size = new System.Drawing.Size(204, 24);
            this.cbbNameCourse.TabIndex = 2;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(151, 42);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(204, 22);
            this.txtClassName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Giảng viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số học sinh tối đa";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Enabled = false;
            this.txtTeacherID.Location = new System.Drawing.Point(223, 161);
            this.txtTeacherID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(131, 22);
            this.txtTeacherID.TabIndex = 7;
            // 
            // txtMaxStudent
            // 
            this.txtMaxStudent.Location = new System.Drawing.Point(223, 247);
            this.txtMaxStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxStudent.Name = "txtMaxStudent";
            this.txtMaxStudent.Size = new System.Drawing.Size(131, 22);
            this.txtMaxStudent.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lịch học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndLesson1);
            this.groupBox1.Controls.Add(this.txtStartLesson1);
            this.groupBox1.Controls.Add(this.cbbDay1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(485, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(433, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buổi 1";
            // 
            // txtEndLesson1
            // 
            this.txtEndLesson1.Location = new System.Drawing.Point(159, 97);
            this.txtEndLesson1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndLesson1.Name = "txtEndLesson1";
            this.txtEndLesson1.Size = new System.Drawing.Size(204, 22);
            this.txtEndLesson1.TabIndex = 15;
            // 
            // txtStartLesson1
            // 
            this.txtStartLesson1.Location = new System.Drawing.Point(159, 62);
            this.txtStartLesson1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartLesson1.Name = "txtStartLesson1";
            this.txtStartLesson1.Size = new System.Drawing.Size(204, 22);
            this.txtStartLesson1.TabIndex = 11;
            // 
            // cbbDay1
            // 
            this.cbbDay1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDay1.FormattingEnabled = true;
            this.cbbDay1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbDay1.Location = new System.Drawing.Point(159, 27);
            this.cbbDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDay1.Name = "cbbDay1";
            this.cbbDay1.Size = new System.Drawing.Size(204, 24);
            this.cbbDay1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiết kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiết bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thứ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEndLesson2);
            this.groupBox2.Controls.Add(this.txtStartLesson2);
            this.groupBox2.Controls.Add(this.cbbDay2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(485, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(433, 132);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buổi 2";
            // 
            // txtEndLesson2
            // 
            this.txtEndLesson2.Location = new System.Drawing.Point(159, 97);
            this.txtEndLesson2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndLesson2.Name = "txtEndLesson2";
            this.txtEndLesson2.Size = new System.Drawing.Size(204, 22);
            this.txtEndLesson2.TabIndex = 15;
            // 
            // txtStartLesson2
            // 
            this.txtStartLesson2.Location = new System.Drawing.Point(159, 62);
            this.txtStartLesson2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartLesson2.Name = "txtStartLesson2";
            this.txtStartLesson2.Size = new System.Drawing.Size(204, 22);
            this.txtStartLesson2.TabIndex = 11;
            // 
            // cbbDay2
            // 
            this.cbbDay2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDay2.FormattingEnabled = true;
            this.cbbDay2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbDay2.Location = new System.Drawing.Point(159, 27);
            this.cbbDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDay2.Name = "cbbDay2";
            this.cbbDay2.Size = new System.Drawing.Size(204, 24);
            this.cbbDay2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tiết kết thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tiết bắt đầu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Thứ ngày";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 379);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 29);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(742, 379);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 29);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnChoiceTeacher
            // 
            this.btnChoiceTeacher.Location = new System.Drawing.Point(223, 191);
            this.btnChoiceTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoiceTeacher.Name = "btnChoiceTeacher";
            this.btnChoiceTeacher.Size = new System.Drawing.Size(130, 34);
            this.btnChoiceTeacher.TabIndex = 19;
            this.btnChoiceTeacher.Text = "Chọn giảng viên";
            this.btnChoiceTeacher.UseVisualStyleBackColor = true;
            this.btnChoiceTeacher.Click += new System.EventHandler(this.btnChoiceTeacher_Click);
            // 
            // fAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 449);
            this.Controls.Add(this.btnChoiceTeacher);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxStudent);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.cbbNameCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fAddClass";
            this.Text = "THÊM LỚP";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNameCourse;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtMaxStudent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEndLesson1;
        private System.Windows.Forms.TextBox txtStartLesson1;
        private System.Windows.Forms.ComboBox cbbDay1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEndLesson2;
        private System.Windows.Forms.TextBox txtStartLesson2;
        private System.Windows.Forms.ComboBox cbbDay2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnChoiceTeacher;
    }
}
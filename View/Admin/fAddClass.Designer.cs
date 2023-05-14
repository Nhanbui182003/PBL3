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
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa";
            // 
            // cbbNameCourse
            // 
            this.cbbNameCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNameCourse.FormattingEnabled = true;
            this.cbbNameCourse.Location = new System.Drawing.Point(226, 153);
            this.cbbNameCourse.Name = "cbbNameCourse";
            this.cbbNameCourse.Size = new System.Drawing.Size(304, 33);
            this.cbbNameCourse.TabIndex = 2;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(226, 66);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(304, 31);
            this.txtClassName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Giảng viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số học sinh tối đa";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Enabled = false;
            this.txtTeacherID.Location = new System.Drawing.Point(335, 251);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(195, 31);
            this.txtTeacherID.TabIndex = 7;
            // 
            // txtMaxStudent
            // 
            this.txtMaxStudent.Location = new System.Drawing.Point(335, 386);
            this.txtMaxStudent.Name = "txtMaxStudent";
            this.txtMaxStudent.Size = new System.Drawing.Size(195, 31);
            this.txtMaxStudent.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(728, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buổi 1";
            // 
            // txtEndLesson1
            // 
            this.txtEndLesson1.Location = new System.Drawing.Point(239, 151);
            this.txtEndLesson1.Name = "txtEndLesson1";
            this.txtEndLesson1.Size = new System.Drawing.Size(304, 31);
            this.txtEndLesson1.TabIndex = 15;
            // 
            // txtStartLesson1
            // 
            this.txtStartLesson1.Location = new System.Drawing.Point(239, 97);
            this.txtStartLesson1.Name = "txtStartLesson1";
            this.txtStartLesson1.Size = new System.Drawing.Size(304, 31);
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
            this.cbbDay1.Location = new System.Drawing.Point(239, 42);
            this.cbbDay1.Name = "cbbDay1";
            this.cbbDay1.Size = new System.Drawing.Size(304, 33);
            this.cbbDay1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiết kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiết bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(728, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 207);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buổi 2";
            // 
            // txtEndLesson2
            // 
            this.txtEndLesson2.Location = new System.Drawing.Point(239, 151);
            this.txtEndLesson2.Name = "txtEndLesson2";
            this.txtEndLesson2.Size = new System.Drawing.Size(304, 31);
            this.txtEndLesson2.TabIndex = 15;
            // 
            // txtStartLesson2
            // 
            this.txtStartLesson2.Location = new System.Drawing.Point(239, 97);
            this.txtStartLesson2.Name = "txtStartLesson2";
            this.txtStartLesson2.Size = new System.Drawing.Size(304, 31);
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
            this.cbbDay2.Location = new System.Drawing.Point(239, 42);
            this.cbbDay2.Name = "cbbDay2";
            this.cbbDay2.Size = new System.Drawing.Size(304, 33);
            this.cbbDay2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tiết kết thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tiết bắt đầu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Thứ ngày";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 45);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1113, 592);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 45);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnChoiceTeacher
            // 
            this.btnChoiceTeacher.Location = new System.Drawing.Point(335, 298);
            this.btnChoiceTeacher.Name = "btnChoiceTeacher";
            this.btnChoiceTeacher.Size = new System.Drawing.Size(195, 53);
            this.btnChoiceTeacher.TabIndex = 19;
            this.btnChoiceTeacher.Text = "Chọn giảng viên";
            this.btnChoiceTeacher.UseVisualStyleBackColor = true;
            this.btnChoiceTeacher.Click += new System.EventHandler(this.btnChoiceTeacher_Click);
            // 
            // fAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 702);
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
            this.Name = "fAddClass";
            this.Text = "fAddClass";
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
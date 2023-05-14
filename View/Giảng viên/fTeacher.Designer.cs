namespace PBL3.View.Giảng_viên
{
    partial class fTeacher
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
            this.Tho = new System.Windows.Forms.TabControl();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.btnSelection = new System.Windows.Forms.Button();
            this.dtgvClassOfTeacher = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxNameClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabInfos = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpkBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxNewPassAgain = new System.Windows.Forms.TextBox();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.tbxOldPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.Tho.SuspendLayout();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassOfTeacher)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabInfos.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tho
            // 
            this.Tho.Controls.Add(this.tabClasses);
            this.Tho.Controls.Add(this.tabInfos);
            this.Tho.Controls.Add(this.tabPage1);
            this.Tho.Controls.Add(this.tabPage2);
            this.Tho.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tho.Location = new System.Drawing.Point(13, 13);
            this.Tho.Name = "Tho";
            this.Tho.SelectedIndex = 0;
            this.Tho.Size = new System.Drawing.Size(1039, 594);
            this.Tho.TabIndex = 0;
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.btnExit);
            this.tabClasses.Controls.Add(this.btnSelection);
            this.tabClasses.Controls.Add(this.dtgvClassOfTeacher);
            this.tabClasses.Controls.Add(this.panel7);
            this.tabClasses.Location = new System.Drawing.Point(4, 25);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(1031, 565);
            this.tabClasses.TabIndex = 0;
            this.tabClasses.Text = "Lớp học của tôi";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(796, 489);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(102, 49);
            this.btnSelection.TabIndex = 1;
            this.btnSelection.Text = "Truy cập";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // dtgvClassOfTeacher
            // 
            this.dtgvClassOfTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassOfTeacher.Location = new System.Drawing.Point(4, 92);
            this.dtgvClassOfTeacher.Name = "dtgvClassOfTeacher";
            this.dtgvClassOfTeacher.RowHeadersWidth = 51;
            this.dtgvClassOfTeacher.RowTemplate.Height = 24;
            this.dtgvClassOfTeacher.Size = new System.Drawing.Size(1021, 391);
            this.dtgvClassOfTeacher.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbxNameClass);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.cbxCourse);
            this.panel7.Controls.Add(this.btnSearch);
            this.panel7.Location = new System.Drawing.Point(4, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1021, 78);
            this.panel7.TabIndex = 0;
            // 
            // tbxNameClass
            // 
            this.tbxNameClass.Location = new System.Drawing.Point(445, 16);
            this.tbxNameClass.Name = "tbxNameClass";
            this.tbxNameClass.Size = new System.Drawing.Size(239, 22);
            this.tbxNameClass.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên lớp học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Khóa học";
            // 
            // cbxCourse
            // 
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(93, 17);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(178, 24);
            this.cbxCourse.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(916, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabInfos
            // 
            this.tabInfos.Controls.Add(this.btnSave);
            this.tabInfos.Controls.Add(this.panel6);
            this.tabInfos.Controls.Add(this.panel5);
            this.tabInfos.Controls.Add(this.panel4);
            this.tabInfos.Controls.Add(this.panel3);
            this.tabInfos.Controls.Add(this.panel2);
            this.tabInfos.Controls.Add(this.panel1);
            this.tabInfos.Location = new System.Drawing.Point(4, 25);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfos.Size = new System.Drawing.Size(1031, 565);
            this.tabInfos.TabIndex = 1;
            this.tabInfos.Text = "Thông tin";
            this.tabInfos.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(901, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 53);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "LƯU THÔNG TIN";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdoFemale);
            this.panel6.Controls.Add(this.rdoMale);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1028, 62);
            this.panel6.TabIndex = 3;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(434, 14);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(46, 20);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(205, 14);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(55, 20);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbxAddress);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1028, 45);
            this.panel5.TabIndex = 3;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(205, 12);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(332, 22);
            this.tbxAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpkBirthday);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 45);
            this.panel4.TabIndex = 2;
            // 
            // dtpkBirthday
            // 
            this.dtpkBirthday.Location = new System.Drawing.Point(208, 11);
            this.dtpkBirthday.Name = "dtpkBirthday";
            this.dtpkBirthday.Size = new System.Drawing.Size(332, 22);
            this.dtpkBirthday.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxEmail);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 45);
            this.panel3.TabIndex = 2;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(205, 12);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(820, 22);
            this.tbxEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 45);
            this.panel2.TabIndex = 2;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(205, 12);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(335, 22);
            this.tbxPhone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 45);
            this.panel1.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(205, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(335, 22);
            this.tbxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 565);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Lịch dạy";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnConfirm);
            this.tabPage2.Controls.Add(this.tbxNewPassAgain);
            this.tabPage2.Controls.Add(this.tbxNewPass);
            this.tabPage2.Controls.Add(this.tbxOldPass);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 565);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Đổi mật khẩu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(195, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mật khẩu cũ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mật khẩu mới";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Xác nhận lại mật khẩu mới";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(749, 426);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 52);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxNewPassAgain
            // 
            this.tbxNewPassAgain.Location = new System.Drawing.Point(510, 267);
            this.tbxNewPassAgain.Name = "tbxNewPassAgain";
            this.tbxNewPassAgain.PasswordChar = '*';
            this.tbxNewPassAgain.Size = new System.Drawing.Size(352, 22);
            this.tbxNewPassAgain.TabIndex = 7;
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Location = new System.Drawing.Point(510, 198);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.PasswordChar = '*';
            this.tbxNewPass.Size = new System.Drawing.Size(352, 22);
            this.tbxNewPass.TabIndex = 6;
            // 
            // tbxOldPass
            // 
            this.tbxOldPass.Location = new System.Drawing.Point(510, 119);
            this.tbxOldPass.Name = "tbxOldPass";
            this.tbxOldPass.PasswordChar = '*';
            this.tbxOldPass.Size = new System.Drawing.Size(352, 22);
            this.tbxOldPass.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(920, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 609);
            this.Controls.Add(this.Tho);
            this.Name = "fTeacher";
            this.Text = "GIẢNG VIÊN";
            this.Load += new System.EventHandler(this.fTeacher_Load);
            this.Tho.ResumeLayout(false);
            this.tabClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassOfTeacher)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabInfos.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tho;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.DataGridView dtgvClassOfTeacher;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tabInfos;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxNameClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DateTimePicker dtpkBirthday;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxNewPassAgain;
        private System.Windows.Forms.TextBox tbxNewPass;
        private System.Windows.Forms.TextBox tbxOldPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
    }
}
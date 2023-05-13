namespace PBL3.View.Giảng_viên
{
    partial class MyClass
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDownLoadFile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxSortDocument = new System.Windows.Forms.ComboBox();
            this.dtgvListDocument = new System.Windows.Forms.DataGridView();
            this.btnSortDocument = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSortStudent = new System.Windows.Forms.Button();
            this.cbxSortStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRate = new System.Windows.Forms.Button();
            this.dtgvListStudentInClass = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxNameStudent = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIdClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameClass = new System.Windows.Forms.TextBox();
            this.tbxMaxStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvListLesson = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDocument)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStudentInClass)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tài liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDownLoadFile
            // 
            this.btnDownLoadFile.Location = new System.Drawing.Point(222, 31);
            this.btnDownLoadFile.Name = "btnDownLoadFile";
            this.btnDownLoadFile.Size = new System.Drawing.Size(99, 42);
            this.btnDownLoadFile.TabIndex = 3;
            this.btnDownLoadFile.Text = "Tải tài liệu";
            this.btnDownLoadFile.UseVisualStyleBackColor = true;
            this.btnDownLoadFile.Click += new System.EventHandler(this.btnDownLoadFile_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa tài liệu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(24, 32);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(134, 42);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Thêm tài liệu";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnDownLoadFile);
            this.panel3.Controls.Add(this.cbxSortDocument);
            this.panel3.Controls.Add(this.dtgvListDocument);
            this.panel3.Controls.Add(this.btnAddFile);
            this.panel3.Controls.Add(this.btnSortDocument);
            this.panel3.Location = new System.Drawing.Point(7, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 551);
            this.panel3.TabIndex = 0;
            // 
            // cbxSortDocument
            // 
            this.cbxSortDocument.FormattingEnabled = true;
            this.cbxSortDocument.Items.AddRange(new object[] {
            "Mã tài liệu",
            "Ngày đăng tải"});
            this.cbxSortDocument.Location = new System.Drawing.Point(767, 42);
            this.cbxSortDocument.Name = "cbxSortDocument";
            this.cbxSortDocument.Size = new System.Drawing.Size(200, 24);
            this.cbxSortDocument.TabIndex = 4;
            // 
            // dtgvListDocument
            // 
            this.dtgvListDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListDocument.Location = new System.Drawing.Point(24, 94);
            this.dtgvListDocument.Name = "dtgvListDocument";
            this.dtgvListDocument.RowHeadersWidth = 51;
            this.dtgvListDocument.RowTemplate.Height = 24;
            this.dtgvListDocument.Size = new System.Drawing.Size(943, 443);
            this.dtgvListDocument.TabIndex = 0;
            // 
            // btnSortDocument
            // 
            this.btnSortDocument.Location = new System.Drawing.Point(628, 32);
            this.btnSortDocument.Name = "btnSortDocument";
            this.btnSortDocument.Size = new System.Drawing.Size(100, 41);
            this.btnSortDocument.TabIndex = 3;
            this.btnSortDocument.Text = "Sắp xếp ";
            this.btnSortDocument.UseVisualStyleBackColor = true;
            this.btnSortDocument.Click += new System.EventHandler(this.btnSortDocument_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnRate);
            this.tabPage1.Controls.Add(this.dtgvListStudentInClass);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin học viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSortStudent);
            this.panel5.Controls.Add(this.cbxSortStudent);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(621, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 95);
            this.panel5.TabIndex = 18;
            // 
            // btnSortStudent
            // 
            this.btnSortStudent.Location = new System.Drawing.Point(264, 40);
            this.btnSortStudent.Name = "btnSortStudent";
            this.btnSortStudent.Size = new System.Drawing.Size(102, 52);
            this.btnSortStudent.TabIndex = 2;
            this.btnSortStudent.Text = "Sắp xếp";
            this.btnSortStudent.UseVisualStyleBackColor = true;
            this.btnSortStudent.Click += new System.EventHandler(this.btnSortStudent_Click);
            // 
            // cbxSortStudent
            // 
            this.cbxSortStudent.FormattingEnabled = true;
            this.cbxSortStudent.Items.AddRange(new object[] {
            "Mã học viên",
            "Họ và Tên",
            "Điểm trung bình"});
            this.cbxSortStudent.Location = new System.Drawing.Point(41, 52);
            this.cbxSortStudent.Name = "cbxSortStudent";
            this.cbxSortStudent.Size = new System.Drawing.Size(203, 24);
            this.cbxSortStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sắp xếp theo";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(885, 515);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 51);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(763, 515);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(102, 51);
            this.btnRate.TabIndex = 10;
            this.btnRate.Text = "Đánh giá";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // dtgvListStudentInClass
            // 
            this.dtgvListStudentInClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListStudentInClass.Location = new System.Drawing.Point(14, 188);
            this.dtgvListStudentInClass.Name = "dtgvListStudentInClass";
            this.dtgvListStudentInClass.RowHeadersWidth = 51;
            this.dtgvListStudentInClass.RowTemplate.Height = 24;
            this.dtgvListStudentInClass.Size = new System.Drawing.Size(983, 321);
            this.dtgvListStudentInClass.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbxNameStudent);
            this.panel1.Location = new System.Drawing.Point(621, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 72);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 98);
            this.panel4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên học viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(264, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 51);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxNameStudent
            // 
            this.tbxNameStudent.Location = new System.Drawing.Point(41, 28);
            this.tbxNameStudent.Name = "tbxNameStudent";
            this.tbxNameStudent.Size = new System.Drawing.Size(203, 22);
            this.tbxNameStudent.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbxIdClass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxNameClass);
            this.panel2.Controls.Add(this.tbxMaxStudent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 155);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã lớp học";
            // 
            // tbxIdClass
            // 
            this.tbxIdClass.Location = new System.Drawing.Point(151, 9);
            this.tbxIdClass.Name = "tbxIdClass";
            this.tbxIdClass.Size = new System.Drawing.Size(194, 22);
            this.tbxIdClass.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp học ";
            // 
            // tbxNameClass
            // 
            this.tbxNameClass.Location = new System.Drawing.Point(151, 50);
            this.tbxNameClass.Name = "tbxNameClass";
            this.tbxNameClass.Size = new System.Drawing.Size(194, 22);
            this.tbxNameClass.TabIndex = 4;
            // 
            // tbxMaxStudent
            // 
            this.tbxMaxStudent.Location = new System.Drawing.Point(151, 105);
            this.tbxMaxStudent.Name = "tbxMaxStudent";
            this.tbxMaxStudent.Size = new System.Drawing.Size(194, 22);
            this.tbxMaxStudent.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng học viên";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgvListLesson);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1010, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lịch dạy cụ thể";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lịch dạy";
            // 
            // dtgvListLesson
            // 
            this.dtgvListLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListLesson.Location = new System.Drawing.Point(45, 83);
            this.dtgvListLesson.Name = "dtgvListLesson";
            this.dtgvListLesson.RowHeadersWidth = 51;
            this.dtgvListLesson.RowTemplate.Height = 24;
            this.dtgvListLesson.Size = new System.Drawing.Size(917, 438);
            this.dtgvListLesson.TabIndex = 1;
            // 
            // MyClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "MyClass";
            this.Text = "Lớp học ";
            this.Load += new System.EventHandler(this.MyClass_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDocument)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStudentInClass)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.DataGridView dtgvListStudentInClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxNameStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIdClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameClass;
        private System.Windows.Forms.TextBox tbxMaxStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDownLoadFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxSortDocument;
        private System.Windows.Forms.DataGridView dtgvListDocument;
        private System.Windows.Forms.Button btnSortDocument;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSortStudent;
        private System.Windows.Forms.ComboBox cbxSortStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtgvListLesson;
        private System.Windows.Forms.Label label6;
    }
}
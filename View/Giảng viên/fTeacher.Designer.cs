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
            this.Tho.SuspendLayout();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassOfTeacher)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tho
            // 
            this.Tho.Controls.Add(this.tabClasses);
            this.Tho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tho.ItemSize = new System.Drawing.Size(215, 30);
            this.Tho.Location = new System.Drawing.Point(13, 13);
            this.Tho.Name = "Tho";
            this.Tho.SelectedIndex = 0;
            this.Tho.Size = new System.Drawing.Size(1039, 594);
            this.Tho.TabIndex = 0;
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.btnSelection);
            this.tabClasses.Controls.Add(this.dtgvClassOfTeacher);
            this.tabClasses.Controls.Add(this.panel7);
            this.tabClasses.Location = new System.Drawing.Point(4, 34);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(1031, 556);
            this.tabClasses.TabIndex = 0;
            this.tabClasses.Text = "Lớp học của tôi";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // btnSelection
            // 
            this.btnSelection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.Location = new System.Drawing.Point(796, 492);
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
            this.dtgvClassOfTeacher.Size = new System.Drawing.Size(1021, 380);
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
            this.tbxNameClass.Location = new System.Drawing.Point(473, 17);
            this.tbxNameClass.Name = "tbxNameClass";
            this.tbxNameClass.Size = new System.Drawing.Size(239, 25);
            this.tbxNameClass.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên lớp học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Khóa học";
            // 
            // cbxCourse
            // 
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(93, 17);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(178, 25);
            this.cbxCourse.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(792, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tho;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.DataGridView dtgvClassOfTeacher;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxNameClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
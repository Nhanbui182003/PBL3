namespace PBL3.View.Học_viên
{
    partial class fClass
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVClass = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDSHV = new System.Windows.Forms.Button();
            this.txtTKB2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTKB1 = new System.Windows.Forms.TextBox();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lịchHọcTrongNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClass)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cáNhânToolStripMenuItem,
            this.lớpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cáNhânToolStripMenuItem
            // 
            this.cáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.họcPhíToolStripMenuItem,
            this.kếtQuảHọcTậpToolStripMenuItem,
            this.lịchHọcTrongNgàyToolStripMenuItem});
            this.cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            this.cáNhânToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.cáNhânToolStripMenuItem.Text = "Cá nhân";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // họcPhíToolStripMenuItem
            // 
            this.họcPhíToolStripMenuItem.Name = "họcPhíToolStripMenuItem";
            this.họcPhíToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.họcPhíToolStripMenuItem.Text = "Học phí";
            this.họcPhíToolStripMenuItem.Click += new System.EventHandler(this.họcPhíToolStripMenuItem_Click);
            // 
            // kếtQuảHọcTậpToolStripMenuItem
            // 
            this.kếtQuảHọcTậpToolStripMenuItem.Name = "kếtQuảHọcTậpToolStripMenuItem";
            this.kếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kếtQuảHọcTậpToolStripMenuItem.Text = "Kết quả học tập";
            this.kếtQuảHọcTậpToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảHọcTậpToolStripMenuItem_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.lớpToolStripMenuItem.Text = "Lớp học";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVClass);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 336);
            this.panel1.TabIndex = 14;
            // 
            // DGVClass
            // 
            this.DGVClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClass.Location = new System.Drawing.Point(0, 3);
            this.DGVClass.Name = "DGVClass";
            this.DGVClass.RowHeadersWidth = 51;
            this.DGVClass.RowTemplate.Height = 24;
            this.DGVClass.Size = new System.Drawing.Size(459, 333);
            this.DGVClass.TabIndex = 0;
            this.DGVClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClass_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "LỚP HỌC CỦA TÔI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTL);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDSHV);
            this.panel2.Controls.Add(this.txtTKB2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTKB1);
            this.panel2.Controls.Add(this.txtGV);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.txtClassName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(491, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 336);
            this.panel2.TabIndex = 15;
            // 
            // btnTL
            // 
            this.btnTL.Location = new System.Drawing.Point(197, 298);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(75, 23);
            this.btnTL.TabIndex = 11;
            this.btnTL.Text = "Tài liệu";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "THÔNG TIN CHI TIẾT";
            // 
            // btnDSHV
            // 
            this.btnDSHV.Location = new System.Drawing.Point(18, 298);
            this.btnDSHV.Name = "btnDSHV";
            this.btnDSHV.Size = new System.Drawing.Size(75, 23);
            this.btnDSHV.TabIndex = 9;
            this.btnDSHV.Text = "DSHV";
            this.btnDSHV.UseVisualStyleBackColor = true;
            this.btnDSHV.Click += new System.EventHandler(this.btnDSHV_Click);
            // 
            // txtTKB2
            // 
            this.txtTKB2.Location = new System.Drawing.Point(109, 263);
            this.txtTKB2.Name = "txtTKB2";
            this.txtTKB2.Size = new System.Drawing.Size(163, 22);
            this.txtTKB2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "TKB";
            // 
            // txtTKB1
            // 
            this.txtTKB1.Location = new System.Drawing.Point(109, 219);
            this.txtTKB1.Name = "txtTKB1";
            this.txtTKB1.Size = new System.Drawing.Size(163, 22);
            this.txtTKB1.TabIndex = 6;
            // 
            // txtGV
            // 
            this.txtGV.Location = new System.Drawing.Point(109, 164);
            this.txtGV.Name = "txtGV";
            this.txtGV.Size = new System.Drawing.Size(163, 22);
            this.txtGV.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(109, 104);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(163, 22);
            this.txtCourseName.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(109, 50);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(163, 22);
            this.txtClassName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thuộc khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // lịchHọcTrongNgàyToolStripMenuItem
            // 
            this.lịchHọcTrongNgàyToolStripMenuItem.Name = "lịchHọcTrongNgàyToolStripMenuItem";
            this.lịchHọcTrongNgàyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lịchHọcTrongNgàyToolStripMenuItem.Text = "Lịch học trong ngày";
            this.lịchHọcTrongNgàyToolStripMenuItem.Click += new System.EventHandler(this.lịchHọcTrongNgàyToolStripMenuItem_Click);
            // 
            // fClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label11);
            this.Name = "fClass";
            this.Text = "LỚP HỌC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClass)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDSHV;
        private System.Windows.Forms.TextBox txtTKB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTKB1;
        private System.Windows.Forms.TextBox txtGV;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.ToolStripMenuItem lịchHọcTrongNgàyToolStripMenuItem;
    }
}
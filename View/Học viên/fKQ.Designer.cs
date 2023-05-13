namespace PBL3.View.Học_viên
{
    partial class fKQ
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVKetQua = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MidTermExamPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalExamPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKetQua)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "KẾT QUẢ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVKetQua);
            this.panel1.Location = new System.Drawing.Point(13, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 298);
            this.panel1.TabIndex = 7;
            // 
            // DGVKetQua
            // 
            this.DGVKetQua.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClassName,
            this.AssignmentPoint,
            this.MidTermExamPoint,
            this.FinalExamPoint});
            this.DGVKetQua.Location = new System.Drawing.Point(3, 0);
            this.DGVKetQua.Name = "DGVKetQua";
            this.DGVKetQua.RowHeadersWidth = 51;
            this.DGVKetQua.RowTemplate.Height = 24;
            this.DGVKetQua.Size = new System.Drawing.Size(773, 282);
            this.DGVKetQua.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 150;
            // 
            // AssignmentPoint
            // 
            this.AssignmentPoint.HeaderText = "AssignmentPoint";
            this.AssignmentPoint.MinimumWidth = 6;
            this.AssignmentPoint.Name = "AssignmentPoint";
            this.AssignmentPoint.Width = 150;
            // 
            // MidTermExamPoint
            // 
            this.MidTermExamPoint.HeaderText = "MidTermExamPoint";
            this.MidTermExamPoint.MinimumWidth = 6;
            this.MidTermExamPoint.Name = "MidTermExamPoint";
            this.MidTermExamPoint.Width = 150;
            // 
            // FinalExamPoint
            // 
            this.FinalExamPoint.HeaderText = "FinalExamPoint";
            this.FinalExamPoint.MinimumWidth = 6;
            this.FinalExamPoint.Name = "FinalExamPoint";
            this.FinalExamPoint.Width = 150;
            // 
            // cáNhânToolStripMenuItem
            // 
            this.cáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.họcPhíToolStripMenuItem,
            this.kếtQuảHọcTậpToolStripMenuItem});
            this.cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            this.cáNhânToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.cáNhânToolStripMenuItem.Text = "Cá nhân";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // họcPhíToolStripMenuItem
            // 
            this.họcPhíToolStripMenuItem.Name = "họcPhíToolStripMenuItem";
            this.họcPhíToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.họcPhíToolStripMenuItem.Text = "Học phí";
            this.họcPhíToolStripMenuItem.Click += new System.EventHandler(this.họcPhíToolStripMenuItem_Click);
            // 
            // kếtQuảHọcTậpToolStripMenuItem
            // 
            this.kếtQuảHọcTậpToolStripMenuItem.Name = "kếtQuảHọcTậpToolStripMenuItem";
            this.kếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.kếtQuảHọcTậpToolStripMenuItem.Text = "Kết quả học tập";
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.lớpToolStripMenuItem.Text = "Lớp học";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
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
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 39);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết kết quả học tập";
            // 
            // fKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fKQ";
            this.Text = "KẾT QUẢ HỌC TẬP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKetQua)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVKetQua;
        private System.Windows.Forms.ToolStripMenuItem cáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn MidTermExamPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalExamPoint;
    }
}
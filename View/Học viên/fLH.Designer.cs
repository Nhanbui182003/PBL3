namespace PBL3.View.Học_viên
{
    partial class fLH
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewLH = new System.Windows.Forms.Button();
            this.dtpkLH = new System.Windows.Forms.DateTimePicker();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchHọcTrongNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVLH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLH)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày học: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewLH);
            this.panel3.Controls.Add(this.dtpkLH);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 48);
            this.panel3.TabIndex = 15;
            // 
            // btnViewLH
            // 
            this.btnViewLH.Location = new System.Drawing.Point(358, 3);
            this.btnViewLH.Name = "btnViewLH";
            this.btnViewLH.Size = new System.Drawing.Size(132, 32);
            this.btnViewLH.TabIndex = 14;
            this.btnViewLH.Text = "Xem lịch học";
            this.btnViewLH.UseVisualStyleBackColor = true;
            this.btnViewLH.Click += new System.EventHandler(this.btnViewLH_Click);
            // 
            // dtpkLH
            // 
            this.dtpkLH.Location = new System.Drawing.Point(119, 13);
            this.dtpkLH.Name = "dtpkLH";
            this.dtpkLH.Size = new System.Drawing.Size(200, 22);
            this.dtpkLH.TabIndex = 13;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 26);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "LỊCH HỌC TRONG NGÀY";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.lớpToolStripMenuItem.Text = "Lớp học";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // lịchHọcTrongNgàyToolStripMenuItem
            // 
            this.lịchHọcTrongNgàyToolStripMenuItem.Name = "lịchHọcTrongNgàyToolStripMenuItem";
            this.lịchHọcTrongNgàyToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.lịchHọcTrongNgàyToolStripMenuItem.Text = "Lịch học trong ngày";
            // 
            // kếtQuảHọcTậpToolStripMenuItem
            // 
            this.kếtQuảHọcTậpToolStripMenuItem.Name = "kếtQuảHọcTậpToolStripMenuItem";
            this.kếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.kếtQuảHọcTậpToolStripMenuItem.Text = "Kết quả học tập";
            this.kếtQuảHọcTậpToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảHọcTậpToolStripMenuItem_Click);
            // 
            // họcPhíToolStripMenuItem
            // 
            this.họcPhíToolStripMenuItem.Name = "họcPhíToolStripMenuItem";
            this.họcPhíToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.họcPhíToolStripMenuItem.Text = "Học phí";
            this.họcPhíToolStripMenuItem.Click += new System.EventHandler(this.họcPhíToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // cáNhânToolStripMenuItem
            // 
            this.cáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.họcPhíToolStripMenuItem,
            this.kếtQuảHọcTậpToolStripMenuItem,
            this.lịchHọcTrongNgàyToolStripMenuItem});
            this.cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            this.cáNhânToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.cáNhânToolStripMenuItem.Text = "Cá nhân";
            // 
            // DGVLH
            // 
            this.DGVLH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLH.Location = new System.Drawing.Point(3, 3);
            this.DGVLH.Name = "DGVLH";
            this.DGVLH.RowHeadersWidth = 51;
            this.DGVLH.RowTemplate.Height = 24;
            this.DGVLH.Size = new System.Drawing.Size(772, 264);
            this.DGVLH.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVLH);
            this.panel1.Location = new System.Drawing.Point(13, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 270);
            this.panel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cáNhânToolStripMenuItem,
            this.lớpToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fLH";
            this.Text = "LỊCH HỌC TRONG NGÀY ";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewLH;
        private System.Windows.Forms.DateTimePicker dtpkLH;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchHọcTrongNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cáNhânToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVLH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
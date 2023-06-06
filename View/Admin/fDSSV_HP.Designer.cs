namespace PBL3.View.Admin
{
    partial class fDSSV_HP
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
            this.LbTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.DGVDSHV_HP = new System.Windows.Forms.DataGridView();
            this.txtSearchDS = new System.Windows.Forms.TextBox();
            this.btnSearchDS = new System.Windows.Forms.Button();
            this.cbbSortDS = new System.Windows.Forms.ComboBox();
            this.btnSortDS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDSHV_HP)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTK
            // 
            this.LbTK.AutoSize = true;
            this.LbTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTK.Location = new System.Drawing.Point(200, 30);
            this.LbTK.Name = "LbTK";
            this.LbTK.Size = new System.Drawing.Size(365, 24);
            this.LbTK.TabIndex = 4;
            this.LbTK.Text = "DANH SÁCH HỌC VIÊN NỘP HỌC PHÍ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khóa học";
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(105, 70);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(134, 22);
            this.txtKH.TabIndex = 6;
            // 
            // DGVDSHV_HP
            // 
            this.DGVDSHV_HP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDSHV_HP.Location = new System.Drawing.Point(30, 114);
            this.DGVDSHV_HP.Name = "DGVDSHV_HP";
            this.DGVDSHV_HP.RowHeadersWidth = 51;
            this.DGVDSHV_HP.RowTemplate.Height = 24;
            this.DGVDSHV_HP.Size = new System.Drawing.Size(737, 258);
            this.DGVDSHV_HP.TabIndex = 7;
            // 
            // txtSearchDS
            // 
            this.txtSearchDS.Location = new System.Drawing.Point(231, 405);
            this.txtSearchDS.Name = "txtSearchDS";
            this.txtSearchDS.Size = new System.Drawing.Size(134, 22);
            this.txtSearchDS.TabIndex = 8;
            // 
            // btnSearchDS
            // 
            this.btnSearchDS.Location = new System.Drawing.Point(30, 395);
            this.btnSearchDS.Name = "btnSearchDS";
            this.btnSearchDS.Size = new System.Drawing.Size(180, 43);
            this.btnSearchDS.TabIndex = 9;
            this.btnSearchDS.Text = "Tìm kiếm theo tên học viên";
            this.btnSearchDS.UseVisualStyleBackColor = true;
            this.btnSearchDS.Click += new System.EventHandler(this.btnSearchDS_Click);
            // 
            // cbbSortDS
            // 
            this.cbbSortDS.FormattingEnabled = true;
            this.cbbSortDS.Items.AddRange(new object[] {
            "Tên học viên",
            "Thời gian"});
            this.cbbSortDS.Location = new System.Drawing.Point(628, 403);
            this.cbbSortDS.Name = "cbbSortDS";
            this.cbbSortDS.Size = new System.Drawing.Size(139, 24);
            this.cbbSortDS.TabIndex = 11;
            // 
            // btnSortDS
            // 
            this.btnSortDS.Location = new System.Drawing.Point(485, 395);
            this.btnSortDS.Name = "btnSortDS";
            this.btnSortDS.Size = new System.Drawing.Size(119, 43);
            this.btnSortDS.TabIndex = 12;
            this.btnSortDS.Text = "Sắp xếp";
            this.btnSortDS.UseVisualStyleBackColor = true;
            this.btnSortDS.Click += new System.EventHandler(this.btnSortDS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(626, 70);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(141, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // fDSSV_HP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSortDS);
            this.Controls.Add(this.cbbSortDS);
            this.Controls.Add(this.btnSearchDS);
            this.Controls.Add(this.txtSearchDS);
            this.Controls.Add(this.DGVDSHV_HP);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbTK);
            this.Name = "fDSSV_HP";
            this.Text = "fDSSV_HP";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDSHV_HP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.DataGridView DGVDSHV_HP;
        private System.Windows.Forms.TextBox txtSearchDS;
        private System.Windows.Forms.Button btnSearchDS;
        private System.Windows.Forms.ComboBox cbbSortDS;
        private System.Windows.Forms.Button btnSortDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
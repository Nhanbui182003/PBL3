namespace PBL3.View.Học_viên
{
    partial class fDSHV
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
            this.DGVDSHV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(294, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "DANH SÁCH HỌC VIÊN ";
            // 
            // DGVDSHV
            // 
            this.DGVDSHV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDSHV.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVDSHV.Location = new System.Drawing.Point(12, 112);
            this.DGVDSHV.Name = "DGVDSHV";
            this.DGVDSHV.RowHeadersWidth = 51;
            this.DGVDSHV.RowTemplate.Height = 24;
            this.DGVDSHV.Size = new System.Drawing.Size(776, 326);
            this.DGVDSHV.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lớp ";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(64, 71);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(167, 22);
            this.txtLop.TabIndex = 12;
            // 
            // fDSHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDSHV);
            this.Controls.Add(this.label11);
            this.Name = "fDSHV";
            this.Text = "DANH SÁCH HỌC VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDSHV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGVDSHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLop;
    }
}
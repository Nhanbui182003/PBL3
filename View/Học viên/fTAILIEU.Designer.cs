namespace PBL3.View.Học_viên
{
    partial class fTAILIEU
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
            this.DGVTL = new System.Windows.Forms.DataGridView();
            this.btnDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTL)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(348, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "TÀI LIỆU ";
            // 
            // DGVTL
            // 
            this.DGVTL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTL.Location = new System.Drawing.Point(12, 87);
            this.DGVTL.Name = "DGVTL";
            this.DGVTL.RowHeadersWidth = 51;
            this.DGVTL.RowTemplate.Height = 24;
            this.DGVTL.Size = new System.Drawing.Size(775, 240);
            this.DGVTL.TabIndex = 10;
            // 
            // btnDL
            // 
            this.btnDL.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDL.Location = new System.Drawing.Point(330, 370);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(159, 36);
            this.btnDL.TabIndex = 11;
            this.btnDL.Text = "DOWNLOAD";
            this.btnDL.UseVisualStyleBackColor = true;
            this.btnDL.Click += new System.EventHandler(this.btnDL_Click);
            // 
            // fTAILIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDL);
            this.Controls.Add(this.DGVTL);
            this.Controls.Add(this.label11);
            this.Name = "fTAILIEU";
            this.Text = "TÀI LIỆU";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGVTL;
        private System.Windows.Forms.Button btnDL;
    }
}
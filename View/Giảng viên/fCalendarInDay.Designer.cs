namespace PBL3.View.Giảng_viên
{
    partial class fCalendarInDay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.dtpkListJob = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvListJob = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListJob)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTomorrow);
            this.panel1.Controls.Add(this.btnYesterday);
            this.panel1.Controls.Add(this.dtpkListJob);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 81);
            this.panel1.TabIndex = 0;
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Location = new System.Drawing.Point(602, 24);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(94, 54);
            this.btnTomorrow.TabIndex = 2;
            this.btnTomorrow.Text = "Ngày mai";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.Location = new System.Drawing.Point(3, 25);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(89, 53);
            this.btnYesterday.TabIndex = 1;
            this.btnYesterday.Text = "Hôm qua";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // dtpkListJob
            // 
            this.dtpkListJob.Location = new System.Drawing.Point(210, 38);
            this.dtpkListJob.Name = "dtpkListJob";
            this.dtpkListJob.Size = new System.Drawing.Size(255, 22);
            this.dtpkListJob.TabIndex = 0;
            this.dtpkListJob.ValueChanged += new System.EventHandler(this.dtpkListJob_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvListJob);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 376);
            this.panel2.TabIndex = 1;
            // 
            // dtgvListJob
            // 
            this.dtgvListJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListJob.Location = new System.Drawing.Point(12, 41);
            this.dtgvListJob.Name = "dtgvListJob";
            this.dtgvListJob.RowHeadersWidth = 51;
            this.dtgvListJob.RowTemplate.Height = 24;
            this.dtgvListJob.Size = new System.Drawing.Size(684, 332);
            this.dtgvListJob.TabIndex = 0;
            // 
            // fCalendarInDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fCalendarInDay";
            this.Text = "LỊCH DẠY TRONG NGÀY";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.DateTimePicker dtpkListJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvListJob;
    }
}
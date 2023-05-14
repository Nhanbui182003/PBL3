using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Học_viên
{
    public partial class fLH : Form
    {
        public int MSHV;
        public fLH(int mshv)
        {
            MSHV = mshv;
            InitializeComponent();
            setDGVLH(MSHV);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HV f = new HV(MSHV);
            f.ShowDialog();
        }

        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHP f = new fHP(MSHV);
            f.ShowDialog();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKQ f = new fKQ(MSHV);
            f.ShowDialog();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fClass f = new fClass(MSHV);
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        public void setDGVLH (int MSHV)
        {
            DGVLH.DataSource = new HVBLL().getCalendarInDayByMSHVBLL(MSHV, dtpkLH.Value.DayOfWeek.ToString());
        }
        private void btnViewLH_Click(object sender, EventArgs e)
        {
            DGVLH.DataSource = new HVBLL().getCalendarInDayByMSHVBLL(MSHV, dtpkLH.Value.DayOfWeek.ToString());
        }
    }
}

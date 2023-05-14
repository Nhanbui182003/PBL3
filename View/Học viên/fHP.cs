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
    public partial class fHP : Form
    {
        public int MSHV;
        public fHP(int mshv)
        {
            MSHV = mshv;
            InitializeComponent();
            setDGVHP(mshv);
        }
        public void setDGVHP(int mshv)
        {
            HVBLL bll = new HVBLL();    
            
            var hv = bll.setInfoBLL(mshv);
            txtHT_hp.Text = hv[0].Name; 
            txtHT_hp.ReadOnly = true;
            txtSDT_hp.Text = hv[0].Phone;
            txtSDT_hp.ReadOnly = true;  

            DGVHP.DataSource = bll.getBillByMSHV(mshv);
            txtTotal.Text = bll.getTotalBillBLL(mshv,0);
            txtTotal.ReadOnly = true;
            txtNO.Text = bll.getTotalBillBLL(mshv, 1);
            txtNO.ReadOnly = true;
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HV f = new HV(MSHV);
            f.ShowDialog();
        }


        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fClass f = new fClass(MSHV);
            f.ShowDialog();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKQ f = new fKQ(MSHV);
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void lịchHọcTrongNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLH f = new fLH(MSHV);
            f.ShowDialog();
        }
    }
}

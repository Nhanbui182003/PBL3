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
    public partial class fHV : Form
    {
        public fHV()
        {
            InitializeComponent();
        }

        private void lịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLH f = new fLH(); 
            f.ShowDialog();
            
        }

        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHV f = new fHV();
            f.ShowDialog();
            
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKQ f = new fKQ();
            f.ShowDialog();
            
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fClass f = new fClass();
            f.ShowDialog();
            
        }
    }
}

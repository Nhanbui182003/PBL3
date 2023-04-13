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
    public partial class fHocvien : Form
    {
        public fHocvien()
        {
            InitializeComponent();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            fDMK f = new fDMK();
            f.ShowDialog(); 
        }
    }
}

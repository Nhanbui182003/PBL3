using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Admin
{
    public partial class fChangePassword : Form
    {
        private int adminId;
        public fChangePassword(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}

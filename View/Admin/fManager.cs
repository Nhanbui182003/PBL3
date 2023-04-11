using PBL3.View.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fAddCourse fadd = new fAddCourse();
            fadd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fAddCourse fupdate = new fAddCourse();
            fupdate.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

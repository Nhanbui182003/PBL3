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
    public partial class fKQ : Form
    {
        public int MSHV;
        public fKQ(int mshv)
        {
            MSHV = mshv;
            InitializeComponent();
            setKQ(mshv);
        }
        public void setKQ(int mshv)
        {
            HVBLL bll =  new HVBLL();
            // ket qua xuat theo mshv 
            var li = bll.getLRByMSHVBLL(mshv);
            foreach (var i in li)
            {
                var cl = bll.getClassByIdBLL(i.ClassId);
                DGVKetQua.Rows.Add(i.ClassId,cl.ClassName,i.AssignmentPoint,i.MidTermExamPoint,i.FinalExamPoint);
            }
            //DGVKetQua.DataSource = li.Select(p => new { p.ClassId, p.Class.ClassName, p.AssignmentPoint, p.MidTermExamPoint, p.FinalExamPoint}).ToList();   
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
    }
}

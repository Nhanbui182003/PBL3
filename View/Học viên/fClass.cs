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
    public partial class fClass : Form
    {
        public int MSHV;
        public fClass(int mshv)
        {
            MSHV = mshv;
            InitializeComponent();
            setDGVClass(mshv);
            DGVClass.Columns[0].HeaderText = "Mã lớp học";
            DGVClass.Columns[1].HeaderText = "Tên lớp học";
            DGVClass.Columns[2].HeaderText = "Học viên tối đa";
            DGVClass.Columns[3].HeaderText = "Ngày bắt đầu";
            DGVClass.Columns[4].HeaderText = "Ngày kết thúc";
            DGVClass.Columns[5].HeaderText = "Tình trạng lớp học";
        }
        public void setDGVClass(int mshv)
        {
            DGVClass.DataSource = new HVBLL().getClassesByMSHVBLL(mshv);    
        }

        private void DGVClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGVClass.CurrentRow.Index;
            int class_Id = Convert.ToInt32(DGVClass.Rows[i].Cells["Id"].Value.ToString());
            var cl = new HVBLL().getClassByIdBLL(class_Id); 
            var course = new HVBLL().getCourseByIdBLL(cl.CourseId);
            List<Calendar> cal = new List<Calendar>();
            cal.AddRange(new HVBLL().getCalendarBLL(cl.Id));
            var gvInfo = new HVBLL().getGVInfoByClassIdBLL(class_Id);   

            txtClassName.Text = cl.ClassName;
            txtCourseName.Text = course.CourseName;
            txtGV.Text = gvInfo.Name;
            txtTKB1.Text = (cal[0].DayLesson + ", period" + cal[0].FromLesson.ToString() + "-" + cal[0].ToLesson.ToString());
            txtTKB2.Text = (cal[1].DayLesson + ", period" + cal[1].FromLesson.ToString() + "-" + cal[1].ToLesson.ToString());
        }
        private void btnDSHV_Click(object sender, EventArgs e)
        {
            int i;
            i = DGVClass.CurrentRow.Index;
            int class_Id = Convert.ToInt32(DGVClass.Rows[i].Cells["Id"].Value.ToString());
            fDSHV f = new fDSHV(class_Id);
            f.ShowDialog();
        }
        private void btnTL_Click(object sender, EventArgs e)
        {
            int i=0;
            i = DGVClass.CurrentRow.Index;
            int class_Id = Convert.ToInt32(DGVClass.Rows[i].Cells["Id"].Value.ToString());
            fTAILIEU f = new fTAILIEU(class_Id);
            f.ShowDialog(); 
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

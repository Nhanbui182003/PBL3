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
        }
        public void setDGVClass(int mshv)
        {
            HVBLL bll = new HVBLL();
            List<Class> li = new List<Class>();
            li = bll.getClassesByMSHVBLL(mshv);
            DGVClass.DataSource = li.Select(p => new { p.Id, p.ClassName, p.MaxStudent }).ToList();
        }

        private void DGVClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGVClass.CurrentRow.Index;
            int class_Id = Convert.ToInt32(DGVClass.Rows[i].Cells["Id"].Value.ToString());
            HVBLL bll = new HVBLL();
            Class cl = new Class(); 
            cl = bll.getClassByIdBLL(class_Id);

            Course course = new Course();
            course = bll.getCourseByIdBLL(cl.CourseId);

            List<Calendar> cal = new List<Calendar>();
            cal.AddRange(bll.getCalendarBLL(cl.Id));

            AccountInfo gvInfo = bll.getGVInfoByClassIdBLL(class_Id);

            txtClassName.Text = cl.ClassName;
            txtCourseName.Text = course.CourseName;
            txtGV.Text = gvInfo.Name;
            txtTKB1.Text = (cal[0].DayLesson + ", tiết" + cal[0].FromLesson.ToString() + "-" + cal[0].ToLesson.ToString());
            txtTKB2.Text = (cal[1].DayLesson + ", tiết" + cal[1].FromLesson.ToString() + "-" + cal[1].ToLesson.ToString());

        }
        private void btnDSHV_Click(object sender, EventArgs e)
        {
            int i;
            i = DGVClass.CurrentRow.Index;
            int class_Id = Convert.ToInt32(DGVClass.Rows[i].Cells["Id"].Value.ToString());
            fDSHV f = new fDSHV(class_Id);
            f.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i;
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

    }
}

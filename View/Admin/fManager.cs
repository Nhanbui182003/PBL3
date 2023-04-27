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
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                dgvCourse.DataSource = db.Courses.Select(p=> new {p.ID,p.Name,p.Start_date,p.End_date,p.Price}).ToList();
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            fAddCourse fadd = new fAddCourse();
            fadd.ShowDialog();
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                dgvCourse.DataSource = db.Courses.Select(p => new {p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
            }
        }

        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvCourse.SelectedRows)
                {
                    using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
                    {
                        int id = Convert.ToInt32(i.Cells["ID"].Value.ToString());
                        var course = db.Courses.Where(p=>p.ID == id).FirstOrDefault(); 
                        db.Courses.Remove(course);
                        db.SaveChanges();
                        dgvCourse.DataSource = db.Courses.Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();

                    }
                }
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dgvCourse.SelectedRows[0].Cells["ID"].Value.ToString());
                fAddCourse f = new fAddCourse(id);
                f.ShowDialog();
                using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
                {
                    dgvCourse.DataSource = db.Courses.Select(p=> new { p.ID, p.Name,p.Start_date,p.End_date,p.Price }).ToList();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p=>p.Name.Contains(txtSearchCourse.Text)).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                if (course!=null)
                {
                    dgvCourse.DataSource = course;
                }
            }
        }

        private void btnSortCourse_Click(object sender, EventArgs e)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                switch (cbSortCourse.SelectedIndex)
                {
                    case 0:
                        dgvCourse.DataSource = db.Courses.OrderBy(p => p.Name).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                        break;
                    case 1:
                        dgvCourse.DataSource = db.Courses.OrderBy(p => p.Start_date).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                        break;
                    case 2:
                        dgvCourse.DataSource = db.Courses.OrderBy(p => p.End_date).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                        break;
                    case 3:
                        dgvCourse.DataSource = db.Courses.OrderBy(p => p.Price).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                        break;
                }
            }
        }
    }
}

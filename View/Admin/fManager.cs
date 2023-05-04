using PBL3.BLL;
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
        public int ID { get; set; }
        public fManager(int id)
        {
            InitializeComponent();
            SetCBB();
            ID = id;
            dgvCourse.DataSource = new ManagerBLL().GetALlCourseBLL().Select(p=> new {p.ID,p.Name,p.Start_date,p.End_date,p.Price}).ToList();
            dgvClass.DataSource = new ManagerBLL().GetAllClassBLL().ToList().Select(p=>new {p.ID,p.Name,p.Course.ID,p.MaxStudent}).ToList();  
        }
        public void SetCBB()
        {
            var listCourse = new ManagerBLL().GetALlCourseBLL();
            cbbListCourse.Items.Add(new CBBItem() { Value = 0,Text="All" }) ;
            foreach (Course i in listCourse)
            {
                cbbListCourse.Items.Add(new CBBItem()
                {
                    Value= i.ID,
                    Text= i.Name,
                });
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            fAddCourse fadd = new fAddCourse();
            fadd.ShowDialog();
            dgvCourse.DataSource = new ManagerBLL().GetALlCourseBLL().Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
        }

        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvCourse.SelectedRows)
                {
                    int id = Convert.ToInt32(i.Cells[0].Value);
                    new ManagerBLL().DeleteCourseBLL(id);
                    dgvCourse.DataSource = new ManagerBLL().GetALlCourseBLL().Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
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
                dgvCourse.DataSource = new ManagerBLL().GetALlCourseBLL().Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCourse.DataSource = new ManagerBLL().GetCourseByNameBLL(txtSearchCourse.Text).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
        }

        private void btnSortCourse_Click(object sender, EventArgs e)
        {
            List<Course> list = new ManagerBLL().GetALlCourseBLL();
            switch (cbSortCourse.SelectedIndex)
            {
                case 0:
                    dgvCourse.DataSource = list.OrderBy(p => p.Name).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                    break;
                case 1:
                    dgvCourse.DataSource = list.OrderBy(p => p.Start_date).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                    break;
                case 2:
                    dgvCourse.DataSource = list.OrderBy(p => p.End_date).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                    break;
                case 3:
                    dgvCourse.DataSource = list.OrderBy(p => p.Price).Select(p => new { p.ID, p.Name, p.Start_date, p.End_date, p.Price }).ToList();
                    break;
            }
        }

        private void cbbListCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseID = ((CBBItem)cbbListCourse.SelectedItem).Value;
            if (courseID == 0)
            {
                dgvClass.DataSource = new ManagerBLL().GetAllClassBLL().ToList();
            }
            else
            {
                dgvClass.DataSource = new ManagerBLL().GetAllClassByCourseIDBLL(courseID).ToList();
            }
        }
    }
}

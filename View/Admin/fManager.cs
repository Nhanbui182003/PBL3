using PBL3.BLL;
using PBL3.DTO;
using PBL3.View.Admin;
using PBL3.View.Giảng_viên;
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
        private int ID;
        private BLL_Account bllAccount;
        public fManager(int id)
        {
            InitializeComponent();
            SetCBB();
            ID = id;
            ManagerBLL bll = new ManagerBLL();
            bllAccount = new BLL_Account();

            bll.LoadDataGridViewCourse(dgvCourse);
            dgvCourse.Columns[0].HeaderText = "Mã khóa học";
            dgvCourse.Columns[1].HeaderText = "Tên khóa học";
            dgvCourse.Columns[2].HeaderText = "Ngày bắt đầu";
            dgvCourse.Columns[3].HeaderText = "Ngày kết thục";
            dgvCourse.Columns[4].HeaderText = "Giá";

            bll.LoadDataGridViewClass(dgvClass);
            dgvClass.Columns[0].HeaderText = "Mã lớp học";
            dgvClass.Columns[1].HeaderText = "Tên lớp học";
            dgvClass.Columns[2].HeaderText = "Tên khóa học";
            dgvClass.Columns[3].HeaderText = "Số học sinh tối đa";
        }
        public void SetCBB()
        {
            var listCourse = new ManagerBLL().GetALlCourseBLL();
            cbbListCourse.Items.Add(new CBBItem() { Value = 0,Text="All" }) ;
            foreach (Course i in listCourse)
            {
                cbbListCourse.Items.Add(new CBBItem()
                {
                    Value= i.Id,
                    Text= i.CourseName,
                });
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            fAddCourse fadd = new fAddCourse();
            fadd.ShowDialog();

            new ManagerBLL().LoadDataGridViewCourse(dgvCourse);
            cbbListCourse.Items.Clear();
            SetCBB();
        }
        void LoadAllRole()
        {
            bllAccount.LoadAllRole(cbxRole);
        }

        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            ManagerBLL bll = new ManagerBLL();

            if (dgvCourse.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvCourse.SelectedRows)
                {
                    int id = Convert.ToInt32(i.Cells[0].Value);
                    bll.DeleteCourseBLL(id);
                }
                MessageBox.Show("Xóa thành công!!!");
            }
            bll.LoadDataGridViewCourse(dgvCourse);

            cbbListCourse.Items.Clear();
            SetCBB();

            bll.LoadDataGridViewClass(dgvClass);
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dgvCourse.SelectedRows[0].Cells[0].Value.ToString());
                fAddCourse f = new fAddCourse(id);
                f.ShowDialog();
                new ManagerBLL().LoadDataGridViewCourse(dgvCourse);
            }

            cbbListCourse.Items.Clear();
            SetCBB();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCourse.DataSource = new ManagerBLL().GetCourseByNameBLL(txtSearchCourse.Text).Select(p => new { p.Id, p.CourseName, p.StartDate, p.EndDate, p.Price }).ToList();
        }

        private void btnSortCourse_Click(object sender, EventArgs e)
        {
            List<Course> list = new ManagerBLL().GetALlCourseBLL();
            switch (cbSortCourse.SelectedIndex)
            {
                case 0:
                    dgvCourse.DataSource = list.OrderBy(p => p.CourseName).Select(p => new { p.Id, p.CourseName, p.StartDate, p.EndDate, p.Price }).ToList();
                    break;
                case 1:
                    dgvCourse.DataSource = list.OrderBy(p => p.StartDate).Select(p => new { p.Id, p.CourseName, p.StartDate, p.EndDate, p.Price }).ToList();
                    break;
                case 2:
                    dgvCourse.DataSource = list.OrderBy(p => p.EndDate).Select(p => new { p.Id, p.CourseName, p.StartDate, p.EndDate, p.Price }).ToList();
                    break;
                case 3:
                    dgvCourse.DataSource = list.OrderBy(p => p.Price).Select(p => new { p.Id, p.CourseName, p.StartDate, p.EndDate, p.Price }).ToList();
                    break;
            }
        }

        private void cbbListCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerBLL bll = new ManagerBLL();
            int courseID = ((CBBItem)cbbListCourse.SelectedItem).Value;
            if (courseID == 0)
            {
                bll.LoadDataGridViewClass(dgvClass);
            }
            else
            {
                dgvClass.DataSource = new ManagerBLL().GetAllClassByCourseIDBLL(courseID).Select(p => new { p.Id, p.ClassName, p.Course.CourseName, p.MaxStudent }).ToList();
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            fAddClass f = new fAddClass();
            f.ShowDialog();
            f.Dispose();
            new ManagerBLL().LoadDataGridViewClass(dgvClass);
        }

        private void btnManageClass_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvClass.SelectedRows[0].Cells[0].Value);
                fManageClass f = new fManageClass(id);
                f.ShowDialog();
                f.Dispose();
            }
            new ManagerBLL().LoadDataGridViewClass(dgvClass);
        }
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            ManagerBLL bll  = new ManagerBLL(); 
            if (dgvClass.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvClass.SelectedRows)
                {
                    int id = Convert.ToInt32(i.Cells[0].Value);
                    bll.DeleteClassByClassIDBLL(id);
                }
                MessageBox.Show("Xóa thành công!");
                bll.LoadDataGridViewClass(dgvClass);
            }
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            dgvClass.DataSource = new ManagerBLL().GetClassByNameBLL(txtSearchClass.Text).Select(p => new { p.Id, p.ClassName, p.Course.CourseName,p.MaxStudent }).ToList();
        }


    }
}

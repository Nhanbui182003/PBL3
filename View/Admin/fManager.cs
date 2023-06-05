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
using System.Xml;

namespace PBL3.View
{
    public partial class fManager : Form
    {
        private int AdminId;
        private BLL_Account bllAccount;
        public fManager(int id)
        {
            InitializeComponent();
            SetCBB();
            txtDT.ReadOnly = true;  
            AdminId = id;
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

            LoadAllAccount();
            LoadAllRole();
            LoadAdminInfo();
        }
        // tải dữ liệu của account
        void LoadAllAccount()
        {
            bllAccount.LoadDataOfAccount(dtgvListAccounts);
        }
        void LoadAllRole()
        {
            bllAccount.LoadAllRole(cbxRole);
        }
        void LoadAdminInfo()
        {
            ManagerBLL bll = new ManagerBLL();
            var admin = bll.GetAccountByID(AdminId);
            txtName.Text = admin.AccountInfo.Name;
            dtDate.Value = admin.AccountInfo.Birthday.Value;
            txtAddress.Text = admin.AccountInfo.Address;
            txtPhone.Text = admin.AccountInfo.Phone;
            //txtEmail.Text = admin.AccountInfo.Email;
            if (admin.AccountInfo.Gender == true) rbtnMale.Checked = true; else rbtnFemale.Checked = true;
            txtUsername.Text = admin.UserName;
            txtPassword.Text = admin.PassWord;
        }
        // 
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

        private void fManager_Load(object sender, EventArgs e)
        {
            LoadAllAccount();
            LoadAllRole();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string Username = tbxDisplayName.Text;
            int idRole = Int32.Parse(cbxRole.SelectedValue.ToString());
            bllAccount.SearchAccount(Username, idRole, dtgvListAccounts);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(0);
            f.LData += F_LData;
            f.Show();
        }

        private void F_LData(object sender, EventArgs e)
        {
            LoadAllAccount();
        }

        private void btnEditInfoAccount_Click(object sender, EventArgs e)
        {
            if (dtgvListAccounts.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgvListAccounts.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                fAccount f = new fAccount(id);
                f.LData += F_LData;
                f.ShowDialog();

            }
            else if (dtgvListAccounts.SelectedRows.Count > 1)
            {
                MessageBox.Show("Để thay đổi thông tin bạn hãy chọn duy nhất 1 học viên ");
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 tài khoản để thay đổi thông tin");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dtgvListAccounts.SelectedRows.Count >= 1)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa các tài khoản này không ???", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    List<int> list = new List<int>();
                    foreach (DataGridViewRow row in dtgvListAccounts.SelectedRows)
                    {
                        int item = Int32.Parse(dtgvListAccounts.SelectedRows[0].Cells["Id"].Value.ToString());
                        list.Add(item);

                    }
                    if (list.Contains(AdminId))
                    {
                        MessageBox.Show("Bạn không thể xóa tài khoản này ");
                    }
                    else
                    {
                        if (bllAccount.DeleteAccount(list))
                        {
                            MessageBox.Show("Xóa tài khoản thành công !!!");

                            LoadAllAccount();

                        }
                        else
                        {
                            MessageBox.Show("Xóa tài khoản thất bại !!! ");
                        }
                    }

                    

                }

            }
            else
            {
                MessageBox.Show("Hãy chọn 1 tài khoản để xóa ");
            }
        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            if (dtgvListAccounts.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có thực sự muốn reset lại mật khẩu của tài khoản này ???", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    int id = Int32.Parse(dtgvListAccounts.SelectedRows[0].Cells["Id"].Value.ToString());
                                           
                    if (bllAccount.ResetAccountPassWords(id))
                    {
                        MessageBox.Show("Reset mật khẩu thành công !!!");

                        LoadAllAccount();

                    }
                    else
                    {
                        MessageBox.Show("Reset mật khẩu thất bại !!! ");
                    }

                }

            } else if(dtgvListAccounts.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ chọn một tài khoản để reset mật khẩu ");
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 tài khoản  ");
            }

        }
        private void setDGVRevenue()
        {
            DGVRevenue.Columns[0].HeaderText = "Số thứ tự";
            DGVRevenue.Columns[1].HeaderText = "Mã khóa học";
            DGVRevenue.Columns[2].HeaderText = "Tên khóa học";
            DGVRevenue.Columns[3].HeaderText = "Số lượng học viên đã nộp";
            DGVRevenue.Columns[4].HeaderText = "Học phí";
            DGVRevenue.Columns[5].HeaderText = "Tổng học phí";
        }
        public void TKDT()
        {
            DataGridViewRowCollection rows = DGVRevenue.Rows;

            int sum = 0;
            foreach (DataGridViewRow row in rows)
            {
                string value = row.Cells["SumPrice"].Value.ToString();
                sum += Convert.ToInt32(value);
            }
            txtDT.Text = sum.ToString();
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            DGVRevenue.DataSource = new ManagerBLL().getRevenueBLL(dateTimePicker1.Value, dateTimePicker2.Value , cbbSort.SelectedIndex + 1 , "");
            TKDT();
            setDGVRevenue();
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            if (cbbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn năm thống kê!");
            }
            else
            {
                Chart ch = new Chart(cbbYear.Text);
                ch.ShowDialog();
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phương thức sắp xếp");
            }
            else if (cbbSort.SelectedIndex == 0)
            {
                DGVRevenue.DataSource = new ManagerBLL().getRevenueBLL(dateTimePicker1.Value, dateTimePicker2.Value, 1,txtTK.Text);
            }
            else if (cbbSort.SelectedIndex == 1)
            {
                DGVRevenue.DataSource = new ManagerBLL().getRevenueBLL(dateTimePicker1.Value, dateTimePicker2.Value, 2, txtTK.Text);
            }
            else if (cbbSort.SelectedIndex == 2)
            {
                DGVRevenue.DataSource = new ManagerBLL().getRevenueBLL(dateTimePicker1.Value, dateTimePicker2.Value, 3, txtTK.Text);
            }
            else if (cbbSort.SelectedIndex == 3)
            {
                DGVRevenue.DataSource = new ManagerBLL().getRevenueBLL(dateTimePicker1.Value, dateTimePicker2.Value, 4, txtTK.Text);
            }
            TKDT();
            setDGVRevenue();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Dispose();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(AdminId);
            f.ShowDialog();
        }

        private void btnSearchTK_Click(object sender, EventArgs e)
        {
            DGVRevenue.DataSource = new ManagerBLL().getRevenueBLL(dateTimePicker1.Value, dateTimePicker2.Value, cbbSort.SelectedIndex + 1, txtTK.Text);
            TKDT();
            setDGVRevenue();
        }

        private void btnDSCT_Click(object sender, EventArgs e)
        {
            if (DGVRevenue.SelectedRows.Count ==1)
            {
                int courseId = Convert.ToInt32(DGVRevenue.SelectedRows[0].Cells[1].Value.ToString());
                string courseName = DGVRevenue.SelectedRows[0].Cells[2].Value.ToString();
                fDSSV_HP f = new fDSSV_HP(courseName, courseId, dateTimePicker1.Value, dateTimePicker2.Value);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường!");
            }
        }
    }
}

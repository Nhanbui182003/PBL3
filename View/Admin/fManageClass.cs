using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Admin
{
    public partial class fManageClass : Form
    {
        private int ClassID;
        public fManageClass(String maLopHoc)
        {
            InitializeComponent();
            
            ClassID = int.Parse(maLopHoc.Substring(1));
            SetCBB();

            ManagerBLL bll = new ManagerBLL();
            bll.LoadDataGridViewStudent(dgvStudent,ClassID);
            dgvStudent.Columns[0].HeaderText = "Mã số học viên";
            dgvStudent.Columns[1].HeaderText = "Tên học viên";
            dgvStudent.Columns[2].HeaderText = "Số điện thoại";
            dgvStudent.Columns[3].HeaderText = "Email";
            dgvStudent.Columns[4].HeaderText = "Giới tính";

            ShowClassInfo();

        }
        public void SetCBB()
        {
            var listCourse = new ManagerBLL().GetALlCourseBLL();
            foreach (Course i in listCourse)
            {
                cbbNameCourse.Items.Add(new CBBItem()
                {
                    Value = i.Id,
                    Text = i.CourseName,
                });
            }
        }

        public void ShowClassInfo()
        {
            ManagerBLL bll = new ManagerBLL();
            Class c = bll.GetClassByClassIDBLL(ClassID);
            txtClassName.Text = c.ClassName;
            cbbNameCourse.SelectedItem = cbbNameCourse.Items.Cast<CBBItem>().FirstOrDefault(p => p.Text == c.Course.CourseName);
            txtNumOfStudent.Text = dgvStudent.RowCount.ToString();
            txtMaxStudent.Text = c.MaxStudent.ToString();
            txtTeacherName.Text = bll.GetTeacherOfClassByClassIDBLL(ClassID).Name.ToString();
            List<Calendar> list = bll.GetListCalendarsByClassIDBLL(ClassID);
            cbbDay1.Text = list[0].DayLesson.ToString();
            txtStartLesson1.Text = list[0].FromLesson.ToString();
            txtEndLesson1.Text = list[0].ToLesson.ToString();
            cbbDay2.Text = list[1].DayLesson.ToString();
            txtStartLesson2.Text = list[1].FromLesson.ToString();
            txtEndLesson2.Text = list[1].ToLesson.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            fAddStudentToClass f = new fAddStudentToClass(ClassID);
            f.ShowDialog();
            new ManagerBLL().LoadDataGridViewStudent(dgvStudent, ClassID);

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            ManagerBLL bll = new ManagerBLL();
            if (dgvStudent.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvStudent.SelectedRows)
                {
                    String MaHocVien = i.Cells[0].Value.ToString();
                    bll.DeleteStudentBLL(MaHocVien, ClassID);
                }
                MessageBox.Show("Xoá thành công!");
            }
            bll.LoadDataGridViewStudent(dgvStudent,ClassID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = new ManagerBLL().GetStudentByNameANDCLassIDBLL(txtStudentName.Text, ClassID).Select(p => new { p.Id, p.AccountInfo.Name, p.AccountInfo.Phone, p.AccountInfo.Email, p.AccountInfo.Gender }).ToList();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            fAddClass frm = new fAddClass(ClassID);
            frm.ShowDialog();
            ShowClassInfo();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            ManagerBLL bll = new ManagerBLL();
            if (dgvStudent.SelectedRows.Count > 0)
            {
                String MaHocVien = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                Bill studentBill = bll.GetBillOfStudentBLL(MaHocVien, ClassID);
                if (studentBill.Status == false)
                {
                    bll.ConfirmPaymentBLL(studentBill);
                    MessageBox.Show("Xác nhận nộp thành công!");
                }
                else
                {
                    MessageBox.Show("Học viên đó đã nộp!");
                }
            }
        }
    }
}

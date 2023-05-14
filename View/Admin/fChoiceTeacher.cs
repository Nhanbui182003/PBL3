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

namespace PBL3.View.Admin
{
    public partial class fChoiceTeacher : Form
    {
        public int teacherId = 0;
        public fChoiceTeacher()
        {
            InitializeComponent();

            ManagerBLL bll = new ManagerBLL();
            bll.LoadDataGridViewTeacherAccounts(dgvTeacher);
            SetDataGridView();
        }

        public fChoiceTeacher(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            ManagerBLL bll = new ManagerBLL();
            bll.LoadDataGridViewTeacherAccounts(dgvTeacher);
            SetDataGridView();

        }

        public void SetDataGridView()
        {
            dgvTeacher.Columns[0].HeaderText = "Mã số giảng viên";
            dgvTeacher.Columns[1].HeaderText = "Tên giảng viên";
            dgvTeacher.Columns[2].HeaderText = "Số điện thoại";
            dgvTeacher.Columns[3].HeaderText = "Email";
            dgvTeacher.Columns[4].HeaderText = "Giới tính";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count>0)
            {
                teacherId = Convert.ToInt32(dgvTeacher.SelectedRows[0].Cells[0].Value);
                DialogResult = DialogResult.OK;
            }
        }
    }
}

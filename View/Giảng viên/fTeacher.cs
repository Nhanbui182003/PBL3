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

namespace PBL3.View.Giảng_viên
{
    public partial class fTeacher : Form
    {
        #region Properties
        private int IdTeacher;
        private BLL_Class BllClass;
        private BLL_Account bllAccount;

        #endregion
        public fTeacher(int idTeacher)
        {
            InitializeComponent();
            BllClass = new BLL_Class();
            bllAccount = new BLL_Account(); 
            IdTeacher = idTeacher;
            
        }

        void DisplayDataOfAllClasses()
        {
            IdTeacher = 2;
            dtgvClassOfTeacher.DataSource = null;
            BllClass.LoadDataClass(dtgvClassOfTeacher, IdTeacher);
            
        }
        void DisPlayAllCourse()
        {
            BllClass.GetAllCourse(cbxCourse);
        }
        void DisplayInfoTeacher()
        {
            AccountInfo info = new AccountInfo();
            info = BllClass.GetInfo(IdTeacher);
            tbxName.Text = info.Name;   
            tbxAddress.Text = info.Address; 
            tbxEmail.Text = info.Email;
            tbxPhone.Text = info.Phone;
            dtpkBirthday.Value = (DateTime)info.Birthday;
            if(info.Gender == true)
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = false;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idCourse = Int32.Parse(cbxCourse.SelectedValue.ToString());
            string nameClass = tbxNameClass.Text;
            IdTeacher = 2;
            BllClass.SearchClass(IdTeacher, idCourse, nameClass, dtgvClassOfTeacher);

        }

        private void fTeacher_Load(object sender, EventArgs e)
        {
            DisplayDataOfAllClasses();
            DisPlayAllCourse();
            DisplayInfoTeacher();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            if(dtgvClassOfTeacher.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgvClassOfTeacher.SelectedRows[0];
                int idClass = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                
                MyClass f = new MyClass(idClass);
                f.Show();
            }
            else if(dtgvClassOfTeacher.SelectedRows.Count > 1)
            {
                MessageBox.Show("Hãy chọn duy nhất 1 lớp học khi truy cập!!!");
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 lớp học để truy cập !!!");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountInfo info = new AccountInfo();
            info.Name = tbxName.Text;
            info.Address = tbxAddress.Text;
            info.Email = tbxEmail.Text;
            info.Phone = tbxPhone.Text;
            info.Birthday = dtpkBirthday.Value;
            if (rdoMale.Checked == true)
            {
                info.Gender = true;
            }
            else
            {
                info.Gender = false;
            }
            if(BllClass.EditInfo(IdTeacher,info))
            {
                MessageBox.Show("Sửa thông tin thành công!!!");
                DisplayInfoTeacher();
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công !!!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            fTeacherCalendar f = new fTeacherCalendar(IdTeacher);
            f.ShowDialog(); 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldPass = tbxOldPass.Text;
            string newPass = tbxNewPass.Text;
            string newPassAgain = tbxNewPassAgain.Text;
            
            if(newPass != newPassAgain)
            {
                MessageBox.Show("Bạn cần xác nhận lại mật khẩu mới!");
            }
            else
            {
                if(bllAccount.SetPassWord(IdTeacher, oldPass, newPass))
                {
                    MessageBox.Show("Bạn đã cập nhật mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn đã cập nhật mật khẩu thất bại!");
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
            
        }
    }
}

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
    public partial class fAccountOfTeacher : Form
    {
        private int IdTeacher;
        private BLL_Class BllClass;
        private BLL_Account bllAccount;
        public fAccountOfTeacher(int id)
        {
            IdTeacher = id;

            InitializeComponent();
            BllClass= new BLL_Class();
            bllAccount= new BLL_Account();  
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

            if (info.Gender == true)
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = false;
            }
            tbxName.Enabled = false;
            tbxAddress.Enabled = false;
            tbxEmail.Enabled = false;
            tbxPhone.Enabled = false;
            dtpkBirthday.Enabled = false;
            rdoFemale.Enabled = false;
            rdoMale.Enabled = false;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            tbxName.Enabled = true;
            tbxAddress.Enabled = true;  
            tbxEmail.Enabled = true;
            tbxPhone.Enabled = true;
            dtpkBirthday.Enabled =true; 
            rdoMale.Enabled = true; 
            rdoFemale.Enabled = true;   
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
            if (BllClass.EditInfo(IdTeacher, info))
            {
                MessageBox.Show("Sửa thông tin thành công!!!");

            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công !!!");

            }
            DisplayInfoTeacher();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldPass = tbxOldPass.Text;
            string newPass = tbxNewPass.Text;
            string newPassAgain = tbxNewPassAgain.Text;

            if (newPass != newPassAgain)
            {
                MessageBox.Show("Bạn cần xác nhận lại mật khẩu mới!");
            }
            else
            {
                if (bllAccount.SetPassWord(IdTeacher, oldPass, newPass))
                {
                    MessageBox.Show("Bạn đã cập nhật mật khẩu thành công!");
                    tbxOldPass.Text = tbxNewPass.Text = tbxNewPassAgain.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn đã cập nhật mật khẩu thất bại!");
                }

            }
            tbxOldPass.Text = "";
            tbxNewPass.Text = "";
            tbxNewPassAgain.Text = "";
        }

        private void fAccountOfTeacher_Load(object sender, EventArgs e)
        {
            DisplayInfoTeacher();
             
        }
    }
}

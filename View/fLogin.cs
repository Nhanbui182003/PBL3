using PBL3.BLL;
using PBL3.View;
using PBL3.View.Giảng_viên;
using PBL3.View.Học_viên;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var account = new ManagerBLL().GetAccountByUsernamePassword(username, password);    
            if (account != null && account.PassWord==password)
            {
                if (account.RoleId == 1)
                {
                    this.Hide();
                    fManager f = new fManager(account.Id);
                    f.ShowDialog();
                } else
                if (account.RoleId == 2)
                {
                    this.Hide();
                    fTeacher f = new fTeacher(account.Id);
                    f.ShowDialog();
                } else
                {
                    this.Hide();
                    var id = account.Id;
                    fHV f = new fHV(id);
                    f.ShowDialog();
                }
                
                
            } else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát chưa trình hay không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

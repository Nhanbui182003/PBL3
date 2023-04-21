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
            DBEnglishCenterEntities db = new DBEnglishCenterEntities();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var account = db.Accounts.Where(p=>p.username== username).FirstOrDefault();
            if (account != null && account.password==password)
            {
                if (account.Role_ID==1)
                {
                    this.Hide();
                    fManager f = new fManager();
                    f.ShowDialog();
                } else
                if (account.Role_ID == 2)
                {
                    this.Hide();
                    fTeacher f = new fTeacher();
                    f.ShowDialog();
                } else
                {
                    this.Hide();
                    fHV f = new fHV();
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

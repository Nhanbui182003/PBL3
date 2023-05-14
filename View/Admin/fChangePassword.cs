using System;
using PBL3.BLL;
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
    public partial class fChangePassword : Form
    {
        private int adminId;
        public fChangePassword(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i = new ManagerBLL().saveMKBLL(txtOldPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text, adminId);
            if (i == 2)
            {
                MessageBox.Show("Mật khẩu nhập chưa chính xác!");
            }
            else if (i == 3)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
            }
            else if (i == 4)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                txtOldPassword.Text = txtNewPassword.Text = txtConfirmPassword.Text = "";
            }
        }
    }
}

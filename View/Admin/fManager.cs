using PBL3.BLL;
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
        private BLL_Account bllAccount;

        public fManager()
        {
            InitializeComponent();
            bllAccount= new BLL_Account();  
        }

        void LoadAllAccount()
        {

            bllAccount.LoadDataOfAccount(dtgvListAccounts);
            dtgvListAccounts.Columns[0].Width = (int)(dtgvListAccounts.Width * 0.06);
            dtgvListAccounts.Columns[1].Width = (int)(dtgvListAccounts.Width * 0.1);
            dtgvListAccounts.Columns[2].Width = (int)(dtgvListAccounts.Width * 0.1);
            dtgvListAccounts.Columns[3].Width = (int)(dtgvListAccounts.Width * 0.2);
            dtgvListAccounts.Columns[4].Width = (int)(dtgvListAccounts.Width * 0.2);
            dtgvListAccounts.Columns[5].Width = (int)(dtgvListAccounts.Width * 0.1);
            dtgvListAccounts.Columns[6].Width = (int)(dtgvListAccounts.Width * 0.1);
           
        }
        void LoadAllRole()
        {
            bllAccount.LoadAllRole(cbxRole);
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            LoadAllAccount();   
            LoadAllRole();  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Username = tbxUsername.Text;
            int idRole = Int32.Parse(cbxRole.SelectedValue.ToString());
            bllAccount.SearchAccount(Username, idRole, dtgvListAccounts);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(0);
            f.LData += F_LData;
            f.Show();
        }

        private void F_LData(object sender, EventArgs e)
        {
            LoadAllAccount();   
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
    }
}

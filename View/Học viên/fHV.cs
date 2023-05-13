using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Học_viên
{
    public partial class HV : Form
    {
        private int mshv;
        public HV(int id)
        {
            mshv = id;
            InitializeComponent();
            setInfo(mshv);
        }
        private void setInfo(int mshv)
        {
            HVBLL bll = new HVBLL();
            List<AccountInfo> list = new List<AccountInfo>();    
            list = bll.setInfoBLL(mshv);
            foreach (AccountInfo i in list)
            {
                txtHT.Text = i.Name;
                txtGT.Text = (i.Gender) ? "Nam" : "Nữ";
                dtpNS.Value = i.Birthday.Value;
                txtEmail.Text = i.Email;
                txtDC.Text = i.Address;
                txtSDT.Text = i.Phone;
            }
        }
        private void btnSaveHV_Click(object sender, EventArgs e)
        {
            HVBLL bll = new HVBLL();
            bll.saveInfoBLL(txtHT.Text, txtGT.Text, txtDC.Text, txtEmail.Text, txtSDT.Text, dtpNS.Value, mshv);
        }

        private void btnSaveMK_Click(object sender, EventArgs e)
        {
            HVBLL bll = new HVBLL();
            int i = bll.saveMKBLL(txtDN.Text, txtMKC.Text, txtMKM.Text, txtCheckMK.Text, mshv);
            if (i== 1)
            {
                MessageBox.Show("Tên đăng nhập chưa chính xác!");
            }
            else if (i == 2)
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
                txtDN.Text = txtMKC.Text = txtMKM.Text = txtCheckMK.Text = "";
            }
        }
        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Hide();
            fHP f =new fHP(mshv);
            f.ShowDialog(); 
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKQ f = new fKQ(mshv);
            f.ShowDialog();
            
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fClass f = new fClass(mshv);
            f.ShowDialog();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog(); 
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HVBLL().docFileBLL();
        }
    }
}

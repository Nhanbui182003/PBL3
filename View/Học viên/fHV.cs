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
    public partial class fHV : Form
    {
        private int mshv;
        public fHV(int id)
        {
            mshv= id;
            InitializeComponent();
            setInfo(mshv);
        }
        private void setInfo(int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var hv = db.Accounts.Where(p=> p.Id == mshv).FirstOrDefault();
                if (hv != null)
                {
                    txtHT.Text = hv.AccountInfo.Name;
                    txtGT.Text = (hv.AccountInfo.Gender == true) ? "Nam" : "Nữ";
                    txtDC.Text = hv.AccountInfo.Address;
                    txtEmail.Text = hv.AccountInfo.Email;
                    txtSDT.Text = hv.AccountInfo.Phone;
                    dtpNS.Value = Convert.ToDateTime(hv.AccountInfo.Birthday);
                }
            }
        }
        private void lịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLH f = new fLH(); 
            f.ShowDialog();
            
        }

        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Hide();
            fHP f =new fHP();
            f.ShowDialog(); 
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKQ f = new fKQ();
            f.ShowDialog();
            
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fClass f = new fClass();
            f.ShowDialog();
        }

        private void btnSaveHV_Click(object sender, EventArgs e)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var hv = db.Accounts.Where(p=>p.Id == mshv).FirstOrDefault(); 
                hv.AccountInfo.Name = txtHT.Text;
                hv.AccountInfo.Gender = (txtGT.Text == "Nam")? true : false;
                hv.AccountInfo.Birthday = dtpNS.Value;
                hv.AccountInfo.Phone = txtSDT.Text;
                hv.AccountInfo.Email = txtEmail.Text;  
                hv.AccountInfo.Address = txtDC.Text;
                db.Accounts.AddOrUpdate(hv);
                db.SaveChanges();   
            }
        }

        private void btnSaveMK_Click(object sender, EventArgs e)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var account = db.Accounts.Where(p => p.Id == mshv).FirstOrDefault();
                bool temp = true;
                if (account.UserName != txtDN.Text)
                {
                    MessageBox.Show("Mật khẩu / Tên đăng nhập không trùng khớp!");
                    temp = false;
                }
                else if (account.PassWord != txtMKC.Text)
                {
                    MessageBox.Show("Mật khẩu / Tên đăng nhập không trùng khớp!");
                    temp = false; 
                }
                else if (txtCheckMK.Text != txtMKM.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
                    temp = false;   
                }
                if (temp)
                {
                    account.PassWord = txtMKM.Text;
                    db.Accounts.AddOrUpdate(account); 
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    txtDN.Text = txtMKM.Text = txtMKC.Text = txtCheckMK.Text = "";
                }

            }
        }
    }
}

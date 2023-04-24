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
                var hv = db.Accounts.Where(p=> p.ID == mshv).FirstOrDefault();
                if (hv != null)
                {
                    txtHT.Text = hv.Account_Info.Name;
                    txtGT.Text = (hv.Account_Info.Gender == true) ? "Nam" : "Nữ";
                    txtDC.Text = hv.Account_Info.Address;
                    txtEmail.Text = hv.Account_Info.Email;
                    txtSDT.Text = hv.Account_Info.Phone;
                    dtpNS.Value = Convert.ToDateTime(hv.Account_Info.Birthday);
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
                var hv = db.Accounts.Where(p=>p.ID == mshv).FirstOrDefault(); 
                hv.Account_Info.Name = txtHT.Text;
                hv.Account_Info.Gender = (txtGT.Text == "Nam")? true : false;
                hv.Account_Info.Birthday = dtpNS.Value;
                hv.Account_Info.Phone = txtSDT.Text;
                hv.Account_Info.Email = txtEmail.Text;  
                hv.Account_Info.Address = txtDC.Text;
                db.Accounts.AddOrUpdate(hv);
                db.SaveChanges();   
            }
        }

        private void btnSaveMK_Click(object sender, EventArgs e)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var account = db.Accounts.Where(p => p.ID == mshv).FirstOrDefault();
                bool temp = true;
                if (account.username != txtDN.Text)
                {
                    MessageBox.Show("Mật khẩu / Tên đăng nhập không trùng khớp!");
                    temp = false;
                }
                else if (account.password != txtMKC.Text)
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
                    account.password = txtMKM.Text;
                    db.Accounts.AddOrUpdate(account); 
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    txtDN.Text = txtMKM.Text = txtMKC.Text = txtCheckMK.Text = "";
                }

            }
        }
    }
}

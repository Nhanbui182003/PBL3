﻿using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Admin
{
    public partial class fAccount : Form
    {
        private int IdAccount;
        private BLL_Account bllAccount;
        private event EventHandler lData;
        public event EventHandler LData
        {
            add { lData += value; }
            remove { lData -= value; }
        }
        public fAccount(int idAccount)
        {
            InitializeComponent();
            bllAccount = new BLL_Account();
            IdAccount = idAccount;  
        }
        void LoadData()
        {
            bllAccount.LoadRole(cbxRoleAccount);
            if(IdAccount == 0)
            {
                tbxId.Enabled = false;
            }
            else
            {
                tbxId.Text = IdAccount.ToString();
                Account a = bllAccount.GetAccount(IdAccount);
                AccountInfo info = bllAccount.GetAccountInfo(IdAccount);
                tbxId.Text = a.Id.ToString();
                tbxUsername.Text = a.UserName;
                
                cbxRoleAccount.SelectedValue = a.RoleId;
                tbxNameAccount.Text = info.Name;
                dtpkBirthday.Value = (DateTime)info.Birthday;
                tbxAddressAccount.Text = info.Address;
                tbxPhoneAccount.Text = info.Phone;
                tbxEmailAccount.Text = info.Email;
                if(info.Gender == true)
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = false;
                }
                tbxId.Enabled = false;
                cbxRoleAccount.Enabled = false;
                tbxUsername.Enabled = false;



            }
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Account a = new Account() { UserName = tbxUsername.Text, PassWord = "123", RoleId = Int32.Parse(cbxRoleAccount.SelectedValue.ToString()) };
            AccountInfo info = new AccountInfo() { Name = tbxNameAccount.Text, Birthday = (DateTime)dtpkBirthday.Value, Email = tbxEmailAccount.Text, Address = tbxAddressAccount.Text, Phone = tbxPhoneAccount.Text, Gender = rdoMale.Checked };
            if (IdAccount == 0)
            {
                if(bllAccount.AddAccount(a, info))
                {
                    MessageBox.Show("Thêm thành công tài khoản");

                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");

                }
            }
            else{
                
                if(bllAccount.EditAccount(IdAccount, info))
                {
                    MessageBox.Show("Cập nhật  thông tin tài khoản thành công");

                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin  tài khoản thất bại");
                }

            }
            if(lData != null)
            {
                lData(this, new EventArgs());
            }
            this.Close ();  
        }
    }
}

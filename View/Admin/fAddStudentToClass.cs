﻿using PBL3.BLL;
using System;
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
    public partial class fAddStudentToClass : Form
    {
        private int ClassID;
        public fAddStudentToClass(int classid)
        {
            ClassID= classid;
            InitializeComponent();

            ManagerBLL bll = new ManagerBLL();
            bll.LoadDataGridViewStudentAccounts(dgvStudentAccount);
            dgvStudentAccount.Columns[0].HeaderText = "Mã số học viên";
            dgvStudentAccount.Columns[1].HeaderText = "Tên học viên";
            dgvStudentAccount.Columns[2].HeaderText = "Số điện thoại";
            dgvStudentAccount.Columns[3].HeaderText = "Email";
            dgvStudentAccount.Columns[4].HeaderText = "Giới tính";

        }
        


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ManagerBLL bll = new ManagerBLL();
            if (dgvStudentAccount.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvStudentAccount.SelectedRows)
                {
                    int AccountId = Convert.ToInt32(i.Cells[0].Value);
                    if (bll.IsExistingStudentBLL(AccountId, ClassID)==false)
                    {
                        bll.AddStudentToClassBLL(AccountId,ClassID);
                    }
                }
                MessageBox.Show("Thêm thành công!");
                Dispose();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
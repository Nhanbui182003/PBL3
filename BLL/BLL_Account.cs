using PBL3.DAL;
using PBL3.View.Giảng_viên;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL3.BLL
{
    public class BLL_Account
    {
        private DAL_Account dalAccount;
        public BLL_Account()
        {
            dalAccount = new DAL_Account(); 
        }
        public void LoadDataOfAccount(DataGridView dg)
        {
            dg.DataSource = dalAccount.GetAllAccount();
            dg.Columns[0].Width = (int)(dg.Width * 0.2);
            dg.Columns[1].Width = (int)(dg.Width * 0.2);
            dg.Columns[2].Width = (int)(dg.Width * 0.2);
            dg.Columns[3].Width = (int)(dg.Width * 0.2);
            dg.Columns[4].Width = (int)(dg.Width * 0.2);
            dg.Columns[5].Width = (int)(dg.Width * 0.1);
            dg.Columns[6].Width = (int)(dg.Width * 0.1);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "Id")
                {
                    column.HeaderText = "Mã học viên";
                }
                else if (column.Name == "UserName")
                {
                    column.HeaderText = "Tên hiển thị";
                }
                else if (column.Name == "RoleName")
                {
                    column.HeaderText = "Loại tài khoản";
                }
                else if (column.Name == "Name")
                {
                    column.HeaderText = "Họ và tên";
                }
                else if (column.Name == "Address")
                {
                    column.HeaderText = "Địa chỉ";
                }
                else if (column.Name == "Gender")
                {
                    column.HeaderText = "Giới tính";
                }
                else if (column.Name == "Birthday")
                {
                    column.HeaderText = "Ngày sinh";
                }

            }
        }
        public void LoadAllRole(ComboBox cb)
        {
            cb.DataSource = dalAccount.GetAllRoleData();
            cb.DisplayMember = "NameRole";
            cb.ValueMember = "Id";
        }
        public void LoadRole(ComboBox cb) {

            cb.DataSource = dalAccount.GetRoleAccount();
            cb.DisplayMember = "NameRole";
            cb.ValueMember = "Id";
        }
        public void SearchAccount(string UserName,int idRole , DataGridView dg)
        {
            dg.DataSource = dalAccount.SearchAccountFromUserNameAndIdRole(UserName, idRole);
        }
        public bool AddAccount(Account a, AccountInfo info)
        {
            try
            {
                dalAccount.AddAccountAndInfo(a, info);
                return true;
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Account GetAccount(int id)
        {
            return dalAccount.GetAccountFromId(id);
        }
        public AccountInfo GetAccountInfo(int id)
        {
            return dalAccount.GetAccountInfoFromId(id);
        }
        public bool EditAccount(int id, AccountInfo info)
        {
            try
            {
                dalAccount.EditAccount(id, info);
                return true;
            }
            catch(DbUpdateException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }catch(Exception e) {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }
        public bool SetPassWord(int IdTeacher,string oldPass,string newPass)
        {
            if(dalAccount.CheckOldPassWord(IdTeacher, oldPass))
            {
                try
                {
                    dalAccount.SetPassWord(IdTeacher, newPass);
                    return true;
                }
                catch(DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu cũ nhập chưa đúng");
                return false;
            }
        }
        public bool DeleteAccount(List<int> list)
        {
            try
            {
                dalAccount.DeleteListAccounts(list);

                return true;
            }catch(DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool ResetAccountPassWords( int id)
        {
            try
            {
                dalAccount.ResetPassWord(id);
                return true;
            }catch(DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}

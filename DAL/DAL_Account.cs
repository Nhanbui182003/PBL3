using PBL3.DTO;
using PBL3.View.Giảng_viên;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL3.DAL
{
    public class DAL_Account
    {
        private DBEnglishCenterEntities db;
        public DAL_Account()
        {
            db = new DBEnglishCenterEntities();
        }
        public dynamic GetAllAccount()
        {
            db = new DBEnglishCenterEntities();
            var dsAccount = db.Accounts.Select(s => new {s.Id, s.UserName, s.Role.RoleName, s.AccountInfo.Name, s.AccountInfo.Address, s.AccountInfo.Gender, s.AccountInfo.Birthday}).ToList();
            return dsAccount;
        }
        public List<CBBRole> GetAllRoleData()
        {
            List<CBBRole> list = new List<CBBRole>();
            list.Add(new CBBRole() { Id = 0, NameRole = "All" });
            List<Role> listRole = new List<Role>();
            listRole = db.Roles.ToList();   
            foreach(Role item in listRole) {
                list.Add(new CBBRole() { Id = item.IdRole, NameRole = item.RoleName });
            }
            return list;
        }
        public List<CBBRole> GetRoleAccount()
        {
            List<CBBRole> list = new List<CBBRole>();
            
            List<Role> listRole = new List<Role>();
            listRole = db.Roles.ToList();
            foreach (Role item in listRole)
            {
                list.Add(new CBBRole() { Id = item.IdRole, NameRole = item.RoleName });
            }
            return list;
        }
        public dynamic SearchAccountFromUserNameAndIdRole(string UserName,int idRole)
        {
            List<Account> list = new List<Account>();
            if(idRole == 0)
            {
                list = db.Accounts.Where(s => s.UserName.Contains(UserName)).ToList();
            }
            else
            {
                list = db.Accounts.Where(s => s.UserName.Contains(UserName)  && s.RoleId == idRole ).ToList();   
            }
            var ds = list.Select(s => new { s.Id, s.UserName, s.Role.RoleName, s.AccountInfo.Name, s.AccountInfo.Address, s.AccountInfo.Gender, s.AccountInfo.Birthday }).ToList();
            return ds;
        }
        public void AddAccountAndInfo(Account a,AccountInfo info)
        {
            if (CheckUserName(a.UserName))
            {
                if(info.Name == "" || (info.Gender != true && info.Gender != false))
                {
                    throw new Exception("Chú ý phần tên của tài khoản và phần giới tính không được bỏ sót");
                }
                db.Accounts.Add(a);
                db.SaveChanges();
                int accountId = a.Id;
                AccountInfo ai = new AccountInfo()
                {
                    AccountId = accountId,
                    Name = info.Name,
                    Phone = info.Phone,
                    Email = info.Email,
                    Birthday = info.Birthday,
                    Address = info.Address,
                    Gender = info.Gender,
                };
                db.AccountInfoes.Add(ai);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Tên hiển thị không hợp lệ");
            }
               
        }
        public Account GetAccountFromId(int id)
        {
            return db.Accounts.Where(s => s.Id == id).FirstOrDefault(); 
        }
        public AccountInfo GetAccountInfoFromId(int id)
        {
            return db.AccountInfoes.Where(s => s.AccountId== id).FirstOrDefault();  
        }
        public void EditAccount(int id,AccountInfo info)
        {
            Account ac = db.Accounts.Find(id);
            AccountInfo acif = db.AccountInfoes.Find(id);

            if (info.Name == "" || (info.Gender != true && info.Gender != false))
            {
                throw new Exception("Chú ý phần tên của tài khoản và phần giới tính không được bỏ sót");
            }
            acif.Name = info.Name;
            acif.Phone = info.Phone;    
            acif.Email = info.Email;    
            acif.Birthday = info.Birthday;  
            acif.Address= info.Address; 
            acif.Gender = info.Gender;
            db.SaveChanges();
            
        }
        public bool CheckOldPassWord(int IdTeacher, string oldPass)
        {
            if(oldPass == db.Accounts.Find(IdTeacher).PassWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetPassWord(int IdTeacher,string newPass)
        {
            Account ac = db.Accounts.Find(IdTeacher);
            ac.PassWord = newPass;
            db.SaveChanges();

        }
        public bool CheckUserName(string username)
        {
            if(username != "")
            {
                List<Account> list = db.Accounts.ToList();

                foreach (Account account in list)
                {
                    if(username == account.UserName)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }


    }
}

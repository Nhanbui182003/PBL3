using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PBL3.DAO
{
    internal class HVDAL
    {
        //Account
        public List<AccountInfo> getInfoByMSHV (int mshv)
        { 
            List<AccountInfo> acc = new List<AccountInfo>();    
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities ())
            {
                var tt = db.AccountInfoes.Where(p=>p.AccountId == mshv).FirstOrDefault(); 
                acc.Add(tt);
            }
            return acc;
        }

        public void saveInfoDAL (string HT, string GT, string DC, string EM, string SDT, DateTime NS ,int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var hv = db.Accounts.Where(p => p.Id == mshv).FirstOrDefault();
                hv.AccountInfo.Name = HT;
                hv.AccountInfo.Gender = (GT == "Nam") ? true : false;
                hv.AccountInfo.Birthday = NS;
                hv.AccountInfo.Phone = SDT;
                hv.AccountInfo.Email = EM;
                hv.AccountInfo.Address = DC;
                db.Accounts.AddOrUpdate(hv);
                db.SaveChanges();
            }
        }
        public Account getAccountBYMSHV (int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var account = db.Accounts.Where(p => p.Id == mshv).FirstOrDefault();
                return account;
            }
        }
        public int saveMKDAL (string UN, string MKC, string MKM, string check, int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                int index = 1; 
                bool temp = true;
                Account acc = this.getAccountBYMSHV(mshv);
                try 
                {
                    if (acc == null)
                    {
                        temp = false;
                        return 1;
                    }
                }
                catch (Exception ex) { }
                try
                {
                    if (UN != acc.UserName)
                    {
                        temp = false;
                        return 1;
                    }
                }
                catch (Exception ex) { }
                try
                {
                    if (acc.PassWord != MKC)
                    {
                        temp = false;
                        return 2;
                    }
                }
                catch (Exception ex) { }
                try
                {
                    if (check != MKM)
                    {
                        temp = false;
                        return 3;
                    }
                }
                catch (Exception ex) { }
                try
                {
                    if (temp)
                    {
                        acc.PassWord = MKM;
                        db.Accounts.AddOrUpdate(acc);
                        db.SaveChanges();
                        return 4;
                    }
                }
                catch(Exception ex) { }    
                return index;
            }
        }
        public List<AccountInfo> getHVInfoByClassIdDAL(int Class_Id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where(p => p.ClassId == Class_Id).ToList();
                List<Account> li = new List<Account>();
                foreach (LearningResult i in lr)
                {
                    var acc = db.Accounts.Where(p => p.Id == i.AccountId).FirstOrDefault();
                    li.Add(acc);
                }

                List<AccountInfo> list = new List<AccountInfo>();
                var hv = li.Where(p => p.RoleId == 3).ToList();
                foreach (var i in hv)
                {
                    var hvInfo = db.AccountInfoes.Where(p => p.AccountId == i.Id).FirstOrDefault();
                    list.Add(hvInfo);
                }
                return list;    
            }
        }
        //class
        public List<Class> getClassesByMSHVDAL(int mshv)
        {
            List<Class> list = new List<Class>();
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where(p => p.AccountId == mshv).ToList();
                foreach (var i in lr)
                {
                    var cl = db.Classes.Where(p => p.Id == i.ClassId).FirstOrDefault();
                    list.Add(cl);
                }
            }
            return list;
        }
        public Class getCLassByIdDAL(int Class_Id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var cl = db.Classes.Where(p => p.Id == Class_Id).FirstOrDefault();
                return cl;
            }
        }
        //Calendar
        public List<Calendar> getCalendarDAL(int Class_Id)
        {
            List<Calendar> list = new List<Calendar>();
            using (var db = new DBEnglishCenterEntities())
            {
                var calendar = db.Calendars.Where(p=>p.ClassId == Class_Id).ToList();
                list.AddRange(calendar);
            }
            return list;
        }


        //course
        public Course getCourseByIdDAL (int Course_id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p=>p.Id==Course_id).FirstOrDefault(); 
                return course;
            } 
        }

        //GV
        public AccountInfo getGVInfoByClassIdDAL (int Class_Id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where(p => p.ClassId == Class_Id).ToList();
                List<Account> li = new List<Account>(); 
                foreach (LearningResult i in lr)
                {
                    var acc = db.Accounts.Where(p=>p.Id == i.AccountId).FirstOrDefault();
                    li.Add(acc);    
                }
                Account gv = li.Where(p=>p.RoleId == 2).FirstOrDefault();    
                AccountInfo gvInfo = db.AccountInfoes.Where(p=> p.AccountId == gv.Id).FirstOrDefault();
                return gvInfo;
            }
        }
        // ket qua
        public List<LearningResult> getLRByMSHVDAL (int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where(p=>p.AccountId == mshv).ToList();
                return lr;
            }
        }

        //hoc phi
        public List<Bill> getBillByMSHVDAL (int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where((p=>p.AccountId == mshv)).ToList();   
                List<Bill> bill = new List<Bill>();
                foreach(var i in lr)
                {
                    var b = db.Bills.Where(p=>p.LearningResultId == i.Id).FirstOrDefault();
                    bill.Add(b);
                }
                return bill;    
            }
        }
        //tai lieu
        public List<Document> getDocumentByClassIdDAL (int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var doc = db.Documents.Where(p=>p.ClassId == classId).ToList(); 
                return doc; 
            }
        }
        public void docFileDAL()
        {
            string path = @"D:\";
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var file = db.Documents.Find(1);
                if (file != null)
                {
                    file.FileData = System.IO.File.ReadAllBytes(Path.GetFullPath(path + file.FileName));
                    MessageBox.Show("File translated successfully!!");
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
        }
        public void downloadFileDAL (int fileId)
        {
            string savePath = @"D:\";

            using (var db = new DBEnglishCenterEntities())
            {
                var file = db.Documents.Find(fileId);
                if (file != null)
                {
                    System.IO.File.WriteAllBytes(savePath + file.FileName, file.FileData);
                    MessageBox.Show("File downloaded successfully!!");
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
        }

    }
}

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
using System.Security.Cryptography;

namespace PBL3.DAL
{
    internal class HVDAL
    {
        //Account
        public List<AccountInfo> getInfoByMSHV(int mshv)
        {
            List<AccountInfo> acc = new List<AccountInfo>();
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var tt = db.AccountInfoes.Where(p => p.AccountId == mshv).FirstOrDefault();
                acc.Add(tt);
            }
            return acc;
        }

        public void saveInfoDAL(string HT, string GT, string DC, string EM, string SDT, DateTime NS, int mshv)
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
        public Account getAccountBYMSHV(int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var account = db.Accounts.Where(p => p.Id == mshv).FirstOrDefault();
                return account;
            }
        }
        public int saveMKDAL(string UN, string MKC, string MKM, string check, int mshv)
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
                string hasPass1 = new ManagerDAL().getMD5DAL(MKC);
                try
                {
                    if (acc.PassWord != hasPass1)
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
                        string hasPass = new ManagerDAL().getMD5DAL(MKM);
                        acc.PassWord = hasPass;
                        db.Accounts.AddOrUpdate(acc);
                        db.SaveChanges();
                        return 4;
                    }
                }
                catch (Exception ex) { }
                return index;
            }
        }
        public dynamic getHVInfoByClassIdDAL(int Class_Id)
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
                var ds = list.Select(p=> new {p.AccountId,p.Name,p.Birthday,p.Gender,p.Phone,p.Email}).ToList();
                return ds;  
            }
        }
        //class
        public dynamic getClassesByMSHVDAL(int mshv)
        {
            List<Class> list = new List<Class>();
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {   
                  
                var lr = db.LearningResults.Where(p => p.AccountId == mshv).ToList();
                foreach (var i in lr)
                {
                    var cl = db.Classes.Where(p => p.Id == i.ClassId ).FirstOrDefault();
                    list.Add(cl);
                }
                var ds = list.Select(p => new { p.Id, p.ClassName, p.MaxStudent,p.Course.StartDate,p.Course.EndDate}).ToList();
                return ds;
            }
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
                var calendar = db.Calendars.Where(p => p.ClassId == Class_Id ).ToList();
                list.AddRange(calendar);
            }
            return list;
        }

        public dynamic getCalendarInDayByMSHVDAL(int mshv, string dayOfWeek)
        {
            List<Class> li = new List<Class>();
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where(p => p.AccountId == mshv).ToList();
                foreach (var i in lr)
                {
                    var cl = db.Classes.Where(p => p.Id == i.ClassId).FirstOrDefault();
                    li.Add(cl);
                }

                List<Calendar> cal = new List<Calendar>();
                foreach(Class i in li)
                {
                    var calendar = db.Calendars.Where(p => p.ClassId == i.Id).ToList();
                    cal.AddRange(calendar);
                }
                var ds = cal.Where(p=>p.DayLesson == dayOfWeek).Select(p=> new {p.ClassId, p.Class.ClassName, p.DayLesson,p.FromLesson,p.ToLesson}).ToList();
                return ds;
            }
        }


        //course
        public Course getCourseByIdDAL(int Course_id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p => p.Id == Course_id ).FirstOrDefault();
                return course;
            }
        }

        //GV
        public AccountInfo getGVInfoByClassIdDAL(int Class_Id)
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
                Account gv = li.Where(p => p.RoleId == 2).FirstOrDefault();
                AccountInfo gvInfo = db.AccountInfoes.Where(p => p.AccountId == gv.Id).FirstOrDefault();
                return gvInfo;
            }
        }
        // ket qua
        public dynamic getLRByMSHVDAL(int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where(p => p.AccountId == mshv).Select(p => new { p.ClassId, p.Class.ClassName, p.AssignmentPoint, p.MidTermExamPoint, p.FinalExamPoint }).ToList();
                return lr;
            }
        }

        //hoc phi
        public dynamic getBillByMSHVDAL(int mshv)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where((p => p.AccountId == mshv)).ToList();
                List<Bill> bill = new List<Bill>();
                foreach (var i in lr)
                {
                    var b = db.Bills.Where(p => p.LearningResultId == i.Id).FirstOrDefault();
                    bill.Add(b);
                }
                var ds = bill.Select(p=>new {p.Id,p.LearningResult.Class.Course.CourseName,p.LearningResult.Class.ClassName,p.Price, p.Status, p.Time}).ToList();
                return ds;
            }
        }
        public string getTotalBillDAL(int mshv, int index )
        {
            int total = 0;
            List<int> li = new List<int>(); 
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var lr = db.LearningResults.Where((p => p.AccountId == mshv)).ToList();
                if (index == 0)
                {
                    foreach (var i in lr)
                    {
                        li.Add(db.Bills.Where(p => p.LearningResultId == i.Id).Select(p => p.Price).FirstOrDefault());
                    }
                    li.ToArray();
                    for (int i = 0; i < li.Count(); i++)
                    {
                        total += li[i];
                    }
                }
                else if (index == 1) 
                {
            
                    foreach (var i in lr)
                    {
                        li.Add(db.Bills.Where(p => p.LearningResultId == i.Id && p.Status == false).Select(p => p.Price).FirstOrDefault());
                    }
                    li.ToArray();
                    for (int i = 0; i < li.Count(); i++)
                    {
                        total += li[i];
                    }
                }
                
            }
            return total.ToString();
        }
        //tai lieu
        public dynamic getDocumentByClassIdDAL(int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var doc = db.Documents.Where(p => p.ClassId == classId).Select(p => new { p.Id, p.FileName, p.Filedate}).ToList();
                return doc;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PBL3.DAL
{
    class ManagerDAL
    {
        public List<Course> GetAllCourseDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Courses.Where(p=>p.CourseActive==true).ToList();
            }
        }
        public Course GetCourseByIDDAL(int id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p => p.Id == id).FirstOrDefault();
                return course;
            }
        }
        public List<Course> GetCourseByNameDAL(string name)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p => p.CourseName.Contains(name)&&p.CourseActive==true);
                return course.ToList();
            }
        }
        public bool isExistingCourseDAL(Course course)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Courses.Any(p => p.CourseName == course.CourseName && p.StartDate.CompareTo(course.StartDate) == 0 && p.EndDate.CompareTo(course.EndDate) == 0 && p.CourseActive==true);
            }
        }
        public void AddCourseDAL(Course course)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                db.Courses.Add(course);
                db.SaveChanges();
            }
        }
        public void DeleteCourseDAL(int id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p => p.Id == id).FirstOrDefault();
                if (course != null)
                {
                    var classes = db.Classes.Where(p => p.CourseId == id);
                    foreach (var c in classes)
                    {
                        var learningResults = db.LearningResults.Where(p => p.ClassId == c.Id);
                        foreach (var learningResult in learningResults)
                        {
                            learningResult.LearningResultActive = false;
                        }
                        //var calendars = db.Calendars.Where(p => p.ClassId == c.Id);
                        //db.Calendars.RemoveRange(calendars);
                        c.ClassActive = false;
                    }
                    //db.Classes.RemoveRange(classes);
                    //db.Courses.Remove(course);
                    course.CourseActive = false;
                    db.SaveChanges();
                }
            }
        }
        public void UpdateCourseDAL(Course newcourse)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var course = db.Courses.Where(p => p.Id == newcourse.Id).FirstOrDefault();
                if (course != null)
                {
                    course.CourseName = newcourse.CourseName;
                    course.Description = newcourse.Description;
                    course.StartDate = newcourse.StartDate;
                    course.EndDate = newcourse.EndDate;
                    course.Price = newcourse.Price;
                    course.CourseActive = true;
                    db.SaveChanges();
                }
            }
        }

        public List<Class> GetAllClassDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p => p.Course).Where(p=>p.ClassActive==true).ToList();
            }
        }
        public List<Class> GetAllClassByCourseIDDAL(int id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p => p.Course).Where(p => p.CourseId == id && p.ClassActive==true).ToList();
            }
        }
        public string getMD5DAL(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte b in hasData)
            {
                hasPass += b;
            }
            return hasPass;
        }
        public Account GetAccountByUsernamePassword(string username, string password)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                string hasPass = this.getMD5DAL(password);
                var account = db.Accounts.Where(p => p.UserName == username && p.PassWord == hasPass && p.AccountActive == true).FirstOrDefault();
                if (account != null)
                {
                    return account;
                }
                else
                    return null;
            }
        }
        public Account GetAccountByID(int id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var account = db.Accounts.Include(p=>p.AccountInfo).Where(p => p.Id == id && p.AccountActive == true).FirstOrDefault();
                if (account != null)
                {
                    return account;
                }
                else
                    return null;
            }
        }
        public bool isExistingClassDAL(Class c)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Any(p => p.ClassName == c.ClassName && p.CourseId == c.CourseId && p.ClassActive==true);
            }
        }
        public void AddClassDAL(Class c)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                db.Classes.Add(c);
                db.SaveChanges();
            }
        }
        public void AddLearningResult(LearningResult learningResult)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                db.LearningResults.Add(learningResult);
                db.SaveChanges();
            }
        }
        public void AddCalendarDAL(Calendar calendar)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                db.Calendars.Add(calendar);
                db.SaveChanges();
            }
        }
        public List<Account> GetAllStudentByClassIdDAL(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                int[] ids = db.LearningResults.Where(p => p.ClassId == classID && p.LearningResultActive==true).Select(p => p.AccountId).ToArray();
                List<Account> students = new List<Account>();
                for (int i = 0; i < ids.Length; i++)
                {
                    int id = ids[i];
                    var account = db.Accounts.Include(p => p.AccountInfo).Where(p => p.Id == id && p.RoleId == 3 && p.AccountActive==true).FirstOrDefault();
                    if (account != null)
                    {
                        students.Add(account);
                    }

                }
                return students;
            }
        }
        public bool isExistingStudentDAL(int accountId, int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var learningResult = db.LearningResults.Where(p => p.AccountId == accountId && p.ClassId == classID && p.LearningResultActive == true).FirstOrDefault();
                if (learningResult == null) return false; else return true;
            }
        }
        public void AddStudentToClassDAL(int accountId, int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var l = db.LearningResults.Where(p=>p.AccountId== accountId&& p.ClassId == classID&&p.LearningResultActive==false).FirstOrDefault();
                if (l==null)
                {
                    LearningResult student = new LearningResult()
                    {
                        AccountId = accountId,
                        ClassId = classID,
                        LearningResultActive = true
                    };
                    db.LearningResults.Add(student);

                    Class c = db.Classes.Include(p => p.Course).Where(p => p.Id == classID && p.ClassActive == true).FirstOrDefault();
                    db.Bills.Add(new Bill()
                    {
                        LearningResultId = student.Id,
                        Price = c.Course.Price,
                        Status = false,
                    });
                }
                else 
                {
                    l.LearningResultActive = true;
                }
                
                db.SaveChanges();
            };
        }
        public void DeleteStudentDAL(int accountId, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var l = db.LearningResults.Where(p => p.AccountId == accountId && p.ClassId == classId).FirstOrDefault();
                l.LearningResultActive = false;
                
                db.SaveChanges();
            }
        }
        public Class GetClassByClassIDDAL(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p => p.Course).Where(p => p.Id == classID && p.ClassActive==true).FirstOrDefault();
            }
        }
        public List<Calendar> GetListCalendarsByClassIDDAL(int ClassID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Calendars.Where(p => p.ClassId == ClassID).ToList();
            }
        }
        public AccountInfo GetTeacherInfoOfClassByClassID(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var l = db.LearningResults.Where(p => p.ClassId == classID && p.LearningResultActive == true);
                foreach (var i in l)
                {
                    var account = db.Accounts.Where(p => p.Id == i.AccountId && p.AccountActive==true).FirstOrDefault();
                    if (account.RoleId == 2)
                    {
                        return db.AccountInfoes.Where(p => p.AccountId == account.Id).FirstOrDefault();
                    }
                }
                return null;
            };
        }
        public void DeleteClassByClassIDDAL(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                //var learningResult = db.LearningResults.Where(p => p.ClassId == classID);
                //db.LearningResults.RemoveRange(learningResult);

                //var calendars = db.Calendars.Where(p => p.ClassId == classID);
                //db.Calendars.RemoveRange(calendars);

                //var c = db.Classes.Where(p => p.Id == classID).FirstOrDefault();
                //db.Classes.Remove(c);

                var l = db.LearningResults.Where(p => p.Id == classID).ToList();
                foreach (var i in l)
                {
                    i.LearningResultActive = false;
                }
                var c = db.Classes.Where(p => p.Id== classID).FirstOrDefault();
                c.ClassActive= false;
                
                db.SaveChanges();
            }
        }
        public List<Class> GetClassByNameDAL(string name)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var cs = db.Classes.Include(p => p.Course).Where(p => p.ClassName.Contains(name) && p.ClassActive==true);
                return cs.ToList();
            }
        }
        public List<Account> GetStudentByNameANDClassIDDAL(string name, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                List<Account> list = GetAllStudentByClassIdDAL(classId);
                var students = list.Where(p => p.AccountInfo.Name.Contains(name) && p.AccountActive==true);
                return students.ToList();
            }
        }
        public LearningResult GetLearningResultOfTeacherByClassIDDAL(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var l = db.LearningResults.Where(p => p.ClassId == classID && p.LearningResultActive==true);
                foreach (var i in l)
                {
                    var account = db.Accounts.Where(p => p.Id == i.AccountId && p.AccountActive == true).FirstOrDefault();
                    if (account.RoleId == 2)
                    {
                        return i;
                    }
                }
                return null;
            }
        }
        public void UpdateClassDAL(Class updatedClass, LearningResult newTeacher, List<Calendar> newCalendars)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                Class oldClass = db.Classes.Where(p => p.Id == updatedClass.Id).FirstOrDefault();
                oldClass.ClassName = updatedClass.ClassName;
                oldClass.CourseId = updatedClass.CourseId;
                oldClass.MaxStudent = updatedClass.MaxStudent;

                List<LearningResult> l = db.LearningResults.Where(p => p.ClassId == updatedClass.Id && p.LearningResultActive==true).ToList();
                LearningResult oldTeacher = new LearningResult();
                foreach (LearningResult i in l)
                {
                    var account = db.Accounts.Where(p => p.Id == i.AccountId && p.AccountActive == true ).FirstOrDefault();
                    if (account.RoleId == 2)
                    {
                        oldTeacher = i;
                    }
                }
                oldTeacher.AccountId = newTeacher.AccountId;


                List<Calendar> oldCalendars = db.Calendars.Where(p => p.ClassId == updatedClass.Id ).ToList();
                oldCalendars[0].DayLesson = newCalendars[0].DayLesson;
                oldCalendars[0].FromLesson = newCalendars[0].FromLesson;
                oldCalendars[0].ToLesson = newCalendars[0].ToLesson;

                oldCalendars[1].DayLesson = newCalendars[1].DayLesson;
                oldCalendars[1].FromLesson = newCalendars[1].FromLesson;
                oldCalendars[1].ToLesson = newCalendars[1].ToLesson;

                db.SaveChanges();
            }
        }
        public List<Account> GetAllStudentAccountDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                List<Account> listStudentAccounts = db.Accounts.Include(p => p.AccountInfo).Where(p => p.RoleId == 3 && p.AccountActive == true ).ToList();
                return listStudentAccounts;
            }
        }
        public List<Account> GetAllTeacherAccountDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                List<Account> listTeacherAccounts = db.Accounts.Include(p => p.AccountInfo).Where(p => p.RoleId == 2 && p.AccountActive == true ).ToList();
                return listTeacherAccounts;
            }
        }
        public LearningResult GetLearningResultOfStudentDAL(int studentId, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.LearningResults.Where(p => p.ClassId == classId && p.AccountId == studentId && p.LearningResultActive==true).FirstOrDefault();
            }
        }
        public Bill GetBillOfStudentDAL(int studentId, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                LearningResult student = GetLearningResultOfStudentDAL(studentId, classId);
                return db.Bills.Where(p => p.LearningResultId == student.Id).FirstOrDefault();
            }
        }
        public void ConfirmPaymentDAL(Bill oldBill)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                Bill updatedBill = db.Bills.Where(p => p.Id == oldBill.Id).FirstOrDefault();
                updatedBill.Status = true;
                updatedBill.Time = DateTime.Now;
                db.SaveChanges();
            }
        }
        public bool isExistingCalendarByAccountIDDAL(int accountId, Calendar CheckedCalendar)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var learningResults = db.LearningResults.Where(p => p.AccountId == accountId && p.LearningResultActive==true);
                foreach (var l in learningResults)
                {
                    var calendars = db.Calendars.Where(p=>p.ClassId== l.ClassId);
                    foreach (var calendar in calendars)
                    {
                        if (CheckedCalendar.DayLesson == calendar.DayLesson)
                        {
                            if (CheckedCalendar.ToLesson < calendar.FromLesson || calendar.ToLesson < CheckedCalendar.FromLesson)
                            {
                                continue;
                            } else
                            {
                                return true;
                            }
                        } 
                    }
                }
            }
            return false;
        }
        public dynamic getRevenueDAL (DateTime checkIn, DateTime checkOut, int index, string text)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
 
                var bill = db.Bills.Where(p => p.Status == true && p.Time <= checkOut & p.Time >= checkIn & (p.LearningResult.Class.Course.CourseName.Contains(text) || p.LearningResult.Account.AccountInfo.Name.Contains(text)))
                    .Select(p=>p).ToList();
                int groupIndex = 1; 
                var list = bill.GroupBy(p => p.LearningResult.Class.Course.CourseName).Select(group => 
                new {
                    GroupIndex = groupIndex++,
                    CourseId = group.First().LearningResult.Class.Course.Id,
                    CourseName = group.Key,  
                    Count = group.Count(),
                    Price = group.First().Price,
                    SumPrice = group.Sum(p=>p.Price)
                }).ToList();
                if (index == 1)
                {
                    list = list.OrderBy(p=> p.GroupIndex).ToList();   
                }
                else if (index == 2)
                {
                    list = list.OrderByDescending(p => p.CourseName).ToList();
                }
                else if (index == 3)
                {
                    list = list.OrderByDescending(p => p.Price).ToList();
                }
                else if (index == 4)
                {
                    list = list.OrderByDescending(p => p.SumPrice).ToList();
                }
                return list;    
            }
        }
        public dynamic getRevenueByMonthDAL (string year)
        {
            int sum = 0;
            int nam = Convert.ToInt32(year.ToString());
            List<int> li = new List<int>();
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                for (int i= 1; i <= 12; i++)
                {
                    var bill = db.Bills.Where(p => p.Status == true && p.Time.Value.Year == nam && p.Time.Value.Month == i).Select(p => p.Price).ToArray();
                    foreach(var j in bill)
                    {
                        sum += j;
                    }
                    li.Add(sum);
                    sum = 0;
                }
            }
            return li.ToArray();    
        }

        public dynamic getAccoutByCourseNameDAL(int courseId, DateTime checkIn, DateTime checkOut, int index , string name)
        {
            using(DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var ds = db.Bills.Where(p => p.Status == true && p.Time <= checkOut & p.Time >= checkIn && p.LearningResult.Class.Course.Id == courseId && p.LearningResult.Account.AccountInfo.Name.Contains(name))
                    .Select(p => new { p.LearningResult.Account.Id, p.LearningResult.Account.AccountInfo.Name,p.LearningResult.Class.ClassName ,p.Price, p.Time }).ToList();
                if (index == 0)
                {
                    ds = ds.OrderBy(p=> p.Name).ToList();   
                }
                else
                {
                    ds = ds.OrderBy(p=> p.Time).ToList();   
                }
                return ds;
            }
        
        }
        public int saveMKDAL(string MKC, string MKM, string check, int adminId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                int index = 2;
                bool temp = true;
                Account acc = this.GetAccountByID(adminId);
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
    }
}

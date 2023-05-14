using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DAL
{
    public class DAL_Class
    {
        DBEnglishCenterEntities db;
        public DAL_Class()
        {
            db = new DBEnglishCenterEntities(); 
        }
        public dynamic GetClassOfTeacher(int id)
        {
            using(db = new DBEnglishCenterEntities())
            {
                List<LearningResult> lr = new List<LearningResult>();
                lr = db.LearningResults.Where(s => s.AccountId == id).ToList();
                List<Class> ListClass = new List<Class>();
                foreach (LearningResult lrResult in lr)
                {
                    ListClass.Add(db.Classes.Where(s => s.Id == lrResult.ClassId).FirstOrDefault());
                }
                var ds = ListClass.Where(s => s.ClassActive == true).Select(s => new { s.Id, s.ClassName, s.MaxStudent, s.Course.CourseName }).ToList();
                return ds;
            }
            
            
        }
        public List<CbbCourse> GetAllCourse()
        {
            using(db = new DBEnglishCenterEntities()) {

                List<CbbCourse> listCourse = new List<CbbCourse>();
                listCourse.Add(new CbbCourse() { Id = 0, Name = "All" });
                List<Course> listC = new List<Course>();
                listC = db.Courses.ToList();
                foreach (Course item in listC)
                {
                    listCourse.Add(new CbbCourse() { Id = item.Id, Name = item.CourseName });
                }


                return listCourse;
            }
            
        }
        public dynamic SearchClass(int idTeacher, int idCourse, string nameClass)
        {

            using(db = new DBEnglishCenterEntities())
            {
                List<LearningResult> lr = new List<LearningResult>();
                lr = db.LearningResults.Where(s => s.AccountId == idTeacher).ToList();
                List<Class> ListClass = new List<Class>();
                foreach (LearningResult lrResult in lr)
                {
                    ListClass.Add(db.Classes.Where(s => s.Id == lrResult.ClassId).FirstOrDefault());
                }
                if (idCourse == 0)
                {
                    var ds = ListClass.Where(s => s.ClassName.Contains(nameClass)).Select(s => new { s.Id, s.ClassName, s.MaxStudent, s.Course.CourseName }).ToList();
                    return ds;
                }
                else
                {

                    var ds = ListClass.Where(s => s.ClassName.Contains(nameClass) && s.CourseId == idCourse).Select(s => new { s.Id, s.ClassName, s.MaxStudent, s.Course.CourseName }).ToList();
                    return ds;

                }
            }
            
            

        }
        public AccountInfo GetInfoTeacher(int idTeacher)
        {
            using(db = new DBEnglishCenterEntities())
            {
                AccountInfo info = new AccountInfo();
                info = db.AccountInfoes.Where(s => s.AccountId == idTeacher).FirstOrDefault();
                return info;
            }
            
        }
        public void EditInfoTeacher(AccountInfo info, int idTeacher)
        {
            using(db = new DBEnglishCenterEntities())
            {
                AccountInfo InfoTeacher = db.AccountInfoes.Find(idTeacher);
                if(info.Name == "")
                {
                    throw new Exception("Mục họ và tên không được để trống");
                }
                else
                {
                    InfoTeacher.Name = info.Name;
                    InfoTeacher.Phone = info.Phone;
                    InfoTeacher.Email = info.Email;
                    InfoTeacher.Birthday = info.Birthday;
                    InfoTeacher.Gender = InfoTeacher.Gender;
                    InfoTeacher.Address = info.Address;
                    db.SaveChanges();
                }
                
            }
               

        }
        public bool CheckTime(Class cl , DateTime jobDay)
        {
            
            
                if (DateTime.Compare(cl.Course.StartDate, jobDay) <= 0 && DateTime.Compare(cl.Course.EndDate, jobDay) >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            
        }
        public dynamic GetCalendarOfTeacher(int idTeacher, DateTime JobDay)
        {
            using(db = new DBEnglishCenterEntities())
            {
                List<LearningResult> lr = new List<LearningResult>();
                lr = db.LearningResults.Where(s => s.AccountId == idTeacher).ToList();
                List<Calendar> cal = new List<Calendar>();
                Class lop = new Class();
                foreach (LearningResult lrResult in lr)
                {

                    lop = db.Classes.Where(s => s.Id == lrResult.ClassId).FirstOrDefault();
                    if (CheckTime(lop, JobDay))
                    {
                        cal.AddRange(db.Calendars.Where(s => s.ClassId == lop.Id).ToList());
                    }


                }

                var ds = cal.Where(s => s.DayLesson == JobDay.DayOfWeek.ToString()).Select(s => new { s.Class.ClassName, s.DayLesson, s.FromLesson, s.ToLesson }).ToList();
                return ds;
            }
            
        }
        public Class GetClassFromId(int id)
        {
            using(db = new DBEnglishCenterEntities()) {
                Class cl = db.Classes.Where(s => s.Id == id).FirstOrDefault();
                return cl;
            }
           
        }
        public dynamic GetStudentInClass(int idClass)
        {
            using(db = new DBEnglishCenterEntities())
            {
                List<LearningResult> lr = new List<LearningResult>();
                lr = db.LearningResults.Where(s => s.ClassId == idClass && s.Account.RoleId == 3).ToList();
                var ds = lr.Select(s => new { s.Account.Id, s.Account.AccountInfo.Name, s.Account.AccountInfo.Birthday, s.Account.AccountInfo.Gender, s.AssignmentPoint, s.MidTermExamPoint, s.FinalExamPoint }).ToList();

                return ds;
            }
            
        }
        public dynamic SortStudentWithType(int IdClass,int type)
        {
            using(db = new DBEnglishCenterEntities())
            {
                List<LearningResult> lr = new List<LearningResult>();
                lr = db.LearningResults.Where(s => s.ClassId == IdClass && s.Account.RoleId == 3).ToList();

                switch (type)
                {
                    case 0:
                        lr = lr.OrderBy(s => s.Account.Id).ToList();
                        break;

                    case 1:
                        lr = lr.OrderBy(s => s.Account.AccountInfo.Name).ToList();
                        break;
                    case 2:
                        lr = lr.OrderByDescending(kqht =>
                        {
                            double diemGiuaKy = kqht.AssignmentPoint ?? 0;
                            double diemCuoiKy = kqht.MidTermExamPoint ?? 0;
                            double diemBaiTap = kqht.FinalExamPoint ?? 0;
                            return (diemGiuaKy + diemCuoiKy + diemBaiTap) / 3;
                        }).ToList();
                        break;
                    default:

                        break;
                }
                var ds = lr.Select(s => new { s.Account.Id, s.Account.AccountInfo.Name, s.Account.AccountInfo.Birthday, s.Account.AccountInfo.Gender, s.AssignmentPoint, s.MidTermExamPoint, s.FinalExamPoint }).ToList();
                return ds;
            }
            


        }
        public dynamic SearchStudentInClass(int idClass, string nameStudent)
        {
            using(db = new DBEnglishCenterEntities())
            {
                List<LearningResult> lr = new List<LearningResult>();
                lr = db.LearningResults.Where(s => s.ClassId == idClass && s.Account.RoleId == 3 && s.Account.AccountInfo.Name.Contains(nameStudent)).ToList();
                var ds = lr.Select(s => new { s.Account.Id, s.Account.AccountInfo.Name, s.Account.AccountInfo.Birthday, s.Account.AccountInfo.Gender, s.AssignmentPoint, s.MidTermExamPoint, s.FinalExamPoint }).ToList();

                return ds;
            }
           
        }
        public bool CheckTimeClass(int idClass)
        {
            using(db = new DBEnglishCenterEntities())
            {
                Course c = new Course();
                int idCourse = (db.Classes.Find(idClass)).CourseId;
                c = db.Courses.Find(idCourse);
                if (DateTime.Now <= c.EndDate && DateTime.Now >= c.StartDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        public dynamic LoadLessonOfClass( int IdClass)
        {
            using (db = new DBEnglishCenterEntities())
            {

                List<Calendar> list = db.Calendars.Where(s => s.Id == IdClass).ToList();
                var ds = list.Select(s => new { s.Class.ClassName, s.Class.Course.CourseName, s.DayLesson, s.FromLesson, s.ToLesson }).ToList();
                return ds;
                
            }
        }

    }
}

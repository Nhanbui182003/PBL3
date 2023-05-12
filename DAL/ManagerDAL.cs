﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3.DAO
{
    class ManagerDAL
    {
        public List<Course> GetAllCourseDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Courses.ToList();
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
                var course = db.Courses.Where(p => p.CourseName.Contains(name));
                return course.ToList();
            }
        }
        public bool isExistingCourseDAL(Course course)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Courses.Any(p => p.CourseName == course.CourseName && p.StartDate.CompareTo(course.StartDate) == 0 && p.EndDate.CompareTo(course.EndDate) == 0);
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
                        db.LearningResults.RemoveRange(learningResults);
                        var calendars = db.Calendars.Where(p => p.ClassId == c.Id);
                        db.Calendars.RemoveRange(calendars);
                    }
                    db.Classes.RemoveRange(classes);
                    db.Courses.Remove(course);
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
                    db.SaveChanges();
                }
            }
        }

        public List<Class> GetAllClassDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p => p.Course).ToList();
            }
        }
        public List<Class> GetAllClassByCourseIDDAL(int id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p => p.Course).Where(p => p.CourseId == id).ToList();
            }
        }
        public Account GetAccountByUsernamePassword(string username, string password)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var account = db.Accounts.Where(p => p.UserName == username && p.PassWord == password).FirstOrDefault();
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
                var account = db.Accounts.Where(p => p.Id == id).FirstOrDefault();
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
                return db.Classes.Any(p => p.ClassName == c.ClassName && p.CourseId == c.CourseId);
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
                int[] ids = db.LearningResults.Where(p => p.ClassId == classID).Select(p => p.AccountId).ToArray();
                List<Account> students = new List<Account>();
                for (int i = 0; i < ids.Length; i++)
                {
                    int id = ids[i];
                    var account = db.Accounts.Include(p => p.AccountInfo).Where(p => p.Id == id && p.RoleId == 3).FirstOrDefault();
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
                var learningResult = db.LearningResults.Where(p => p.AccountId == accountId && p.ClassId == classID).FirstOrDefault();
                if (learningResult == null) return false; else return true;
            }
        }
        public void AddStudentToClassDAL(int accountId, int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                LearningResult student = new LearningResult()
                {
                    AccountId = accountId,
                    ClassId = classID
                };
                db.LearningResults.Add(student);

                Class c = db.Classes.Include(p => p.Course).Where(p => p.Id == classID).FirstOrDefault();
                db.Bills.Add(new Bill()
                {
                    LearningResultId = student.Id,
                    Price = c.Course.Price,
                    Status = false,
                });
                db.SaveChanges();
            };
        }
        public void DeleteStudentDAL(int accountId, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var l = db.LearningResults.Where(p => p.AccountId == accountId && p.ClassId == classId).FirstOrDefault();
                db.LearningResults.Remove(l);
                db.SaveChanges();
            }
        }
        public Class GetClassByClassIDDAL(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p => p.Course).Where(p => p.Id == classID).FirstOrDefault();
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
                var l = db.LearningResults.Where(p => p.ClassId == classID);
                foreach (var i in l)
                {
                    var account = db.Accounts.Where(p => p.Id == i.AccountId).FirstOrDefault();
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
                var learningResult = db.LearningResults.Where(p => p.ClassId == classID);
                db.LearningResults.RemoveRange(learningResult);

                var calendars = db.Calendars.Where(p => p.ClassId == classID);
                db.Calendars.RemoveRange(calendars);

                var c = db.Classes.Where(p => p.Id == classID).FirstOrDefault();
                db.Classes.Remove(c);

                db.SaveChanges();
            }
        }
        public List<Class> GetClassByNameDAL(string name)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var cs = db.Classes.Include(p => p.Course).Where(p => p.ClassName.Contains(name));
                return cs.ToList();
            }
        }
        public List<Account> GetStudentByNameANDClassIDDAL(string name, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                List<Account> list = GetAllStudentByClassIdDAL(classId);
                var students = list.Where(p => p.AccountInfo.Name.Contains(name));
                return students.ToList();
            }
        }
        public LearningResult GetLearningResultOfTeacherByClassIDDAL(int classID)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                var l = db.LearningResults.Where(p => p.ClassId == classID);
                foreach (var i in l)
                {
                    var account = db.Accounts.Where(p => p.Id == i.AccountId).FirstOrDefault();
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

                List<LearningResult> l = db.LearningResults.Where(p => p.ClassId == updatedClass.Id).ToList();
                LearningResult oldTeacher = new LearningResult();
                foreach (LearningResult i in l)
                {
                    var account = db.Accounts.Where(p => p.Id == i.AccountId).FirstOrDefault();
                    if (account.RoleId == 2)
                    {
                        oldTeacher = i;
                    }
                }
                oldTeacher.AccountId = newTeacher.AccountId;


                List<Calendar> oldCalendars = db.Calendars.Where(p => p.ClassId == updatedClass.Id).ToList();
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
                List<Account> listStudentAccounts = db.Accounts.Include(p => p.AccountInfo).Where(p => p.RoleId == 3).ToList();
                return listStudentAccounts;
            }
        }
        public List<Account> GetAllTeacherAccountDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                List<Account> listTeacherAccounts = db.Accounts.Include(p => p.AccountInfo).Where(p => p.RoleId == 2).ToList();
                return listTeacherAccounts;
            }
        }
        public LearningResult GetLearningResultOfStudentDAL(int studentId, int classId)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.LearningResults.Where(p => p.ClassId == classId && p.AccountId == studentId).FirstOrDefault();
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
                db.SaveChanges();
            }
        }
    }
}
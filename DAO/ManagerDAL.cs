using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var course = db.Courses.Where(p => p.Id==id).FirstOrDefault();
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
                var course = db.Courses.Where(p=>p.Id==id).FirstOrDefault(); 
                if (course != null)
                {
                    var classes = db.Classes.Where(p => p.CourseId == id);
                    foreach (var c in classes)
                    {
                        var learningResult = db.LearningResults.Where(p => p.ClassId == id);
                        db.LearningResults.RemoveRange(learningResult);
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
                var course = db.Courses.Where(p=>p.Id == newcourse.Id).FirstOrDefault();
                if (course != null) 
                { 
                    course.CourseName = newcourse.CourseName;
                    course.Description = newcourse.Description;
                    course.StartDate = newcourse.StartDate;
                    course.EndDate= newcourse.EndDate;
                    course.Price= newcourse.Price;
                    db.SaveChanges() ;
                }
            }
        }

        public List<Class> GetAllClassDAL()
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Include(p=>p.Course).ToList();
            }
        }
        public List<Class> GetAllClassByCourseIDDAL(int id)
        {
            using (DBEnglishCenterEntities db = new DBEnglishCenterEntities())
            {
                return db.Classes.Where(p=>p.CourseId==id).ToList();
            }
        }

    }
}

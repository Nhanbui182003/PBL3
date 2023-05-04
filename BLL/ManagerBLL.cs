using PBL3.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    class ManagerBLL
    {
        public List<Course> GetALlCourseBLL()
        {
            return new ManagerDAL().GetAllCourseDAL();
        }
        public Course GetCourseByIDBLL(int ID)
        {
            return new ManagerDAL().GetCourseByIDDAL(ID);
        }
        public List<Course> GetCourseByNameBLL(string name)
        {
            return new ManagerDAL().GetCourseByNameDAL(name);

        }
        public void AddCourseBLL(Course course)
        {
            new ManagerDAL().AddCourseDAL(course);
        }
        public void DeleteCourseBLL(int id)
        {
            new ManagerDAL().DeleteCourseDAL(id);
        }
        public void UpdateCourseBLL(Course course)
        {
            new ManagerDAL().UpdateCourseDAL(course);
        }
        public List<Class> GetAllClassBLL()
        {
            return new ManagerDAL().GetAllClassDAL();
        }
        public List<Class> GetAllClassByCourseIDBLL(int id)
        {
            return new ManagerDAL().GetAllClassByCourseIDDAL(id);   
        }
    }
}

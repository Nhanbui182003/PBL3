using PBL3.DAL;
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
        public void LoadDataGridViewCourse(DataGridView dgv)
        {
            dgv.DataSource = GetALlCourseBLL().Select(p => new { p.Id, p.CourseName, p.StartDate, p.EndDate, p.Price }).ToList();
        }
        public bool isExistingCourseBLL(Course course)
        {
            return new ManagerDAL().isExistingCourseDAL(course);
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
        public void LoadDataGridViewClass(DataGridView dgv)
        {
            dgv.DataSource = GetAllClassBLL().Select(p => new { p.Id, p.ClassName, p.Course.CourseName, p.MaxStudent }).ToList();

        }
        public List<Class> GetAllClassByCourseIDBLL(int id)
        {
            return new ManagerDAL().GetAllClassByCourseIDDAL(id);   
        }
        public Account GetAccountByUsernamePassword(string username, string password)
        {
            return new ManagerDAL().GetAccountByUsernamePassword(username, password);
        }
        public Account GetAccountByID(int id)
        {
            return new ManagerDAL().GetAccountByID(id);
        }
        public bool isExistingClassBLL(Class c)
        {
            return new ManagerDAL().isExistingClassDAL(c);
        }
        public void AddClassBLL(Class c) 
        { 
            new ManagerDAL().AddClassDAL(c);
        }
        public void AddLearningResult(LearningResult learningResult)
        {
            new ManagerDAL().AddLearningResult(learningResult);
        }
        public void AddCalendarBLL(Calendar calendar)
        {
            new ManagerDAL().AddCalendarDAL(calendar);
        }
        public List<Account> GetAllStudentByClassIdBLL(int classID)
        {
            return new ManagerDAL().GetAllStudentByClassIdDAL(classID);
        }
        public void LoadDataGridViewStudent(DataGridView dgv, int classID)
        {
            dgv.DataSource = GetAllStudentByClassIdBLL(classID).Select(p => new {p.Id,p.AccountInfo.Name,p.AccountInfo.Phone,p.AccountInfo.Email,p.AccountInfo.Gender}).ToList();
        }
        public bool IsExistingStudentBLL(int accountId,int classID)
        {
            return new ManagerDAL().isExistingStudentDAL(accountId, classID);
        }
        public void AddStudentToClassBLL(int accountId,int classId)
        {
            new ManagerDAL().AddStudentToClassDAL(accountId, classId);
        }
        public void DeleteStudentBLL(int accountId , int classId)
        {
            new ManagerDAL().DeleteStudentDAL(accountId, classId);  
        }
        public Class GetClassByClassIDBLL(int classID)
        {
            return new ManagerDAL().GetClassByClassIDDAL(classID);
        }
        public List<Calendar> GetListCalendarsByClassIDBLL(int ClassID)
        {
            return new ManagerDAL().GetListCalendarsByClassIDDAL(ClassID);
        }
        public AccountInfo GetTeacherOfClassByClassIDBLL(int classID)
        {
            return new ManagerDAL().GetTeacherInfoOfClassByClassID(classID);
        }
        public void DeleteClassByClassIDBLL(int classID)
        {
            new ManagerDAL().DeleteClassByClassIDDAL(classID);
        }
        public List<Class> GetClassByNameBLL(string name) 
        { 
            return new ManagerDAL().GetClassByNameDAL(name);
        }
        public List<Account> GetStudentByNameANDCLassIDBLL(string name,int classID)
        {
            return new ManagerDAL().GetStudentByNameANDClassIDDAL(name,classID);
        }
        public LearningResult GetLearningResultOfTeacherByClassIDBLL(int classID)
        {
            return new ManagerDAL().GetLearningResultOfTeacherByClassIDDAL(classID);
        }
        public void UpdateClassBLL(Class newClass, LearningResult newTeacher, List<Calendar> newCalendars)
        {
            new ManagerDAL().UpdateClassDAL(newClass,newTeacher,newCalendars);   
        }
        public void LoadDataGridViewStudentAccounts(DataGridView dgv)
        {
            dgv.DataSource = new ManagerDAL().GetAllStudentAccountDAL().Select(p => new { p.Id, p.AccountInfo.Name, p.AccountInfo.Phone, p.AccountInfo.Email, p.AccountInfo.Gender }).ToList();   
        }
        public void LoadDataGridViewTeacherAccounts(DataGridView dgv)
        {
            dgv.DataSource = new ManagerDAL().GetAllTeacherAccountDAL().Select(p => new { p.Id, p.AccountInfo.Name, p.AccountInfo.Phone, p.AccountInfo.Email, p.AccountInfo.Gender }).ToList();
        }
        public LearningResult GetLearningResultOfStudentBLL(int studentId, int classId)
        {
            return new ManagerDAL().GetLearningResultOfStudentDAL(studentId, classId);
        }
        public Bill GetBillOfStudentBLL(int studentId, int classId)
        {
            return new ManagerDAL().GetBillOfStudentDAL(studentId, classId); 
        }
        public void ConfirmPaymentBLL(Bill oldBill)
        {
            new ManagerDAL().ConfirmPaymentDAL(oldBill);
        }
        public bool isExistingCalendarByAccountIDBLL(int accountId, Calendar CheckedCalendar)
        {
            return new ManagerDAL().isExistingCalendarByAccountIDDAL(accountId, CheckedCalendar);
        }

        public dynamic getRevenueBLL(DateTime checkIn, DateTime checkOut, int index,String text)
        {
            return new ManagerDAL().getRevenueDAL(checkIn, checkOut, index,text);
        }
        public dynamic getRevenueByMonthBLL(string year)
        {
            return new ManagerDAL().getRevenueByMonthDAL(year); 
        }
        public int saveMKBLL(string MKC, string MKM, string check, int adminId)
        {
            int i = new ManagerDAL().saveMKDAL( MKC, MKM, check, adminId);
            if (i == 2)
            {
                return 2;
            }
            else if (i == 3)
            {
                return 3;
            }
            else if (i == 4)
            {
                return 4;
            }
            return 2;
        }
    }
}

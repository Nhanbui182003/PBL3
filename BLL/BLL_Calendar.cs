using PBL3.DAL;
using PBL3.View.Giảng_viên;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class BLL_Calendar
    {
        DAL_Class dalClass;
        public BLL_Calendar()
        {
            dalClass = new DAL_Class(); 
        }
        public void GetCalendarForTeacher(DataGridView dg, DateTime jobDay, int idTeacher)
        {
            dg.DataSource = dalClass.GetCalendarOfTeacher(idTeacher, jobDay);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "ClassName")
                {
                    column.HeaderText = "Tên lớp học ";
                }
                else if (column.Name == "DayLesson")
                {
                    column.HeaderText = "Ngày dạy";
                }
                else if (column.Name == "FromLesson")
                {
                    column.HeaderText = "Tiết bắt đầu";
                }
                else if (column.Name == "ToLesson")
                {
                    column.HeaderText = "Tiết kết thúc";
                }

            }
            dg.Columns[0].Width = (int)(dg.Width * 0.2);
            dg.Columns[1].Width = (int)(dg.Width * 0.3);
            dg.Columns[2].Width = (int)(dg.Width * 0.25);
            dg.Columns[3].Width = (int)(dg.Width * 0.25);

        }
        public void LoadLessonOfClass(int IdClass, DataGridView dg)
        {
            dg.DataSource = dalClass.LoadLessonOfClass(IdClass);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "ClassName")
                {
                    column.HeaderText = "Tên lớp học ";
                }else if(column.Name == "CourseName")
                {
                    column.HeaderText = "Tên khoá học ";
                }
                else if (column.Name == "DayLesson")
                {
                    column.HeaderText = "Ngày dạy";
                }
                else if (column.Name == "FromLesson")
                {
                    column.HeaderText = "Tiết bắt đầu";
                }
                else if (column.Name == "ToLesson")
                {
                    column.HeaderText = "Tiết kết thúc";
                }

            }
            dg.Columns[0].Width = (int)(dg.Width * 0.2);
            dg.Columns[1].Width = (int)(dg.Width * 0.2);
            dg.Columns[2].Width = (int)(dg.Width * 0.2);
            dg.Columns[3].Width = (int)(dg.Width * 0.2);
            dg.Columns[3].Width = (int)(dg.Width * 0.2);


        }
        public bool CheckCalendarOfTeacher(DateTime useDate,int IdTeacher)
        {
            if(dalClass.CheckCalendarOfTeacher(useDate, IdTeacher))
            {
                return true;
            }
            return false;
        }
    }
}

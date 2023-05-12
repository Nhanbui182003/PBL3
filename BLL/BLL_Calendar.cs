using PBL3.DAL;
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
                if (column.Name == "NameClass")
                {
                    column.HeaderText = "Mã lớp học ";
                }
                else if (column.Name == "Day")
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

        }
    }
}

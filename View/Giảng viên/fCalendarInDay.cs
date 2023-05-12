using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Giảng_viên
{
    public partial class fCalendarInDay : Form
    {
        private DateTime JobDate;
        private int IdTeacher;
        private BLL_Calendar bllCalendar;
        public fCalendarInDay(DateTime jobDate,int  idTeacher)
        {
            InitializeComponent();
            bllCalendar = new BLL_Calendar();
            JobDate = jobDate;  
            dtpkListJob.Value = jobDate; 
            IdTeacher = idTeacher;
            DisplayCalendarInDay(jobDate);
            
        }
        void DisplayCalendarInDay(DateTime date)
        {
            bllCalendar.GetCalendarForTeacher(dtgvListJob, date, IdTeacher);
            
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dtpkListJob.Value = dtpkListJob.Value.AddDays(-1);
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            dtpkListJob.Value = dtpkListJob.Value.AddDays(1);
        }

        private void dtpkListJob_ValueChanged(object sender, EventArgs e)
        {
            DisplayCalendarInDay(dtpkListJob.Value);
        }
    }
}

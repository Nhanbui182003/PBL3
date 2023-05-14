using PBL3.DTO;
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
    public partial class fTeacherCalendar : Form
    {
        #region Properties
        int IdTeacher;
        public List<List<Button>> Matrix { get; set; }
        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        #endregion
        public fTeacherCalendar(int idTeacher)
        {
            InitializeComponent();
            IdTeacher = idTeacher;  
            fLoad();
        }
        void fLoad()
        {
            Button OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            Matrix = new List<List<Button>>();

            for (int i = 0; i < Cons.DayOfColunm; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.DatebtnWidth, Height = Cons.DatebtnHeight };
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width + Cons.Margin, OldBtn.Location.Y);
                    btn.Click += Btn_Click;
                    pnlMatrix.Controls.Add(btn);

                    Matrix[i].Add(btn);
                    OldBtn = btn;

                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, OldBtn.Location.Y + Cons.DatebtnHeight) };
            }
            SetDefaultValue();
        }
        void SetDefaultValue()
        {
            dtpkDateSelection.Value = DateTime.Now;
        }
        bool IsEqualDatetime(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:

                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2: if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0)) { return 29; } else { return 28; }

                default: return 30;

            }
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (column >= 6)
                {
                    line++;
                }

                if (IsEqualDatetime(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }
                if (IsEqualDatetime(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                useDate = useDate.AddDays(1);


            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            fCalendarInDay daily = new fCalendarInDay(new DateTime(dtpkDateSelection.Value.Year, dtpkDateSelection.Value.Month, Convert.ToInt32((sender as Button).Text)), IdTeacher);
            daily.ShowDialog();
            
        }

        private void dtpkDateSelection_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultValue();
        }

        private void btnPreMonth_Click(object sender, EventArgs e)
        {
            dtpkDateSelection.Value =  dtpkDateSelection.Value.AddMonths(-1);

        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDateSelection.Value =  dtpkDateSelection.Value.AddMonths(1);
        }
    }
}

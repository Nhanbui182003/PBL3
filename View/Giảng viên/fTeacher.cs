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
    public partial class fTeacher : Form
    {
        #region Properties
        private int IdTeacher;
        private BLL_Class BllClass;
        private event EventHandler deleteOldForm;
        public event EventHandler DeleteOldForm
        {
            add { deleteOldForm += value; }
            remove { deleteOldForm -= value; }
        }


        #endregion
        public fTeacher(int idTeacher)
        {
            InitializeComponent();
            BllClass = new BLL_Class();
            IdTeacher = idTeacher;
            DisplayDataOfAllClasses();
        }

        void DisplayDataOfAllClasses()
        {
            BllClass.SearchClass(IdTeacher, 0, "", dtgvClassOfTeacher);
        }
        void DisPlayAllCourse()
        {
            BllClass.GetAllCourse(cbxCourse);
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idCourse = Int32.Parse(cbxCourse.SelectedValue.ToString());
            string nameClass = tbxNameClass.Text;
            BllClass.SearchClass(IdTeacher, idCourse, nameClass, dtgvClassOfTeacher);

        }

        private void fTeacher_Load(object sender, EventArgs e)
        {
            DisplayDataOfAllClasses();
            DisPlayAllCourse();
           
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            if(dtgvClassOfTeacher.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgvClassOfTeacher.SelectedRows[0];
                int idClass = Convert.ToInt32(row.Cells["Id"].Value.ToString().Substring(1));
                
                //MyClass f = new MyClass(idClass, IdTeacher);
                
                //f.StartPosition = FormStartPosition.CenterScreen;
                //f.Show();
                //this.Hide();
                fMainTeacher f = new fMainTeacher(IdTeacher);
                f.Open(idClass, IdTeacher);
                f.Show();
                this.Hide();
                if(deleteOldForm != null)
                {
                    deleteOldForm(this, new EventArgs());
                }
                
            }
            else if(dtgvClassOfTeacher.SelectedRows.Count > 1)
            {
                MessageBox.Show("Hãy chọn duy nhất 1 lớp học khi truy cập!!!");
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 lớp học để truy cập !!!");

            }
        }

 
    }
}

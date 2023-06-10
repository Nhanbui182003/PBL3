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
    public partial class fMainTeacher : Form
    {
        private Form formshow;
        private int IdTeacher;
        public delegate void OpenFormClass(int idClass, int idTeacher);
        public OpenFormClass Open;
        public fMainTeacher(int idTeacher)
        {
            InitializeComponent();
            IdTeacher = idTeacher;
            Open = new OpenFormClass(OpenClassOfTeacherForm);
        }
        private void OpenClassOfTeacherForm(int idClass, int idTeacher) {
            MyClass f = new MyClass(idClass, idTeacher);
            openPanelBody(f);
        }
        private void openPanelBody(Form f1)
        {
            if (formshow != null)
            {
                formshow.Close();
            }
            formshow = f1;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            pnBody.Controls.Add(f1);
            pnBody.Tag = f1;
            f1.BringToFront();
            f1.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            fTeacher f = new fTeacher(IdTeacher);
            f.DeleteOldForm += F_DeleteOldForm;
            openPanelBody(f);

        }

        private void F_DeleteOldForm(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            fTeacherCalendar f = new fTeacherCalendar(IdTeacher);
            openPanelBody(f);   
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccountOfTeacher f = new fAccountOfTeacher(IdTeacher);
            openPanelBody(f);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }
    }
}

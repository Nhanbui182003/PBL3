using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Giảng_viên
{
    
    public partial class LearningResultOfStudent : Form
    {
        #region Properties
        private int IdStudent;
        private int IdClass;
        private BLL_Student bllStudent;
        private double aPoint;
        private double mPoint;
        private double fPoint;
        private event EventHandler loadData;
        public event EventHandler LoadData
        {
            add { loadData += value; }
            remove { loadData -= value; }   
        }
        #endregion

        public LearningResultOfStudent(int idStudent, int idClass)
        {
            InitializeComponent();
            bllStudent= new BLL_Student();    
            IdStudent = idStudent;
            IdClass = idClass;
        }
        void LoadInfoSudent()
        {
            AccountInfo info = new AccountInfo();
            info = bllStudent.GetInfo(IdStudent);
            tbxIdStudent.Text = IdStudent.ToString();
            tbxNameStudent.Text = info.Name;
            dtpkBirthday.Value = (DateTime)info.Birthday;
            if(info.Gender == true)
            {
                tbxGender.Text = "Nam";
            }
            else
            {
                tbxGender.Text = "Nữ";
            }
        }
        void LoadLearningResult()
        {
            LearningResult lr = new LearningResult();
            lr = bllStudent.GetResult(IdStudent, IdClass);
            if(lr.AssignmentPoint != null)
            {
                tbxAssignmentPoint.Text = lr.AssignmentPoint.ToString();    
            }
            if (lr.MidTermExamPoint != null)
            {
                tbxMidTermPoint.Text = lr.MidTermExamPoint.ToString();
            }
            if (lr.FinalExamPoint != null)
            {
                tbxFinalPoint.Text = lr.FinalExamPoint.ToString();
            }
        }
        private void LearningResultOfStudent_Load(object sender, EventArgs e)
        {
            LoadInfoSudent();
            LoadLearningResult();
        }

        private void OK_Click(object sender, EventArgs e)
        {
         
            
                
                    if (bllStudent.EditLearningResult(IdStudent, IdClass, tbxAssignmentPoint.Text, tbxMidTermPoint.Text, tbxFinalPoint.Text))
                    {
                        MessageBox.Show("Cập nhật điểm thành công");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật điểm không thành công");
                    }
                    if(loadData != null)
                    {
                        loadData(this, new EventArgs());
                    }
                    this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

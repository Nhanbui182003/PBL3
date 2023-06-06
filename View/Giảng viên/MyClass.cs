using PBL3.BLL;
using PBL3.DAL;
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
    public partial class MyClass : Form
    {
        #region Properties
        private int IdClass;
        private int IdTeacher;
        private BLL_Class bllClass;
        private BLL_Document bllDocument;
        private BLL_Calendar bllCalendar;
        #endregion
        public MyClass(int idClass, int idTeacher)
        {
            InitializeComponent();
            IdClass = idClass;
            IdTeacher = idTeacher;  
            bllClass= new BLL_Class();
            bllDocument = new BLL_Document();   
            bllCalendar = new BLL_Calendar();   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameStudent = tbxNameStudent.Text;
            bllClass.SearchStudent(IdClass, dtgvListStudentInClass, NameStudent);

        }
        void DisPlayInfoClass()
        {
            Class cl = bllClass.GetClassFromId(IdClass);
            tbxIdClass.Text = cl.Id.ToString();
            tbxNameClass.Text = cl.ClassName.ToString();    
            tbxMaxStudent.Text = cl.MaxStudent.ToString();
            tbxIdClass.Enabled = false;
            tbxNameClass.Enabled = false;
            tbxMaxStudent.Enabled = false;
            Course course = bllClass.GetCourseFromIdClass(IdClass); 
            string TimeRate = "Từ ";
            TimeRate += course.StartDate.ToString("dd/MM/yyyy");
            TimeRate += " Đến " + course.EndDate.ToString("dd/MM/yyyy");
            tbxTimeRate.Text = TimeRate;
        }
        void LoadListSudentInClass(int id)
        {
            dtgvListStudentInClass.DataSource = null;
            bllClass.GetListStudent(id, dtgvListStudentInClass);
        }
        private void LoadAllDocument()
        {
            
            bllDocument.LoadListDocument(dtgvListDocument, IdClass);  
            
        }
        private void LoadLessonInWeakOfClass()
        {
            bllCalendar.LoadLessonOfClass(IdClass, dtgvListLesson);
        }

        private void MyClass_Load(object sender, EventArgs e)
        {
            DisPlayInfoClass();
            cbxSortStudent.SelectedIndex = 0;
            cbxSortDocument.SelectedIndex = 0;
            LoadListSudentInClass(IdClass);
            LoadAllDocument();
            LoadLessonInWeakOfClass();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fTeacher f = new fTeacher(IdTeacher);
            f.Show();
            this.Hide();
            
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            if (bllClass.CheckTimeClass(IdClass))
            {
                if (dtgvListStudentInClass.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dtgvListStudentInClass.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                    LearningResultOfStudent f = new LearningResultOfStudent(id, IdClass);
                    f.LoadData += F_LoadData;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();

                }
                else if (dtgvListStudentInClass.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Để đánh giá bạn hãy chọn duy nhất 1 học viên ");
                }
                else
                {
                    MessageBox.Show("Hãy chọn 1 học viên để đánh giá");
                }
            }
            else
            {
                MessageBox.Show("Bạn không thể đánh giá lớp học này được nữa vì đã quá thời gian ");
            }
            
        }

        
        private void F_LoadData(object sender, EventArgs e)
        {
            
            
            
            dtgvListStudentInClass.DataSource = null;
            
            bllClass.GetListStudent(IdClass, dtgvListStudentInClass);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            fDocument f = new fDocument(IdClass, 0);
            f.LoadData += F_LoadData1;
            f.Show(); 
        }

        private void F_LoadData1(object sender, EventArgs e)
        {
            
            bllDocument.LoadListDocument(dtgvListDocument, IdClass);
        
        }

        private void btnDownLoadFile_Click(object sender, EventArgs e)
        {
            if(dtgvListDocument.SelectedRows.Count == 1)
            {
                int idDocument = Int32.Parse(dtgvListDocument.SelectedRows[0].Cells["Id"].Value.ToString());
                fDocument f = new fDocument(IdClass, idDocument);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài liệu để tải xuống");
            }
            
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dtgvListDocument.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa các tài liệu này không ???", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    List<int> list = new List<int>();
                    foreach (DataGridViewRow row in dtgvListDocument.SelectedRows)
                    {
                        int item = Int32.Parse(dtgvListDocument.SelectedRows[0].Cells["Id"].Value.ToString());
                        list.Add(item);

                    }
                    if (bllDocument.DeleteDocuments(list))
                    {
                        MessageBox.Show("Xóa tài liệu thành công!!");

                        LoadAllDocument();
                        
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài liệu thât bại ");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tài liệu để xóa");
            }
            


            
        }

        private void btnSortStudent_Click(object sender, EventArgs e)
        {
            switch (cbxSortStudent.SelectedIndex)
            {
                case 0:
                    bllClass.SortStudent(dtgvListStudentInClass,IdClass, 0);
                    break;
                case 1:
                    bllClass.SortStudent(dtgvListStudentInClass ,IdClass, 1);
                    break;
                case 2:
                    bllClass.SortStudent(dtgvListStudentInClass, IdClass, 2);
                    break;
            }
        }

        private void btnSortDocument_Click(object sender, EventArgs e)
        {
            switch(cbxSortDocument.SelectedIndex) {
                case 0:
                    bllDocument.SortDocument(dtgvListDocument, IdClass, 0);
                    break;
                case 1:
                    bllDocument.SortDocument(dtgvListDocument, IdClass, 1);
                    break;
            }
        }
    }
}

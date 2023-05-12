using PBL3.BLL;
using PBL3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.Admin
{
    public partial class fAddClass : Form
    {
        private int ClassID = 0;
        public fAddClass()
        {
            InitializeComponent();
            SetCBB();
            
        }
        public fAddClass(int id)
        {
            ClassID= id;
            InitializeComponent();
            SetCBB();

            ManagerBLL bll = new ManagerBLL();
            Class c = bll.GetClassByClassIDBLL(ClassID);
            txtClassName.Text = c.ClassName;
            cbbNameCourse.SelectedItem = cbbNameCourse.Items.Cast<CBBItem>().FirstOrDefault(p => p.Text == c.Course.CourseName);
            txtMaxStudent.Text = c.MaxStudent.ToString();
            
            LearningResult t = bll.GetLearningResultOfTeacherByClassIDBLL(ClassID);
            txtTeacherID.Text = t.AccountId.ToString();
           
            List<Calendar> calendas = bll.GetListCalendarsByClassIDBLL(ClassID);
            cbbDay1.SelectedItem = calendas[0].DayLesson.ToString();
            txtStartLesson1.Text = calendas[0].FromLesson.ToString();
            txtEndLesson1.Text = calendas[0].ToLesson.ToString();

            cbbDay2.SelectedItem = calendas[1].DayLesson.ToString();
            txtStartLesson2.Text = calendas[1].FromLesson.ToString();
            txtEndLesson2.Text = calendas[1].ToLesson.ToString();
        }

        public void SetCBB()
        {
            var listCourse = new ManagerBLL().GetALlCourseBLL().ToList();
            foreach (var c in listCourse)
            {
                cbbNameCourse.Items.Add(new CBBItem()
                {
                    Value = c.Id,
                    Text = c.CourseName
                });
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text!=""||cbbNameCourse.SelectedIndex==-1||txtTeacherID.Text==""||txtMaxStudent.Text==""||cbbDay1.SelectedIndex==-1||txtStartLesson1.Text==""||txtEndLesson1.Text=="" || cbbDay2.SelectedIndex == -1 || txtStartLesson2.Text == "" || txtEndLesson2.Text == "")
            {
                int startLesson1 = Convert.ToInt32(txtStartLesson1.Text);
                int endLesson1 = Convert.ToInt32(txtEndLesson1.Text);
                int startLesson2 = Convert.ToInt32(txtStartLesson2.Text);
                int endLesson2 = Convert.ToInt32(txtEndLesson2.Text);
                if (startLesson1 >= endLesson1 || startLesson2 >= endLesson2 )
                {
                    MessageBox.Show("Thời gian tiết học không xác thực");
                }
                else
                {
                    if (startLesson1 >= 1 && startLesson1 <= 10 && endLesson1 >= 1 && endLesson1 <= 10 && startLesson2 >= 1 && startLesson2 <= 10 && endLesson2 >= 1 && endLesson2 <= 10)
                    {
                        var teacher = new ManagerBLL().GetAccountByID(Convert.ToInt32(txtTeacherID.Text));
                        if (teacher == null || teacher.RoleId !=2)
                        {
                            MessageBox.Show("Không tìm thấy giảng viên!!!");
                        }
                        else
                        {
                            ManagerBLL bll = new ManagerBLL();
                            int courseId = ((CBBItem)cbbNameCourse.SelectedItem).Value;

                            //Trường hợp thêm
                            if (ClassID == 0)
                            {
                                Class c = new Class()
                                {
                                    CourseId = courseId,
                                    ClassName = txtClassName.Text,
                                    MaxStudent = Convert.ToInt32(txtMaxStudent.Text),
                                };
                                if (bll.isExistingClassBLL(c) == false)
                                {
                                    bll.AddClassBLL(c);
                                    LearningResult t = new LearningResult()
                                    {
                                        AccountId = teacher.Id,
                                        ClassId = c.Id,
                                    };
                                    bll.AddLearningResult(t);
                                    Calendar t1 = new Calendar()
                                    {
                                        ClassId = c.Id,
                                        DayLesson = cbbDay1.SelectedItem.ToString(),
                                        FromLesson = startLesson1,
                                        ToLesson = endLesson1,
                                    };
                                    bll.AddCalendarBLL(t1);
                                    Calendar t2 = new Calendar()
                                    {
                                        ClassId = c.Id,
                                        DayLesson = cbbDay2.SelectedItem.ToString(),
                                        FromLesson = startLesson2,
                                        ToLesson = endLesson2,
                                    };
                                    bll.AddCalendarBLL(t2);
                                    MessageBox.Show("Lớp học đã được thêm!!!");
                                    Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("Lớp học đã tồn tại!!!");
                                }
                            } 
                            //Trường hợp cập nhật
                            else
                            {
                                Class newClass = bll.GetClassByClassIDBLL(ClassID);
                                newClass.ClassName = txtClassName.Text;
                                newClass.CourseId = courseId;
                                newClass.MaxStudent = Convert.ToInt32(txtMaxStudent.Text);

                                LearningResult newTeacher = bll.GetLearningResultOfTeacherByClassIDBLL(ClassID);
                                newTeacher.AccountId = Convert.ToInt32(txtTeacherID.Text);

                                List<Calendar> calendas = bll.GetListCalendarsByClassIDBLL(ClassID);
                                calendas[0].DayLesson = cbbDay1.SelectedItem.ToString();
                                calendas[0].FromLesson = startLesson1;
                                calendas[0].ToLesson = endLesson1;

                                calendas[1].DayLesson= cbbDay2.SelectedItem.ToString();
                                calendas[1].FromLesson = startLesson2;
                                calendas[1].ToLesson = endLesson2;
                                bll.UpdateClassBLL(newClass, newTeacher, calendas);
                                MessageBox.Show("Cập nhật thành công!");
                                Dispose();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiết học phải từ 1 đến 10.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnChoiceTeacher_Click(object sender, EventArgs e)
        {
            using (fChoiceTeacher f = new fChoiceTeacher())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    txtTeacherID.Text = f.teacherId.ToString();
                }
            }
        }
    }
}

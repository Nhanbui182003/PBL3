using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3.View.Admin
{
    public partial class fAddCourse : Form
    {
        // Kiểm tra trường hợp thêm hay cập nhật
        // Mặc định trường hợp thêm, id = 0
        private int id =0;
        public fAddCourse()
        {
            InitializeComponent();
        }
        public fAddCourse(int id)
        {
            InitializeComponent();
            this.id = id;
            var course = new ManagerBLL().GetCourseByIDBLL(id);
            txtName.Text = course.CourseName;
            txtDescription.Text = course.Description;
            txtPrice.Text = course.Price.ToString();
            dtStartDate.Value = course.StartDate;
            dtEndDate.Value = course.EndDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dtStartDate.Value.CompareTo(dtEndDate.Value)<=0)
            {
              
                
                // Trường hợp thêm 
                if (id==0)
                {
                    new ManagerBLL().AddCourseBLL(new Course()
                    {
                        CourseName = txtName.Text,
                        StartDate = dtStartDate.Value.Date,
                        EndDate = dtEndDate.Value.Date,
                        Description = txtDescription.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                    });
                } 
                // Trường hợp cập nhật ( tồn tại id != 0)
                else
                {
                    Course course = new Course();
                    course.Id = id;
                    course.CourseName = txtName.Text;
                    course.StartDate = dtStartDate.Value.Date;
                    course.EndDate = dtEndDate.Value.Date;
                    course.Description = txtDescription.Text;
                    course.Price = Convert.ToInt32(txtPrice.Text);
                    new ManagerBLL().UpdateCourseBLL(course);
                }
                
               Dispose();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

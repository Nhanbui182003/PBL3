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
            txtName.Text = course.Name;
            txtDescription.Text = course.Description;
            txtPrice.Text = course.Price.ToString();
            dtStartDate.Value = course.Start_date.Value;
            dtEndDate.Value = course.End_date.Value;
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
                        Name = txtName.Text,
                        Start_date = dtStartDate.Value.Date,
                        End_date = dtEndDate.Value.Date,
                        Description = txtDescription.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                    });
                } 
                // Trường hợp cập nhật ( tồn tại id != 0)
                else
                {
                    Course course = new Course();
                    course.ID = id;
                    course.Name = txtName.Text;
                    course.Start_date = dtStartDate.Value.Date;
                    course.End_date = dtEndDate.Value.Date;
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

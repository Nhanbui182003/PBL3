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
            this.Text = "Thêm khóa học";
        }
        public fAddCourse(String MaKhoaHoc)
        {   
            id = int.Parse(MaKhoaHoc.Substring(1));
            InitializeComponent();
            this.Text = "Cập nhật khóa học";
            var course = new ManagerBLL().GetCourseByIDBLL(id);
            txtName.Text = course.CourseName;
            txtDescription.Text = course.Description;
            txtPrice.Text = course.Price.ToString();
            dtStartDate.Value = course.StartDate;
            dtEndDate.Value = course.EndDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ManagerBLL bll = new ManagerBLL();
            if (dtStartDate.Value.CompareTo(dtEndDate.Value)<=0)
            {
                if (txtPrice.Text != "")
                {
                    Course newCourse = new Course()
                    {
                        CourseName = txtName.Text,
                        StartDate = dtStartDate.Value.Date,
                        EndDate = dtEndDate.Value.Date,
                        Description = txtDescription.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                        CourseActive = true
                    };
                    if (id == 0)
                    {
                        bll.AddCourseBLL(newCourse);
                        MessageBox.Show("Thêm thành công!");
                    }
                    // Trường hợp cập nhật ( tồn tại id != 0)
                    else
                    {
                        newCourse.Id = id;
                        if (bll.isExpiredCourseBLL(id)!=true)
                        {
                            bll.UpdateCourseBLL(newCourse);
                            MessageBox.Show("Cập nhật thành công!");
                        } 
                        else
                        {
                            MessageBox.Show("Khóa học đã hết hạn không thể thay đổi giá tiền. Cập nhật không thành công!");
                        }    
                        
                    }
                    Dispose();
                    // Trường hợp thêm 

                } else
                {
                    MessageBox.Show("Vui lòng nhập giá tiền!");
                }

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

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

namespace PBL3.View.Học_viên
{
    public partial class fDSHV : Form
    {
        public fDSHV(int Class_id)
        {
            InitializeComponent();
            setDGVDSHV(Class_id);
            DGVDSHV.Columns[0].HeaderText = "Mã học viên";
            DGVDSHV.Columns[1].HeaderText = "Tên học viên";
            DGVDSHV.Columns[2].HeaderText = "Ngày sinh";
            DGVDSHV.Columns[3].HeaderText = "Giới tính";
            DGVDSHV.Columns[4].HeaderText = "Số điện thoại";
            DGVDSHV.Columns[5].HeaderText = "Email";
        }
        public void setDGVDSHV (int Class_id)
        {
            var cl = new HVBLL().getClassByIdBLL(Class_id);
            txtLop.Text = cl.ClassName;
            DGVDSHV.DataSource = new HVBLL().getHVInfoByClassIdBLL(Class_id);   
        }

    }
}

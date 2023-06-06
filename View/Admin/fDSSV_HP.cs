using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
namespace PBL3.View.Admin
{
    public partial class fDSSV_HP : Form
    {
        private int id;
        private string name;
        private DateTime checkIn, checkOut;
        public fDSSV_HP(string courseName, int courseId, DateTime checkIn1, DateTime checkOut1)
        {
            InitializeComponent();
            id = courseId;
            name = courseName;
            checkIn = checkIn1;
            checkOut = checkOut1;
            setDGVDSHV_HP();
            DGVDSHV_HP.Columns[0].HeaderText = "Mã học viên";
            DGVDSHV_HP.Columns[1].HeaderText = "Tên học viên";
            DGVDSHV_HP.Columns[2].HeaderText = "Tên lớp học";
            DGVDSHV_HP.Columns[3].HeaderText = "Học phí";
            DGVDSHV_HP.Columns[4].HeaderText = "Thời gian nộp";
        }

        private void btnSearchDS_Click(object sender, EventArgs e)
        {
            DGVDSHV_HP.DataSource = new ManagerBLL().getAccoutByCourseIdBLL(id, checkIn, checkOut, cbbSortDS.SelectedIndex, txtSearchDS.Text);
            TKDT();
        }

        private void btnSortDS_Click(object sender, EventArgs e)
        {
            DGVDSHV_HP.DataSource = new ManagerBLL().getAccoutByCourseIdBLL(id, checkIn, checkOut, cbbSortDS.SelectedIndex,txtSearchDS.Text);
            TKDT();
        }

        public void setDGVDSHV_HP ()
        {
            txtKH.Text = name;
            txtKH.ReadOnly = true;  
            DGVDSHV_HP.DataSource = new ManagerBLL().getAccoutByCourseIdBLL(id,checkIn,checkOut, cbbSortDS.SelectedIndex, txtSearchDS.Text);
            TKDT();
        }
        public void TKDT()
        {
            DataGridViewRowCollection rows = DGVDSHV_HP.Rows;

            int sum = 0;
            foreach (DataGridViewRow row in rows)
            {
                string value = row.Cells["Price"].Value.ToString();
                sum += Convert.ToInt32(value);
            }
            txtTotal.Text = sum.ToString();
            txtTotal.ReadOnly = true;
        }

    }
}

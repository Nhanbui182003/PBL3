using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3.View.Giảng_viên;

namespace PBL3.View.Học_viên
{
    public partial class fTAILIEU : Form
    {
        public int classid;
        public fTAILIEU(int class_id)
        {
            classid= class_id;
            InitializeComponent();
            setDGVTL(class_id);
            DGVTL.Columns[0].HeaderText = "Mã tài liệu";
            DGVTL.Columns[1].HeaderText = "Tài liệu";
            DGVTL.Columns[2].HeaderText = "Ngày cập nhật";
        }
        public void setDGVTL(int class_id)
        {
            DGVTL.DataSource = new HVBLL().getDocumentByClassIdBLL(class_id);
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            if (DGVTL.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn một tệp để lưu");
            } 
           else
            {
                int fileId = Convert.ToInt32(DGVTL.SelectedRows[0].Cells[0].Value.ToString());
                fDocument doc = new fDocument(classid, fileId);
                doc.ShowDialog(); 
            }
        }
    }
}

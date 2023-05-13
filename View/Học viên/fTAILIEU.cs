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

namespace PBL3.View.Học_viên
{
    public partial class fTAILIEU : Form
    {
        public fTAILIEU(int class_id)
        {
            InitializeComponent();
            setDGVTL(class_id);
        }
        public void setDGVTL(int class_id)
        {
            HVBLL bll = new HVBLL();
            var li = bll.getDocumentByClassIdBLL(class_id);
            DGVTL.DataSource = li.Select(p => new { p.Id, p.FileName }).ToList();
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            int fileId = Convert.ToInt32(DGVTL.SelectedRows[0].Cells[0].Value.ToString());
            new HVBLL().downloadFile(fileId);
        }
    }
}

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
        }
        public void setDGVDSHV (int Class_id)
        {
            HVBLL bll = new HVBLL();
            var li = bll.getHVInfoByClassIdBLL(Class_id);
            var cl = bll.getClassByIdBLL(Class_id);

            txtLop.Text = cl.ClassName;
            DGVDSHV.DataSource = li.Select(p => new { p.AccountId, p.Name, p.Gender, p.Phone ,p.Email}).ToList();
        }

    }
}

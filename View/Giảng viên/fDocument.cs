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
using System.Xml.Linq;

namespace PBL3.View.Giảng_viên
{
    public partial class fDocument : Form
    {
        #region properties
        public int IdClass { get; set; }
        public int IdDocument { get; set; } 
        private BLL_Document bllDocument;
        private event EventHandler loadData;
        public event EventHandler LoadData
        {
            add { loadData += value; }
            remove { loadData -= value; }
        }
        #endregion
        public fDocument(int idClass, int idDocument)
        {
            InitializeComponent();
            IdClass = idClass; 
            IdDocument = idDocument;    
            bllDocument = new BLL_Document();   
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string filePath = tbxPath.Text;
            if(IdDocument== 0)
            {
                if (bllDocument.AddDocument(filePath, IdClass))
                {
                    MessageBox.Show("Thêm tài liệu thành công ");
                    if (loadData != null)
                    {
                        loadData(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm tài liệu thất bại!!!");
                }
            }
            else
            {
                string fileSave = filePath + "\\";
                if (bllDocument.DownloadDocument(IdDocument, IdClass, fileSave))
                {
                    MessageBox.Show("Tải tài liệu thành công ");
                }
                else
                {
                    MessageBox.Show("Tải tài liệu thất bại");
                }
            }
           
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

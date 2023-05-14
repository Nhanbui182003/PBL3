using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class BLL_Document
    {
        private DAL_Document dalDocument;
        public BLL_Document()
        {
            dalDocument = new DAL_Document();
        }
        public void LoadListDocument(DataGridView dg, int idClass)
        {
            dg.DataSource = dalDocument.GetAllDocument(idClass);

            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "IdDocument")
                {
                    column.HeaderText = "Mã tài liệu";
                }
                else if (column.Name == "FileName")
                {
                    column.HeaderText = "Tên tài liệu";
                }
                
            }
        }
        public bool AddDocument(string filePath, int IdClass)
        {
            try
            {
                dalDocument.AddDocument(filePath, IdClass);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool DownloadDocument(int idDocument,int  IdClass,string fileSave)
        {
            try
            {
                dalDocument.DownLoadDocument(idDocument, IdClass, fileSave);
                return true;

            }catch(Exception ex) {
                
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteDocuments( List<int> list)
        {
            try
            {
                dalDocument.DeleteListDocument(list);
                return true;
            }catch(DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
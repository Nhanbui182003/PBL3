using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PBL3.DAL
{
    public class DAL_Document
    {
        private DBEnglishCenterEntities db;
        public DAL_Document()
        {
            db = new DBEnglishCenterEntities(); 
        }
        public dynamic GetAllDocument(int idClass)
        {
            var ds = db.Documents.Where(s => s.ClassId == idClass ).Select(s => new {s.IdDocument, s.FileName}).ToList();   
            return ds;  
        }
        public void AddDocument(string filePath, int IdClass)
        {
            string fileName = Path.GetFileName(filePath);
            byte[] data = File.ReadAllBytes(filePath);
            var file = new Document { ClassId = IdClass, FileName = fileName, FileData = data };
            db.Documents.Add(file);
            db.SaveChanges();
        }
        public void DownLoadDocument(int idDocument, int  IdClass, string fileSave)
        {
            
            var file = db.Documents.Find(idDocument);
            if(file != null)
            {
                
                File.WriteAllBytes(Path.GetFullPath(fileSave + file.FileName), file.FileData);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file");
            }
        }
        public void DeleteListDocument( List<int> list)
        {
            foreach(int i in list)
            {
                Document file = db.Documents.Where(s => s.IdDocument == i).FirstOrDefault();
                db.Documents.Remove(file);
            }
            db.SaveChanges();
        }
    }
}

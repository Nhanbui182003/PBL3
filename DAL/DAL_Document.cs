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
            using(db = new DBEnglishCenterEntities()) {

                var ds = db.Documents.Where(s => s.ClassId == idClass).Select(s => new { s.Id, s.FileName, s.Filedate }).ToList();
                return ds;
            }
            
        }
        public void AddDocument(string filePath, int IdClass)
        {
            using(db = new DBEnglishCenterEntities())
            {
                string fileName = Path.GetFileName(filePath);
                byte[] data = File.ReadAllBytes(filePath);
                var file = new Document { ClassId = IdClass, FileName = fileName, FileData = data, Filedate = DateTime.Now };
                db.Documents.Add(file);
                db.SaveChanges();
            }
            
        }
        public void DownLoadDocument(int idDocument, int  IdClass, string fileSave)
        {
            using(db = new DBEnglishCenterEntities())
            {
                var file = db.Documents.Find(idDocument);
                if (file != null)
                {

                    File.WriteAllBytes(Path.GetFullPath(fileSave + file.FileName), file.FileData);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file");
                }
            }
            
        }
        public void DeleteListDocument( List<int> list)
        {
            using(db = new DBEnglishCenterEntities())
            {
                foreach (int i in list)
                {
                    Document file = db.Documents.Where(s => s.Id == i).FirstOrDefault();
                    db.Documents.Remove(file);
                }
                db.SaveChanges();
            }
            
        }
        public dynamic SortDocumentWithType(int IdClass,int type)
        {
            using(db = new DBEnglishCenterEntities())
            {
                List<Document> list = db.Documents.Where(s => s.ClassId == IdClass).ToList();
                switch (type)
                {
                    case 0:
                        list = list.OrderBy(s => s.Id).ToList();
                        break;
                    case 1:
                        list = list.OrderByDescending(s => s.Filedate).ToList();
                        break;
                    default:
                        break;

                }
                var ls = list.Select(s => new { s.Id, s.FileName, s.Filedate }).ToList();
                return ls;
            }
            
        }
    }
}

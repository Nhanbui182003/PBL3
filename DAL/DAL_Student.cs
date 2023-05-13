using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class DAL_Student
    {
        private DBEnglishCenterEntities db;
        public DAL_Student() { 
            db = new DBEnglishCenterEntities(); 
        
        }    
        public AccountInfo GetAccountInfoFromIdAccount(int id)
        {
            using(db = new DBEnglishCenterEntities()) {
                return db.AccountInfoes.Where(s => s.AccountId == id).FirstOrDefault();
            }
            
        }
        public LearningResult GetReslultOfStudent(int idStudent, int idClass)
        {
            using(db = new DBEnglishCenterEntities())
            {
                LearningResult lr = new LearningResult();
                lr = db.LearningResults.Where(s => s.AccountId == idStudent && s.ClassId == idClass).FirstOrDefault();
                return lr;
            }   
            

        }
        public void RatingStudent(int idStudent , int idClass, string assignment, string midtern, string final)
        {
            using(db = new DBEnglishCenterEntities())
            {
                LearningResult lr = new LearningResult();
                lr = db.LearningResults.Where(s => s.AccountId == idStudent && s.ClassId == idClass).FirstOrDefault();
                if (assignment != "")
                {
                    lr.AssignmentPoint = Convert.ToDouble(assignment);
                }
                else
                {
                    lr.AssignmentPoint = null;
                }
                if (midtern != "")
                {
                    lr.MidTermExamPoint = Convert.ToDouble(midtern);
                }
                else
                {
                    lr.MidTermExamPoint = null;
                }
                if (final != "")
                {
                    lr.FinalExamPoint = Convert.ToDouble(final);
                }
                else
                {
                    lr.FinalExamPoint = null;
                }
                db.SaveChanges();
            }
              
        }
        
    }
}

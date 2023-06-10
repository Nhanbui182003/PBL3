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
                return db.AccountInfoes.Where(s => s.AccountId == id && s.Account.AccountActive == true).FirstOrDefault();
            }
            
        }
        public LearningResult GetReslultOfStudent(int idStudent, int idClass)
        {
            using(db = new DBEnglishCenterEntities())
            {
                LearningResult lr = new LearningResult();
                lr = db.LearningResults.Where(s => s.AccountId == idStudent && s.ClassId == idClass && s.LearningResultActive == true).FirstOrDefault();
                return lr;
            }   
            

        }
        public void RatingStudent(int idStudent , int idClass, string assignment, string midtern, string final)
        {
            bool check = true;
            using(db = new DBEnglishCenterEntities())
            {
                LearningResult lr = new LearningResult();
                lr = db.LearningResults.Where(s => s.AccountId == idStudent && s.ClassId == idClass && s.LearningResultActive == true ).FirstOrDefault();
                if (assignment != "")
                {
                    lr.AssignmentPoint = Convert.ToDouble(assignment);
                    if(lr.AssignmentPoint < 0 || lr.AssignmentPoint > 10)
                    {
                        check = false;
                    }
                }
                else
                {
                    lr.AssignmentPoint = null;
                }
                if (midtern != "")
                {
                    lr.MidTermExamPoint = Convert.ToDouble(midtern);
                    if(lr.MidTermExamPoint <0 || lr.MidTermExamPoint > 10)
                    {
                        check = false;
                    }
                }
                else
                {
                    lr.MidTermExamPoint = null;
                }
                if (final != "")
                {
                    lr.FinalExamPoint = Convert.ToDouble(final);
                    if(lr.FinalExamPoint < 0 || lr.FinalExamPoint > 10)
                    {
                        check = false;
                    }
                }
                else
                {
                    lr.FinalExamPoint = null;
                }

                if(check)
                {
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Giá trị nằm trong khoảng từ 0 - 10");
                }
               
            }
              
        }
        
    }
}

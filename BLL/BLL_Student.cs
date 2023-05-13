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
    public class BLL_Student
    {
        private DAL_Student dalStudent;
        public BLL_Student() {
            dalStudent = new DAL_Student();
        }    
        public AccountInfo GetInfo(int id) {
            return dalStudent.GetAccountInfoFromIdAccount(id);
        }
        public LearningResult GetResult(int idStudent, int idClass)
        {
            return dalStudent.GetReslultOfStudent(idStudent, idClass);
        }
        public bool EditLearningResult(int idStudent, int idClass, string assignment, string midtern, string final)
        {
            try{
                dalStudent.RatingStudent(idStudent, idClass, assignment, midtern, final);
                return true;

            }catch(DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}

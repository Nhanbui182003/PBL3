using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    internal class HVBLL
    {
        // hoc vien 
        public List <AccountInfo>  setInfoBLL ( int mshv)
        {
            return new HVDAL().getInfoByMSHV(mshv);   
        }
        public void saveInfoBLL (string HT, string GT, string DC, string EM, string SDT, DateTime NS, int mshv)
        {
            HVDAL dal = new HVDAL();
            dal.saveInfoDAL(HT, GT, DC, EM, SDT, NS, mshv);
        }
        public int saveMKBLL(string UN, string MKC, string MKM, string check, int mshv)
        {
            int i = new HVDAL().saveMKDAL(UN, MKC, MKM, check, mshv);
            if (i == 1)
            {
                return 1;
            }
            else if (i == 2)
            {
                return 2;
            }
            else if (i == 3)
            {
                return 3;
            }
            else if (i == 4)
            {
                return 4;
            }
            return 1;
        }
        public dynamic getHVInfoByClassIdBLL(int Class_id)
        {
            return new HVDAL().getHVInfoByClassIdDAL(Class_id);
        }
        // class
        public dynamic getClassesByMSHVBLL (int mshv)
        {
            return new HVDAL().getClassesByMSHVDAL(mshv);    
        }
        public Class getClassByIdBLL (int Class_Id)
        {
            return new HVDAL().getCLassByIdDAL(Class_Id);
        }

        //calendar
        public List<Calendar> getCalendarBLL(int Class_Id)
        {
            return new HVDAL().getCalendarDAL(Class_Id);
        }

        public dynamic getCalendarInDayByMSHVBLL(int mshv, string dayOfWeek)
        {
            return new HVDAL().getCalendarInDayByMSHVDAL(mshv,dayOfWeek);
        }

        //course
        public Course getCourseByIdBLL (int Course_Id)
        {
            return new HVDAL().getCourseByIdDAL(Course_Id);   
        }

        //Gv
        public AccountInfo getGVInfoByClassIdBLL (int Class_Id)
        {
            return new HVDAL().getGVInfoByClassIdDAL(Class_Id);
        }

        //Ket qua
        public dynamic getLRByMSHVBLL (int mshv)
        {
            return new HVDAL().getLRByMSHVDAL(mshv);
        }
        //Hocphi
        public dynamic getBillByMSHV (int mshv)
        {
            return new HVDAL().getBillByMSHVDAL(mshv); 
        }
        public string getTotalBillBLL(int mshv, int index)
        {
            return new HVDAL().getTotalBillDAL(mshv,index);
        }
        // tai lieu
        public dynamic getDocumentByClassIdBLL (int classid)
        {
            return new HVDAL().getDocumentByClassIdDAL(classid);
        }
        
    }
}

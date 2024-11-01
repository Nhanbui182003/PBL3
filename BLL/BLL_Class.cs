﻿using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public  class BLL_Class
    {
        private DAL_Class DalClass;
        public BLL_Class()
        {
            DalClass= new DAL_Class();  
        }
        
        public void GetAllCourse(ComboBox cb)
        {
            cb.DataSource = DalClass.GetAllCourse();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
        }
        public void SearchClass(int idTeacher,int idCourse, string nameClass, DataGridView dg)
        {
            
            dg.DataSource = DalClass.SearchClass(idTeacher, idCourse, nameClass);
            dg.Columns[0].Width = (int)(dg.Width * 0.1);
            dg.Columns[1].Width = (int)(dg.Width * 0.2);
            dg.Columns[2].Width = (int)(dg.Width * 0.3);
            dg.Columns[3].Width = (int)(dg.Width * 0.2);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "Id")
                {
                    column.HeaderText = "Mã lớp";
                }
                else if (column.Name == "ClassName")
                {
                    column.HeaderText = "Tên lớp";
                }
                else if (column.Name == "MaxStudent")
                {
                    column.HeaderText = "Số Học viên tối đa";
                }
                else if (column.Name == "CourseName")
                {
                    column.HeaderText = "Tên khóa học";
                }

            }
            DataGridViewTextBoxColumn colSoThuTu = new DataGridViewTextBoxColumn();
            colSoThuTu.HeaderText = "Số thứ tự";
            colSoThuTu.Name = "colSoThuTu";
            if (dg.Columns[0].Name != "colSoThuTu")
            {
                dg.Columns.Insert(0, colSoThuTu);
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells["colSoThuTu"].Value = (i + 1).ToString();
            }

        }
        public AccountInfo GetInfo(int idTeacher)
        {
            AccountInfo info = new AccountInfo();
            info = DalClass.GetInfoTeacher(idTeacher);

            return info;
        }
        public bool EditInfo(int idTeacher, AccountInfo info)
        {
            try
            {
                DalClass.EditInfoTeacher(info, idTeacher);
                return true;
            }catch(DbUpdateException ex) {
                MessageBox.Show(ex.Message);
                return false;

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public Class GetClassFromId(int idClass)
        {
            Class cl = new Class();
            cl = DalClass.GetClassFromId(idClass);
            return cl;
        }
        public Course GetCourseFromIdClass(int idClass)
        {
            Course course = new Course();
            course = DalClass.GetCourseFromIdClass(idClass);
            return course;
        }
        public void GetListStudent(int idClass, DataGridView dg)
        {
            dg.DataSource = DalClass.GetStudentInClass(idClass);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "Id")
                {
                    column.HeaderText = "Mã học viên";
                }
                else if (column.Name == "Name")
                {
                    column.HeaderText = "Họ và tên";
                }
                else if (column.Name == "Birthday")
                {
                    column.HeaderText = "Ngày sinh";
                }
                else if (column.Name == "Gender")
                {
                    column.HeaderText = "Giới tính";
                }
                else if (column.Name == "AssignmentPoint")
                {
                    column.HeaderText = "Điểm bài tập";
                }
                else if (column.Name == "MidTermExamPoint")
                {
                    column.HeaderText = "Điểm giữa kì";
                }
                else if (column.Name == "FinalExamPoint")
                {
                    column.HeaderText = "Điểm cuối kì";
                }

            }
            DataGridViewTextBoxColumn colSoThuTu = new DataGridViewTextBoxColumn();
            colSoThuTu.HeaderText = "Số thứ tự";
            colSoThuTu.Name = "colSoThuTu";
            if (dg.Columns[0].Name != "colSoThuTu")
            {
                dg.Columns.Insert(0, colSoThuTu);
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells["colSoThuTu"].Value = (i + 1).ToString();
            }
        }
        public void SearchStudent(int idClass, DataGridView dg, string nameStudent)
        {
            dg.DataSource = DalClass.SearchStudentInClass(idClass, nameStudent);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "Id")
                {
                    column.HeaderText = "Mã học viên";
                }
                else if (column.Name == "Name")
                {
                    column.HeaderText = "Họ và tên";
                }
                else if (column.Name == "Birthday")
                {
                    column.HeaderText = "Ngày sinh";
                }
                else if (column.Name == "Gender")
                {
                    column.HeaderText = "Giới tính";
                }
                else if (column.Name == "AssignmentPoint")
                {
                    column.HeaderText = "Điểm bài tập";
                }
                else if (column.Name == "MidTermExamPoint")
                {
                    column.HeaderText = "Điểm giữa kì";
                }
                else if (column.Name == "FinalExamPoint")
                {
                    column.HeaderText = "Điểm cuối kì";
                }

            }
            DataGridViewTextBoxColumn colSoThuTu = new DataGridViewTextBoxColumn();
            colSoThuTu.HeaderText = "Số thứ tự";
            colSoThuTu.Name = "colSoThuTu";
            if (dg.Columns[0].Name != "colSoThuTu")
            {
                dg.Columns.Insert(0, colSoThuTu);
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells["colSoThuTu"].Value = (i + 1).ToString();
            }
        }
        public bool CheckTimeClass(int idclass)
        {
            return DalClass.CheckTimeClass( idclass);
        }
        public void SortStudent(DataGridView dg,int  IdClass, int type)
        {
            dg.DataSource = DalClass.SortStudentWithType(IdClass, type);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Name == "Id")
                {
                    column.HeaderText = "Mã học viên";
                }
                else if (column.Name == "Name")
                {
                    column.HeaderText = "Họ và tên";
                }
                else if (column.Name == "Birthday")
                {
                    column.HeaderText = "Ngày sinh";
                }
                else if (column.Name == "Gender")
                {
                    column.HeaderText = "Giới tính";
                }
                else if (column.Name == "AssignmentPoint")
                {
                    column.HeaderText = "Điểm bài tập";
                }
                else if (column.Name == "MidTermExamPoint")
                {
                    column.HeaderText = "Điểm giữa kì";
                }
                else if (column.Name == "FinalExamPoint")
                {
                    column.HeaderText = "Điểm cuối kì";
                }

            }
            DataGridViewTextBoxColumn colSoThuTu = new DataGridViewTextBoxColumn();
            colSoThuTu.HeaderText = "Số thứ tự";
            colSoThuTu.Name = "colSoThuTu";
            if (dg.Columns[0].Name != "colSoThuTu")
            {
                dg.Columns.Insert(0, colSoThuTu);
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells["colSoThuTu"].Value = (i + 1).ToString();
            }

        }
    }
}

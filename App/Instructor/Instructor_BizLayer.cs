using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Instructor_BizLayer
    {
        public static DataTable GetTeach_Courses(string LoginName)
        {
            return DB_Layer.Select(new SqlCommand($"select c.crs_name as Name,c.crs_duration as Duration from course c, Instructor i, Ins_Course ic " +
                $"where i.username = '{LoginName}' and i.ins_id = ic.ins_id and c.crs_id = ic.crs_id"));
        }

        public static DataTable GetStudent_Course(string crs_name,string LoginName)
        {
            return DB_Layer.Select(new SqlCommand($"select s.St_Fname +' '+s.St_Lname as [Student Name] " +
                $"from Course c, Student s, Instructor i, Stud_Course sc, Ins_Course ic " +
                $"where c.Crs_Name = '{crs_name}' and c.Crs_Id = sc.Crs_Id and sc.St_Id = s.St_Id " +
                $"and i.username = '{LoginName}' and i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id"));
        }

        public static DataTable Get_Instructor(string LoginName)
        {
            return DB_Layer.Select(new SqlCommand($"select Ins_Name as Name,Ins_Degree as Degree,password from Instructor where username = '{LoginName}'"));
        }

        public static int Edit_Instructor(string name,string degree,string pass,string LoginName)
        {
            return DB_Layer.Dml(new SqlCommand($"UPDATE Instructor " +
                $"SET ins_name = '{name}', ins_degree = '{degree}', password = '{pass}' " +
                $"where username = '{LoginName}'"));
        }
    }
}

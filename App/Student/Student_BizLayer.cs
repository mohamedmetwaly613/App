using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Student_BizLayer
    {
        public static DataTable Getall_Course()
        {
            return DB_Layer.Select(new SqlCommand("select crs_name as Name,crs_duration as Duration from course"));
        }

        public static DataTable GetTaken_Course(string LoginName)
        {
            return DB_Layer.Select(new SqlCommand($"select c.crs_name as Name,c.crs_duration as Duration from course c, student s, Stud_Course sc where s.username = '{LoginName}' and s.st_id = sc.st_id and c.crs_id = sc.crs_id"));
        }

        public static DataTable Getall_Topic()
        {
            return DB_Layer.Select(new SqlCommand("select * from topic"));
        }

        public static DataTable GetFilter_Course(int id)
        {
            return DB_Layer.Select(new SqlCommand($"select crs_name as Name,crs_duration as Duration from course where top_id={id}"));
        }

        public static DataTable Get_course_ins(string name)
        {
            return DB_Layer.Select(new SqlCommand($"select i.Ins_Name as [Instructor Name] from Instructor i, Ins_Course ic, Course c " +
                $"where i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id and c.Crs_Name = '{name}'"));
        }
        
        public static DataTable Add_Course()
        {
            return DB_Layer.Select(new SqlCommand("select crs_id , crs_name from course"));
        }

        public static int Getst_id(string LoginName)
        {
            DataTable results = DB_Layer.Select(new SqlCommand($"select st_id from student where username = '{LoginName}'"));
            return int.Parse(results.Rows[0][0].ToString());
        }

        public static int Add_Course(int crs_id, int st_id)
        {
            return DB_Layer.Dml(new SqlCommand($"insert into Stud_Course (crs_id,st_id) values({crs_id},{st_id})"));
        }
    }
}
using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Course_BizLayer
    {
        public static DataTable Getall_Course()
        {
            return DB_Layer.Select(new SqlCommand("select c.crs_id,c.crs_name,c.crs_duration,t.top_name from course c , topic t where c.top_id=t.top_id"));
        }

        //insert

        public static int Add_Course(int id, string name, int duration, int top_id)
        {
            return DB_Layer.Dml(new SqlCommand($"insert into course values({id},'{name}',{duration},{top_id})"));
        }

        //update

        public static int Update_Course(int id, string name, int duration, int top_id)
        {
            return DB_Layer.Dml(new SqlCommand($"update course set crs_name='{name}' ,crs_duration={duration},top_id={top_id}  where crs_id={id}"));
        }

        //delete

        public static int Delete_Course(int id)
        {
            return DB_Layer.Dml(new SqlCommand("delete from course where crs_id=" + id));
        }
    }
}

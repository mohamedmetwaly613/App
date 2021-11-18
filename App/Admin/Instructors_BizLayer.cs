using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Instructors_BizLayer
    {
        public static DataTable Getall_Instructor()
        {
            return DB_Layer.Select(new SqlCommand("select i.ins_id,i.ins_name,i.ins_degree,i.salary,d.dept_name,i.username,i.password from Instructor i,department d where i.dept_id=d.dept_id"));
        }

        public static DataTable Getall_Department()
        {
            return DB_Layer.Select(new SqlCommand("select dept_id,dept_name from department"));
        }
        //insert

        public static int Add_Instructor(int id, string name, string degree, float salary,
            int dept_id, string username, string password)
        {
            return DB_Layer.Dml(new SqlCommand($"insert into Instructor values({id},'{name}','{degree}',{salary},{dept_id},'{username}','{password}')"));
        }

        //delete

        public static int Delete_Instructor(int id)
        {
            return DB_Layer.Dml(new SqlCommand("delete from Instructor where ins_id=" + id));
        }
    }
}

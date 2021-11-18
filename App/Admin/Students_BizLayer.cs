using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Students_BizLayer
    {
        public static DataTable Getall_Student()
        {
            return DB_Layer.Select(new SqlCommand("select s.st_id,s.st_fname,s.st_lname,s.st_address,s.st_age,d.dept_name,s.st_super,s.username,s.password from student s,department d where s.dept_id=d.dept_id"));
        }

        public static DataTable Getall_Department()
        {
            return DB_Layer.Select(new SqlCommand("select dept_id,dept_name from department"));
        }
        //insert

        public static int Add_Student(int id,string fname,string lname,string address,int age,
            int dept_id,int super,string username,string password)
        {
            return DB_Layer.Dml(new SqlCommand($"insert into Student values({id},'{fname}','{lname}','{address}'" +
                $",{age},{dept_id},{super},'{username}','{password}')"));
        }

        //delete

        public static int Delete_Student(int id)
        {
            return DB_Layer.Dml(new SqlCommand("delete from Student where st_id=" + id));
        }
    }
}

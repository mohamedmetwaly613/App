using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Login_BizLayer
    {
        public static DataTable Getall_LoginAdmin(string username,string password)
        {
            return DB_Layer.Select(new SqlCommand($"select username,password from admin where username= '{username}' and password = '{password}'"));
        }

        public static DataTable Getall_LoginInstructor(string username, string password)
        {
            return DB_Layer.Select(new SqlCommand($"select username,password from Instructor where username= '{username}' and password = '{password}'"));
        }

        public static DataTable Getall_LoginStudent(string username, string password)
        {
            return DB_Layer.Select(new SqlCommand($"select username,password from student where username= '{username}' and password = '{password}'"));
        }
    }
}

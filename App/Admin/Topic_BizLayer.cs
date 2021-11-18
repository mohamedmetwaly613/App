using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Topic_BizLayer
    {
        public static DataTable Getall_Topic()
        {
            return DB_Layer.Select(new SqlCommand("select * from topic"));
        }

        //insert

        public static int Add_Topic(int id, string name)
        {
            return DB_Layer.Dml(new SqlCommand($"insert into topic values({id},'{name}')"));
        }

        //update

        public static int Update_Topic(int id, string name)
        {
            return DB_Layer.Dml(new SqlCommand($"update topic set top_name='{name}' where top_id={id}"));
        }

        //delete

        public static int Delete_Topic(int id)
        {
            return DB_Layer.Dml(new SqlCommand("delete from topic where top_id=" + id));
        }
    }
}

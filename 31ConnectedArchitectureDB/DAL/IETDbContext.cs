
using _31ConnectedArchitectureDB.Model;
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitectureDB.DAL
{
    public class IETDbContext
    {
        string conStr = @"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True; ";
        List<Emp> emps = new List<Emp>();

        public List<Emp> SelectRecords()
        {
            SqlConnection con = new SqlConnection(conStr);
            string SelectQuery = "select * from Emp";
            SqlCommand command = new SqlCommand(SelectQuery, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                emps.Add(new Emp()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()
                }

                    );
            }
            con.Close();

            return emps;
        }

        public int InsertRecords(Emp emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"insert into Emp values({emp.Id},'{emp.Name}','{emp.Address}')";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowsAffected;
        }

        public int UpdateRecords(Emp emp) {
            SqlConnection con = new SqlConnection(conStr);
            string updateQuery = $"update Emp set Name='{emp.Name}', Address = '{emp.Address}' where Id = {emp.Id}";             
            SqlCommand cmd = new SqlCommand(updateQuery, con);  
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();   
            con.Close();
            return rowsAffected;
        }

        internal int DeleteRecords(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            string DeleteQuery = $"delete from Emp where Id = {id}";
            SqlCommand cmd = new SqlCommand(DeleteQuery,con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close() ;
            return rowAffected;
        }
    }
}
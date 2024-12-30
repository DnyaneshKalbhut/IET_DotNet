using _13ConntedInMVC.Models;
using Microsoft.Data.SqlClient;

namespace _13ConntedInMVC.DAL
{
    public class IETDbContext
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";

        public List<Emp> SelectRecords() { 
        List<Emp> employees = new List<Emp>();
        SqlConnection con = new SqlConnection(constr);
        string selectQuery = "select * from Emp";
        SqlCommand cmd = new SqlCommand(selectQuery, con);
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.Id = Convert.ToInt32(reader["ID"]);
                emp.Name = reader["Name"].ToString();
                emp.Address = reader["Address"].ToString();
                employees.Add(emp);
            }
            con.Close();
            return employees;
        }
    }
}

using System.Data;
using Microsoft.Data.SqlClient;

namespace _33ConnectedWithDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            
            DataColumn col1 = new DataColumn("Id",typeof(int));
            DataColumn col2 = new DataColumn("Name",typeof(string));
            DataColumn col3 = new DataColumn("Address",typeof(string));

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.PrimaryKey = new DataColumn[] { col1 };

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from Emp",con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                DataRow row = dt.NewRow();
                row["Id"] = Convert.ToInt32(rd["Id"]);
                row["Name"] = rd["Name"].ToString();
                row["Address"] = rd["Address"].ToString();
                dt.Rows.Add(row);
            }

            con.Close();
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\240845920024\DotNet\EmpData.xml");

        }
    }
}

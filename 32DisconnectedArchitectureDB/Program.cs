using System.Data;
using Microsoft.Data.SqlClient;

namespace _32DisconnectedArchitectureDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True; ";
            SqlConnection con = new SqlConnection(conStr);

            #region Select Query

            string selectquery = "select * from Emp";
            SqlDataAdapter da = new SqlDataAdapter(selectquery, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Address: {row["Address"]}");
            }

            #endregion


            #region Insert Query

            //Console.WriteLine("Enter ID of New Employee");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name of New Employee");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Adress of New Employee");
            //string address = Console.ReadLine();

            ////DataTable dt = new DataTable();
            //DataRow dr = dt.NewRow();
            //dr["Id"] = id;
            //dr["Name"] = name;
            //dr["Address"] = address;

            //dt.Rows.Add(dr);
            //da.Update(dt);
            #endregion


            #region Update
            //Console.WriteLine("Enter Id");
            //int  id = Convert.ToInt32(Console.ReadLine());
            //DataRow emptoBeEdited = dt.Rows.Find(id);

            //Console.WriteLine("Enter name");
            //emptoBeEdited["Name"] = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //emptoBeEdited["Address"] = Console.ReadLine();

            //da.Update(dt);

            #endregion


            #region delete
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            DataRow? emptoDeleted = dt.Rows.Find(id);

        
            emptoDeleted.Delete();

            da.Update(dt); 
            #endregion

        }
    }
}

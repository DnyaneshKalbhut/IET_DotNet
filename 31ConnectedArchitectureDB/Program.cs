using _31ConnectedArchitectureDB.DAL;
using _31ConnectedArchitectureDB.Model;
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitectureDB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                IETDbContext dbContext = new IETDbContext();
                int noOfRowAffected = 0;
                Console.WriteLine("Enter your choice 1.Select 2.Insert 3.Update 4.Delete");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:

                        List<Emp> emplst = dbContext.SelectRecords();
                        foreach (var emp in emplst)
                        {
                            Console.WriteLine($"id is {emp.Id} name is {emp.Name} Address is {emp.Address}");
                        }
                        break;
                    case 2:
                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter ID of New Employee");
                        empToBeInserted.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name of New Employee");
                        empToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Adress of New Employee");
                        empToBeInserted.Address = Console.ReadLine();
                        noOfRowAffected = dbContext.InsertRecords(empToBeInserted);
                        break;
                    case 3:
                        Emp empToBeUpdated = new Emp();
                        Console.WriteLine("Enter Id:");
                        empToBeUpdated.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        empToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empToBeUpdated.Address = Console.ReadLine();
                        noOfRowAffected = dbContext.UpdateRecords(empToBeUpdated);
                        if (noOfRowAffected > 0)
                        {
                            Console.WriteLine("Records updated in DB successfully");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Enter ID of Employee To Delete");
                        int id = Convert.ToInt32(Console.ReadLine());

                        noOfRowAffected = dbContext.DeleteRecords(id);
                        if (noOfRowAffected > 0)
                        {
                            Console.WriteLine("Records deleted from DB successfully");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}
using System.Security.Cryptography;


namespace _30LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> employees = new List<Emp>() {
            new Emp() { Id = 11, Name = "Ganesh", Address = "Pune" },
                new Emp() { Id = 12, Name = "Gajanan", Address = "Punjab" },
                new Emp() { Id = 13, Name = "Divyansh", Address = "Mumbai" },
                new Emp() { Id = 14, Name = "Anup", Address = "Pune" },
                new Emp() { Id = 15, Name = "Deepali", Address = "Patna" },
                new Emp() { Id = 16, Name = "Aman", Address = "Manipur" },
                new Emp() { Id = 17, Name = "Gunjan", Address = "Pune" },
                new Emp() { Id = 18, Name = "Abhiraj", Address = "Indore" },
                new Emp() { Id = 19, Name = "Aishwarya", Address = "Kolhapur" }

            };

            #region normal foreach
            //Console.WriteLine("Enter city to search Employee");
            //string city = Console.ReadLine();

            //Console.WriteLine($"Emp Found in the {city} city are -->");
            //foreach (Emp emp in employees)
            //{
            //    if (emp.Address.ToLower() == city)
            //    {
            //        Console.WriteLine($"Employee Name : {emp.Name} , ID : {emp.Id} , Address: {emp.Address}");
            //    }
            //} 
            #endregion


            #region using LINQ basic
            //IEnumerable<Emp> filteredCollection = (from emp in employees select emp);

            //foreach (var emp in filteredCollection)
            //{
            //    Console.WriteLine(emp.Id+" "+emp.Name +" "+emp.Address);
            //}

            //Console.WriteLine("Enter a city name");
            //string city=Console.ReadLine();
            //IEnumerable<Emp> filteredCollection = (from emp in employees where emp.Address.ToLower() == city select emp);

            //foreach (var emp in filteredCollection)
            //{
            //    Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Address);
            //} 
            #endregion


            #region Delayed ,differed, Lazing Loading of LINQ 
            //Console.WriteLine("Enter city to search Employee");
            //string city = Console.ReadLine();

            //IEnumerable<Emp> filteredCollection = (from emp in employees
            //                                       where emp.Address.ToLower() == city
            //                                       select emp);
            //employees.Add(new Emp() { Id = 20, Name = "Amit", Address = "Pune" });
            //employees.Add(new Emp() { Id = 21, Name = "Neha", Address = "Kolhapur" });

            //foreach (Emp emp in filteredCollection)
            //{
            //    Console.WriteLine($"Employee Name : {emp.Name} , Id: {emp.Id} , Address : {emp.Address}");
            //} 
            #endregion


            #region Eager LINQ Filteration
            //Console.WriteLine("Enter city name");
            //string? city = Console.ReadLine();

            //var filteredCollection = (from emp in employees where emp.Address.ToLower() == city select emp).ToList();
            //employees.Add(new Emp() { Id = 20, Name = "Amit", Address = "Pune" });
            //employees.Add(new Emp() { Id = 21, Name = "Neha", Address = "Kolhapur" });
            //foreach (var emp in filteredCollection)
            //{
            //    Console.WriteLine($"Id= {emp.Id} name = {emp.Name} address = {emp.Address}");

            //} 
            #endregion


            #region LINQ filteration based on multiple return values 

            //Console.WriteLine("Enter city name");
            //string? city = Console.ReadLine();

            //var filterCollection = (from emp in employees
            //                        where emp.Address.ToLower() == city
            //                        select new Holder() { Hname = emp.Name, Hid = emp.Id,Haddress=emp.Address}).ToList();

            //foreach (Holder obj in filterCollection)
            //{
            //    Console.WriteLine($"Name = {obj.Hname}, Address = {obj.Haddress}");
            //}
            #endregion


            Console.WriteLine("Enter name of city :");
            string? city = Console.ReadLine();

            var FilteredCollection = (from emp in employees
                                      where emp.Address.ToLower() == city.ToLower()
                                      select new { nm = emp.Name, addr = emp.Address }).ToList();

            foreach (var emp in FilteredCollection)
            {
                Console.WriteLine($"emp name {emp.nm} address = {emp.addr} ");
            }


        }
    }

    public class Holder 
    { 
        public int Hid { get; set; }
        public string Hname { get; set; }

        public string Haddress { get; set; }
    }
    public class Emp {
    
        public int Id { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }


    }

}

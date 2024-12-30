namespace _06Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do { 
            Console.WriteLine("Select a server 1.SQLServer 2.Oracle 3.MySQL");
            int choice = Convert.ToInt32(Console.ReadLine());
            DatabaseFactory databaseFactory = new DatabaseFactory();
            IDatabase somedb = databaseFactory.getSomeDatabase(choice);

            Console.WriteLine("Select Operation want to perform ");
            Console.WriteLine("1.Insert 2.Update 3.Delete");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    somedb.Insert();
                    break;

                case 2:
                    somedb.Update();
                    break;

                case 3:
                    somedb.Delete();
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            }while (true);

        }
    }






    public interface IDatabase
    {
        void Delete();
        void Insert();
        void Update();
    }

    public class DatabaseFactory
    {
        public IDatabase getSomeDatabase(int choice)
        {
            IDatabase somedatabase = null;

            switch (choice)
            {
                case 1:
                    somedatabase = new SQLServer();
                    break;
                case 2:
                    somedatabase = new Oracle();
                    break;
                case 3:
                    somedatabase = new MySQL();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            return somedatabase;
        }




        public class MySQL : IDatabase
        {
            public void Delete()
            {
                Console.WriteLine("Delete done in my sql");
            }

            public void Insert()
            {
                Console.WriteLine("Insert done in mysql ");

            }

            public void Update()
            {
                Console.WriteLine("Updation done in mysql");
            }
        }
        public class SQLServer : IDatabase
        {
            public void Delete()
            {
                Console.WriteLine("Delete done in my SQLServer");
            }

            public void Insert()
            {
                Console.WriteLine("Insert done in SQLServer ");

            }

            public void Update()
            {
                Console.WriteLine("Updation done in SQLServer");
            }
        }
        public class Oracle : IDatabase
        {
            public void Delete()
            {
                Console.WriteLine("Delete done in my Oracle");
            }

            public void Insert()
            {
                Console.WriteLine("Insert done in Oracle ");

            }

            public void Update()
            {
                Console.WriteLine("Updation done in Oracle");
            }
        }
    }

}
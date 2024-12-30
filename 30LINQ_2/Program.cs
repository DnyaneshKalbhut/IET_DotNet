namespace _30LINQ_2
{
    internal class Program
    {

        public delegate bool MyDelegate(int i);
        static void Main(string[] args)
        {
            List<Emp> employees = new List<Emp>() {
                new Emp(){Id = 11, Name="Ganesh", Address="Pune"},
                new Emp(){Id = 12, Name="Gajanan", Address="Punjab"},
                new Emp(){Id = 13, Name="Divyansh", Address="Mumbai"},
                new Emp(){Id = 14, Name="Anup", Address="Pune"},
                new Emp(){Id = 15, Name="Deepali", Address="Patna"},
                new Emp(){Id = 16, Name="Aman", Address="Manipur"},
                new Emp(){Id = 17, Name="Gunjan", Address="Pune"},
                new Emp(){Id = 18, Name="Abhiraj", Address="Indore"},
                new Emp(){Id = 19, Name="Aishwarya", Address="Kolhapur"}
            };

            MyDelegate pointer = new MyDelegate(ConditionalCheck);



        }
        public static bool ConditionalCheck(Emp emp, string city)
        {
            return emp.Address.ToLower()==city.ToLower();
        }

        public static List<Emp> MyWhere(List<Emp> emps,)


    }


    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}

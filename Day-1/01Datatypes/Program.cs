namespace _01Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i.ToString());
            string str = "Dnyanesh";
            Console.WriteLine(str);
            bool b = true;
            if (b)
            {
                Console.WriteLine("its true");
            }
            Console.WriteLine("Enter Number 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int Addition = x + y;
            Console.WriteLine("Addition is " + Addition.ToString());

        }
    }
}

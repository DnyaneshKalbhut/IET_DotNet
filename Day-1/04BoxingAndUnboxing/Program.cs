namespace _04BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            string str = num.ToString();//boxing
            Console.WriteLine(str);

            int num1 = Convert.ToInt32(str);//unboxing
            Console.WriteLine(num1);

            double d1 = 12.12;


            Object obj = new Object();
            obj = num; //boxing
            obj = str; // type casting
            obj = d1; // boxing

            double d2 = Convert.ToDouble(obj);

            Console.WriteLine(d2);
            
        }
    }
}

namespace _15GenricCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int p = 10;
            int q = 12;
            Console.WriteLine("before swapping" + p + " " + q);
            swap(ref p, ref q);
            Console.WriteLine("after swapping" + p + " " + q);

            //Genric classs
            CMath<int> obj = new CMath<int>();
            int a = 10, b = 20;

            Console.WriteLine("Before Swap : P ={0} , Q = {1}", a, b);
            obj.Swap(ref a, ref b);
            Console.WriteLine("After Swap : P ={0} , Q = {1}", a, b);

        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
        public class CMath<T> //Generic Class
        {
            public void Swap(ref T x, ref T y) //Generic Method
            {
                T temp;
                temp = x;
                x = y;
                y = temp;
            }
      
           
            public void Calculate(T x, T y, out T sum, out T product)
            {
                //dynamic type gets defination at runtime by CLR
                dynamic para1 = x;
                dynamic para2 = y;

                sum = para1 + para2;
                product = para1 * para2;
            }
        }
    }
}
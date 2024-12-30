using 16MyLib;
namespace _17HostMyLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(10, 20);
            MyClass obj2 = new MyClass();
            obj2.Add(100, 200);
            obj2.WrapperMEthodForBase();
        }
    }
    public class MyClass : Program
    {
        public void WrapperMEthodForBase()
        {
            base.Mult(4, 4);
            base.Div(15, 5);
        }
    }
}

namespace _07Interface2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Cmath cmath = new Cmath(); // not work

            IX xob = new CMath();
            xob.Add(22, 13);
            xob.Sub(323, 42);
            IY yob = new CMath();
            yob.Add(221, 312);
            yob.Mul(213, 324);





            #region Implicit way
            CMath cMath = new CMath();
            cMath.Add(1, 2);
            cMath.Sub(2, 3);
            cMath.Mul(4, 5);

            IX x = new CMath();
            x.Add(1, 2);
            x.Sub(2, 3);

            IY y = new CMath();
            y.Add(23, 12);
            y.Mul(12, 21); 
            #endregion

        }
    }


    public interface IX
    {
        void Add(int x, int y);
        void Sub(int x, int y);
    }

    public interface IY
    {
        void Add(int x, int y);
        void Mul(int x, int y);
    }


    public class Cmath : IX, IY
    {
        void IX.Add(int x, int y)
        {
            throw new NotImplementedException();
        }

        void IY.Add(int x, int y)
        {
            throw new NotImplementedException();
        }

        void IY.Mul(int x, int y)
        {
            throw new NotImplementedException();
        }

        void IX.Sub(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    public class CMath : IX, IY  //implicit way
    {
        public void Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Add : " + result);
        }

        public void Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Sub : " + result);
        }


        public void Mul(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Mul : " + result);
        }


    }


}

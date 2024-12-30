namespace _02Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region ForLoop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i.ToString());

            //} 
            //#endregion
            
            int a=0;

            //#region DoWhile
            //do
            //{

            //    Console.WriteLine(a);
            //    a++;

            //}
            //while (a != 10);
            //#endregion

            Console.WriteLine("Enter 1 number");
            int num = Convert.ToInt32(Console.ReadLine());

            #region IfElse

            if (num > 10)
            {

                Console.WriteLine("Its greater than 10");
                if (num % 2 == 0)
                {

                    Console.WriteLine("Its even also");

                }
            }
            else
            {
                Console.WriteLine("its smaller than 10");
            } 
            #endregion

        }
    }
}
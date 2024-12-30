namespace _03ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try Catch Finally
            try
            {
                Console.WriteLine("ENter Numerator");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENter  Denominator");
                int den = Convert.ToInt32(Console.ReadLine());
                int result = num / den;
                Console.WriteLine("Divison Result is " + result.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("In Finally Block");
                Console.WriteLine("End of Exception HAndling");
            } 
            #endregion
        }
    }
}

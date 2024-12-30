using _22CompanyInfoLib;
namespace _23DemoLib
{
    [Serializable]
    [Company(CompanyName = "BROS", DeveloperName = "Vikram")]
    public class Demo
    {
        public void SayHi()
        {
            Console.WriteLine("Hello...");
        }
    }
}
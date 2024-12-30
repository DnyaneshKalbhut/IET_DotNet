namespace _10Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Console.WriteLine("enter emp id");
            e1.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emp name");
            e1.EName = Console.ReadLine();
            Console.WriteLine("enter dept");
            e1.Dept=Console.ReadLine();
            string result = string.Format("EMPLOYEE ID = {0} , NAME = {1} , DEPT = {2}",e1.EmpId,e1.EName,e1.Dept);
            Console.WriteLine(result);
        }
    }

    public class Emp
    {
        private int _Id;
        private string _Ename;
        private string _Dept;

        public string Dept
        {
            get
            {
                //_Dept = "HR";
                return _Dept;
            }
            set
            {
                _Dept = value;
            }
        }


        public int EmpId
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public string EName
        {
            get {
                //_Ename = "Vikram";    
                return _Ename; 
            }
            set { _Ename = value; }
        }

    }
}

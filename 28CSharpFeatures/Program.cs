using System.Collections;

namespace _28CSharpFeatures
{

    public delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region partial classes
            //CMath obj = new CMath();
            //Console.WriteLine($"Add ={obj.Add(155, 120)} ");
            //Console.WriteLine($"Sub ={obj.Sub(33, 22)} ");
            //obj.SayHi(); 
            #endregion


            #region Nullable
            //int? i = null;
            //Console.WriteLine(i);
            //Nullable<int> j = null;

            //if (i == null)
            //{
            //    Console.WriteLine("I has Null Value");
            //}
            //else
            //{
            //    Console.WriteLine($"value of i is {i}");
            //} 

            //Employee employee = new Employee();
            //employee.Eid = 10;
            //employee.Ename = "vikram";
            //employee.Edept = null;
            //string str = $"ID = {employee.Eid} name = {employee.Ename} dept = {employee.Edept}null";
            //Console.WriteLine(str);
            #endregion


            #region Anonymous methods
            //Normal method to call
            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //bool status =check(a);
            //if (status == true) {
            //    Console.WriteLine("no is greater ");
            //}
            //else
            //{
            //    Console.WriteLine("No lesser");
            //}


            //delegate 
            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //MyDelegate del = new MyDelegate(check);

            //bool status = del(a);
            //if (status == true)
            //{
            //    Console.WriteLine("num is greater ");
            //}
            //else
            //{
            //    Console.WriteLine("Num lesser");
            //}

            //MyDelegate del2 = delegate (int a)
            //{
            //    return a > 10;
            //};
            //bool status1 = del2(a);
            //if (status1 == true)
            //{
            //    Console.WriteLine("num is greater ");
            //}
            //else
            //{
            //    Console.WriteLine("Num lesser");
            //} 
            #endregion


            #region Lambada Expression
            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //MyDelegate del = (a) =>
            //{
            //    return a > 10;
            //};

            //MyDelegate del2 = i => i > 10;

            //bool status = del2(a);
            //if (status == true)
            //{
            //    Console.WriteLine("Number is greater ");
            //}
            //else
            //{
            //    Console.WriteLine("Number is lesser");
            //}

            #endregion


            #region Predicate Delegate
            //Predicate<int> pred = i => i > 10;
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool result = pred(input);

            //Console.WriteLine($"{input} is greater : {result}"); 
            #endregion


            #region Iterator

            //int[] numbers = { 1,2,3,4,5};
            //ArrayList lst = new ArrayList();
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    lst.Add(numbers[i]);
            //}
            //foreach (int i in lst)
            //{
            //    Console.WriteLine(i);
            //}

            //Week day = new Week();
            //foreach (string item in day)
            //{
            //    Console.WriteLine("Today is "+item);
            //}

            #endregion


            #region ImplicitWay
            //var q = 10;
            //Console.WriteLine(q.GetType().ToString());

            //Console.WriteLine("enter choice");
            //var choice = Convert.ToInt32(Console.ReadLine());
            //var result = GetMeSomething(choice);
            //if (result is bool)
            //    Console.WriteLine("result is of type {0}", result.GetType().ToString());
            //if (result is Employee)
            //    Console.WriteLine("result is of type {0}", result.GetType().ToString()); 
            #endregion


            #region Anonymous Types
            //var v1 = new { Eid = 10, Ename = "Vikram" };
            //Console.WriteLine(v1.GetType().ToString());
            //string output1 = $"EMPLOYEE ID = {v1.Eid} , Name={v1.Ename}";
            //Console.WriteLine(output1);

            //var v2 = new { Eid = 20, Ename = "Dnynash", Edept = "Support" };
            //Console.WriteLine(v2.GetType().ToString());
            //string output2 = $"EMPLOYEE ID = {v2.Eid} , Name={v2.Ename} , Dept = {v2.Edept}";
            //Console.WriteLine(output2); 
            #endregion

            #region Extension method
            // int [] arr = { 1, 2, 3, 4, 5 };
            // Console.WriteLine(arr.Max());

            // string mail = "asd@gmail.com";

            //bool status= mail.CheckForValidEmail();
            // if (status)
            // {
            //     Console.WriteLine("valid user");
            // }
            // else
            // {
            //     Console.WriteLine("INVALID");
            // } 
            #endregion

            

        }

     
        public static bool check(int num)
        {
            return num > 10 ? true : false;
        }

        public static object GetMeSomething(int choice)
        {
            if(choice == 0)
            {
                return true;
            }
            else
            {
                return new Employee(10,"Dk","IT");
            }
        }
    }
    public static class checkMail
    {

        public static bool CheckForValidEmail(this string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Employee
    {
        public int Eid { set; get; }
        public string Ename { set; get; }

        public string? Edept { set; get; }

        public Employee(int id, string name, string dept)
        {
            Eid = id;
              Ename = name;
            Edept = dept;
        }

        
    }

    public class Week : IEnumerable {
        private string[] days = new string[] { "monday", "tuesday","wednesday","thusday","friday","saturaday","sunday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            { 
                string day = days[i];
                yield return day;
            }
        }
    }
}

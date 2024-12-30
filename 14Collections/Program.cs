using System.Collections;

namespace _14Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            #region EMP ARRAY
            Emp eobj = new Emp();
            eobj.Eid = 1;
            eobj.Ename = "Dk";
            eobj.Dept = "Dev";

            Emp eobj1 = new Emp();
            eobj1.Eid = 2;
            eobj1.Ename = "VG";
            eobj1.Dept = "Tester";

            Emp eobj2 = new Emp();
            eobj2.Eid = 3;
            eobj2.Ename = "TP";
            eobj2.Dept = "HR";

            Emp eobj3 = new Emp();
            eobj3.Eid = 4;
            eobj3.Ename = "Mosq";
            eobj3.Dept = "das";

            Emp[] earr = new Emp[4];
            earr[0] = eobj;
            earr[1] = eobj1;
            earr[2] = eobj2;
            earr[3] = eobj3;

            //foreach (var item in earr)
            //{
            //    string empstr = string.Format($"empid {item.Eid} empname = {item.Ename} empdept : {item.Dept} ");
            //    Console.WriteLine(empstr);
            //} 
            #endregion
            #region objectArray

            //Object[] obj = new object[4];
            //obj[0] = 10; 
            //obj[1] = 20.12;
            //obj[2] = "Dnyanesh";
            //obj[3]=eobj;

            //foreach (var item in obj)
            //{

            //    if(item is int)
            //    {
            //        int i = Convert.ToInt32(item);
            //        Console.WriteLine(i.ToString());
            //    }

            //    if (item is double){

            //        double d = Convert.ToDouble(item);  
            //        Console.WriteLine(d.ToString());

            //    }

            //    if (item is string)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    if (item is Emp)
            //    {
            //        Emp emp = item as Emp;
            //        string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
            //        emp.Eid, emp.Ename, emp.Dept);
            //        Console.WriteLine(result);
            //    }
            //}

            #endregion

            ArrayList arr = new ArrayList();
            arr.Add(132);
            arr.Add("Vikram");
            arr.Add(eobj2);
            arr.Add(22.22);

            foreach (var item in arr) 
            {
                if (item is int)
                {
                    int i = Convert.ToInt32(item);
                    Console.WriteLine(i.ToString());
                }

                if (item is double)
                {

                    double d = Convert.ToDouble(item);
                    Console.WriteLine(d.ToString());

                }

                if (item is string)
                {
                    Console.WriteLine(item);
                }
                if (item is Emp)
                {
                    Emp emp = item as Emp;
                    string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
                    emp.Eid, emp.Ename, emp.Dept);
                    Console.WriteLine(result);
                }
            }

            #region hashtable

            Hashtable ht = new Hashtable();
            ht.Add(1, 110);
            ht.Add(2, "abc");
            ht.Add(3, eobj1);
            ht.Add(4, 12.32);
            foreach (var key in ht.Keys)
            {
                //Console.WriteLine(ht[key]);
                if (ht[key] is int)
                {
                    int i = Convert.ToInt32(ht[key]);
                    Console.WriteLine("Key ={0}, Value = {1}", key, i);
                }
                if (ht[key] is string)
                {
                    string str = Convert.ToString(ht[key]);
                    Console.WriteLine("Key ={0}, Value = {1}", key, str);
                }
                if (ht[key] is double)
                {
                    double d = Convert.ToDouble(ht[key]);
                    Console.WriteLine("Key ={0}, Value = {1}", key, d);
                }
                if (ht[key] is Emp)
                {
                    Emp emp = ht[key] as Emp;
                    string result = string.Format(" [Id = {0}, Name = {1}, dept = {2}]",
                            emp.Eid, emp.Ename, emp.Dept);
                    Console.WriteLine("Key ={0}, Value = {1}", key, result);
                }
            } 
            #endregion

            #region stack
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            } 
            #endregion

            #region queue

            Queue queue = new Queue();
            queue.Enqueue(1210);
            queue.Enqueue(203);
            queue.Enqueue(3012);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            #endregion



            var boy = Display(100, "Dk", "Pulgaon");
            Console.WriteLine(boy);
            Console.WriteLine(boy.nm);
        }
        public static (int Id, string nm, string add) Display(int id, string name, string Address)
        {
            int Id = id;
            string nm = name;
            string add = Address;
            return (Id, nm, add);
        }
    }
    }

    public class Emp
    {
        private int _Eid;
        private string _Ename;
        private string _Dept;

        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
        }

        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }

        public int Eid
        {
            get { return _Eid; }
            set { _Eid = value; }
        }



    }
}

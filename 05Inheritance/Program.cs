namespace _05Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student(1, "Vikram", 99);
            //s.DisplayDetails();

            //Parent p = new Parent();
            //p.show();

            //Child ch = new Parent(); //not work

            Parent p = new Child();
            p.show();

            //Child p = new Child();
            //p.show();

            AdvAdd add = new AdvAdd();
            Console.WriteLine( add.Addition(1, 2, 3));
        }
    }

    public class Person
    {
        protected int id;
        protected string name;

        public Person()
        {
            id = 0;
            name = "";
        }
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ID of Person : " + id);
            Console.WriteLine("Name of Person : " + name);
        }
    }

    public class Student : Person
    {
        private int mark;
        public Student()
        {
            mark = 0;
        }

        public Student(int id, string name, int mark) : base(id, name)
        {
            this.mark = mark;
        }

        // new Keywork --> 
        public new void DisplayDetails()
        {
            Console.WriteLine("ID of Student : " + id.ToString());
            Console.WriteLine("Name of Student : " + name);
            Console.WriteLine("Mark of Student : " + mark.ToString());
        }
    }


    //public sealed class  Parent this class cant be inherited
    public  class Parent

    {
        public Parent()
        {

        }
        public  void show()
        {
            Console.WriteLine("in parent show method");
        }
    }

    public class Child : Parent
    {
        public Child()
        {
        }

        public  void show()
        {
            Console.WriteLine("in child show method");
        }
    }



    public class Add
    {
      private  int a;
       private int b;

        public int Addition(int a, int b) {
            return a + b;
        }
    }

    public class AdvAdd : Add
    {
        private int c;

        public int Addition(int a , int b , int c) {
            return base.Addition(a, b) + c;  //Wrapper method
        }
    }

}

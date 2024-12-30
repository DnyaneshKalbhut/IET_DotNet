using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using System.Net;
namespace _18FileIOSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region read and write FO
            string filepath = "C:\\240845920024\\DotNet\\Data.txt";
            FileStream fs = null;
            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine("Hello duniya");
                writer.Flush();
                writer.Close();
                fs.Close();
            }
            else if (!File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine("Hello duniya");
                writer.Flush();
                writer.Close();
                fs.Close();
            }
            Console.WriteLine("Done");

            StreamReader reader = new StreamReader(filepath);
            string output = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(output);
        }
        #endregion

        #region binaryformatter
        //string filePath = "C:\\240845920024\\DotNet\\Data.txt";
        //FileStream fs = null;
        //if (File.Exists(filePath))
        //{
        //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
        //}
        //else
        //{
        //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        //}
        //Emp emp = new Emp();
        //Console.WriteLine("Enter Emp Id ");
        //emp.Id = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Emp name");
        //emp.Name = Convert.ToString(Console.ReadLine());
        //Console.WriteLine("Enter employee address");
        //emp.Address = Convert.ToString(Console.ReadLine());

        //BinaryFormatter bf = new BinaryFormatter();
        //bf.Serialize(fs, emp);

        //fs.Close();
        //Console.WriteLine("Done !"); 
        #endregion

        #region Deserializer
        //string filePath = "C:\\240845920024\\DotNet\\Data.txt";
        //FileStream fs = null;
        //if (File.Exists(filePath))
        //{
        //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //}
        //else
        //{
        //    Console.WriteLine("File Does not exist....");
        //}
        ////Pen
        //BinaryFormatter bf = new BinaryFormatter();
        //Emp emp = bf.Deserialize(fs) as Emp;
        //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

        //fs.Close(); 
        #endregion


        //if (File.Exists(filePath))
        //{
        //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
        //}
        //else
        //{
        //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        //}
        //Emp emp = new Emp();
        //Console.WriteLine("Enter Emp Id");
        //emp.Id = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Emp Name");
        //emp.Name = Console.ReadLine();
        //Console.WriteLine("Enter Emp Address");
        //emp.Address = Console.ReadLine();

        //JsonSerializer.Serialize(fs, emp);

        //fs.Close();
        //Console.WriteLine("Done !");

        //if (File.Exists(filePath))
        //{
        //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //}
        //else
        //{
        //    Console.WriteLine("File Does not exist....");
        //}
        ////Pen
        //Emp emp = JsonSerializer.Deserialize<Emp>(fs);
        //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

        //fs.Close();

        //string filePath = "C:\\240845920024\\DotNet\\data.xml";
        //    FileStream fs = null;

        //    if (File.Exists(filePath))
        //    {
        //        fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);

        //    }
        //    else {
        //        fs = new FileStream(filePath,FileMode.Create, FileAccess.Write);
        //    }

        //    Emp emp = new Emp();
        //    Console.WriteLine("Enter Emp Id ");
        //    emp.Id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Emp name");
        //    emp.Name = Convert.ToString(Console.ReadLine());
        //    Console.WriteLine("Enter employee address");
        //    emp.Address = Convert.ToString(Console.ReadLine());

        //    Book book = new Book();
        //    book.BookName = "Hello World";

        //    ArrayList arr = new ArrayList();
        //    arr.Add(emp);
        //    arr.Add(book);

        //    Type[] types = new Type[arr.Count];
        //    types[0] = typeof(Emp);
        //    types[1] = typeof(Book);
        //    XmlSerializer xs = new XmlSerializer(typeof(ArrayList));
        //    xs.Serialize(fs, arr);
        //    fs.Close ();
        //    Console.WriteLine("Done");


        //}
    }

    [Serializable]
    public class Emp
    {
        private int _EId;
        private string _EName;
        //[NonSerialized]
        private string _EAddress;

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

    }


    public class Book
    {
        private string _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }

    }




}
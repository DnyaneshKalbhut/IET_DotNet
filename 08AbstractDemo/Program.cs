using System.Net.Sockets;

namespace _08AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Tell us what do you want: 1.PDF, 2.DOCX,3.Text,4.XML");
                int choice = Convert.ToInt32(Console.ReadLine());

                ReportFactory reportFactory = new ReportFactory();

                IReport somrep = reportFactory.GetSomeReport(choice);
                somrep.GenrateReport();

                Console.WriteLine("DO you want to continue? y/n");
                string ynChoice = Console.ReadLine();

                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }


     
    public interface IReport
    {
        void GenrateReport();
    }
    public abstract class Report : IReport
    {
        protected abstract void parse();
        protected abstract void valid();
        protected abstract void save();

        public virtual void GenrateReport()
        {
            parse();
            valid();
            save();
        }
    }
    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();

        public override void GenrateReport()
        {
            parse();
            valid();
            ReValidate();
            save();
        }
    }
    public class ReportFactory
    {

        public Report GetSomeReport(int choice)
        {
            Report report = null;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("dsdas");
                    report = new PDF();
                    break;

                case 2:
                    report = new Docx();
                    break;

                case 3:
                    report = new Text();
                    break;
                
                case 4:
                    report = new XML();
                    break;

                default:
                    report = null;
                    break;
            }

            return report;
        }

    }

 


    public class PDF : Report
    {
        protected override void parse()
        {
            Console.WriteLine("PDF parsed");
        }


        protected override void save()
        {
            Console.WriteLine("PDF saved");
        }


        protected override void valid()
        {
            Console.WriteLine("PDF valid");
        }
    }
    public class Docx : Report
    {
        protected override void parse()
        {
            Console.WriteLine("Docx parse");
        }


        protected override void save()
        {
            Console.WriteLine("Docx saved");
        }



        protected override void valid()
        {
            Console.WriteLine("Docx valid");
        }
    }

    public class Text : Report
    {
        protected override void parse()
        {
            Console.WriteLine("Text parse");
        }
        protected override void valid()
        {
            Console.WriteLine("Text valid");
        }
        protected override void save()
        {
            Console.WriteLine("text saved");
        }

    }

    public class XML : SpecialReport
    {
        protected override void parse()
        {
            Console.WriteLine("XML parse");
        }

        protected override void valid()
        {
            Console.WriteLine("XML valid");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("Revalid XML");
        }

        protected override void save()
        {
            Console.WriteLine("XML Save");
        }

    }

}


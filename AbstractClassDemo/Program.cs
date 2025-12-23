using System.Xml.Schema;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Old code 
            //PDF pdf = new PDF();
            //pdf.GenerateReport();
            ////pdf.ParsePDF();
            ////pdf.SavePDF();// do not allow this to happen
            ////pdf.ValidatePDF();
            //DOCX docx = new DOCX();
            //docx.Parse();
            //docx.Save();
            ////docx.Validate();
            //docx.GenerateReport(); 
            #endregion

            while (true)
            {
                //select what type of document to generate
                Console.WriteLine("Enter your report choice: 1. PDF  2. XML  3. JSON  4. EXCEL  5. DOCX");
                int choice = Convert.ToInt32(Console.ReadLine());

                //create factory object
                ReportFactory factory = new ReportFactory();
                //create report object of type Report(GetSomeReport) which return object according to choice(someReport)
                Report report = factory.GetSomeReport(choice);
                report.GenerateReport();                          //call GenerateReport() method of Report

                Console.WriteLine("do you want to generate another report? (y/n)");
                string ynChoice = Console.ReadLine();

                if (ynChoice.ToLower() == "y")
                {
                    Main(args); //recursive call to Main to generate another report
                }
                else
                {
                    Console.WriteLine("Thank you for using the report generator!");
                    break;
                }
            }
    }

    public abstract class Report
    {
        protected abstract void Parse();

        protected abstract void Validate();

        protected abstract void Save();

        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report generated successfully.");
        }
    }

    //This is a middle-man. It inherits from Report but adds a new requirement: ReValidate().
    public abstract class SpecialReport : Report
    {
        //extra method
        //only added to direct sub-classes
        protected abstract void Revalidate();

        //It changes the workflow for special formats (XML and JSON) to include that extra validation step.
        public override void GenerateReport()
        {
            Parse();
            Validate();
            Revalidate();
            Save();
            Console.WriteLine("Special Report generated");
        }
    }

    public class ReportFactory
    {
        //creates an object of the Abstract class according to choice (pdf, xml etc.)
        //return someReport;: It sends the specific object back to the main program.
        ////This keeps the main program "clean"—it doesn't need to know how to create PDFs or XMLs; it just asks the factory.
        public Report GetSomeReport(int choice)
        {
            Report someReport = null;
            switch (choice)
            {
                case 1:
                    someReport = new PDF();
                    break;
                case 2:
                    someReport = new XML();
                    break;
                case 3:
                    someReport = new JSON();
                    break;
                case 4:
                    someReport = new EXCEL();
                    break;
                case 5:
                    someReport = new DOCX();
                    break;

            }
            return someReport;
        }
    }

    public class PDF() : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF validated");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF saved");
        }
    }

    public class XML() : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("XML parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("XML validated");
        }
        protected override void Save()
        {
            Console.WriteLine("XML saved");
        }
        protected override void Revalidate()
        {
            Console.WriteLine("XML re-validated");
        }
    }

    public class JSON() : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("JSON parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("JSON validated");
        }
        protected override void Save()
        {
            Console.WriteLine("JSON saved");
        }
        protected override void Revalidate()
        {
            Console.WriteLine("JSON re-validated");
        }
    }

    public class EXCEL() : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("EXCEL parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("EXCEL validated");
        }
        protected override void Save()
        {
            Console.WriteLine("EXCEL saved");
        }
    }

    public class DOCX() : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX saved");
        }
    }
}
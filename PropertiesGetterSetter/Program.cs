namespace PropertiesGetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeee = new Employee();
            //employeee.SetEmpId = 101;
            //int id = employeee.GetEmpId;
            //Console.WriteLine($"Employee id= {id}");
        }
    }

    public class Employee
    {
        public int _EmpId;
        public string _EmpName;


        #region Generate SETTER/GETTER methods
        // Generate SETTER/GETTER methods
        /*
        public int SetEmpId
        {
            set { _EmpId = value; }
        }

        public int GetEmpId
        {
            get { return _EmpId; }
        }
        */
        #endregion

    }

}

using InheritanceDemo01.logic;

namespace InheritanceDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Person demo
            Person p =new Person();
            p.fname = "John";
            p.lname = "Cena";

            Console.WriteLine(p);   //Fully qualified name ---> InheritanceDemo01.logic.Person
            Console.WriteLine("Person name= {0} {1}", p.fname, p.lname);
            #endregion

            #region Employee demo
            Employee e = new Employee();
            e.emp_id = 101;

            Console.WriteLine(e);   //Fully qualified name ---> InheritanceDemo01.logic.Employee
            Console.WriteLine("Emploee details= {0} {1} {2}", e.emp_id, p.fname, p.lname);
            #endregion
        }
    }
}

using System.Security.Cryptography;

namespace InheritanceDemo02
{ 

    internal class Person
{
    private int id;
        private string name;

        public Person()
    {
        Console.WriteLine("in default constructor of person");
    }

    public Person(int id)
    {
        Console.WriteLine("in Id constructor of Person");
        this.id = id;
        Console.WriteLine("id= {0}", id);
    }

        public Person(int id, string name) : this(id)
        {
            Console.WriteLine("using THIS");
            Console.WriteLine("in Id and Name constructor of Person"); 
            this.name = name;
            Console.WriteLine("id= {0}, name={1}", id, name);
        }

        //public static void Main(string[] args)
        //{
        //    Person p = new Person();
        //    Person p1 = new Person(101);
        //    Person p2 = new Person(501, "Rajan" );

        //    Console.WriteLine("object 1={0}", p);
        //    Console.WriteLine("object 2={0}", p1);
        //    Console.WriteLine("object 2={0}", p2);
        //}

    }

    internal class Student : Person
    {
        private int age;
        private string school;

        public Student()
        {
            Console.WriteLine("in default constructor of derived class");
        }
        public Student(int id) : base(id)
        {
            Console.WriteLine("using BASE");
            Console.WriteLine("student id= {0}", id);
        }

        public Student(int id, string name, int age) : base(id,name)
        {
            Console.WriteLine("using BASE");
            Console.WriteLine("student id= {0}, name= {1}", id, school);
        }

        public Student(int id, string name, int age, string school) : base(id,name)
        {
            Console.WriteLine("using BASE ");
            Console.WriteLine("student id= {0}, name= {1}, age= {2}, school= {3}", id, name, age, school);
        }
    }

}

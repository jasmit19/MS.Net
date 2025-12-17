using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //Person p1 = new Person(101);
            //Person p2 = new Person(102, "Jayant");

            //Student s = new Student();
            //Student s1 = new Student(501);
            //Student s2 = new Student(502, "Pranay", 21);
            //Student S3 = new Student(503, "Vishal", 22, "Pallotti");


            //Console.WriteLine("p= {0}", p);
            //Console.WriteLine("p1= {0}", p1);
            //Console.WriteLine("p2= {0}", p2 );

            //Console.WriteLine("s= {0}", s);
            //Console.WriteLine("s1= {0}", s1);
            //Console.WriteLine("s2= {0}", s2);

            //C c=new C();
            //string s=c.ToString();
            //Console.WriteLine("data= {0}",s);

            //C c1 = new C(101, "harsh", "sales", 19);
            //string s1=c1.ToString();
            //Console.WriteLine(s1);

            NewCal cal= new NewCal();
            //cal.Add(2, 3);
            cal.Add(1, 2, 3, 4);
            //cal.mul(2, 3);
            //cal.sub(2, 3);

            Console.WriteLine("method() overloading addition= {0}", cal.Add(2, 3, 4));
            Console.WriteLine("method() overriding multiplication= {0}", cal.mul(2,3));
            Console.WriteLine("method() shadowing subtraction= {0}", cal.sub(2,3));
            //Console.WriteLine("add= {0}", cal.Add(1, 2, 3, 4));
        }
    }
}

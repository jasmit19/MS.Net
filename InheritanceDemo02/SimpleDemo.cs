using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo02
{
    internal class A
    {
        private int id;
        private string name;
        public A()
        {
            Console.WriteLine("in constructor of A");
        }

        public A(int id)
        {
            this.id = id;
            Console.WriteLine("in ID constructor of A");
        }

        public A(int id, string name) : this(id)
        {
            Console.WriteLine("in constructor of A using THIS");
        }

    }

    internal class B : A
    {
        private string job;
        public B() : base()
        {
            Console.WriteLine("in constructor of B");
        }

       public B(int id, String name, string job) : base(id,name)
        {
            Console.WriteLine("in constructor of B using BASE");
        }
    }

    internal class C : B
    {
        private int age;
        public C() : base()
        {
            Console.WriteLine("in constructor of C");
        }

        public C(int id, string name, string job, int age) : base(id, name, job)
        {
            Console.WriteLine("in constructor of C using BASE");
            Console.WriteLine("id= {0}, name= {1}, job= {2}, age= {3}",id,name,job,age);
        }
     }
}

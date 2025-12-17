using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo02
{
    internal class Cal
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        //method() overloading within same Class
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        //shadow in derived class
        public int sub(int a, int b)
        {
            return a - b;
        }

        //override in derived class
        public virtual int mul(int a, int b)
        {
            return a * b;
        }
    }

    internal class NewCal : Cal
    {
        // Shadowing the base class method
        public new int sub(int a, int b)
        {
            return a - b;
        }

        // Overriding the base class method
        public override int mul(int x, int b)
        {
            return x * b;
        }



        //method() overloading in child Class
        // Method overloading within across the inherited class
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        //overloading
        public void Add(int a, int b, int c, int d)
        {
            Console.WriteLine("method() overloading addition= {0}",a + b + c + d);
        }
    }
}

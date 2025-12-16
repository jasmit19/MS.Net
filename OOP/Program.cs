using One;
//using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fully Qualified Name
            System.Int32 a = 1;
            System.Int32 b = 2;

            Int32 p = 101;
            Int32 q = 102;

            int x = 201;
            int y = 202;
            
            Console.WriteLine("a={0}, b={1}, p={2}, q={3}, x={4}, y={5}", a, b, p, q, x, y);
            #endregion

            MyClass obj =new MyClass();
            obj.GetMessage();

            //Explicitly calling a class by its'spackage name
            One.MyClass01 obj1=new One.MyClass01();
            obj1.GetMessage();

            MyClass01 obj2= new MyClass01();
            obj2.GetMessage();
        }
    }
}

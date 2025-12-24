namespace DelegatesDemo
{

    //Delegates
    public delegate void VoidDelegate();

    public delegate void StringDelegate(string str);

    public delegate int SqDelegate(int x);

    public delegate int AddDelegate(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            //first way to call a method()      ----> static method() called
            sayHi();
            SaySomething(".Net Practical lab");

            //second way to call method()       ----> by creating class objects
            MyClass c1=new MyClass();
            c1.SayHello();

            //third way to call method()        ----> (via Delegate)
            VoidDelegate del1 = new VoidDelegate(Program.sayHi);
            del1.Invoke();
            MyClass c2 = new MyClass();
            VoidDelegate del2 = new VoidDelegate(c2.SayHello);
            del2.Invoke();


            //Delegate with parameter:
            StringDelegate del3 = new StringDelegate(c1.Greet);
            del3.Invoke("MORNING....");

            Cal cal = new Cal();
            AddDelegate del4 = new AddDelegate(cal.Add);
            Console.WriteLine($"addition = {del4.Invoke(13, 45)}");

            SqDelegate del5 = new SqDelegate(cal.Square);
            del5.Invoke(12);
            Console.WriteLine($"square = {del5.Invoke(19)}");


        }

        static void sayHi()
        {
            Console.WriteLine("HII from Static Pune");
        }

        static void SaySomething(string str)
        {
            Console.WriteLine($"Hello, i am doing {str}");
        }
    }

    public class Cal
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Square(int x)
        {
            return x * x;
        }
    }

    public class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("HI from MyClass Nagpur");
        }

        public void Greet(string str)
        {
            Console.WriteLine($"good {str}!!!");
        }
    }
}

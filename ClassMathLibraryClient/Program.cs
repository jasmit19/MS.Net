using ClassMathLib;

namespace ClassMathLibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AdvMath amath = new AdvMath();
            amath.AdvWrappermethod();

            MyMath mymath = new MyMath();
            mymath.MyWrapperMethod();
        }
    }
    public class MyMath : CMath
    {
        public void MyWrapperMethod()
        {
            base.Add(2, 3);     // PUBLIC
            //base.Sub();       // PRIVATE method(), can't be accessed
            base.Mult(2, 3);    // PROTECTED method(), available inside and outside the assembly if in Derived Class
            //base.Div(2, 3);   // INTERNAL method(), available only in same assembly (not out)
            base.Square(2);     // PROTECTED INTERNAL METHOD(), available bcoz we took thereference of parent assesmbly
            
            Console.WriteLine("Addition= {0}, Multiplication= {1}, Square= {2}", base.Add(2, 3), base.Mult(10, 5), base.Square(7));

        }
    }
}

namespace ClassMathLib
{
    public class CMath
    {
        // Public : available/ accessible within assembly and outside the assembly
        public int Add(int x, int y)
        {
            return x + y;
        }

        // Private : accessible only with the same class/ module
        private int Sub(int x, int y) 
        { 
            return x - y; 
        }

        // Protected : Available with the assembly and outside the assembly : if :
        // accessible with the heirarchy of inheritace/ derived classes
        protected int Mult(int x, int y)
        {
            return x * y;
        }

        // Internal : only available with the same assembly
        internal int Div(int x, int y)
        {
            return x / y;
        }

        // Protected - internal : only available with the same assembly and within the heirarchy
        protected internal int Square(int x)
        {
            return x * x;
        }
    }


    public class AdvMath : CMath        // within the same assembly
    {
        public void AdvWrappermethod()
        {
            base.Add(1, 2);         // public
            //base.Sub(5, 4);       // PRIVATE method() not accessible out of the class
            base.Mult(10, 5);       // protected 
            base.Div(40, 8);        // internal - available only in same assembly
            base.Square(7);         // protcted - internal

            Console.WriteLine("Addition= {0}, Multiplication= {1}, Division= {2}, Square= {3}", base.Add(2, 3), base.Mult(10, 5), base.Div(40, 8), base.Square(7));
        }
    }
}

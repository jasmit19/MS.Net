namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public sealed class CMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    public class AdvancedMath // : CMath
    {
        // The 'CMath' object is being wrapped inside this class
        public int WrapperAdd(int x, int y)
        {
            CMath cmath = new CMath();
            return cmath.Add(x, y);
        }
        public virtual int square(int x)
        {
            return x * x;
        }
    }
    public class MyMath1 : AdvancedMath
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi from MyMath1");
        }
        public sealed override int square(int y)
        {
            //return y * y * y; // Cubing instead of squaring
            // implentation c
            return y * y;
        }
    }
    public class MyMath2 : MyMath1
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi from MyMath2");
        }

        //public override int square(int a)
        //{
        //    return a * a;
        //}
    }
}

using System.Globalization;
using System.Security.Cryptography;

namespace Generic
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            CMath cmath = new CMath();
            #region Without Template Swap Method Code
            //Console.WriteLine("enter the value of a");
            //string str1 = Console.ReadLine();

            //Console.WriteLine("enter the value of b");
            //string str2 = Console.ReadLine();

            //string str1 = "Hello";
            //string str2 = "Bye";
            //CMath cmath = new CMath();
            //cmath.Swap(ref str1, ref str2);
            //Console.WriteLine($"after swapping : str1={str1}, str2={str2}");

            //    Console.WriteLine("enter the value of a");
            //    int a= Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("enter the value of b");  
            //    int b=Convert.ToInt32(Console.ReadLine());

            //int a = 12;
            //int b = 7;
            //cmath.swap(ref a, ref b);
            //Console.WriteLine($"after swapping : a={a}, b={b}");
            #endregion

            #region With Template Swap() Method Code
            //int a = 12;
            //int b = 7;
            //CMath cmath = new CMath();
            //cmath.swap(ref a, ref b);
            //Console.WriteLine($"after swapping : a={a}, b={b}");
            #endregion

            #region Public overloaded Demo() Methods of CMath class (not Demo class)
            //cmath.Demo<int, string, double, bool>(12, "Amigos", 65.77, true);
            double result = cmath.Demo<int, string, double, bool>(100, "Hugh JAckman", 23.33, true);
            Console.WriteLine(result);

            char result1 = cmath.Demo<int, string, double, bool, char>(200, "Chris Hemsworth", 45.55, false, 'A');
            Console.WriteLine(result1);


            #endregion

            #region Dynamic Type
            Console.WriteLine(cmath.Add<int>(24,687));
            Console.WriteLine(cmath.Add<string>("Hello ","World"));
            Console.WriteLine(cmath.Add<double>(23.45, 67.89));
            #endregion

            #region 'out' Parameter
            double area, circum = 0;
            double radius = 10;
            cmath.CalculateCircle(radius, out area, out circum);
            Console.WriteLine($"Area of circle: {area} and Circumference of circle: {circum}");
            #endregion

            #region Generic Class With Generic() and Non- Generic() MEthods
            GenClass<string> gen = new GenClass<string>();
            gen.SayHello("Hello Generic Class");            // Generic Methods()
            //gen.DoubleTheNum(25);                         // Non- Generic Methods()
            Console.WriteLine("Double of 25 is: " + gen.DoubleTheNum(25));
            #endregion

            #region 'params' Keyword
            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            Demo demo = new Demo();
            demo.Add(numbers);

            demo.PlayerNames("Alice", "Bob");
            demo.PlayerNames(0, "Charlie", "David", "Eve", "Frank");
            #endregion

        }

    }
    public class GenClass<T>
    {
        public void SayHello(T msg)
        {
            Console.WriteLine(msg);
        }

        public int DoubleTheNum(int num)
        {
            return num * 2;
        }
    }
   
    public class Demo
    {
        public void Add(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of array elements: {sum}");
        }

        public void PlayerNames(int x, params string[] names)
        {
            string output = "Player Names: ";
            for(int i=0; i<names.Length; i++)
            {
                output += names[i] + " ";
            }
            Console.WriteLine(output);
        }

        public void PlayerNames(string p1, string p2)
        {
            string output = string.Format("Player 1: {0}, Player 2: {1}", p1, p2);
            Console.WriteLine(output);
            Console.WriteLine("Player 1: {0}, Player 2: {1}", p1, p2);
        }
    }

    public class CMath
    {
        public T Add<T>(T a, T b)
        {
            dynamic para1 = a;
            dynamic para2 = b;
            dynamic sum = para1 + para2;
            return sum;
        }

        public void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
            //Console.WriteLine($"x: {x}, y: {y}");   
        }

        public void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public R Demo<P, Q, R, S>(P a, Q b, R c, S d)
        {
            return c;
        }

        public T5 Demo<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return e;
        }

        public void CalculateCircle(double radius, out double area, out double circum)
        {
            area = radius * radius * 22 / 7;
            circum = 2 * 22 / 7 * radius;
        }
    }
}
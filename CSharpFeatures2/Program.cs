using System;

namespace CSharpFeatures2
{
    internal class Program
    {
        public delegate bool MyDelegate(int num);
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32 (Console.ReadLine());

            #region MOST BASIC AND COMMON WAY (NOT EFFICIENT)
            //if(check(num))
            //{
            //    Console.WriteLine($" {num} is greater than 10");
            //}
            //else {
            //    Console.WriteLine($" {num} is not greater than 10");
            //}
            #endregion

            #region calling function in IF-Loop via storing in a variable  ----> Normal Function Call for Check Method :
            //var result = check(num);
            //if (result)
            //{
            //    Console.WriteLine($" {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($" {num} is not greater than 10");
            //}
            #endregion

            #region Check Method Call with MyDelegate :
            //MyDelegate del1 = new MyDelegate(check);
            //var result = del1(num);
            //if (result)
            //{
            //    Console.WriteLine($" {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($" {num} is not greater than 10");
            //}
            #endregion

            #region Anonymous Methods() with MyDelegate and Delegate keywords :

            // ANONYMOUS Methods(): Methods without name, local methods, 
            // short scope - cannot be used elsewhere in the application
            // used for short  purposes, like conditional CHECK or HOLDER

            #region TYPE-1
            MyDelegate del1 = new MyDelegate(delegate (int num)
                                            {
                                                return num > 10;
                                            });
            #endregion

            #region TYPE-2
            MyDelegate del2 = delegate (int num)
                                            {
                                                return num > 10;
                                            };
            #endregion

            // Lamabada Expression : => goes to operator:

            #region TYPE-3
            MyDelegate del3 = (int num) =>
                                {
                                    return (num > 10);
                                };
            #endregion

            #region TYPE-4 
            MyDelegate del4 = num => num > 10;
            #endregion


            // Predicate is a built-in DataType that represents a method which takes a single input parameter
            // and return a Boolean (True/False)
            //it is commonly used to define conditions for filtering, searching, and valditing data in Collections

            #region TYPE-5 (Predicate)
            Predicate<int> del5 = num => num > 10;
            #endregion


            //if (del5(num))
            //{
            //    Console.WriteLine($" {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($" {num} is not greater than 10");
            //}
            #endregion

            #region In-built Sum Extension Methods and normal MySum methods()
            int[] arr = new int[] { 1, 5, 2, 3 };
            var result1 = arr.Sum();
            Console.WriteLine($"Sum1: {result1}");


            var result2 = MySum(arr);
            Console.WriteLine($"Sum2: {result2}");


            string[] names = new string[] { "Hugh", "John", "Tom" };
            var result3 = MySum(names);
            Console.WriteLine($"Sum3: {result3}");
            #endregion

            #region Regular valid email id checking code : 

            //without 'this' keyword
            //Console.WriteLine("enter Email ID: ");
            //string email = Console.ReadLine();     

            //if(email != null)
            //{
            //    if(CheckForValidEmailID(email))         //giver COMPILER ERROR
            //    {
            //        Console.WriteLine("Valid Email ID");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Email ID");
            //    }
            //}
            #endregion

            #region Extension MEthods: Demo 01
            // Extending in-built Data Types functionalities by writting specific classes using below Rules:
            // To create Extension menthod:
            // 1. Declare a static class
            // 2. Declare a static method
            // 3. Write 'this' keyword in front of that paramaeter which datatype functionality you want to extend!
            // 4. Please NOTE: 'this' should always be a first parameter to the method.
            // 5. We can pass other parametrs after this paarameter.


            // with 'this' keyword
            //Console.WriteLine("enter Email ID: ");
            //string email = Console.ReadLine();          // '?'  --->  can be null   ---> accepts nullable

            //if (email != null)
            //{
            //    if (MyClass.CheckForValidEmailID(email))         //called by class name since STATIC
            //    {
            //        Console.WriteLine("Valid Email ID");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Email ID");
            //    }
            //}
            #endregion

            #region Extension MEthods: Demo 02
            int[] numbers = { 101, 102, 103, 104, 105 };
            string[] days = { "Mon", "Tue", "Wed", "Sun" };

            List<int> intlist = numbers.ConvertToList(758888345);
            foreach(var item in intlist)
            {
                Console.WriteLine(item);
            }

            List<string> stringlist = days.ConvertToList(427786);
            foreach(var item in  stringlist)
            {
                Console.WriteLine(item);
            }
            #endregion



        }

        public static bool check(int n)
        {
            return n > 10;
        }

        public static T MySum<T>(IEnumerable<T> arr)
        {
            // represents an object whose output will be resolved at RunTime
            dynamic sum = 0;
            foreach(var ele in arr)
            {
                sum += ele;
            }
            return sum;
        }

    }

    public static class MyClass //: String : not allowed.   sealed class
    {
        public static bool CheckForValidEmailID(string email)
        {
            return email.Contains("@gmail.com");
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int nonsenseParameter)
        {
            List<T> list = new List<T>();

            foreach(var ele in source)
            {
                list.Add(ele);
            }
            Console.WriteLine($"the value of nonsenseParameter = {nonsenseParameter}");
            return list;
        }
    }
}

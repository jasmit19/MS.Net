using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int[]
            int[] id = new int[5];
            id[0] = 101;
            id[2] = 102;
            id[3] = 103;
            id[4] = 104;
            #endregion

            #region string[]
            string[] names = new string[5];
            names[0] = "Vijay";
            names[1] = "Aman";
            names[2] = "Raj";
            names[3] = "Simran";
            names[4] = "Karan";
            #endregion

            //Emp Class Object
            Emp emp1 = new Emp();
            emp1.Eid = 501;
            emp1.Ename = "Salman";
            emp1.Ecity = "Mumbai";

            Emp emp2 = new Emp();
            emp2.Eid = 502;
            emp2.Ename = "Aamir";
            emp2.Ecity = "Pune";

            Emp emp3 = new Emp();
            emp3.Eid = 503;
            emp3.Ename = "Hritik";
            emp3.Ecity = "Banglore";

            //Book Class Object
            Book book1 = new Book();
            book1.Author = "Chetan Bhagat";
            book1.BookName = "Half Girlfriend";

            Book book2 = new Book();
            book2.Author = "Ruskin Bond";
            book2.BookName = "The Blue Umbrella";


            #region Emp[] and Book[] arrays of objects of user-defined classes
            Emp[] emparr = new Emp[5];
            emparr[0] = emp1;
            emparr[1] = emp2;
            emparr[2] = emp3;

            Book[] bookarr = new Book[3];
            bookarr[0] = book1;
            bookarr[1] = book2;
            #endregion

            #region Object[] array to hold different data types
            Object[] obj = new Object[5];
            obj[0] = 1903; // Boxing ---> converting value type to refernce type
            obj[1] = "non sense";
            obj[2] = emp3;
            obj[3] = book1;
            obj[4] = 34.56; // Boxing
            #endregion

            #region Old Syntax for Type Convertion
            //fetching value and type of each element from object array

            /*for (int i = 0; i < obj.Length; i++)
            {
                object element = obj[i];
                Type type = element.GetType();

                //Console.WriteLine($"Element at index {i} is {element} and its type is {type}");
                if (type.ToString() == "System.Int32")
                {
                    int j = Convert.ToInt32(element); //Unboxing ---> converting reference type to value type
                    Console.WriteLine($"Value = {j} ----> Type = {type.ToString()}");
                }

                if (type.ToString() == "System.String")
                {
                    String str = Convert.ToString(element);
                    Console.WriteLine($"Value = {str} ----> Type = {type.ToString()}");
                }

                if (type.ToString() == "Collections.Emp")
                {
                    Emp e = (Emp)element;           // converting Object obj  to Emp obj
                    Console.WriteLine($"Value = {e.Eid}, {e.Ename}, {e.Ecity} ----> Type = {type.ToString()}");
                }

                if (type.ToString() == "Collections.Book")
                {
                    Book b = (Book)element;         // converting Object obj  to Book obj
                    Console.WriteLine($"Value = {b.BookName}, {b.Author} ----> Type = {type.ToString()}");
                }

                if (type.ToString() == "System.Double")
                {
                    Double d = Convert.ToDouble(element); //Unboxing
                    Console.WriteLine($"Value = {d} ----> Type = {type.ToString()}");
                }
            }*/
            #endregion

            #region New Syntax for Type Convertion
            /*for(int i=0; i< obj.Length; i++)
            {
                object element = obj[i];
                //Type type = element.GetType();
                //Pattern Matching using 'is' keyword
                if (element is int j)
                {
                    Console.WriteLine($"Value = {j} ----> Type = {element.GetType().ToString()}");
                }
                if (element is string str)
                {
                    Console.WriteLine($"Value = {str} ----> Type = {element.GetType().ToString()}");
                }
                if (element is Emp e)
                {
                    Console.WriteLine($"Value = {e.Eid}, {e.Ename}, {e.Ecity} ----> Type = {element.GetType().ToString()}");
                }
                if (element is Book b)
                {
                    Console.WriteLine($"Value = {b.BookName}, {b.Author} ----> Type = {element.GetType().ToString()}");
                }
                if (element is double d)
                {
                    Console.WriteLine($"Value = {d} ----> Type = {element.GetType().ToString()}");
                }
            }*/
            #endregion

            //Non - Generic Collection : System.Collections namespace
            // This is object type collection, its size is dynamic in nature, means grows and shrinks at runtime

            #region Arraylist
            ArrayList alist = new ArrayList();
            alist.Add(101);
            alist.Add("Hello");
            alist.Add(emp1);
            alist.Add(book2);
            alist.Add(45.67);

            /*(int i = 0; i < alist.Count; i++)
            {
                object element = alist[i];

                if (element is int j)
                {
                    Console.WriteLine($"Value = {j} ----> Type = {element.GetType().ToString()}");
                }
                if (element is string str)
                {
                    Console.WriteLine($"Value = {str} ----> Type = {element.GetType().ToString()}");
                }
                if (element is Emp e)
                {
                    Console.WriteLine($"Value = {e.Eid}, {e.Ename}, {e.Ecity} ----> Type = {element.GetType().ToString()}");
                }
                if (element is Book b)
                {
                    Console.WriteLine($"Value = {b.BookName}, {b.Author} ----> Type = {element.GetType().ToString()}");
                }
                if (element is double d)
                {
                    Console.WriteLine($"Value = {d} ----> Type = {element.GetType().ToString()}");
                }
            }*/
            #endregion

            #region HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1,101);
            ht.Add("A","Apple");
            ht.Add(2, emp1);
            ht.Add(3, book1);
            ht.Add(4, 25.33);

            for(int i=0; i<ht.Count; i++)
            {
                foreach(object key in ht.Keys)
                {

                }
            }
            #endregion

            #region Tuples
            var empDetails = Display(201, "Anil", "Chennai");
            Console.WriteLine($"Id = {empDetails.Id}, Name = {empDetails.Name}, City = {empDetails.City}");
            #endregion
        }
        //Tuples : Display Method
        public static (int Id, string Name, string City) Display(int id, string name, string city)
        {
            int Id = id;
            string Name = name;
            string City = city;
            return (Id, Name, City);
        }
    }
    public class Emp
    {
        private int _Eid;
        private string _Ename;
        private string _Ecity;

        public int Eid
        {
            set
            {
                _Eid = value;
            }
            get
            {
                return _Eid;
            }
        }
        public string Ename
        {
            set
            {
                _Ename = value;
            }
            get
            {
                return _Ename;
            }
        }
        public string Ecity
        {
            set
            {
                _Ecity = value;
            }
            get
            {
                return _Ecity;
            }
        }
    }

    public class Book
    {
        private string _Author;
        private string _BookName;

        public string Author
        {
            set
            {
                _Author = value;
            }
            get
            {
                return _Author;
            }
        }

        public string BookName
        {
            set
            {
                _BookName = value;
            }
            get
            {
                return _BookName;
            }
        }
    }
}
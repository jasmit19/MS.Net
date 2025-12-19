namespace InterfaceDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IMPLICIT interface-implementation (switch-case)
            /*
            //implicit implementation of interface IDrink 
            Console.WriteLine("enter a choice: 1.Cold  2,.Hot");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    IDrink cold=new ColdDrink();    ----------->    interface object (ob cold)
                                                    ----------->    defined w default constructor of class ColdDrink
                    cold.GetDrink();                ----------->    object (cold) is calling GetDrink() from class ColdDrink
                    break;

                case 2:
                    IDrink hot = new HotDrink();
                    hot.GetDrink();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
                
            }
            */
            #endregion

        }

        #region IMPLICIT interface-implementation
        //implicit implementation
        /*
        public interface IDrink
        {                               ----------->    classes which implements interface IDrink
            void GetDrink();            ----------->    compulsory to implement this method     
        }

        public class ColdDrink : IDrink
        {           
                                        ----------->    compulsory implementation
            public void GetDrink()      ----------->    override the GetDrink() method from interface IDrink
            {
                Console.WriteLine("enjoy ur Cold Drink");
            }
        }

        public class HotDrink : IDrink
        {
                                        ----------->    compulsory implementation
            public void GetDrink()      ----------->    override the GetDrink() method from interface IDrink
            {
                Console.WriteLine("enjoy ur Cold Drink");
            }
        }
        */
        #endregion

        //Explicit interface-implementation

        public interface IX
        {
            int Add(int x, int y);

            int Sub(int x, int y);
        }

        public interface IY
        {
            int Add(int x, int y);

            int Mult(int x, int y);
        }

        public interface IDemo
        {
            int Div(int x, int y);

            void Log(string message);
        }

        #region IMPLICIT way
        //public class MyMath : IX,IY
        //{
        //                          --------------->    IMPLICIT way of interface implementation
        //    public int Add(int x, int y)
        //    {
        //        return x + y;
        //    }

        //    public int Sub(int x, int y)
        //    {
        //        return x - y;
        //    }

        //    public int Mult(int x, int y)
        //    {
        //        return x * y;
        //    }

        //    public int Add(int x, int y)
        //    {
        //        return x + y +1000;
        //    }
        //}
        #endregion

        #region EXPLICIT way
        public class MyMath : IX, IY
        {
            //                          --------------->   EXPLICIT way of interface implementation
            //public int IX.Add(int x, int y)   ------->   Explicitly called methods() can't be public
            int IX.Add(int x, int y)
            {
                return x + y;
            }

            public int Sub(int x, int y)
            {
                return x - y;
            }

            public int Mult(int x, int y)
            {
                return x * y;
            }

            //public int IY.Add(int x, int y)   ------->   Explicitly called methods() can't be public
            int IY.Add(int x, int y)
            {
                return x + y + 1000;
            }
        }
        #endregion

    }
}

namespace SingletonLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Database to connect to: 1. SQL Server  2. MySQL Server  3. Oracle Server");
            int dbChoice = Convert.ToInt32(Console.ReadLine());

            DatabaseFactory factory = new DatabaseFactory();
            Database db = factory.GetSomeDatabase(dbChoice);

            // Now you can use the db object to perform database operations
            Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
            int opChoice = Convert.ToInt32(Console.ReadLine());

            switch (opChoice)
            {
                case 1:
                    db.Insert();
                    break;
                case 2:
                    db.Update();
                    break;
                case 3:
                    db.Delete();
                    break;
                default:
                    Console.WriteLine("Invalid operation choice");
                    break;
            }

            Console.WriteLine("Do you want to continue? (y/n)");
            string ynChoice = Console.ReadLine();

            if (ynChoice.ToLower() == "y")
            {
                Main(args); //recursive call to Main to perform another operation
            }
            else
            {
                Console.WriteLine("Thank you for using the database manager!");
            }
        }
    }
    public abstract class Database
    {
        public Logger _logger = null;

        // Every time a database object is created, it grabs the single instance of the Logger.
        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();

        protected abstract void DoUpdate();

        protected abstract void DoDelete();

        protected abstract string GetDatabaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"insert operation from {GetDatabaseName()} completed");
        }
        public void Update()
        {
            DoUpdate();
            _logger.Log($"update operation from {GetDatabaseName()} completed");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log($"delete operation from {GetDatabaseName()} completed");
        }

    }

    /*The Factory's job is to create objects for you
      so the "Main" program doesn't have to know the details of how they are built.*/
    public class DatabaseFactory
    {
        //this funct is called in Main after creating a foctory object to get database object according to user choice
        public Database GetSomeDatabase(int dbChoice)
        {
            Database db = null;

            switch (dbChoice)
            {
                case 1:
                    db = new SqlServer();
                    break;
                case 2:
                    db = new MySqlServer();
                    break;
                case 3:
                    db = new OracleServer();
                    break;
                default:
                    db = null;
                    break;
            }
            //returns the created database object to Main
            return db;
        }
    }

    public class SqlServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "SQL Server";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Inserted data in SQL Server successfully");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Updated data in SQL Server successfully");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Deleted data in SQL Server successfully");
        }
    }

    public class MySqlServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "MySQL Server";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Inserted data in MySQL Server successfully");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Updated data in MySQL Server successfully");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Deleted data in MySQL Server successfully");
        }
    }

    public class OracleServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "Oracle Server";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Inserted data in Oracle Server successfully");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Updated data in Oracle Server successfully");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Deleted data in Oracle Server successfully");
        }
    }
    /*Logger class is designed so that only one instance of it ever exists. This is useful for something 
    like a log file where u don't want multiple objects fighting to write to the same file at the same time*/
    public class Logger
    {
        /*static readonly instance: is created when the class is loaded.
                                    creates the single instance inside the class.*/
        private static readonly Logger _logger1 = new Logger();
        #region OLD-way
        //private static readonly Logger _logger2 = new Logger();
        //private static readonly Logger _logger3 = new Logger();
        //private static Logger[] _loggerObjectPool = new Logger[3] { _logger1, _logger2, _logger3};
        #endregion

        //private constructor prevents instantiation from outside the class
        //prevents other classes from using new Logger()
        private Logger()
        {
            Console.WriteLine("Logger instance is created for the first time");
        }

        //Logger class provides a global access point to the single instance via the Instance property
        public static Logger GetLogger()
        {
            return _logger1;
        }
        #region OLD-way
        //public static Logger[] GetLoggers()
        //{
        //    return _loggerObjectPool;
        //}
        #endregion

        public void Log(string message)
        {
            Console.WriteLine($"----Logged at: {DateTime.Now.ToString()}, message:{message}");
        }
    }
}
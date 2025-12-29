using Microsoft.Data.SqlClient;

namespace ConnectedAdoNet01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first step is always defining a Connection String 

            /* Purpose: Tells .NET how to find and access your database.
                        A text instruction that tells your program how to connect to a database.*/

            // Data Source: "(LocalDB)\MSSQLLocalDB" means use SQL Server LocalDB (a lightweight developer database on your machine).
            // Initial Catalog: "IETDb" is the database name.
            // Integrated Security: True uses your "Windows account" for authentication(no username / password in the string).

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PRN29db;Integrated Security=True";



            #region SELECT QUERY
            //// Purpose: Represents a live connection to the database.
            //// What happens: You create a connection object but it’s not open yet.
            //// Why connectionString?   You’re creating a connection object (con) that knows where to go and how to authenticate.
            //SqlConnection con = new SqlConnection(connectionString);

            //// Purpose: The SQL command you want to run.
            //string selectQuery = "SELECT * FROM Emp";


            //// Purpose: A command object knows the SQL to run and which connection to use.
            //// Connection: Links the command to your database connection.
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;    //Command type: “Text” means plain SQL (not a stored procedure).
            //cmd.CommandText = selectQuery;                     //SQL: Assigns the query string to the command.
            //cmd.Connection = con;                              //Connection: Links the command to your database connection.

            //// Purpose: Establishes the actual network connection to the database.
            //// Note: If the database is missing or access is blocked, this line can throw an exception.
            //con.Open();

            //// Purpose: Run the SELECT and stream the rows.
            //// What is a DataReader? ----->
            //// A forward-only, read-only cursor over the result set; to read rows one by one.
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())                               //reader.Read(): Moves to the next row; returns false when no more rows.
            //{
            //    int id = Convert.ToInt32(reader["ID"]);
            //    string? nm = reader["Name"].ToString();
            //    string? city = reader["City"].ToString();
            //    Console.WriteLine($"Employee Details: id={id}, name={nm}, city={city}");
            //}

            //// Purpose: Frees resources and returns the connection to the pool.
            //// Best practice: Close or dispose both the reader and the connection. Use using blocks to do this automatically.
            //con.Close();
            #endregion


            #region INSERT QUERY
            //SqlConnection con = new SqlConnection(connectionString);

            //Console.WriteLine("enter name of the Employee to be inserted:");
            //string nm = Console.ReadLine();

            //Console.WriteLine("enter city:");
            //string city = Console.ReadLine();

            //string insertQuery = $"INSERT INTO Emp(NAME,CITY) VALUES('{nm}','{city}')";

            //// Queries with user input (INSERT, UPDATE, DELETE, SELECT with WHERE): Always use parameters to safely pass values.
            /*   A SqlCommand object doesn’t know by itself which database to talk to.
                 By passing con, you link the command to the open connection    */
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //// cmd.CommandType = System.Data.CommandType.Text;
            //// cmd.CommandText = insertQuery;
            //// cmd.Connection = con;

            //con.Open();

            ////  For INSERT/UPDATE/DELETE, ExecuteNonQuery returns how many rows were affected. 
            ////  If the row was inserted successfully, you typically get 1 (true).
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record inserted successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //con.Close();
            #endregion


            #region UPDATE QUERY
            //SqlConnection con = new SqlConnection(connectionString);

            //Console.WriteLine("Enter the ID of the Employee to be updated:");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter new NAME:");
            //string nm = Console.ReadLine();

            //Console.WriteLine("Enter new CITY:");
            //string city = Console.ReadLine();

            //string updateQuery = $"UPDATE Emp SET NAME='{nm}', CITY='{city}' WHERE id={id}";

            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            ////cmd.CommandType = System.Data.CommandType.Text;
            ////cmd.CommandText = updateQuery;
            ////cmd.Connection = con;

            //con.Open();

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record updated successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //con.Close();
            #endregion


            #region DELETE QUERY
            //SqlConnection con = new SqlConnection(connectionString);

            //Console.WriteLine("enter ID of the employee to be DELETED");
            //int id = Convert.ToInt32(Console.ReadLine());

            //string deleteQuery = $"DELETE FROM Emp WHERE id={id}";

            //SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = deleteQuery;
            //cmd.Connection = con;

            //con.Open();

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //if(noOfRowsAffected > 0 )
            //{
            //    Console.WriteLine("Employee DELETED succssfully");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //con.Close();
            #endregion

        }
    }
}

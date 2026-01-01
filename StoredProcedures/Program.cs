using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StoredProcedures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = PRN29db; Integrated Security = True";

            //InsertDepartment(conString, "Sales");

            //InsertEmployee(conString, "Akshay", 1);
            //InsertEmployee(conString, "Simran", 2);
            //InsertEmployee(conString, "Tilak", 3);

            GetEmployeeByDepartment(conString, 1);
        }

        #region INSERT Department
        public static void InsertDepartment(string conString, string deptName)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "InsertDepartment";       // Stored Procedure's name
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Departmentname", deptName);   // Parameter name, and value

                    int noOfRowsAffected = cmd.ExecuteNonQuery();
                    if (noOfRowsAffected > 0)
                    {
                        Console.WriteLine("Department inserted successfully!!");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                con.Close();
            }
        }
        #endregion

        #region INSERT Employee
        public static void InsertEmployee(string constr, string empName, int deptId)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                //we can also directly pass the Stored Procedure and Connection object 
                //but we have to specify the CommandType
                using (SqlCommand cmd = new SqlCommand("InsertEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeName", empName);
                    cmd.Parameters.AddWithValue("@DepartmentId", deptId);

                    int noOfRowsAffected = cmd.ExecuteNonQuery();
                    if (noOfRowsAffected > 0)
                    {
                        Console.WriteLine("Employee inserted successfully!!");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
        }
        #endregion

        #region GET Employee BY ID
        public static void GetEmployeeByDepartment(string conString, int deptId)
        {
            // Example of retrieving an employee by ID using a stored procedure
            using (var con = new SqlConnection(conString))
            {
                con.Open();

                using (var cmd = new SqlCommand("@GetEmployeeByDepartment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentId", deptId);
                    //cmd.ExecuteNonQuery();                                Not Valid in SELECT function

                    //since we're fetching data to view
                    //we need to display it, Hence, reader()
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"EMPLOYEE DETAILS\nId: {reader["EmployeeId"]}, Name: {reader["EmployeeName"]}");
                        }
                    }
                }
                //con.Close();
            }
        }
        #endregion
    }
}
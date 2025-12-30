using ConnectedADO.Models;
using Microsoft.Data.SqlClient;

namespace ConnectedADO.DAL
{
    // Controller
    // Buissness Logic
    // DataBase Connectivity Layer
    public class MyDbContext
    {
        string connecionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PRN29db;Integrated Security=True";
        public List<Emp> GetEmpRecords()
        {
            SqlConnection con = new SqlConnection(connecionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Emp", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<Emp> allEmpRecords = NewMethod();

            while (reader.Read())
            {
                allEmpRecords.Add(new Emp()
                                            {
                                                Eid = Convert.ToInt32(reader["Id"]),
                                                //Ename= Convert.ToString(reader["name"])
                                                Ename = reader["Name"].ToString(),
                                                Ecity = reader["City"].ToString()
                                            });
            }

            con.Close();
            return allEmpRecords;
        }


        // we are creating a function to return a List<Emp>() constructor
        // bcoz it will used many times
        private List<Emp> NewMethod()
        {
            return new List<Emp>();
        }

        public List<Emp> GetEmpRecordsById(int idToBeSearched)
        {
            SqlConnection con = new SqlConnection(connecionString);

            string selectById = $"SELECT * FROM Emp WHERE ID ={idToBeSearched}";

            SqlCommand cmd = new SqlCommand(selectById, con);

            con.Open();

            List<Emp> searchedRecords = new List<Emp>();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                searchedRecords.Add(new Emp()
                {
                    Eid = Convert.ToInt32(reader["Id"]),
                    Ename = reader["Name"].ToString(),
                    Ecity = reader["City"].ToString(),
                });
            }

            con.Close();
            return searchedRecords;
        }

        public int InsertEmpRecord(Emp empToBeInserted)
        {
            SqlConnection con = new SqlConnection (connecionString);

            string insertQuery = $"INSERT INTO Emp(Name, City) VALUES('{empToBeInserted.Ename}','{empToBeInserted.Ecity}')";

            SqlCommand cmd = new SqlCommand (insertQuery, con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowsAffected;
        }

        public int DeleteEmpRecord(Emp emp)
        {
            SqlConnection con = new SqlConnection(connecionString);

            string deleteQuery = $"DELETE * FROM Emp WHERE ID = {emp.Eid}";

            SqlCommand cmd = new SqlCommand (deleteQuery, con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close ();

            return rowsAffected;
        }

        public int UpdateEmpRecord(int eid, Emp emp)
        {
            SqlConnection con = new SqlConnection(connecionString);

          //if(eid 

            string updateQuery = $"UPDATE EMP SET NAME ='{emp.Ename}',CITY ='{emp.Ecity}' WHERE ID = {eid} ";

            SqlCommand cmd = new SqlCommand(updateQuery, con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowsAffected;
        }
    }
}

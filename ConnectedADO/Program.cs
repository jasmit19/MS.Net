using ConnectedADO.DAL;
using ConnectedADO.Models;

namespace ConnectedADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UI
            // Buissness Presentation Layer
            // Views
            MyDbContext dbContext = new MyDbContext();
            int noOfRowsAffected = 0;

            while(true)
            {
                Console.WriteLine("Enter DB operation choice: 1.SELECT, 2.SELECT by ID, 3.INSERT, 4.UPDATE, 5.DELETE");
                int opChoice = Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        var records = dbContext.GetEmpRecords();
                        foreach(var emp in records)
                        {
                            Console.WriteLine($"ID: {emp.Eid}, Name: {emp.Ename}, City: {emp.Ecity}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ID to be searched:");
                        int idToBeSearched = Convert.ToInt32(Console.ReadLine());

                        var searchedEmp = dbContext.GetEmpRecordsById(idToBeSearched);

                        if(searchedEmp != null)
                        {
                            Emp empFound = searchedEmp.FirstOrDefault();

                            if(empFound != null)
                            {
                                Console.WriteLine($"ID: {empFound.Eid}, Name: {empFound.Ename}, City: {empFound.Ecity}");
                            }
                            else
                            {
                                Console.WriteLine($"No Emp found by id : {idToBeSearched}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Emp by id = {idToBeSearched} Not found / Error");
                        }
                        break;
                    case 3:
                        Emp empToBeInserted = new Emp();

                        Console.WriteLine("Enter NAME of the employee to be INSERTED:");
                        empToBeInserted.Ename = Console.ReadLine(); 

                        Console.WriteLine("Enter CITY of the employee to be INSERTED:");
                        empToBeInserted.Ecity = Console.ReadLine();

                        //int noOfRowsAffected = 0; ---->   already passes above
                        noOfRowsAffected = dbContext.InsertEmpRecord(empToBeInserted);

                        if(noOfRowsAffected > 0)
                        {
                            Console.WriteLine("Record INSERTED successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Error with INSERT query!");
                        }
                        break;
                    case 4:
                        Emp empToBeUpdated = new Emp();

                        Console.WriteLine("Enter Id of Emp to be updated");
                        empToBeUpdated.Eid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name of Emp to be updated");
                        empToBeUpdated.Ename = Console.ReadLine();

                        Console.WriteLine("Enter NAddress of Emp  to be updated");
                        empToBeUpdated.Ecity = Console.ReadLine();

                        noOfRowsAffected = dbContext.UpdateEmpRecord(empToBeUpdated.Eid, empToBeUpdated);

                        if(noOfRowsAffected > 0)
                        {
                            Console.WriteLine("Record UPDATED successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Error with UPDATE query");
                        }
                        break;
                    case 5:
                                Emp empToBeDeleted = new Emp();

                                Console.WriteLine("Enter ID of the employee to be DELETED:");
                                empToBeDeleted.Eid = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter NAME of the employee to be DELETED:");
                                empToBeDeleted.Ename = Console.ReadLine();

                                Console.WriteLine("Enter CITY of the employee to be DELETED:");
                                empToBeDeleted.Ecity = Console.ReadLine();

                                noOfRowsAffected = dbContext.DeleteEmpRecord(empToBeDeleted);

                                if (noOfRowsAffected > 0)
                                {
                                    Console.WriteLine("Record DELETED successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Error with DELETE query!");
                                }
                                break;
                }
                Console.WriteLine("Do you want continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}

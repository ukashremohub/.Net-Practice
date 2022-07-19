using System.Configuration;
using System.Data.SqlClient;

var adoConnection = new AdoConnection();
adoConnection.SqlConnection();

public class AdoConnection
{
    public void SqlConnection()
    {

        try
        {
            //const string ConnectionStrings = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ukash;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var ConnectionStrings = ConfigurationManager.AppSettings["ConnectionStrings"];

            //var ConnectionStrings2 = ConfigurationManager.AppSettings["ConnectionStrings2"];

            var sqlConnection = new SqlConnection(ConnectionStrings);
            sqlConnection.Open();

            SqlCommand sqlCommandForInsertion = new SqlCommand(InsertionQuery(), sqlConnection);
            Console.WriteLine(sqlCommandForInsertion.ExecuteNonQuery());

            Console.WriteLine("\nRead data from DB");
            //Separate instance of SqlCommand is required 
            //for executing each sql query
            SqlCommand sqlCommandForRetreval = new SqlCommand("Select * from Employee", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommandForRetreval.ExecuteReader();

            while (sqlDataReader.Read())
            {
                int empId = (int)sqlDataReader["Id"];
                string name = (string)sqlDataReader["Name"];
                string role = (string)sqlDataReader["Role"];
                Console.WriteLine($"{empId} : {name} : {role}");
            }

            sqlConnection.Close();

        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
            //Console.WriteLine(ex);
        }

    }

    public string InsertionQuery()
    {
        Console.WriteLine("Enter Emp Id : ");
        int EmpId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Emp Name : ");
        string EmpName = Console.ReadLine();

        Console.WriteLine("Enter Emp Role : ");
        string Role = Console.ReadLine();

       return "insert into Employee values(" + EmpId + ",'" + EmpName + "','" + Role + "')";

    }
}
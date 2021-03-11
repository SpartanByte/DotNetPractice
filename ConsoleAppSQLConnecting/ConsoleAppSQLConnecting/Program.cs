using System;
using System.Data.SqlClient;

// add need namespaces
class Program
{
    static void Main()
    {
        string connectionString = "Data Source=LAPTOP-T1POA9KQ\\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // select all data from People table
        string command = "Select * from dbo.People";
        // low level resource that needs to be desposed of properly
        using (SqlConnection conn = new SqlConnection(connectionString)) 
        {
            try //no guarantee connection will be successful
            {
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(command, conn);
                using (SqlDataReader reader = sqlComm.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine("{0}: {1} {2}", reader[0], reader[1], reader[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

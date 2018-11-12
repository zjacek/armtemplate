using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;

public static void Run(string myQueueItem, ILogger log)
{
    log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

    var cnnString  = Environment.GetEnvironmentVariable("ConnectionString03");
    DateTime czas2 = DateTime.Now; 

    log.LogInformation($"C# Queue trigger function processed: {czas2}");

    using (SqlConnection conn = new SqlConnection(cnnString))
    {
        conn.Open();

        // Insert to DB        
        var dbInsert = "INSERT INTO [dbo].[functionlogs] ([czas],[log])" +  
        "VALUES ('"+ czas2 + "','" + myQueueItem + "')";
                   
        // Execute and load data into database.
        using (SqlCommand cmd = new SqlCommand(dbInsert, conn))
        {
            var rows = cmd.ExecuteNonQuery();
        }
        
        
    }
}

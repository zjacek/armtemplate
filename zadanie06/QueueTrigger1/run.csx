#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.Http;
using Dapper;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");

    var cnnString  = Environment.GetEnvironmentVariable("ConnectionString04");
    string data1 = req.Query["data1"];
    log.LogInformation($"Data: {data1}");
    
    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
    dynamic data = JsonConvert.DeserializeObject(requestBody);
    data1 = data1 ?? data?.data1;

    using (var conn = new SqlConnection(cnnString))
    {
        conn.Open();

        // Select            
        String dbSelect = "select * from functionlogs where czas LIKE CONCAT('%',@data1,'%');";
                   
        // Execute  
        var json1 = conn.Query(dbSelect, new {data1});
        //string jsonData = JsonConvert.SerializeObject(json1);

        return new OkObjectResult(json1);
    }
}

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

public static async Task<HttpResponseMessage> Run(HttpRequest req, ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");

    var cnnString  = Environment.GetEnvironmentVariable("ConnectionString03");
    string data1 = req.Query["data1"];
    log.LogInformation($"Data: {data1}");
    var json1 = new StringBuilder();
    
    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
    dynamic data = JsonConvert.DeserializeObject(requestBody);
    data1 = data1 ?? data?.data1;

    using (SqlConnection conn = new SqlConnection(cnnString))
    {
        conn.Open();

        // Select         
        var dbSelect = $"select * from functionlogs where czas = '{data1}' FOR JSON PATH";
                   
        // Execute 
        SqlCommand cmd = new SqlCommand(dbSelect, conn);
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            json1.Append(reader.GetValue(0));
        }
    }

  return data1 != null
    ? new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent(json1.ToString()) }
    : new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest) { Content = new StringContent("Brak zmiennej data1") };

}
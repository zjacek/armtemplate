using System;

public static void Run(TimerInfo myTimer,ICollector<string> outputQueueItem, ILogger log)
{
    log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
    outputQueueItem.Add("Data wywolania funkcji: " + DateTime.Now);
}

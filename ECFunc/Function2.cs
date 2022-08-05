using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ECFunc
{
    public class Function2
    {
        [FunctionName("Function2")]
        public void Run([QueueTrigger("myqueue-items", Connection = "ConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
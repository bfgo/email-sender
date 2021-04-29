using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace BFGO.EmailSender
{
    public static class EmailSender
    {
        [FunctionName("EmailSender")]
        public static void Run([QueueTrigger("orders", Connection = "StorageAccount")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}

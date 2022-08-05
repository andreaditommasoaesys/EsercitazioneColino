using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ECFunc
{
    public class F_NewBlobTrigger
    {
        [FunctionName("F_NewBlobTrigger")]
        public void Run([BlobTrigger("https://esercitazionecolinosa.blob.core.windows.net/todocontainer/{name}", Connection = "DefaultEndpointsProtocol=https;AccountName=esercitazionecolinosa;AccountKey=z4VKSverUPASVJtVuOxEjSFBffyu6NT/E+QXW8W+X2PbKUOs6PJ4VlISgU0TI5ne/ZVEQaTD/VNn+AStMLRVUA==;EndpointSuffix=core.windows.net")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}

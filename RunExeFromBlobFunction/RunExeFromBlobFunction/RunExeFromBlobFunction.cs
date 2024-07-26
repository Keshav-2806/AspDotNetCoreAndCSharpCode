using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Azure.Storage.Blobs;
using System.Diagnostics;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace RunExeFromBlobFunction
{
    public static class RunExeFromBlobFunction
    {
        [FunctionName("RunExeFromBlob")]
        public static async Task<IActionResult> RunExeFromBlob(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string connectionString = Environment.GetEnvironmentVariable("CCIBStorageConnectionString");
            string containerName = "ccibcontainer";//here we have to give the container name 
            string blobName = "3424F52266219_500-20240528171032-7433af70.x12";// here we have to give the exe like ourprogram.exe
            string localPath = Path.Combine(Path.GetTempPath(),blobName);
            string result;
            try
            {
                BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
                BlobClient blobClient = containerClient.GetBlobClient(blobName);

                log.LogInformation($"Downloading blob to {localPath}");
               await blobClient.DownloadToAsync(localPath);

                if (!File.Exists(localPath)) 
                {
                    log.LogError("The file was not downloaded to the local path: {0}",localPath);
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }

                ProcessStartInfo startInfo = new ProcessStartInfo(localPath)
                {
                    //FileName = localPath,
                    //Arguments = "",//need to add any arguments for our exe here
                    //RedirectStandardInput = true,
                   // UseShellExecute = false,
                    //CreateNoWindow = true,

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };
                using (Process process=Process.Start(startInfo)) 
                {
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();
                    //process.Start();
                    //result = await process.StandardOutput.ReadToEndAsync();
                    process.WaitForExit();

                    if (process.ExitCode!=0) 
                    {
                        log.LogInformation("Executable output: {0}", output);
                        return new BadRequestObjectResult($"Executable failed:{error}");
                    }
                    log.LogInformation("Executable output:{0}", output);
                    return new OkObjectResult($"Executable succeeded:{output}");
                }

               
            }
            catch (Exception ex)
            {
                log.LogError($"Exception occurred: {ex.Message}");
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            };        
            
        }
    }
}



//using System;
//using System.IO;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
//using Microsoft.WindowsAzure.Storage.Auth;
//using Microsoft.WindowsAzure.Storage.Blob;
//using Microsoft.Extensions.Options;
//using Azure.Storage.Blobs;
//using Azure.Identity;

//namespace ProcessB2BConflux
//{
//    public class Outbound943

//    {
//        private readonly FunctionSettings settings;

//        public Outbound943(IOptions<FunctionSettings> options)
//        {
//            settings = options.Value;
//        }
//        [FunctionName("Outbound943")]
//        public async Task<IActionResult> Run(
//            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
//            ILogger log)
//        {
//            log.LogInformation("C# HTTP trigger function processed a request.");

//            string outputFilePath = "943.x12";

//            System.Diagnostics.Process process = new System.Diagnostics.Process();
//            var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
//            Directory.CreateDirectory(tempDirectoryPath);
//            var tempFilePath = string.Empty;
//            var storageCredentials = new StorageCredentials(settings.AdfStorageAccountName, settings.AdfStorageKey);
//            var containerUri = new Uri(new Uri(settings.AdfStorageRoot), settings.containerName);
//            var blobContainer = new CloudBlobContainer(containerUri, storageCredentials);
//            BlobContinuationToken blobContinuationToken = null;


//            var blobSourceDirectory = blobContainer.GetDirectoryReference("conflux");
//            var blobList = await blobSourceDirectory.ListBlobsSegmentedAsync(blobContinuationToken);
//            var list = blobList.Results;
//            foreach (var blob in list)
//            {
//                string filename = blob.Uri.Segments[blob.Uri.Segments.Length - 1];
//                var sourceContainer = new CloudBlockBlob(blob.Uri, storageCredentials);
//                await sourceContainer.DownloadToFileAsync(Path.Combine(tempDirectoryPath, filename), FileMode.Create);

//            }

//            tempFilePath = Path.Combine(tempDirectoryPath, "Input" + ".xml");
//            var tempexeFilePath = Path.Combine(tempDirectoryPath, "Mapping" + ".exe");
//            var tempoutputFilePath = Path.Combine(tempDirectoryPath, "943.x12");
//            var tempenvelope943 = Path.Combine(tempDirectoryPath, "Envelope_943" + ".xml");




//            process.StartInfo.FileName = tempexeFilePath;

//            process.StartInfo.ArgumentList.Add("/ISActrlno");
//            process.StartInfo.ArgumentList.Add("1");
//            process.StartInfo.ArgumentList.Add("/InputFile");
//            process.StartInfo.ArgumentList.Add(tempFilePath);
//            process.StartInfo.ArgumentList.Add("/Envelope943");
//            process.StartInfo.ArgumentList.Add(tempenvelope943);
//            process.StartInfo.ArgumentList.Add("/943Output.x12");
//            process.StartInfo.ArgumentList.Add(tempoutputFilePath);
//            // test(process.StartInfo.ArgumentList.ToArray());
//            // Keep this False, is MUST !
//            process.StartInfo.UseShellExecute = false;
//            // Enabling Reading Application's Outputs
//            process.StartInfo.RedirectStandardOutput = true;
//            process.Start();
//            // This would Return your Application's Only First 
//            // Console.Write(). This is not a MUST ! 
//            string output = process.StandardOutput.ReadToEnd();
//            process.WaitForExit();


//            var bloboutputFilePath = blobContainer.GetBlockBlobReference(outputFilePath);
//            await bloboutputFilePath.UploadFromFileAsync(tempoutputFilePath);
//            string outputMessage = File.ReadAllText(tempoutputFilePath);
//            string responseMessage = string.IsNullOrEmpty("test")
//                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
//                : $"Hello,  This HTTP triggered function executed successfully.";

//            return new OkObjectResult(outputMessage);
//        }
//    }
//}

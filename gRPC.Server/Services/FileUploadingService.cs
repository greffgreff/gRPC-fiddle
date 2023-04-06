using System.Diagnostics;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;

namespace gRPC.Server.Controllers;

public class FileUploadingService : FileUploading.FileUploadingBase
{
    public override async Task<Response> Upload(File request, ServerCallContext context)
    {
        Debug.WriteLine("File uploading...");
        return new Response { Message = "File uploaded successfully." };
    }
}
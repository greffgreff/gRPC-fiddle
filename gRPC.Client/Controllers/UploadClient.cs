using Google.Protobuf;
using gRPC.Client;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using File = gRPC.Client.File;

namespace gRPC.Server.Client.Controllers;

[ApiController]
[Route("upload")]
public class UploadClient : ControllerBase
{
    [HttpGet("testUpload")]
    public IActionResult Upload()
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5060");
        var client = new FileUploading.FileUploadingClient(channel);
        var reply = client.Upload(new File{ Data = ByteString.Empty });
        return Ok(reply.Message);
    }
}

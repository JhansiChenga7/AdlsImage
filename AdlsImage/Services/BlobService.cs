using Azure.Storage.Blobs;

namespace AdlsImage.Services;

public class BlobService
{
    private readonly BlobContainerClient _containerClient;

    public BlobService()
    {
        var connectionString =
            Environment.GetEnvironmentVariable("AZURE_BLOB_CONNECTION_STRING");

        var containerName =
            Environment.GetEnvironmentVariable("AZURE_BLOB_CONTAINER_NAME");

        _containerClient = new BlobContainerClient(connectionString, containerName);
    }

    public async Task<string> UploadImageAsync(IFormFile file)
    {
        var blobClient = _containerClient.GetBlobClient(file.FileName);

        using var stream = file.OpenReadStream();
        await blobClient.UploadAsync(stream, overwrite: true);

        return blobClient.Uri.ToString();
    }

    public async Task<Stream> DownloadImageAsync(string fileName)
    {
        var blobClient = _containerClient.GetBlobClient(fileName);
        var response = await blobClient.DownloadAsync();

        return response.Value.Content;
    }
}

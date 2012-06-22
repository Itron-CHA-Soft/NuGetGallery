
namespace NuGetGallery
{
    public interface IConfiguration
    {
        string AzureStorageAccessKey { get; }
        string AzureStorageAccountName { get; }
        string AzureStorageBlobUrl { get; }
        string FileStorageDirectory { get; }
        PackageStoreType PackageStoreType { get; }
        bool SmtpEnableSsl { get; }

        string GetSiteRoot(bool useHttps);
    }
}
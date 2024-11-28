﻿using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;
using RestMatch.Azure.BlobStorage.Dto;

namespace RestMatch.Azure.BlobStorage
{
    public class AzureStorage : IAzureStorage
    {
        private readonly string _storageConnectionString;
        private readonly string _storageUserImagesContainerName;
        private readonly string _storageRestaurantContainerName;

        public AzureStorage(IConfiguration configuration)
        {
            _storageConnectionString = configuration["BlobConnectionString"]!.ToString();
            _storageUserImagesContainerName = configuration["BlobUserImagesContainerName"]!.ToString();
            _storageRestaurantContainerName = configuration["BlobRestaurantContainerName"]!.ToString();
        }

        public async Task<BlobResponseDto> UploadAsync(byte[] blob, string fileName, ContainerEnum containerType)
        {
            const string ContentType = "image/jpeg";

            var response = new BlobResponseDto();

            var storageContainer = _storageRestaurantContainerName;

            if (containerType == ContainerEnum.User)
            {
                storageContainer = _storageUserImagesContainerName;
            }

            var container = new BlobContainerClient(_storageConnectionString, storageContainer);

            try
            {
                var newFileName = Guid.NewGuid() + Path.GetExtension(fileName);

                var client = container.GetBlobClient(newFileName);

                var options = new BlobUploadOptions
                {
                    HttpHeaders = new BlobHttpHeaders
                    {
                        ContentType = ContentType
                    }
                };

                await using var data = new MemoryStream(blob);

                await client.UploadAsync(data, options);

                response.Status = $"File {fileName} Uploaded Successfully";
                response.Error = false;
                response.Blob.Uri = client.Uri.AbsoluteUri;
                response.Blob.Name = client.Name;
            }
            catch (RequestFailedException ex)
            {
                response.Status = $"Unexpected error: {ex.StackTrace}. Check log with StackTrace ID.";
                response.Error = true;
                return response;
            }

            return response;
        }

        public async Task<BlobResponseDto> DeleteAsync(string blobFilename, ContainerEnum containerType)
        {
            var storageContainer = _storageRestaurantContainerName;

            if (containerType == ContainerEnum.User)
            {
                storageContainer = _storageUserImagesContainerName;
            }

            var client = new BlobContainerClient(_storageConnectionString, storageContainer);

            var file = client.GetBlobClient(blobFilename);

            try
            {
                await file.DeleteAsync();
            }
            catch (RequestFailedException ex)
                when (ex.ErrorCode == BlobErrorCode.BlobNotFound)
            {
                return new() { Error = true, Status = $"File with name {blobFilename} not found." };
            }

            return new() { Error = false, Status = $"File: {blobFilename} has been successfully deleted." };
        }
    }
}
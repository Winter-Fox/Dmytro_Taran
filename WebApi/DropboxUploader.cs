using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Dropbox.Api;
using Dropbox.Api.FileRequests;
using Dropbox.Api.Files;

namespace WebApi
{
    public class DropboxUploader : DropboxFactoryClass
    {
        public string url = "";

        // Check whether file exists on PC
        public override bool CheckFileExist()
        {
            return File.Exists(fileName);
        }

        // Upload file to Dropbox
        public void UploadFile()
        {
            if (CheckFileExist())
            {
                // Read file from memory and upload it to the dropbox
                var memoryStream = new MemoryStream(File.ReadAllBytes(fileName));
                var uploaded = DropboxClient.Files.UploadAsync("/" + fileName, WriteMode.Overwrite.Instance, body: memoryStream);
                uploaded.Wait();
                var sharedLink = DropboxClient.Sharing.CreateSharedLinkWithSettingsAsync("/" + fileName);
                sharedLink.Wait();
                url = sharedLink.Result.Url;
            }
        }

        // Show success message
        public override void ShowSuccessMessage()
        {
            Console.WriteLine("File succefully uploaded! You can find it by url: " + url);
        }
    }
}

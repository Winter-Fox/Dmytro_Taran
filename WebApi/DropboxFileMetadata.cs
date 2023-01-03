using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using Dropbox.Api;
using Dropbox.Api.FileRequests;
using Dropbox.Api.Files;

namespace WebApi
{
    public class DropboxFileMetadata : DropboxFactoryClass
    {
        public override bool CheckFileExist()
        {
            // Upload file and if url is not empty - it is uploaded
            DropboxUploader dbu = new DropboxUploader();
            dbu.UploadFile();

            if (dbu.url.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void ShowSuccessMessage()
        {
            Metadata file = GetFileMetadata();
            if (file != null)
            {
                Console.WriteLine("Metadata was succefully retrieved!");
                Console.WriteLine("Name: " + file.Name);
                Console.WriteLine("Path: " + file.PathDisplay);
                Console.WriteLine("ID: " + file.AsFile.Id);
                Console.WriteLine("Modified: " + file.AsFile.ClientModified);
            } 
        }

        public Metadata GetFileMetadata()
        {
            if (CheckFileExist())
            {
                // Loop through all files in dropbox and if found one with given name retrun it's metadata
                var filesInDropbox = DropboxClient.Files.ListFolderAsync(string.Empty);
                foreach (var item in filesInDropbox.Result.Entries)
                {
                    if (item.Name == fileName)
                    {
                        return item;
                    }
                }
            }

            return null;
        }
    }
}

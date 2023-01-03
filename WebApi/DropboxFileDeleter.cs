using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi
{
    public class DropboxFileDeleter : DropboxFactoryClass
    {
        public override bool CheckFileExist()
        {
            DropboxFileMetadata dfm = new DropboxFileMetadata();
            return dfm.CheckFileExist();
        }

        public override void ShowSuccessMessage()
        {
            Console.WriteLine("You succefully deleted file!");
        }

        public void DeleteFile()
        {
            if (CheckFileExist())
            {
                // Loop through all files in dropbox and if found one with given name retrun it's metadata
                var filesInDropbox = DropboxClient.Files.ListFolderAsync(string.Empty);
                foreach (var item in filesInDropbox.Result.Entries)
                {
                    if (item.Name == fileName)
                    {
                        DropboxClient.Files.DeleteV2Async(item.PathLower);
                    }
                }
            }
        }
    }
}

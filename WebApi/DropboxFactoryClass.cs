using System;
using System.Collections.Generic;
using System.Text;

using Dropbox.Api;

namespace WebApi
{
    public abstract class DropboxFactoryClass
    {
        // Fields universal for every class
        static private string token = "sl.BWlOXLe3EDbiE9gos_Z9LbOBEGM1oV1JnxMVARI_xrPCfTlgIlsl4nVIMmxpDxFtJvWKviUzoGgqww6ZNwY1DIX2tQYjkUu1KxlCcC-oGc_BHsjxhEhRYW7rDqL-OHO_CNpTAjtCahx4";
        public DropboxClient DropboxClient = new DropboxClient(token);

        // Mehtod which checks whether file exists (either on PC or on Dropbox)
        public abstract bool CheckFileExist();
        // Method which shows message of operation success
        public abstract bool CheckResult();

        // Method which checks whether file with a specified name exists in Dropbox
        protected bool CheckFileExistOnDropbox(string fileName)
        {
            var filesInDropbox = DropboxClient.Files.ListFolderAsync(string.Empty);
            foreach (var item in filesInDropbox.Result.Entries)
            {
                if (item.Name == fileName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

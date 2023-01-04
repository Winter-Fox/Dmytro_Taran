using System;
using System.Collections.Generic;
using System.Text;

using Dropbox.Api;

namespace WebApi
{
    public abstract class DropboxFactoryClass
    {
        // Fields universal for every class
        static private string token = "sl.BWMljq3rQq4NjATptu9eounDJrMSAVbK-pFtUphvyd6OKTl_jGsVxPpzDYMBR0vluY1Vh2ebDptrXGkgx-CulhBMvfcU_3amvoW4ZzFrdX_ALa3h3eNiS_hwlnBWPrBrxh6GgReznzWy";
        public DropboxClient DropboxClient = new DropboxClient(token);
        public string fileName = @"FileName.txt";

        // Mehtod which checks whether file exists (either on PC or on Dropbox)
        public abstract bool CheckFileExist();
        // Method which shows message of operation success
        public abstract void ShowSuccessMessage();
        
        
        // Random Main function so that VS won't complain about it's loss and let's you build solution
        static void Main(string[] args)
        {
            //Pass
        }
    }
}

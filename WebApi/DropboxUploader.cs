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
        private string fileName = "FileToUpload.txt";

        // Check whether file exists on PC
        public override bool CheckFileExist()
        {
            return File.Exists(fileName);
        }

        // Upload file to Dropbox
        public void UploadFile(string fileName = "FileToUpload.txt")
        {
            if (CheckFileExist())
            {
                var mem = new MemoryStream(File.ReadAllBytes(fileName));
                var updated = DropboxClient.Files.UploadAsync("/" + fileName, WriteMode.Overwrite.Instance, body: mem);
                updated.Wait();
                var tx = DropboxClient.Sharing.CreateSharedLinkWithSettingsAsync("/" + fileName);
                tx.Wait();
                url = tx.Result.Url;
            }
        }

        // Check for success
        public override bool CheckResult()
        {
            return CheckFileExistOnDropbox(fileName);
        }
    }
}

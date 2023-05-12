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
        private string fileName = "FileToCheckMetadata.txt";
        public override bool CheckFileExist()
        {
            return CheckFileExistOnDropbox(fileName);
        }

        public override bool CheckResult()
        {
            Metadata file = GetFileMetadata();
            if (file != null)
            {
                if ((file.Name == fileName) &&
                    (file.PathDisplay == "/" + fileName) &&
                    (file.AsFile.Id.StartsWith("id:")) &&
                    (file.AsFile.ClientModified == new DateTime(2023, 1, 9, 16, 15, 42, DateTimeKind.Local))) return true;
            }

            return false;
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

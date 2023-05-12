using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi
{
    public class DropboxFileDeleter : DropboxFactoryClass
    {
        public string fileName = "FileToDelete.txt";

        public override bool CheckFileExist()
        {
            return CheckFileExistOnDropbox(fileName);
        }

        public override bool CheckResult()
        {
            return !CheckFileExistOnDropbox(fileName);
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
                        var task = DropboxClient.Files.DeleteV2Async("/"+fileName);
                        task.Wait();
                        return;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using Dropbox.Api;

namespace WebApi
{
    public abstract class DropboxFactoryClass
    {
        // Fields universal for every class
        static private string token = "sl.BeNTy0ljbJXaLGHSsgyL7fBdA0MrCmosMkPQJjSyLeXwqJEnLLqRROUF6igBoZDnzlXmik9y07oZzzWn75zFy50m_MuUPlAx4WKhuzKox1zFRvtYtevqU6_am-icCqeOCpg2_Qs";
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
        
        public static void Main(string[] args) { }
    }
}

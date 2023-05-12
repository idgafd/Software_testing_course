using System;
using TechTalk.SpecFlow;

using WebApi;

namespace WebApiFeature.Steps
{
    [Binding]
    public class WebApiSteps
    {
        private DropboxUploader dbu = new DropboxUploader();
        private DropboxFileDeleter dfd = new DropboxFileDeleter();
        private DropboxFileMetadata dfm = new DropboxFileMetadata();

        [Given(@"check file to upload exists on pc")]
        public void GivenCheckFileToUploadExistsOnPc()
        {
            dbu.CheckFileExist();
        }
        
        [Given(@"file to chekc metadat on exists on Dropbox")]
        public void GivenFileToChekcMetadatOnExistsOnDropbox()
        {
            dfm.CheckFileExist();
        }
        
        [Given(@"file to delete exists on Dropbox")]
        public void GivenFileToDeleteExistsOnDropbox()
        {
            dfd.CheckFileExist();
        }
        
        [When(@"upload file")]
        public void WhenUploadFile()
        {
            dbu.UploadFile();
        }
        
        [When(@"get file metada")]
        public void WhenGetFileMetada()
        {
            dfm.GetFileMetadata();
        }
        
        [When(@"delete file")]
        public void WhenDeleteFile()
        {
            dfd.DeleteFile();
        }
        
        [Then(@"file is uploaded to Dropbox")]
        public void ThenFileIsUploadedToDropbox()
        {
            dbu.CheckResult().Equals(true);
        }
        
        [Then(@"check that metadata is correct")]
        public void ThenCheckThatMetadataIsCorrect()
        {
            dfm.CheckResult().Equals(true); 
        }
        
        [Then(@"file is deleted from Dropbox")]
        public void ThenFileIsDeletedFromDropbox()
        {
            dfd.CheckResult().Equals(true);
            // Upload file again to make test work another time
            dbu.UploadFile(dfd.fileName);
        }
    }
}

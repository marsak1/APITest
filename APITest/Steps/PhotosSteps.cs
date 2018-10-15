using APITest.Actions;
using APITest.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APITest.Steps
{
    [Binding]
    public class PhotosSteps
    {
        PhotosActions photosActions = new PhotosActions();
        Photo photoresponse;
        string path;

        [Given(@"Photo with id ""(.*)"" is requested")]
        public void GivenPhotoWithIdIsRequested(string id)
        {
            photoresponse = photosActions.GetPhotoById(id);
        }

        [When(@"Image url from response is requested")]
        public void WhenImageUrlFromResponseIsRequested()
        {
            string url = photosActions.GetUrlToImageFromResponse(photoresponse);
            path = photosActions.SavedImageOnDisc(url);
        }

        [Then(@"Image is saved on disc")]
        public void ThenImageIsSavedOnDisc()
        {
            Assert.True(File.Exists(path), "File is not exist on disk");
        }


    }
}

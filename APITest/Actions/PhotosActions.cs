using APITest.Controllers;
using APITest.Models;
using APITest.Utilities.Objects;
using RestSharp;
using System.Collections.Generic;
using System.IO;

namespace APITest.Actions
{
    class PhotosActions
    {
        PhotosController photosController = new PhotosController();

        public List<Photo> GetListOfPhotos()
        {
            IRestResponse<List<Photo>> response = photosController.GetPhotos();
            Response.StatusCode = (int)response.StatusCode;
            return response.Data;
        }

        public Photo GetPhotoById(string id)
        {
            IRestResponse<Photo> response = photosController.GetPhotoById(id);
            Response.StatusCode = (int)response.StatusCode;
            return response.Data;
        }

        public string GetUrlToImageFromResponse(Photo photo)
        {
            return photo.url;
        }

        public string SavedImageOnDisc(string url)
        {
            string path = photosController.SaveImageOnDisc(url);
            return path;
        }
    }
}

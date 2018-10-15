using APITest.Models;
using APITest.Utilities.Configurations;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    class PhotosController : GeneralController
    {
        private IRestResponse<Photo> responsePhoto;
        private IRestResponse<List<Photo>> responsePhotosList;
        private IRestResponse response;
        string endpoint = "photos";

        public IRestResponse<List<Photo>> GetPhotos()
        {
            request = new RestRequest(endpoint, Method.GET);
            responsePhotosList = GetRestClient().Execute<List<Photo>>(request);
            return responsePhotosList;
        }

        public IRestResponse<Photo> GetPhotoById(string id)
        {
            request = new RestRequest(endpoint + "/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            responsePhoto = GetRestClient().Execute<Photo>(request);
            return responsePhoto;
        }
        
        public string SaveImageOnDisc(string url)
        {
            string date = DateTime.Now.ToString("HH:mm").Replace(':', '.');
            string path = @"D:\image" + date + ".jpg";
            var fileBytes = GetRestClient().DownloadData(new RestRequest(url, Method.GET));
            File.WriteAllBytes(path, fileBytes);

            return path;
        }
        
    }

    
}

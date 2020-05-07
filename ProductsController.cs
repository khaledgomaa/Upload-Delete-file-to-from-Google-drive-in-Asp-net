using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CSLY.Repository;
using CSLY.Models;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using CSLY.ViewModel;
using CSLY.googledriveapi;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using System.Web;

namespace CSLY.Controllers.api
{
    public class ProductsController : ApiController 
    {
        [HttpPost]
        public IHttpActionResult AddProduct(string filePath)
        {
            string fileId;
            fileId = googledrive.FileUpload(filePath);
            return Ok(product);
        }

        [HttpDelete]
        public IHttpActionResult DeleteProduct(string fileId)
        {
            if(file != null)
                googledrive.DeleteFile(file);
            return Ok();
        }

        
    }
}

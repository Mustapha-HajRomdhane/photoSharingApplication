using PhotoSharingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
namespace PhotoSharingApp.Controllers
{
    public class PhotoController : System.Web.Mvc.Controller
    {   // GET: Photo
        private PhotoSharingContext context = new PhotoSharingContext();
        public ActionResult Index()
        {
            Debug.WriteLine("aaaaaaaa");
             //Photo photo = new Photo();
            //return photo;

             return View(context.Photos.First<Photo>());
        }
    }
}
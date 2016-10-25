using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webServREST_inzKR.Models;

namespace webServREST_inzKR.Controllers
{
    public class PhotoAlbumController : Controller
    {
        // GET: PhotoAlbum
        public ActionResult Index()
        {
            return View();
        }

        public PhotoAlbum Get()
        {
            return new PhotoAlbum(1, OccasionType.ceremonies, "lol", "no co Ty!", new System.Drawing.Bitmap(12,12), new System.Collections.ObjectModel.ObservableCollection<Person>());
        }
    }
}
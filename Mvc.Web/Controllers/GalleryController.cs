using System;
using System.Collections.Generic;
using System.Data;
using Mvc.Data.Models;
using Mvc.Data.Repositories;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace Mvc.Web.Controllers
{
    public class GalleryController : Controller
    {
        GalleryRepository galleryRepo;

        public GalleryController()
        {
            galleryRepo = new GalleryRepository();

        }

      
        public ActionResult Index()
        {
            List<Gallery> allGalleriesFromDB = galleryRepo.GetAll();
            return View(allGalleriesFromDB);
        }



        [HttpGet]
        public ActionResult Create()
        {
            Gallery gallery = new Gallery()
            {

            };

            return View(gallery);
        }


        [HttpPost]
        public ActionResult Create(Gallery model)
        {
            Gallery newGallery = new Data.Models.Gallery()
            {
                Name = model.Name
            };
            galleryRepo.Add(newGallery);



            // return to home index too see the image you have uploaded
            return RedirectToAction("index", "gallery");
        }



    }
}

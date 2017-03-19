using Mvc.Data.Models;
using Mvc.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Web.Controllers
{
    public class GalleryController : Controller
    {
        GalleryRepository galleryRepo;

        public GalleryController()
        {
            galleryRepo = new GalleryRepository();
           
        }
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }




        // GET: Gallery/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gallery/Create
        [HttpPost]
        public ActionResult Create(Gallery model)
        {
            

                return RedirectToAction("Create");
     
         }
        
      
    
    }
}

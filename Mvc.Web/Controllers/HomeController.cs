using Mvc.Data.Models;
using Mvc.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Web.Controllers
{
    public class HomeController : Controller
    {
        PhotoRepository photoRepo;
        CommentRepository commentRepo;

        public HomeController()
        {
            photoRepo = new PhotoRepository();
            commentRepo = new CommentRepository();
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            List<Photo> allPhotosFromDb = photoRepo.GetAll();

            return View(allPhotosFromDb);
        }


        [HttpGet]
        public ActionResult Comment(int id)
        {
            Comment comment = new Comment()
            {
                PhotoId = id,
            };

            return View(comment);
        }

        [HttpPost]
        public ActionResult Comment(Comment model)
        {
            // create a comment for the specific image we want to comment on
            Comment newComment = new Data.Models.Comment()
            {
                CommentString = model.CommentString,
                PhotoId = model.PhotoId,
            };
            commentRepo.Add(newComment);

            // refresh the photos with the new comment
            List<Photo> allPhotosFromDb = photoRepo.GetAll();

            return PartialView("_ListPhotos", allPhotosFromDb);

            //return RedirectToAction("index");
        }
    }
}
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

        [HttpGet]
        public ActionResult Create()
        {
            Photo photo = new Photo()
            {

            };

            return View(photo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Photo model, HttpPostedFileBase uploadfile)
        {
            // save the path of the image: eg. /images/myimage.jpg
            model.Path = string.Format($"/images/{uploadfile.FileName}");

            // save the photo name and path into the database
            photoRepo.CreatePhoto(model);

            //save the file in server folder
            uploadfile.SaveAs(Server.MapPath($"~/images/{uploadfile.FileName}"));

            // return to home index too see the image you have uploaded
            return RedirectToAction("index", "home");
        }




    }
}
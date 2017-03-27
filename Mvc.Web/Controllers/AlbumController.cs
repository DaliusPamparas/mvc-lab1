using System;
using System.Collections.Generic;
using System.Data;
using Mvc.Data.Models;
using Mvc.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace Mvc.Web.Controllers
{
    public class AlbumController : Controller
    {
        AlbumRepository albumRepo;

        public AlbumController()
        {
            albumRepo = new AlbumRepository();
          
        }

        // GET: Album
        public ActionResult Index()
        {
            List<Album> allPhotosFromDB = albumRepo.GetAll();
            return View(allPhotosFromDB);
        }

       

        // GET: Album/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Album/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "AlbumId,Name")] Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Albums.Add(album);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(album);
        //}

        // GET: Album/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Album album = db.Albums.Find(id);
        //    if (album == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(album);
        //}

        // POST: Album/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "AlbumId,Name")] Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(album).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(album);
        //}

        // GET: Album/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Album album = db.Albums.Find(id);
        //    if (album == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(album);
        //}

        // POST: Album/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Album album = db.Albums.Find(id);
        //    db.Albums.Remove(album);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}

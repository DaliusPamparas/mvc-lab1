using Mvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Repositories
{
    public class PhotoRepository
    {
        public List<Photo> GetAll()
        {
            using (MvcEntities _context = new MvcEntities())
            {
                List<Photo> allPhotosFromDB = _context.Photos.Include("Comments").ToList();

                return allPhotosFromDB;
            }

        }

        public void CreatePhoto(Photo photo)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Photos.Add(photo);

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (MvcEntities context = new MvcEntities())
            {
                var photo = context.Photos.Where(p => p.PhotoId == id).FirstOrDefault();

                context.Photos.Remove(photo);

                context.SaveChanges();
            }
        }
    }
}

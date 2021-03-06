﻿using Mvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mvc.Data.Repositories
{

    public class GalleryRepository
    {
        public List<Gallery> GetAll()
        {
            using (MvcEntities _context = new MvcEntities())
            {
                List<Gallery> allGalleriesFromDB = _context.Galleries.ToList();
                return allGalleriesFromDB;
            }
        }
        public void Add(Gallery gallery)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Galleries.Add(gallery);

                context.SaveChanges();
            }
        }
        public void Delete(Gallery gallery)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Galleries.Remove(gallery);

                context.SaveChanges();
            }
        }
    }
}

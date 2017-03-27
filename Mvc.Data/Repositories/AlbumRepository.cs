using Mvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mvc.Data.Repositories
{
    public class AlbumRepository
    {
        public List<Album> GetAll()
        {
            using (MvcEntities _context = new MvcEntities())
            {
                List<Album> allAlbumsFromDB = _context.Albums.ToList();
                return allAlbumsFromDB;
            }
        }
        public void Add(Album album)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Albums.Add(album);
                context.SaveChanges();

            }
        }
        public void Delete(Album album)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Albums.Remove(album);
                context.SaveChanges();
            }
        }

    }
}

using Mvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Repositories
{
    public class CommentRepository
    {
        public void Add(Comment comment)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Comments.Add(comment);

                context.SaveChanges();
            }
        }
        public void Delete(Comment comment)
        {
            using (MvcEntities context = new MvcEntities())
            {
                context.Comments.Remove(comment);

                context.SaveChanges();
            }
        }
    }
}

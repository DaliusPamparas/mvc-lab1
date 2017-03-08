using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Models
{
    class MvcEntities:DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}

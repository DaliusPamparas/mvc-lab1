using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Models
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}

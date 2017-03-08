using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public int GalleryID { get; set; }
        public virtual Gallery Gallery { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}

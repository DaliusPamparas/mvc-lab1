using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}


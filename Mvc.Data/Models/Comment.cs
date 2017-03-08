using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Data.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentString { get; set; }

        public virtual Photo Photo { get; set; }
        public int PhotoId { get; set; }

    }
}

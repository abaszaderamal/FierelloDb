using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class BlogInfo
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }

    }
}

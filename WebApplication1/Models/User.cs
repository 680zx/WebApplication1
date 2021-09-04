using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public string Name { get; set; }

        public int Point { get; set; }

        public bool? IsLiked { get; set; }
    }
}

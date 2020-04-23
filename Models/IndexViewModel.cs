using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123.Models
{
    public class IndexViewModel
    {
        public IEnumerable<IdentityUser> Users { get; set; }

    }
}

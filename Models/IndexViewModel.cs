using _123.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123.Models
{
    public class IndexViewModel
    {
        public IEnumerable<TableUser> Users { get; set; }
        public IEnumerable<string> IdsToChange { get; set; }
    }
}

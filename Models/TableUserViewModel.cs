using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123.Models
{
    public class TableUserViewModel
    {
        public string Id { get; set; }

        public string Email { get; set; }
    
        public DateTime? RegistrationDateTime { get; set; }

        public DateTime? LastLoginDateTime { get; set; }

        public bool? IsEnabled { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace _123.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TableUser class
    public class TableUser : IdentityUser
    {
        [PersonalData]
        public DateTime? RegistrationDateTime { get; set; }

        [PersonalData]
        public DateTime? LastLoginDateTime { get; set; }

        [PersonalData]
        public bool? IsEnabled { get; set; }
    }
}

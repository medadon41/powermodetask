using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PowerMode.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the PowerUser class
    [Table("AspNetUsers")]
    public class PowerUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public string Social { get; set; }

        [Display(Name = "Registration date")]
        [PersonalData]
        public DateTime RegDate { get; set; }

        [Display(Name = "Last seen")]
        [PersonalData]
        public DateTime LastSeen { get; set; }

        [Display(Name = "Is blocked?")]
        [PersonalData]
        public bool isBlocked { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EmreDemir.UI.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the EmreDemirUIUser class
    public class EmreDemirUIUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="text")]
        public string Name { get; set; }

        [PersonalData]
        [Column(TypeName = "text")]
        public string LastName { get; set; }
    }
}

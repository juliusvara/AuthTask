using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthTask.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [PersonalData]
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(12)")]
        public string AdditionalInfo { get; set; }

    }
}

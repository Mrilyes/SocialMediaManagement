using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaManagement.Models
{
    public class User : IdentityUser
    {
       

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [PersonalData]
        [DisplayName("Last Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }     

        public virtual Group Group { get; set; }
    }
}

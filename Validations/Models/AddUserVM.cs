using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validations.Models
{
    public class AddUserVM
    {
        [Required(ErrorMessage = "Field first name is required")]
        [StringLength(10, ErrorMessage = "Name must be max 10 chars")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Field last name is required")]
        [StringLength(20, ErrorMessage = "Last name must be max 20 chars")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field email address is required")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "The Email Address is not valid")]
        public string EmailAddress { get; set; }
    }
}

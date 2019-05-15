using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Employee Id")]
        [Range(100000,999999,ErrorMessage ="You need to enter a valid 6 digit EmployeeId ")]
        public int EmployeeId { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage ="Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength =6,ErrorMessage ="You need to provide at least 6 char long password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and Confirm Password should match")]
        public string ConfirmPassword { get; set; }

    }
}
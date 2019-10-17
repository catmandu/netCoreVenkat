using System.ComponentModel.DataAnnotations;
using TestMVC.Common;

namespace TestMVC.Models
{
    public class Person
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Sex Gender { get; set; }
    }
}
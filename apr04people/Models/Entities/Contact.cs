using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace apr04people.Models.Entities
{
    public partial class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter a Name")]
        [Display(Name = "Namn")]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Enter an E-mail")]
        [EmailAddress()] //Man kan skriva ErrorMessage = "Enter valid email"
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apr04people.Models.ViewModels
{
    public class PeopleCreateVM
    {
        [Required(ErrorMessage = "enter a name")]
        [Display(Name = "Förnamn")]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Enter an E-mail")]
        [EmailAddress()]
        public string Email { get; set; }
        [Display(Name="What is 2 + 2?")]
        [Range(4, 4)]
        [Required(ErrorMessage = "Don't be a robot man")]
        public int BotCheck { get; set; }
    }
}

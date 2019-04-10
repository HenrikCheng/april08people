//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace apr04people.Models
//{
//    public class Person
//    {
//        public int Id { get; set; }
//        [Required(ErrorMessage = "Enter a Name")]
//        [Display(Name="Namn")]
//        public string Name { get; set; }
//        [Display(Name = "E-mail")]
//        [Required(ErrorMessage = "Enter an E-mail")]
//        [EmailAddress()] //Man kan skriva ErrorMessage = "Enter valid email"
//        public string Email { get; set; }
//    }
//}

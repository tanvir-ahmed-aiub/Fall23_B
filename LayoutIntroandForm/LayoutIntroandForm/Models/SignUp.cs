using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutIntroandForm.Models
{
    public class SignUp
    {
        [Required(ErrorMessage ="Provide you name")]
        [StringLength(5,ErrorMessage ="Length <5")]
        
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
    }

}
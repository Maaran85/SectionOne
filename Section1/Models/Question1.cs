using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Section1.Models
{
    public class Question1
    {
        [DisplayName("Enter an Integer Value For M (must be less than 20 and greater than zero):-")]
        [Required]
        [Range(typeof(int), "1", "20", ErrorMessage = "{0} can only be between {1} and {2}")]
        public int m { get; set; }

        [DisplayName("Enter an Integer Value For N (must be less than 20 and greater than zero):-")]
        [Required]
        [Range(typeof(int), "1", "20", ErrorMessage = "{0} can only be between {1} and {2}")]
        public int n { get; set; }


        public string Output { get; set; }
    }
}
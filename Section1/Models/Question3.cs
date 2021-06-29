using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Section1.Models
{
    public class Question3
    {
        [DisplayName("Enter the String:-")]
        [Required(ErrorMessage ="Please Enter the Valid String")]
        public string Input { get; set; }

        [DisplayName("Output:-")]
        public string Output { get; set; }
    }
}
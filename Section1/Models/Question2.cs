using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Section1.Models
{
    public class Question2
    {
        [DisplayName("Enter a Positive Number to Reverse:-")]
        [Required(ErrorMessage = "Not a Valid Input:- Please Enter a Positive Number.")]        
        public uint Number { get; set; }

        [DisplayName("Output - Reversed Number:-")]
        public string Output { get; set; }
    }
}
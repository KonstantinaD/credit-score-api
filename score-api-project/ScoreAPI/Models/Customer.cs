using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Customer
    {
        [Required]
        [RegularExpression(@"^([a-zA-Z]+[ .'-]?)+([ ,]?)+[a-zA-Z]+.?$", ErrorMessage = "Please enter a valid name")]
        public string Name {get; set;}
    }
}

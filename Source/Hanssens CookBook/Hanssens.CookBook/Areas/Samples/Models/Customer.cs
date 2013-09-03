using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hanssens.CookBook.Areas.Samples.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required, Display(Name = "Customer name")]
        public string DisplayName { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime? DateOfBirth { get; set; }

    }
}
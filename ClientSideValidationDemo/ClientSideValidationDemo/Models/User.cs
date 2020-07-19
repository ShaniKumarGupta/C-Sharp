using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // For validation part

namespace ClientSideValidationDemo.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }

        [Range(18,100)]
        public int Age { get; set; }

        [RegularExpression(@"^d{10}$")]
        public string Contact { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }
        public int CityId { get; set; }

        [Required]
        [StringLength(10,MinimumLength =8)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Url]
        public string Website { get; set; }
        public bool IsTerms { get; set; }

        [Required]
        public string[] Languages { get; set; }

        [FileExtensions] // by default works for images
        public HttpPostedFileBase Photo { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace web_app_1.Models
{
    public class Account
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string? Username { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        public string? Password { get; set; }

        [Range(18, 60)]
        public string? Age { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Url]
        public string? Website { get; set; }
    }
}
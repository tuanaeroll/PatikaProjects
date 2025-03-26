﻿using System.ComponentModel.DataAnnotations;

namespace JwtApi.Models
{
        public class User
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }
        }

}

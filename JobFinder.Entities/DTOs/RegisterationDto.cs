﻿using System.ComponentModel.DataAnnotations;

namespace JobFinder.Entities.DTOs
{
    public class RegisterationDto 
    {
        [Required(ErrorMessage = "FIELD_IS_REQUIRED")]
        public string Name { get; set; }

        [Required(ErrorMessage = "FIELD_IS_REQUIRED")]
        [EmailAddress(ErrorMessage = "Email not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "FIELD_IS_REQUIRED")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "FIELD_IS_REQUIRED")]
        public bool isCompany { get; set; }
    }
}

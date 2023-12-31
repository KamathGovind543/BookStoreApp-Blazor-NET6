﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Dto.User
{
    public class UserDto : UserLoginDto
    {
       

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Role { get; set; }

    }
}

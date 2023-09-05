using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Dto.User
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

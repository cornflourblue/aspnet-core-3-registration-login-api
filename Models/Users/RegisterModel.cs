using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Dni { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
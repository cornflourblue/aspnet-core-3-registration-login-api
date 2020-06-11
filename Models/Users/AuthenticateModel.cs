using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class AuthenticateModel
    {
        [Required]
        public string Dni { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
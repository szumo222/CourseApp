using System.ComponentModel.DataAnnotations;

namespace CourseApp.API.Dtos
{
    public class UserFroRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string  Password { get; set; }
    }
}
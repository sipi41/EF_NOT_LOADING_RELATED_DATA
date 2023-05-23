using System.ComponentModel.DataAnnotations;

namespace ITT_OneTeam.Models.Authentication
{
    public class Login
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Plase enter your Username"), MinLength(8, ErrorMessage = "User must have 9 or more characters")] 
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Plase enter your Password"), MinLength(8, ErrorMessage = "Password must have 9 or more characters")]
        public string Password { get; set; }

    }
}

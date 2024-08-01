using System.ComponentModel.DataAnnotations;

namespace Exmp1.Models

{
    public class LoginMode
    {
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}

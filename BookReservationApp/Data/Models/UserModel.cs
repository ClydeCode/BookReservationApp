using Microsoft.AspNetCore.Identity;

namespace BookReservationApp.Data.Models
{
    public class UserModel : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

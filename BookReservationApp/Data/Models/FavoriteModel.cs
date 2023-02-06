using System.ComponentModel.DataAnnotations.Schema;

namespace BookReservationApp.Data.Models
{
    public class FavoriteModel
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }

        public UserModel User { get; set; }
        public BookModel Book { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace BookReservationApp.Data.Models;

public class BookModel
{
    public int Id { get; set; }
    public string? ImageURL { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    [ForeignKey("User")]
    public string? ReservedBy { get; set; }
    public DateTime CreatedAt { get; set; }

    public UserModel User { get; set; }
    public FavoriteModel Favorite { get; set; }
}
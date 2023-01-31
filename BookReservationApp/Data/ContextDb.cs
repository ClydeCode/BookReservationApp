using BookReservationApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReservationApp.Data;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) 
        : base(options)
    {
    }

    public DbSet<BookModel> Books { get; set; } = default!;
}
using BookReservationApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReservationApp.Data
{
	public class DatabaseService
	{
		private readonly IDbContextFactory<ContextDb> _DBFactory;

        public event EventHandler<List<BookModel>> DatabaseChanged;

        public DatabaseService(IDbContextFactory<ContextDb> DBFactory) 
		{ 
			_DBFactory = DBFactory;
		}

		public List<BookModel> GetBooks()
		{
			using var context = _DBFactory.CreateDbContext();

			return context.Books.ToList();
		}

		public BookModel GetBookById(int Id)
		{
			using var context = _DBFactory.CreateDbContext();

			return context.Books.FirstOrDefault(item => item.Id == Id);
		}

		public void AddBook(BookModel bookModel) 
		{
			using var context = _DBFactory.CreateDbContext();

			context.Books.Add(bookModel);
			context.SaveChanges();

            DatabaseChanged?.Invoke(this, GetBooks());
        }

		public void UpdateBook(int Id, BookModel bookModel) 
		{
			using var context = _DBFactory.CreateDbContext();

			var entity = context.Books.FirstOrDefault(item => item.Id == Id);

			context.Entry(entity).CurrentValues.SetValues(bookModel);

			context.SaveChanges();

            DatabaseChanged?.Invoke(this, GetBooks());
        }

		public void DeleteBook(int Id)
		{
			using var context = _DBFactory.CreateDbContext();

			var entity = context.Books.FirstOrDefault(item => item.Id == Id);

			context.Books.Remove(entity);

			context.SaveChanges();

            DatabaseChanged?.Invoke(this, GetBooks());
        }

		public List<FavoriteModel> GetFavorites()
		{
			using var context = _DBFactory.CreateDbContext();

			return context.Favorites.ToList();
		}

        public FavoriteModel GetFavoriteByIdAndUserId(int BookId, string UserId)
        {
            using var context = _DBFactory.CreateDbContext();

            return context.Favorites.FirstOrDefault(item => item.BookId == BookId && item.UserId == UserId);
        }

        public void AddFavorite(FavoriteModel favoriteModel)
        {
            using var context = _DBFactory.CreateDbContext();

            context.Favorites.Add(favoriteModel);

            context.SaveChanges();
        }

        public void UpdateFavorite(int Id, FavoriteModel favoriteModel)
        {
            using var context = _DBFactory.CreateDbContext();

            var entity = context.Favorites.FirstOrDefault(item => item.Id == Id);

            context.Entry(entity).CurrentValues.SetValues(favoriteModel);

            context.SaveChanges();
        }

        public void DeleteFavoriteByIdAndUserId(int BookId, string UserId)
        {
            using var context = _DBFactory.CreateDbContext();

            var entity = context.Favorites.FirstOrDefault(item => item.BookId == BookId && item.UserId == UserId);

            context.Favorites.Remove(entity);

            context.SaveChanges();
        }
    }
}

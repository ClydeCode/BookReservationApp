using BookReservationApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReservationApp.Data
{
	public class DatabaseService
	{
		private readonly IDbContextFactory<ContextDb> _DBFactory;

		public DatabaseService(IDbContextFactory<ContextDb> DBFactory) 
		{ 
			_DBFactory = DBFactory;
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
		}

		public void UpdateBook(int Id, BookModel bookModel) 
		{
			using var context = _DBFactory.CreateDbContext();

			var entity = context.Books.FirstOrDefault(item => item.Id == Id);

			context.Entry(entity).CurrentValues.SetValues(bookModel);

			context.SaveChanges();
		}

		public void DeleteBook(int Id)
		{
			using var context = _DBFactory.CreateDbContext();

			var entity = context.Books.FirstOrDefault(item => item.Id == Id);

			context.Books.Remove(entity);

			context.SaveChanges();
		}
	}
}
